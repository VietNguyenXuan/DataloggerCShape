using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class ParametterSetting
  {
    [Key]
    public int? Id { get; set; }
    public string? StatusName { get; set; }
    public bool? Action { get; set; }
    public string? Condition { get; set; }
    public string? Threshold { get; set; }
    public string? Item { get; set; }
    public DateTime DateCreate { get; set; }
    public int? UnitId { get; set; }

    [Browsable(false)]
    public int? SensorId { get; set; }

    [Browsable(false)]
    public Sensor? Sensor { get; set; }

  }
}
