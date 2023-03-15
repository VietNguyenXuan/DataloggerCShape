using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class Line:IEntity
  {
    [Browsable(false)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreate { get; set; }


    [Browsable(false)]
    public int FactoryId { get; set; }

    [Browsable(false)]
    public Factory Factory { get; set; }

    [Browsable(false)]
    public List<Device> Devices { get; set; }
  }
}
