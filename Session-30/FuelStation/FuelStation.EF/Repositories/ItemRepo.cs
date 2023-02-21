using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {
    public class ItemRepo: IEntityRepo<Item> {

        public IList<Item> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Items
                .Include(item => item.TransactionLines)
                .ToList();
        }

        public Item? GetById(Guid ID) {
            using var context = new FuelStationDbContext();
            return context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
        }

        public void Add(Item entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Guid ID, Item entity) {
            using var context = new FuelStationDbContext();
            var ItemDb = context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null) 
                throw new Exception($"Given id '{ID}' was not found");
            ItemDb.Description = entity.Description;
            ItemDb.Code = entity.Code;
            ItemDb.Price = entity.Price;
            ItemDb.Cost = entity.Cost;
            ItemDb.ItemType = entity.ItemType;
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            using var context = new FuelStationDbContext();
            var ItemDb = context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null)
                throw new Exception($"Given id '{ID}' was not found");
            context.Remove(ItemDb);
            context.SaveChanges();
        }
    }
}
