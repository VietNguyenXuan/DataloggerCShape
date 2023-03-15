using DataloggerDesktops.Models;
using DataloggerDesktops.User;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataloggerDesktops.Repository
{
  public class RepositoryUser
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(Users users)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.Users.AddAsync(users);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();

        MessageBox.Show("Đã tạo tài khoản thành công");
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }


    public List<Users>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var user = _dbContext.Users.ToList();
      if (user != null)
      {
        return user;
      }
      return null;
    }


    public async Task Delete(int id)
    {
      await _dbContext.Database.BeginTransactionAsync();

      try
      {
        var user = _dbContext.Users.SingleOrDefault(m => m.Id == id);
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    public List<int>? GetAllIdUser()
    {
      _dbContext.Database.EnsureCreated();
      var user = _dbContext.Users.Select(s => s.Id).ToList();

      if (user != null)
      {
        return user;
      }
      return null;
    }


    public void UpdateUser(Users user)
    {
      var data = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);

      if (data != null)
      {
        data.NameLogIn = user.NameLogIn;
        data.Fullname=user.Fullname;
        data.BirthDay=user.BirthDay;
        data.Email=user.Email;
        data.Password=user.Password;
        data.DateCreate=user.DateCreate;
        data.Mobile=user.Mobile;

        _dbContext.SaveChanges();

        MessageBox.Show("Update thành công");
      }
    }


    public Users? GetDatabyId(int id)
    {
      _dbContext.Database.EnsureCreated();
      var user = _dbContext.Users.Where(s => s.Id == id).ToList();

      if (user != null)
      {
        return user[0];
      }

      return null;
    }


    public List<string>? GetNameUsers()
    {
      _dbContext.Database.EnsureCreated();
      var users = _dbContext.Users.Select(s => s.NameLogIn).ToList();

      if (users != null)
      {
        return users;
      }
      return null;
    }


    public List<string>? GetPassByName(string name)
    {
      _dbContext.Database.EnsureCreated();
      var user = _dbContext.Users.Where(s => s.NameLogIn == name).ToList();

      if (user != null)
      {
        return user.Select(s => s.Password).ToList(); // Trả về list các pass mà có chung tên name
      }

      return null;
    }

    public Users LogIn(string username, string password)
    {
      return _dbContext.Users.FirstOrDefault(user => user.NameLogIn == username && user.Password == password);
    }





  }
}
