using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Repository
{
  public class RepositoryLine
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public async Task Add(Line line)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.Lines.AddAsync(line);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();

        MessageBox.Show("Đã thêm line thành công");
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

   
    public List<Line>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var line = _dbContext.Lines.ToList();
      if (line != null)
      {
        return line;
      }
      return null;
    }

    public async Task Delete(int id)
    {
      await _dbContext.Database.BeginTransactionAsync();

      try
      {
        var line = _dbContext.Lines.SingleOrDefault(m => m.Id == id);
        _dbContext.Lines.Remove(line);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

  

    public List<string>? GetNameLine()
    {
      _dbContext.Database.EnsureCreated();
      var line = _dbContext.Lines.Select(s => s.Name).ToList();

      if (line != null)
      {
        return line;
      }
      return null;
    }

    public async Task <int>? GetIdLineByName(string name)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      int idLine = await _dbContext.Lines.Where(s => s.Name == name).Select(s => s.Id).FirstOrDefaultAsync();
      return idLine;
    }

    public List<int>? GetAllIdLine()
    {
      _dbContext.Database.EnsureCreated();
      var line = _dbContext.Lines.Select(s => s.Id).ToList();

      if (line != null)
      {
        return line;
      }
      return null;
    }


    public Line GetById(int id)
    {
      throw new NotImplementedException();
    }

    public void UpdateLine(Line line)
    {
      var data = _dbContext.Lines.FirstOrDefault(d => d.Id == line.Id);

      if (data != null)
      {
        data.Name = line.Name;
        data.DateCreate = line.DateCreate;
        data.FactoryId = line.FactoryId;

        _dbContext.SaveChanges();
      }
    }

    public List<string>? GetNameLineByIdFactory(string name, int idFactory)
    {
      _dbContext.Database.EnsureCreated();
      var nameFactory = _dbContext.Lines.Where(s=>s.FactoryId==idFactory).Select(s => s.Name).ToList();

      if (nameFactory != null)
      {
        return nameFactory;
      }
      return null;
    }


  }
}
