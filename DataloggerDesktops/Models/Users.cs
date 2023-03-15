using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class Users
  {
    [Browsable(false)]
    public int Id { get; set; }
    public string? NameLogIn { get; set; }
    public string? Fullname { get; set; }
    public string? BirthDay { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public DateTime DateCreate { get; set; }

    [Browsable(false)]
    public string? Password { get; set; }
  }
}
