using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ΤransactionLinesController : ControllerBase {

        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        public ΤransactionLinesController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Item> itemRepo) {
            _transactionLineRepo = transactionLineRepo;
        }


        [HttpGet]
        public async Task<IEnumerable<TransactionLineListDto>> Get() {
            var result = _transactionLineRepo.GetAll();
            return result.Select(transactionLine => new TransactionLineListDto {
                Id = transactionLine.ID,
                TransactionId = transactionLine.TransactionID,
                ItemId = transactionLine.ItemID,
                Quantity = transactionLine.Quantity,
                ItemPrice = transactionLine.ItemPrice,
                NetValue = transactionLine.NetValue,
                DiscountPercent = transactionLine.DiscountPercent,
                DiscountValue = transactionLine.DiscountValue,
                TotalValue = transactionLine.TotalValue,
            });
        }

        [HttpGet("{Id}")]
        public async Task<TransactionLineEditDto> GetById(Guid Id) {
            var result = _transactionLineRepo.GetById(Id);
            return new TransactionLineEditDto {
                Id = result.ID,
                TransactionId = result.TransactionID,
                ItemId = result.ItemID,
                Quantity = result.Quantity,
                ItemPrice = result.ItemPrice,
                TotalValue = result.TotalValue,
                NetValue = result.NetValue,
                DiscountPercent = result.DiscountPercent,
                DiscountValue = result.DiscountValue,
            };
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transactionLine) {
            var newTransactionLine = new TransactionLine(transactionLine.Quantity, transactionLine.NetValue, transactionLine.DiscountPercent, transactionLine.DiscountValue, transactionLine.TotalValue, transactionLine.TransactionId, transactionLine.ItemId);
            newTransactionLine.TransactionID = transactionLine.TransactionId;
            newTransactionLine.ItemID = transactionLine.ItemId;
            newTransactionLine.Quantity = transactionLine.Quantity;
            newTransactionLine.TotalValue = transactionLine.TotalValue;
            newTransactionLine.NetValue = transactionLine.NetValue;
            newTransactionLine.DiscountPercent = transactionLine.DiscountPercent;
            newTransactionLine.DiscountValue = transactionLine.DiscountValue;
            _transactionLineRepo.Add(newTransactionLine);
        }


        [HttpPut]
        public async Task Put(TransactionLineEditDto transactionLine) {
            var itemToUpdate = _transactionLineRepo.GetById(transactionLine.Id);
            itemToUpdate.ItemID = transactionLine.ItemId;
            itemToUpdate.TotalValue = transactionLine.TotalValue;
            itemToUpdate.Quantity = transactionLine.Quantity;
            itemToUpdate.NetValue = transactionLine.NetValue;
            itemToUpdate.DiscountPercent = transactionLine.DiscountPercent;
            _transactionLineRepo.Update(transactionLine.Id, itemToUpdate);
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            //var transactionLine = _transactionLineRepo.GetById(id).TransactionID;
            _transactionLineRepo.Delete(id);
        }

    }
}
