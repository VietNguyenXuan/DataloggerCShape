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
  public class Device:IEntity
  {
    [Browsable(false)]
    public int Id { get ; set ; }
    public string? Name { get ; set ; }
    public DateTime DateCreate { get ; set ; }
    public string? DeviceCode { get ; set ; }

    public float? Value { get; set; }


    [Browsable(false)]
    public int? LineId { get; set; }

    [Browsable(false)]
    public Line? Line { get; set; }


    [Browsable(false)]
    public List<ParametterSensor>? ParametterSensors { get; set; }

  }
}
