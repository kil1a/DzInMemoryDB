using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.IMInvestItionsBd.ClassTable
{
    [PrimaryKey(nameof(ID))]
    internal class RateStocks
    {
        [Key]
        public int ID { get; set; }
        public int StockId { get; set; }
        public int Rate { get; set; }
        public short Year { get; set; }
    }
}
