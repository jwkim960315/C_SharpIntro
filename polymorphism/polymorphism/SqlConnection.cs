using System;
using System.IO;


namespace polymorphism
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout)
            : base(connectionString, timeout)
        {
            
        }

        public override void Open()
        {
            Console.WriteLine("Sql Database has been Opened!");
        }

        public override void Close()
        {
            Console.WriteLine("Sql Database has been Closed!");
        }
    }
}
