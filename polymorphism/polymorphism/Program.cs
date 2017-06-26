using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("SqlConnection", new TimeSpan(0,5,0));
            var oracle = new OracleConnection("OracleConnection", new TimeSpan(0,10,0));

            Console.WriteLine("SqlConnection: {0}...{1}\nOracleConnection: {2}...{3}",sql.GetConnectionString(),sql.GetTimeout(),oracle.GetConnectionString(),oracle.GetTimeout());
            Console.ReadLine();

            sql.Open();
            sql.Close();
            oracle.Open();
            oracle.Close();
            Console.ReadLine();
        }
    }
}
