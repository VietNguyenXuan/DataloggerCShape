using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.UI
{
  public partial class AddDeviceForm : Form
  {
    public AddDeviceForm()
    {
      InitializeComponent();
    }

    private void AddDeviceForm_Load(object sender, EventArgs e)
    {
      UpdateComboboxIdLine();
    }

    public void UpdateComboboxIdLine()
    {
      RepositoryLine _managerLine = new RepositoryLine();

      var dbIdLine = _managerLine.GetNameLine();
      cbAddDevice.DataSource = dbIdLine;
    }


    RepositoryDevice _managerDevice = new RepositoryDevice();

    RepositoryLine _managerLine = new RepositoryLine();
    private async void btnAddDevice_Click(object sender, EventArgs e)
    {
      Device device = new Device();

      device.Name = cbAddDevice.SelectedItem + "-" + txbNewDevice.Text;
      device.DateCreate = DateTime.Now;

      device.DeviceCode=txbCodeDevice.Text;

      Random rd = new Random();
      device.Value = rd.Next(1, 100);

      device.LineId = await _managerLine.GetIdLineByName(cbAddDevice.SelectedItem.ToString());

      //device.LineId= cbAddDevice.SelectedIndex+1;
      //device.LineId = int.Parse(cbAddDevice.SelectedItem.ToString());


      await _managerDevice.Add(device);
    }

  }
}
