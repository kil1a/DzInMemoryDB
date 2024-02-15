using DzInvestFondInM.IMInvestFondBd;
using DzInvestFondInM.IMInvestFondBd.ClassTable;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp9
{
    public class ManagerDataBase :IDisposable
    {
        private const string HorizontalLine = "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
        private InvestitionsBD _database = new InvestitionsBD();

        public void SetStock()
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Заполните таблицу [Stock]:");
            InsertStock();
            Console.WriteLine("Заполнение таблицы[Stock] завершено");
            Console.WriteLine(HorizontalLine);

        }
        public void InsertStock()
        {
            Console.WriteLine("Заполните строку [Stock]:");
            Console.WriteLine("Напишите данные в формате [Name]:");
            var stockRow = new Stocks();
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {

            }
            else
            {
                stockRow.Name = name;
                _database.StockSet.Add(stockRow);
                InsertStock();
            }
        }

        public void Dispose()
        {
        }

    }
}
