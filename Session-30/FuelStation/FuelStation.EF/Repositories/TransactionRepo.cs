using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {

        public IList<Transaction> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Transactions
               .Include(transaction => transaction.TransactionLines)
               .Include(transaction => transaction.Customer)
               .Include(transaction => transaction.Employee)
               .ToList();
        }

        public Transaction? GetById(Guid ID) {
            using var context = new FuelStationDbContext();
            return context.Transactions.Where(transaction => transaction.ID == ID)
            .Include(transaction => transaction.TransactionLines)
            .Include(transaction => transaction.Customer)
            .Include(transaction => transaction.Employee).SingleOrDefault();
        }

        public void Add(Transaction entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Update(Guid ID, Transaction entity) {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions
                .Where(transaction => transaction.ID == ID)
                .SingleOrDefault();
            if (dbTransaction == null)
                throw new Exception($"Given id '{ID}' was not found");
            dbTransaction.Date = entity.Date;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.CustomerID = entity.CustomerID;
            dbTransaction.EmployeeID = entity.EmployeeID;
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions
                .Where(transaction => transaction.ID == ID)
                .SingleOrDefault();
            if (dbTransaction is null) 
                throw new Exception($"Transaction with id: {ID} not found");
            context.Remove(dbTransaction);
            context.SaveChanges();
        }

    }
}
