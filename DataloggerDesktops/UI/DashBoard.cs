using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using MQTTnet.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataloggerDesktops
{
  public partial class DashBoard : Form
  {
    public DashBoard()
    {
      InitializeComponent();
    }

    RepositoryParametterLog _managerParalog=new RepositoryParametterLog();
    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    private void DashBoard_Load(object sender, EventArgs e)
    {
      var nameFactory = _managerFactory.GetNameFactory();
      if (nameFactory != null) cbFactory.DataSource = nameFactory;

      LoadData();
    }
    private void cbFactory_SelectedValueChanged(object sender, EventArgs e)
    {
      // Lấy ra id Factory và hiển thị cb Line
      if (cbFactory.SelectedItem != null)
      {
        int idFactory = _managerFactory.GetIdFactoryByName(cbFactory.SelectedItem.ToString())[0];
        var nameLine = _managerLine.GetNameLineByIdFactory(cbFactory.SelectedItem.ToString(), idFactory);

        cbLine.DataSource = null;
        if (nameLine != null) cbLine.DataSource = nameLine;
      }
    }


    private async void cbLine_SelectedValueChanged_1(object sender, EventArgs e)
    {
      // Lấy ra id Line và hiển thị cb Device
      if (cbLine.SelectedItem != null)
      {
        int idLine = await _managerLine.GetIdLineByName(cbLine.SelectedItem.ToString());
        var nameDevice =await _managerDevice.GetNameDeviceByIdLine(cbLine.SelectedItem.ToString(), idLine);
        cbDevice.DataSource = null;
        if (nameDevice != null) cbDevice.DataSource = nameDevice;
      }
    }

    private async void tmrDashBoard_Tick(object sender, EventArgs e)
    {
      await LoadData();
    }


    public async Task LoadData()
    {
      try
      {
        // Hiển thị temp và speed
        var dataTemp = await _managerParalog.GetValuesByIdParametter(10);
        if (dataTemp != null) cpbTemp.Text = dataTemp.Value.ToString();

        var dataSpeed = await _managerParalog.GetValuesByIdParametter(4);
        if (dataSpeed != null) cpbSpeed.Text = dataSpeed.Value.ToString();

        // Clear các điểm trên chart trước khi load
        chartVibration.Series["Dữ liệu độ rung"].Points.Clear();
        chartAccoustic.Series["Dữ liệu âm thanh"].Points.Clear();
        chartMagFd.Series["Dữ liệu từ trường"].Points.Clear();

        var dataVibration = await _managerParalog.GetDataChart(7, DateTime.Now.Date, DateTime.Now.Date);
        var dataAcoustic = await _managerParalog.GetDataChart(11, DateTime.Now.Date, DateTime.Now.Date);
        var dataMagFd = await _managerParalog.GetDataChart(1, DateTime.Now.Date, DateTime.Now.Date);

        if (dataVibration != null)
        {
          for (int i = 0; i < dataVibration.Count(); i=i+3)
          {
            chartVibration.Series["Dữ liệu độ rung"].Points.AddXY(dataVibration[i].DateCreate.Hour.ToString() + ":00", dataVibration[i].Value);
          }  
        }
        if (dataAcoustic != null)
        {
          for (int i = 0; i < dataAcoustic.Count(); i = i + 3)
          {
            chartAccoustic.Series["Dữ liệu âm thanh"].Points.AddXY(dataAcoustic[i].DateCreate.Hour.ToString() + ":00", dataAcoustic[i].Value);
          }
        }
        if (dataMagFd != null)
        {
          for (int i = 0; i < dataMagFd.Count(); i = i + 3)
          {
            chartMagFd.Series["Dữ liệu từ trường"].Points.AddXY(dataMagFd[i].DateCreate.Hour.ToString() + ":00", dataMagFd[i].Value);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    
  }
}
