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
  public class RepositoryParametterSetting
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public async Task Add(ParametterSetting parametterSetting)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.ParametterSettings.AddAsync(parametterSetting);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }


    public ParametterSetting? GetData(int idSensor)
    {
      _dbContext.Database.EnsureCreated();
      var data = _dbContext.ParametterSettings.Where(s=>s.SensorId== idSensor).OrderByDescending(s => s.Id).FirstOrDefault();
      if (data != null)
      {
        return data;
      }
      return null;
    }
  }
}
