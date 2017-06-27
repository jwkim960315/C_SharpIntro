using System;

namespace polymorphism
{
    class DbCommand
    {
        private DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection)
        {
            try
            {
                if (dbConnection == null)
                {
                    throw new InvalidOperationException("DB Connection has not been made");
                }
                else
                {
                    _dbConnection = dbConnection;
                }
            }
            catch (InvalidOperationException e)
            {
                System.Console.WriteLine(e);
            }

        }

        public void SendCommand()
        {
            try
            {
                if (_dbConnection == null)
                {
                    throw new InvalidOperationException("DB Connection has not been made");
                }
                else
                {
                    Console.WriteLine("Command has been sent to the database");
                }
            }
            catch (InvalidOperationException e)
            {
                System.Console.WriteLine(e);
            }
        }

        public void Execute()
        {
            try
            {
                if (_dbConnection == null)
                {
                    throw new InvalidOperationException("DB Connectio has to be made first");
                }
                else
                {
                    _dbConnection.Open();
                    this.SendCommand();
                    _dbConnection.Close();
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}