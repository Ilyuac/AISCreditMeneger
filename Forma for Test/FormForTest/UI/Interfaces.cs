using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.UI
{
    public interface IPresinter
    {
        void Run();
        void Close();
    }
    public interface IView
    {
        void Show();
        void Close();
    }
    public interface ILogin : IView
    {
        User User { get; }
        string Username { get; }
        string Password { get; }
        event Func<User> Login;
        event Action<User> Logged_in;
        event Action Clossed;
        void ShowError(string mes);
    }
    public interface IUserForm : IView
    {
        User User { get; }
        Request Request { get; }
        event Action PostRequest;
        event Action GetRequest;
    }
    public interface IAdminPresinter : IPresinter
    {

        string AddUser(User user);//!
        string RemoveUser(User user);//!
        string UpdateUser(int id, User newUser);//!
    }
    public interface IAdminForm : IUserForm
    {
        List<User> Users { get; }
        event Func<User, string> AddUser;
        event Func<User, string> RemoveUser;
        event Func<int, User, string> UpdateUser;
    }
}
