using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Models
{
  internal class ApplicationDbContext :DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source={Application.StartupPath}/DB.db");
    }


    public DbSet<Factory>? Factories { get; set; }
    public DbSet<Line>? Lines { get; set; }
    public DbSet<Device>? Devices { get; set; }

    public DbSet<Users>? Users { get; set; }
    public DbSet<UserHistorical>? UserHistoricals { get; set; }

    public DbSet<ParametterSensor> ParametterSensors { get; set;}
    public DbSet<ParametterLog> ParametterLogs { get; set; }

    public DbSet<ParametterSetting> ParametterSettings { get; set;}
    public DbSet<Sensor> Sensors { get; set; }

  }
}
