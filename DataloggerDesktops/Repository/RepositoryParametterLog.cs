using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DataloggerDesktops.Repository
{
  public class RepositoryParametterLog
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(ParametterLog parametterLog)
    {
      await _dbContext.Database.BeginTransactionAsync();

      try
      {
        await _dbContext.Database.EnsureCreatedAsync();

        await _dbContext.ParametterLogs.AddAsync(parametterLog);

        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }


    public List<ParametterLog>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var parametriclogs = _dbContext.ParametterLogs.ToList();

      if (parametriclogs != null)
      {
        return parametriclogs;
      }

      return null;
    }

    public async Task <ParametterLog?> GetValuesByIdParametter(int idPara)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      var values = await _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).OrderByDescending(s => s.Id).FirstOrDefaultAsync();
      if (values != null)  return  values;
      return null;
    }


    public async Task< List<ParametterLog>?> GetDataChart(int idPara, DateTime dateStart, DateTime dateEnd)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      var values = await _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).Where(x => x.DateCreate.Date >= dateStart && x.DateCreate.Date <= dateEnd).ToListAsync();
      if (values != null) return values;
      return null;
    }



    public iChart? GetDataChart2(int idPara, int hour, DateTime dateStart, DateTime dateEnd)
    {
      _dbContext.Database.EnsureCreated();
      var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).Where(x => x.DateCreate.Hour == hour).OrderByDescending(s => s.Id).FirstOrDefault();
      if (values != null)
      {
        return new iChart
        {
          DateCreate = values.DateCreate,
          Value = (float)values.Value
        };
      }
      return null;
    }





    public List<ParametterLog>? GetDataByDate(int idPara, DateTime dateStart, DateTime dateEnd)
    {
      _dbContext.Database.EnsureCreated();
      var values2 = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).Where(x => x.DateCreate.Date >= dateStart && x.DateCreate.Date <= dateEnd).OrderBy(s => s.Id).ToList(); //OrderByDescending
      if (values2 != null)
      {
        return values2;
      }
      return null;
    }

  }
}
