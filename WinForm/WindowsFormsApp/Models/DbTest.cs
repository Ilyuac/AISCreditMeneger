using LinqToDB;
using System.Data.SqlClient;

namespace WindowsFormsApp.Models
{
    public class DbTest : LinqToDB.Data.DataConnection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DbTest(string connectionString) :
            base(ProviderName.SqlServer2017, connectionString)
        {
        }

        /// <summary>
        /// Таблица с пользователями.
        /// </summary>
        public ITable<User> Users => GetTable<User>();

        /// <summary>
        /// Таблица с логами.
        /// </summary>
        public ITable<Logbook> Logbooks => GetTable<Logbook>();

        /// <summary>
        /// Таблица с запросов.
        /// </summary>
        public ITable<Request> Requests => GetTable<Request>();
    }
}
