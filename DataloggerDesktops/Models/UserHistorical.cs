using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class UserHistorical
  {
    [Browsable(false)]
    public int Id { get; set; }
    public string? NameLogIn { get; set; }
    public DateTime DateLogIn { get; set; }
  }
}
