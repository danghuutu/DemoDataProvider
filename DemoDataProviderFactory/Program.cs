using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataProviderFactory
{
    class Program
    {
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;
        }
        static void ViewProduct()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection(); 
            if(connection == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            DbCommand command = connection.CreateCommand();
            if(command == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select *  From Products";
            using DbDataReader dataReader = command.ExecuteReader();
            Console.WriteLine("**** Product List ****");
            while (dataReader.Read())
            {
                Console.WriteLine($"ProductID: {dataReader["ProductID"]}, " +
                    $"ProductName: {dataReader["ProductName"]}.");
            }
        }

        static void Main(string[] args)
        {
            ViewProduct();
            Console.ReadLine();
        }
    }
}
