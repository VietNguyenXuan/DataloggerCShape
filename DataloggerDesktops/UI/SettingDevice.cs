using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using DataloggerDesktops.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops
{
  public partial class SettingDevice : Form
  {
    public SettingDevice()
    {
      InitializeComponent();
    }

    private void SettingDevice_Load(object sender, EventArgs e)
    {
      cbDisplay.SelectedIndex= 0;
    }

    private void lbAddFactory_Click(object sender, EventArgs e)
    {
      AddFactoryForm frm = new AddFactoryForm();
      frm.ShowDialog();
      UpdateData();
    }
    private void lbAddLine_Click(object sender, EventArgs e)
    {
      AddLineForm frm = new AddLineForm();
      frm.ShowDialog();
      UpdateData();
    }
    private void lbAddDevice_Click(object sender, EventArgs e)
    {
      AddDeviceForm frm = new AddDeviceForm();
      frm.ShowDialog();
      UpdateData();
    }
   
    public void lbSeeMoreFatory_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("1");
      frm.ShowDialog();
      UpdateData();
    }

    public void lbSeeMoreLine_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("2");
      frm.ShowDialog();
      UpdateData();
    }

    public void lbSeeMoreDevice_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("3");
      frm.ShowDialog();
      UpdateData();
    }

    private void cbDisplay_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateData();
    }
    
    public void UpdateData()
    {
      RepositoryFactory _managerFactory = new RepositoryFactory();
      RepositoryLine _managerLine = new RepositoryLine();
      RepositoryDevice _managerDevice = new RepositoryDevice();

      var factory = _managerFactory.GetAll();
      var line = _managerLine.GetAll();
      var device= _managerDevice.GetAll();

      lbNumbersFactory.Text = factory.Count.ToString();
      lbNumbersLine.Text = line.Count.ToString();
      lbNumbersDevice.Text = device.Count.ToString();

      switch (cbDisplay.SelectedIndex)
      {
        case 0:
          dgvSettingDevice.DataSource = factory;
          LoadImage("factory");
          break;
        case 1:
          dgvSettingDevice.DataSource = line;
          LoadImage("line");
          break;
        case 2:
          dgvSettingDevice.DataSource = device;
          LoadImage("device");
          break;
      }
    }
    public void LoadImage(string filename)
    {
      //load image
      picDisplay.Image = new Bitmap(Application.StartupPath + $"\\Resources\\{filename}.png");
      picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}
