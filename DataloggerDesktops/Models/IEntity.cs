using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public interface IEntity
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreate { get; set; }
  }
}
