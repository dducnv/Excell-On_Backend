using Excell_On_Backend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace Excell_On_Backend.Controllers
{
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<Order> GetAll()
        {
            return db.Orders.ToList();
        }
        [Route("MyOrder/{id}")]
        public IEnumerable<Order> GetByUserID(string id)
        {
            var result = db.Orders.Where(m => m.AccountID == id).ToList();
            return result;
        } 
        public Order GetByID(int id)
        {
            return db.Orders.Find(id);
        }
        //customer add order and checkout
        [Route("addorder")]
        [HttpPost]
        public IHttpActionResult AddOrder(OrderViewModel orderViewModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                decimal GrandTotal = 0;
                foreach (var orderDetailsItem in orderViewModel.OrderDetails)
                {
                    var service = db.Services.Find(orderDetailsItem.ServiceID);
                    DateTime startDate = DateTime.Parse(orderDetailsItem.StartDate);
                    DateTime endDate = DateTime.Parse(orderDetailsItem.EndDate);
                    var days = endDate.Subtract(startDate).TotalDays;
                    GrandTotal += service.Price * orderDetailsItem.Qty * Convert.ToInt32(days.ToString());
                };
                var dateNow = DateTime.Now;
                Order order = new Order()
                {
                    AccountID = orderViewModel.AccountID,
                    GrandTotal = GrandTotal,
                    Status = 1,
                    Deposit = orderViewModel.Deposit,
                    CreatedAt = dateNow,
                    UpdateAt = dateNow
                };
                db.Orders.Add(order);
                foreach (var orderDetailsItem in orderViewModel.OrderDetails)
                {
                    var service = db.Services.Find(orderDetailsItem.ServiceID);
                    DateTime startDate = Convert.ToDateTime(orderDetailsItem.StartDate);
                    DateTime endDate = DateTime.Parse(orderDetailsItem.EndDate);
                    var days = endDate.Subtract(startDate).TotalDays;
                    Debug.WriteLine(Convert.ToInt32(days.ToString()));
                    OrderDetails orderDetails = new OrderDetails()
                    {
                        OrderID = order.Id,
                        ServiceID = orderDetailsItem.ServiceID,
                        SpecificationID = orderDetailsItem.SpecificationID,
                        Qty = orderDetailsItem.Qty,
                        StartDate = startDate,
                        EndDate = endDate,
                        Status = 1,
                        UnitPrice = service.Price * orderDetailsItem.Qty * Convert.ToInt32(days.ToString()),
                        CreatedAt = dateNow,
                        UpdateAt = dateNow
                    };
                    db.OrderDetails.Add(orderDetails);
                };
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok();
        }

        // confirm order and send mail for customer
        [Route("ConfirmOrder/{id}")]
        [HttpGet]
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> ConfirmOrder(int id)
        {
            var order = await db.Orders.FindAsync(id);
            var dateNow = DateTime.Now;
            int transHisStatus;

            if (order.Status == 0 && order != null)
            {
                return BadRequest();
            }
            order.Status = 0;
            var endDate = db.OrderDetails.Where(m => m.OrderID == order.Id).OrderBy(m => m.EndDate).FirstOrDefault();
            var startDate = db.OrderDetails.Where(m => m.OrderID == order.Id).OrderByDescending(m => m.StartDate).FirstOrDefault();
            Contract contract = new Contract()
            {
                OrderID = order.Id,
                PriceTotal = order.GrandTotal,
                StartDate = startDate.StartDate,
                EndDate = endDate.EndDate,
                Status = 1,
                CreatedAt = dateNow,
                UpdateAt = dateNow
            };
            if (order.Deposit <= 0)
            {
                transHisStatus = 1;
            }
            else if (contract.PriceTotal - order.Deposit == 0)
            {
                transHisStatus = 0;
            }
            else
            {
                transHisStatus = 2;
            }
            TransactionHistory transactionHistory = new TransactionHistory()
            {
                ContractID = contract.Id,
                PriceSent = order.Deposit,
                InDebt = contract.PriceTotal - order.Deposit,
                Status = transHisStatus,
                CreatedAt = order.CreatedAt,
                UpdateAt = dateNow
            };
            db.Contracts.Add(contract);
            db.TransactionHistories.Add(transactionHistory);
            db.SaveChanges();
            return Ok();
        }

        // Add Employees for a order details
        [Route("EmployeeForOrder")]
        [HttpPost]
        [DisableCors]
        public async Task<IHttpActionResult> AddEmployeeForOrder(EmployeeODViewModel employeeODViewModel)
        {
            try
            {
                var orderDetails = await db.OrderDetails.FindAsync(employeeODViewModel.OrderDetailsID);
                if (orderDetails == null)
                {
                    return BadRequest();
                }
                var dateNow = DateTime.Now;
                foreach (var employee in employeeODViewModel.Employee)
                {
                    OrderDetails_Employee orderDetails_Employee = new OrderDetails_Employee()
                    {
                        AccountID = employee.AccountID,
                        OrderDetailsID = orderDetails.Id,
                        CreatedAt = dateNow,
                        UpdateAt = dateNow
                    };
                    Debug.WriteLine(employee.AccountID);
                    db.OrderDetails_Employees.Add(orderDetails_Employee);
                };

                db.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return BadRequest();
            }

            return Ok();
        }
        
        [Route("EmployeeSpecification")]
        [HttpPost]
        [DisableCors]
        public int  EmployeeSpecification(EmployeeSpecifications employeeSpecifications)
        {
            var i = 0;
            DateTime startDate = Convert.ToDateTime(employeeSpecifications.StartDate);
            DateTime endDate = Convert.ToDateTime(employeeSpecifications.EndDate);
            var empSpecification = db.Specification_Employees.Where(m => m.SpecificationID == employeeSpecifications.SpecificationsID).ToList();
            var orderDetailsEmpl = db.OrderDetails_Employees.Where(m => m.OrderDetails.Status == 0 &&
            m.OrderDetails.SpecificationID == employeeSpecifications.SpecificationsID && m.OrderDetails.StartDate >= startDate).ToList();
            foreach (var orderDetailsEmplItem in orderDetailsEmpl)
            {
                i++;
            }
            var countEmployee = empSpecification.Count() - i;
            return countEmployee;
        }
    
        [Route("GetInDebt/{id}")]
        [HttpGet]
        public TransactionHistory GetInDebt(int id)// contract ID
        {
            var transactionHis = db.TransactionHistories.Where(m => m.ContractID == id).OrderByDescending(m => m.CreatedAt).FirstOrDefault();
            return transactionHis;
        }
        [HttpPost]
        [Route("PaymentContract")]
        public IHttpActionResult Payment(PaymentViewModel paymentViewModel)
        {
            int transHisStatus;
            var dateNow = DateTime.Now;
            var transactionHis = db.TransactionHistories.Where(m => m.ContractID == paymentViewModel.ContractID).OrderByDescending(m => m.CreatedAt).FirstOrDefault();
            if (transactionHis.InDebt - paymentViewModel.PriceSend == 0)
            {
                transHisStatus = 0;
            }
            else
            {
                transHisStatus = 2;
            }
            TransactionHistory transactionHistory = new TransactionHistory()
            {
                ContractID = paymentViewModel.ContractID,
                PriceSent = paymentViewModel.PriceSend,
                InDebt = transactionHis.InDebt - paymentViewModel.PriceSend,
                Status = transHisStatus,
                CreatedAt = dateNow,
                UpdateAt = dateNow
            };
            Debug.WriteLine(transactionHistory.InDebt);
            db.TransactionHistories.Add(transactionHistory);
            db.SaveChanges();
            return Ok();
        }
        [Route("TransactionHistories/{id}")]
        [HttpGet]
        public IEnumerable<TransactionHistory> TransactionHistories(string id)//ACCOUNT ID
        {
            var transactionHistory = db.TransactionHistories.Where(m => m.Contract.Order.AccountID == id).ToList();
            return transactionHistory;
        }

    }
}

