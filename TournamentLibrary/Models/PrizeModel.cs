using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PrizeModel
    {
        public int PrizeNumber { get; set; }
        public string PrizeName { get; set; }
        public decimal PrizeAmount { get; set; }
        public int Id { get; set; }
        public PrizeModel() {}
        public PrizeModel(string prizeName, string prizeNumber, string prizeAmount)
        {
            PrizeName = prizeName;

            int.TryParse(prizeNumber, out int prizeNumberValue);
            PrizeNumber = prizeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;
        }
    }
}
