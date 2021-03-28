using FormForTest.Models;
using System;
using System.Collections.Generic;
using FormForTest.Controllers;

namespace FormForTest.UI
{
    /// <summary>
    /// Обший интерфейс презинтера.
    /// </summary>
    public interface IPresinter
    {
        void Run();
        void Close();
    }

    /// <summary>
    /// Общий интерфейс окон.
    /// </summary>
    public interface IView
    {
        void Show();
        void Close();
    }

    /// <summary>
    /// Представлеие окна логирования.
    /// </summary>
    public interface ILogin : IView
    {
        event Func<string, string, User> Login;
        event Action<User> Logged_in;
        event Action Clossed;
        void ShowError(string mes);
    }

    /// <summary>
    /// Представления пользователя.
    /// </summary>
    public interface IUserForm : IView
    {
        /// <summary>
        /// Событие get запроса.
        /// </summary>
        event Func<string, string> GetRequest;

        /// <summary>
        /// Событие post запроса.
        /// </summary>
        event Func<string, string, string> PostRequest;
    }

    /// <summary>
    /// Представление презентера администратора.
    /// </summary>
    public interface IAdminPresinter : IPresinter
    {
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(int id, User newUser);
    }

    /// <summary>
    /// Представление для администратора.
    /// </summary>
    public interface IAdminForm : IUserForm
    {
        event Func<List<User>> GetUsers;
        event Action<User> AddUser;
        event Action<User> RemoveUser;
        event Func<int, User> UpdateUser;
    }

    /// <summary>
    /// Представление для контроллера запросов.
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// GET запрос
        /// </summary>
        string GET_HttpReuest(string urlStr);

        /// <summary>
        /// POST запрос.
        /// </summary>
        string POST_HttpReuest(string urlStr, string jsonStr);
    }
}
