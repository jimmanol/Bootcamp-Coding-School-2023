using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class MonthlyLedgerDto {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        //public int rent = 5000;

        public List<Transaction> Transactions { get; set; } = new();

        public MonthlyLedgerDto() {
        }

        public MonthlyLedgerDto(DateTime datetime) {
            Year = datetime.Year;
            Month = datetime.Month;
        }
    }
}
