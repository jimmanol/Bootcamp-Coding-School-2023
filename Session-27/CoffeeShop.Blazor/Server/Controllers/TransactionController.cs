using CoffeeShop.Blazor.Shared.Transaction;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {

            _transactionRepo = transactionRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var transactionList = _transactionRepo.GetAll();

            return transactionList.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalPrice = transaction.TotalPrice,
                PaymentMethod = transaction.PaymentMethod,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                //TransactionLines = transaction.TransactionLines,
            });

        }

        
        [HttpGet("{Id}")]
        public async Task<TransactionEditDto?> GetById(int id)
        {
            var result = _transactionRepo.GetById(id);
            return new TransactionEditDto
            {
                Id = id,
                Date = result.Date,
                TotalPrice = result.TotalPrice,
                PaymentMethod = result.PaymentMethod,
                CustomerId = result.CustomerId,
                EmployeeId = result.EmployeeId,
                // transaction lines
            };

        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.TotalPrice, transaction.PaymentMethod);
            //newCustomer.Transactions = new();
            _transactionRepo.Create(newTransaction);

        }

        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var itemToUpdate = _transactionRepo.GetById(transaction.Id);
            itemToUpdate.Date = transaction.Date;
            itemToUpdate.TotalPrice = transaction.TotalPrice;
            itemToUpdate.PaymentMethod = transaction.PaymentMethod;
            itemToUpdate.CustomerId = transaction.CustomerId;
            itemToUpdate.EmployeeId = transaction.EmployeeId;
            // transaction lines

            _transactionRepo.Update(transaction.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _transactionRepo.Delete(id);

        }
        
    }

}

