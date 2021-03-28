using System;
using System.Collections.Generic;

namespace FormForTest.Models
{
    /// <summary>
    /// Интерфейс провайдера.
    /// </summary>
    public interface IProviderDatabase
    {
        /// <summary>
        /// Отправка служебного сообщения.
        /// </summary>
        event Action<string> PostMessage;

        /// <summary>
        /// Все пользователи.
        /// </summary>
        /// <returns></returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Все логи.
        /// </summary>
        /// <returns></returns>
        List<Logbook> GetAllLogbooks();

        /// <summary>
        /// Все запросы.
        /// </summary>
        /// <returns></returns>
        List<Request> GetAllRequests();

        /// <summary>
        /// Поиск пользователя по логину и паролю
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUser(string login, string password);

        /// <summary>
        /// Пользовательские логи.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Logbook> GetUserLogbooks(User user);

        /// <summary>
        /// Пользовательские запросы.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Request> GetUserRequests(User user);

        void AddUser(User user);
        void UpdateUser(User user);
        void AddRequests(Request request);
        void AddLogbook(Logbook logbook);
        void RemoveUser(User user);
    }
}
