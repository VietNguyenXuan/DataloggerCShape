using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class ParametterSensor
  {
    [Browsable(false)]
    public int Id { get; set; }
    public string Name { get; set; }


    [Browsable(false)]
    public List<ParametterLog> ParametterLogs { get; set; }
  }
}
