using System;
using System.Data.Common;

namespace polymorphism
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout)
            : base(connectionString, timeout)
        {

        }

        

        public override void Open()
        {
            Console.WriteLine("Oracle Database has been Opened!");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Database has been Closed!");
        }
    }
    
}
