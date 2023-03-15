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
  public class RepositoryDevice
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

        MessageBox.Show("Đã thêm thiết bị thành công");
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }



    //public async Task< List<Device>> GetAll()
    //{
    //  await _dbContext.Database.EnsureCreatedAsync();
    //  return await _dbContext.Devices.ToListAsync();
    //}

    public List<Device>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var device = _dbContext.Devices.ToList();
      if (device != null)
      {
        return device;
      }
      return null;
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

   
    //public async Task<List<int>?> GetIdDevice()
    //{
    //  await _dbContext.Database.EnsureCreatedAsync();
    //  var line = _dbContext.Devices.Select(s => s.Id).ToList();
    //  //return await _dbContext.Lines.Select(s => s.Id).ToListAsync();

    //  if (line != null)
    //  {
    //    return line;
    //  }
    //  return null;
    //}

    public List<int>? GetAllIdDevice()
    {
      _dbContext.Database.EnsureCreated();
      var device = _dbContext.Devices.Select(s => s.Id).ToList();

      if (device != null)
      {
        return device;
      }
      return null;
    }

    public List<string>? GetNameDevice()
    {
      _dbContext.Database.EnsureCreated();
      var device = _dbContext.Devices.Select(s => s.Name).ToList();

      if (device != null)
      {
        return device;
      }
      return null;
    }


    //public async Task UpdateDevice(Device devices)
    //{

    //  await _dbContext.Database.BeginTransactionAsync();

    //  try
    //  {
    //    var data = _dbContext.Devices.FirstOrDefault(d => d.Id == devices.Id);
    //    if (data != null)
    //    {
    //      data.Name = devices.Name;
    //      data.DateCreate = devices.DateCreate;

    //      _dbContext.SaveChanges();
    //    }

    //    await _dbContext.Database.CommitTransactionAsync();
    //  }
    //  catch (Exception)
    //  {
    //    await _dbContext.Database.RollbackTransactionAsync();
    //  }
    //}

    public void UpdateDevice(Device devices)
    {
      var data = _dbContext.Devices.FirstOrDefault(d => d.Id == devices.Id);
     
      if (data != null)
      {
        data.Name = devices.Name;
        data.DateCreate = devices.DateCreate;
        //data.Value = devices.Value;
        data.DeviceCode = devices.DeviceCode;
        data.LineId = devices.LineId;
        _dbContext.SaveChanges();
      }
    }

    public List<int>? GetIdDeviceByName(string name)
    {
      _dbContext.Database.EnsureCreated();
      var device = _dbContext.Devices.Where(s => s.Name == name).ToList();

      if (device != null)
      {
        return device.Select(s => s.Id).ToList();
      }

      return null;
    }


    public async Task<List<string>?> GetNameDeviceByIdLine(string name, int idLine)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      var nameDevice = await _dbContext.Devices.Where(s => s.LineId == idLine).Select(s => s.Name).ToListAsync();

      if (nameDevice != null)
      {
        return nameDevice;
      }
      return null;
    }

  }
}
