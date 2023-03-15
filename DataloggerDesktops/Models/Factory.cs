using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class Factory: IEntity
  {
    [Browsable(false)]
    public int Id { get; set; }

    public string? Name { get; set; }
    public DateTime DateCreate { get; set; }

    public List<Line>? Line { get; set; }
  }
}
