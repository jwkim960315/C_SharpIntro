using System;

namespace polymorphism
{
    abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            try
            {
                if (string.IsNullOrEmpty(connectionString) || timeout == default(TimeSpan))
                {
                    throw new InvalidOperationException("Invalid parameters");
                }
                else
                {
                    _connectionString = connectionString;
                    _timeout = timeout;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public TimeSpan GetTimeout()
        {
            return _timeout;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
