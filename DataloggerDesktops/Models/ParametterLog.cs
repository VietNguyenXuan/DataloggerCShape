using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class ParametterLog
  {
    [Browsable(false)]
    public int Id { get; set; }
    public float Value { get; set; }
    public DateTime DateCreate { get; set; }



    [Browsable(false)]
    public int ParametterSensorId { get; set; }

    [Browsable(false)]
    public ParametterSensor ParametterSensor { get; set; }
  }
}
