using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;



        public TransactionController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionListDto {
                Id = transaction.ID,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                EmployeeId = transaction.EmployeeID,
                CustomerId = transaction.CustomerID,
                TotalValue = transaction.TotalValue,

            });
        }


        [HttpGet("{Id}")]
        public async Task<TransactionEditDto> GetById(Guid Id) {
            var result = _transactionRepo.GetById(Id);
            return new TransactionEditDto {
                Id = result.ID,
                Date = result.Date,
                PaymentMethod = result.PaymentMethod,
                EmployeeId = result.EmployeeID,
                CustomerId = result.CustomerID,
                TotalValue = result.TotalValue,
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {
            var newTransaction = new Transaction(transaction.Date, transaction.PaymentMethod, transaction.TotalValue, transaction.EmployeeId, transaction.CustomerId);
            newTransaction.Date = transaction.Date;
            newTransaction.PaymentMethod = transaction.PaymentMethod;
            newTransaction.TotalValue = transaction.TotalValue;
            newTransaction.EmployeeID = transaction.EmployeeId;
            newTransaction.CustomerID = transaction.CustomerId;
            _transactionRepo.Add(newTransaction);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto transaction) {
            var itemToUpdate = _transactionRepo.GetById(transaction.Id);
            itemToUpdate.PaymentMethod = transaction.PaymentMethod;
            itemToUpdate.TotalValue = transaction.TotalValue;
            itemToUpdate.EmployeeID = transaction.EmployeeId;
            itemToUpdate.CustomerID = transaction.CustomerId;
            _transactionRepo.Update(transaction.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            _transactionRepo.Delete(id);
        }


    }
}
