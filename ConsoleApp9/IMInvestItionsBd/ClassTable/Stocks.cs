using ConsoleApp9.DataBase;
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
    internal class Stocks
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}


