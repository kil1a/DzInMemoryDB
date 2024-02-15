using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzInvestFondInM.IMInvestFondBd.ClassTable
{
    [PrimaryKey(nameof(ID))]
    internal class StockWallet
    {
        public int ID { get; set; }
        public int StockId { get; set; }
        public bool IsItOpen { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
