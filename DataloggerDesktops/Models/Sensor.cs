using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class Sensor : IEntity
  {
    public int Id { get; set ; }
    public string? Name { get ; set ; }
    public DateTime DateCreate { get; set ; }


    [Browsable(false)]
    public List<ParametterSetting>? ParametterSettings { get; set; }
  }
}
