using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Repository
{
  public interface IRepository<T> where T : class
  {
    Task<List<T>> GetAll();
    Task <T> GetById(int id);
    Task Add(T machines);
    Task Update(T machines);
    Task Delete(int id);
  }
}
