using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Repository
{
  public class RepositoryUserHisrorical
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(UserHistorical userHistorical)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.UserHistoricals.AddAsync(userHistorical);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    public List<string>? GetNameLogInCurrent() 
    {
      _dbContext.Database.EnsureCreated();
      var user = _dbContext.UserHistoricals.OrderByDescending(s => s.Id).Select(s => s.NameLogIn).ToList();

      if (user != null)
      {
        return user;
      }
      return null;
    }




  }
}
