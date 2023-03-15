using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Repository
{
  public class RepositoryBase<T> //where T : //Entity
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(Device devices)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.Devices.AddAsync(devices);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    public async Task<List<Device>> GetAll()
    {
      await _dbContext.Database.EnsureCreatedAsync();
      return await _dbContext.Devices.ToListAsync();
    }

    public async Task Delete(int id)
    {
      await _dbContext.Database.BeginTransactionAsync();

      try
      {
        var device = _dbContext.Devices.SingleOrDefault(m => m.Id == id);
        _dbContext.Devices.Remove(device);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    public async Task<List<int>> GetIdDevice()
    {
      await _dbContext.Database.EnsureCreatedAsync();
      //var machine = _dbContext.Devices.Select(s => s.Id).ToList();
      return await _dbContext.Devices.Select(s => s.Id).ToListAsync();
    }
  }
}
