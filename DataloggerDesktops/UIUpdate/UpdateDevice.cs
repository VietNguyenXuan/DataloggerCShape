using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.UI
{
  public partial class UpdateDevice : Form
  {
    public UpdateDevice()
    {
      InitializeComponent();
    }

    public UpdateDevice(int index)
    {
      InitializeComponent();

      txbNameDevice.Text = _managerDevice.GetNameDevice()[index];
    }

    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    private void UpdateDevice_Load(object sender, EventArgs e)
    {
      cbUpdateIdLineDevice.DataSource = _managerLine.GetNameLine();
    }

    private async void btnUpdateDevice_Click(object sender, EventArgs e)
    {
      Device device = new Device();

      device.Id = _managerDevice.GetIdDeviceByName(txbNameDevice.Text)[0];
      device.Name = cbUpdateIdLineDevice.SelectedItem.ToString() + " - " + txbUpdateDevice.Text;
      device.DateCreate = DateTime.Now;
      device.DeviceCode = txbUpdateCodeDevice.Text;
      device.LineId = await _managerLine.GetIdLineByName(cbUpdateIdLineDevice.SelectedItem.ToString());

      _managerDevice.UpdateDevice(device);
    }
  }
}
