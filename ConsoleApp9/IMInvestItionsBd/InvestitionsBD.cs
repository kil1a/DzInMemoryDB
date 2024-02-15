using ConsoleApp9.IMInvestItionsBd.ClassTable;
using DzInvestFondInM.IMInvestFondBd.ClassTable;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;



namespace DzInvestFondInM.IMInvestFondBd
{
    internal class InvestitionsBD : DbContext
    {
        public DbSet<StockWallet> WalletSet { get; set; }
        public DbSet<RateStocks> RateSet { get; set; }
        public DbSet<Stocks> StockSet { get; set; }

        //====================================================================================================================================================
        //public OrderBD()
        //{
        //    //ошибка была здесь, она заключалась в том что листы с нашими таблицами небыли проинициализированны, вот как можно было это исправить:

        //    //WalletSet = new List<StockWallet>();

        //    //RateSet = new List<RateStocks>();

        //    //StockSet = new List<Stocks>();
        //}
        //====================================================================================================================================================


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionStringBuilder = new SqliteConnectionStringBuilder()
                {
                    DataSource = "Investition.sqlite"
                };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);

                optionsBuilder.UseSqlite(connection);
            }


        }
        //PowerShell Connection Strings EF:
        //CD C:\Users\student.TOP\Desktop\ClassWork\ConsoleApp9\ConsoleApp9
        //    dotnet tool install --global dotnet-ef
        //    dotnet ef migrations add --project ConsoleApp9.csproj
        //    dotnet ef migrations add InitialCreate
    }
}
