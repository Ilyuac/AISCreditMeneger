using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;

namespace FormForTest.Models
{
    /// <summary>
    /// Проваайдер LiqToDb
    /// </summary>
    public class LinqToDbProvider : IProviderDatabase
    {
        string _connectionString;

        public LinqToDbProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Отправка сообщений.
        /// </summary>
        public event Action<string> PostMessage;

        public void AddLogbook(Logbook logbook)
        {
            using (var db = new DbTest(_connectionString))
            {
                db.Insert(logbook);
            }
        }

        public void AddRequests(Request request)
        {
            using (var db = new DbTest(_connectionString))
            {
                db.Insert(request);
            }
        }

        public void AddUser(User user)
        {
            using (var db = new DbTest(_connectionString))
            {
                db.Insert(user);
            }
        }

        /// <summary>
        /// Получить логи.
        /// </summary>
        /// <returns></returns>
        public List<Logbook> GetAllLogbooks()
        {
            List<Logbook> logbooks = new List<Logbook>();

            using (var db = new DbTest(_connectionString))
            {
                foreach (var item in db.Logbooks)
                {
                    logbooks.Add(item);
                }
            }

            return logbooks;
        }

        /// <summary>
        /// Получить запросы.
        /// </summary>
        /// <returns></returns>
        public List<Request> GetAllRequests()
        {
            List<Request> requests = new List<Request>();

            using (var db = new DbTest(_connectionString))
            {
                foreach (var item in db.Requests)
                {
                    requests.Add(item);
                }
            }

            return requests;
        }

        /// <summary>
        /// Получить пользователей.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (var db = new DbTest(_connectionString))
            {
                foreach (var item in db.Users)
                {
                    users.Add(item);
                }
            }

            return users;
        }
        
        /// <summary>
        /// Получить пользователя.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUser(string login, string password)
        {
            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Логин или пароль был null.");
            }

            User user;

            using (var db = new DbTest(_connectionString))
            {
                user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            }

            if (user == null)
            {
                if (PostMessage != null)
                {
                    PostMessage("Пользователь не найден.");
                }
            }
            
            return user;
        }

        /// <summary>
        /// Получить логи пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Logbook> GetUserLogbooks(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("Передан пустой пользователь.");
            }

            List<Logbook> logbooks = null;

            using (var db = new DbTest(_connectionString))
            {
                logbooks = db.Logbooks.Where(l => l.UserId == user.UserId).ToList();
            }

            if (logbooks == null)
            {
                if (PostMessage != null)
                {
                    PostMessage("Логи пользователя не найдены.");
                }
            }

            return logbooks;
        }

        /// <summary>
        /// Получить запросы пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Request> GetUserRequests(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("Передан пустой пользователь.");
            }

            List<Request> requests = null;

            using (var db = new DbTest(_connectionString))
            {
                var logid = db.Logbooks.FirstOrDefault(l => l.UserId == user.UserId).RequestId;
                requests = db.Requests.Where(r => r.RequestId == logid).ToList();
            }

            if (requests == null)
            {
                if (PostMessage != null)
                {
                    PostMessage("Запросы пользователя не найдены.");
                }
            }

            return requests;
        }

        public void RemoveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("Передан пустой пользователь.");
            }

            using (var db = new DbTest(_connectionString))
            {
                db.Delete(user);
            }
        }

        public void UpdateUser(User user)
        {
            using (var db = new DbTest(_connectionString))
            {
                db.Update(user);
            }
        }
    }
}
