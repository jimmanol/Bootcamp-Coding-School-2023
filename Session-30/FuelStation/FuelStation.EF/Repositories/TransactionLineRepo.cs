using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {

        public IList<TransactionLine> GetAll() {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Include(transaction => transaction.Transaction)
                .Include(transaction => transaction.Item).ToList();
        }

        public TransactionLine? GetById(Guid ID) {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Where(transaction => transaction.ID == ID)
                .Include(transaction => transaction.Item)
                .Include(transaction => transaction.Transaction)
                .SingleOrDefault();
        }

        public void Add(TransactionLine entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Update(Guid ID, TransactionLine entity) {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines
                .Where(transaction => transaction.ID == ID)
                .SingleOrDefault();
            if (dbTransactionLine == null)
                throw new Exception($"Transaction Line with id: '{ID}' was not found");
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountValue = entity.DiscountValue;
            dbTransactionLine.TotalValue = entity.TotalValue;
            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.DiscountPercent = entity.DiscountPercent;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.ItemID = entity.ItemID;
            dbTransactionLine.TransactionID = entity.TransactionID;
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines
                .Where(transactionLine => transactionLine.ID == ID)
                .SingleOrDefault();
            if (dbTransactionLine is null)
                throw new Exception($"Transaction Line with id: '{ID}' was not found");
            context.Remove(dbTransactionLine);
            context.SaveChanges();
        }

    }
}
