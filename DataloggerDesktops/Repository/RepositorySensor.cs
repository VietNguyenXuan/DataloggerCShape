using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Repository
{
  public class RepositorySensor
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public int? GetIdDeviceByName(string name)
    {
      _dbContext.Database.EnsureCreated();
      var id = _dbContext.Sensors.Where(s => s.Name == name).Select(s => s.Id).FirstOrDefault();

      if (id != null)
      {
        return id;
      }

      return null;
    }
  }
}
