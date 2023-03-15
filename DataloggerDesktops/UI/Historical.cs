
using DataloggerDesktops.Models;
using DataloggerDesktops.Report;
using DataloggerDesktops.Repository;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DataloggerDesktops
{
  public partial class Historical : Form
  {
    public Historical()
    {
      InitializeComponent();
    }
    RepositoryParametterLog _managerParalog = new RepositoryParametterLog();
    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    public int statusPage = 1;
    private void Historical_Load(object sender, EventArgs e)
    {
      var nameFactory = _managerFactory.GetNameFactory();
      if (nameFactory != null) cbFactory.DataSource = nameFactory;
      LoadData();
    }
    private void tmrHistorical_Tick(object sender, EventArgs e)
    {
      //LoadData();
    }

    public void LoadData()
    {
      // Load từ database
      //Temp Data | Dữ liệu nhiệt độ | 10
      //Speed Data | Dữ liệu tốc độ | 4
      //Vibration Data | Dữ liệu độ rung | 7
      //Acoustic Data | Dữ liệu âm thanh | 11
      // Magnetic Field Data | Dữ liệu từ trường | 1
      dgvUp.Columns[2].Width = 100;
      dgvDown.Columns[2].Width = 100;
      switch (statusPage)
      {
        case 1:
          tlpDown.Visible = true; tlbHearderDown.Visible = true;
          FormatLoadData(dgvUp, "Nhiệt độ", 10, chartUp, "Up", dtmUpStart.Value, dtmUpEnd.Value);
          lbUp.Text = "Nhiệt độ";
          lbChartUp.Text = "Biểu đồ nhiệt độ";
          FormatLoadData(dgvDown, "Tốc độ", 4, chartDown, "Down", dtmDownStart.Value, dtmDownEnd.Value);
          lbDown.Text = "Tốc độ";
          lbChartDown.Text = "Biểu đồ tốc độ";

          picBack.Visible = false; picNext.Visible = true;
          break;
        case 2:
          tlpDown.Visible = true; tlbHearderDown.Visible = true;
          FormatLoadData(dgvUp, "Độ rung", 7, chartUp, "Up", dtmUpStart.Value, dtmUpEnd.Value);
          lbUp.Text = "Độ rung";
          lbChartUp.Text = "Biểu đồ độ rung";
          FormatLoadData(dgvDown, "Âm thanh", 11, chartDown, "Down", dtmDownStart.Value, dtmDownEnd.Value);
          lbDown.Text = "Âm thanh";
          lbChartDown.Text = "Biểu đồ âm thanh";

          picBack.Visible = true; picNext.Visible = true;
          break;
        case 3:
          FormatLoadData(dgvUp, "Từ trường", 1, chartUp, "Up", dtmUpStart.Value, dtmUpEnd.Value);
          lbUp.Text = "Từ trường";
          lbChartUp.Text = "Biểu đồ từ trường";

          tlpDown.Visible = false; tlbHearderDown.Visible = false;
          picBack.Visible = true; picNext.Visible = false;

          break;
      }
    }

    public async void FormatLoadData(DataGridView dgv, string name, int address, Chart chart, string nameSeries, DateTime dateStart, DateTime dateEnd)
    {
      try
      {
        var dgvValues = _managerParalog.GetDataByDate(address, dateStart.Date, dateEnd.Date);
        if (dgvValues != null)
        {
          dgv.Columns[2].HeaderText = name;
          dgv.Rows.Clear();
          for (int i = 0; i < dgvValues.Count; i++) dgv.Rows.Add(i + 1, dgvValues[i].DateCreate, dgvValues[i].Value);
        }

        // Load lên chart
        chart.Series[nameSeries].Points.Clear();
        var chartValues = await _managerParalog.GetDataChart(address, dateStart.Date, dateEnd.Date);
        if (chartValues != null)
        {
          for (int i = 0; i <chartValues.Count(); i++)
          {
            
            chart.Series[nameSeries].Points.AddXY(chartValues[i].DateCreate.Hour.ToString() + ":00", chartValues[i].Value);
          }
        }

        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
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
  
    private async void cbLine_SelectedValueChanged(object sender, EventArgs e)
    {
      // Lấy ra id Line và hiển thị cb Device
      if (cbLine.SelectedItem != null)
      {
        var a = await _managerLine.GetIdLineByName(cbLine.SelectedItem.ToString());
        int idLine = await _managerLine.GetIdLineByName(cbLine.SelectedItem.ToString());
        var nameDevice = await _managerDevice.GetNameDeviceByIdLine(cbLine.SelectedItem.ToString(), idLine);
        cbDevice.DataSource = null;
        if (nameDevice != null) cbDevice.DataSource = nameDevice;
      }
    }


    private void picBack_Click(object sender, EventArgs e)
    {
      if (statusPage > 1) statusPage --;
      LoadData();
    }

    private void picNext_Click(object sender, EventArgs e)
    {
      if (statusPage < 3) statusPage ++;
      LoadData();
    }

    private void btnUpSeeData_Click(object sender, EventArgs e)
    {
      ReviewData frmReviewData = new ReviewData("btnUp", statusPage, dtmUpStart.Value, dtmUpEnd.Value);
      frmReviewData.ShowDialog();
    }

    private void btnDownSeeData_Click(object sender, EventArgs e)
    {
      ReviewData frmReviewData = new ReviewData("btnDown", statusPage, dtmDownStart.Value, dtmDownEnd.Value);
      frmReviewData.ShowDialog();
    }

    ToExcel ToExcel= new ToExcel();
    RepositoryParametterLog _managerParametterLog = new RepositoryParametterLog();
    private void btnUpExport_Click(object sender, EventArgs e)
    {
      switch (statusPage)
      {
        case 1:
          var dataTemp = _managerParametterLog.GetDataByDate(10, dtmUpStart.Value.Date, dtmUpEnd.Value.Date);
          if (dataTemp != null) SaveExcel(dgvUp, dataTemp, "Nhiệt độ");
          break;
        case 2:
          var dataVibration = _managerParametterLog.GetDataByDate(7, dtmUpStart.Value.Date, dtmUpEnd.Value.Date);
          if (dataVibration!=null) SaveExcel(dgvUp, dataVibration, "Độ rung");
          break;
        case 3:
          var dataTempMag = _managerParametterLog.GetDataByDate(1, dtmUpStart.Value.Date, dtmUpEnd.Value.Date);
          if (dataTempMag != null) SaveExcel(dgvUp, dataTempMag, "Từ trường");
          break;
      }
    }
    private void btnDownExport_Click(object sender, EventArgs e)
    {
      switch (statusPage)
      {
        case 1:
          var dataSpeed = _managerParametterLog.GetDataByDate(4, dtmDownStart.Value.Date, dtmDownEnd.Value.Date);
          if (dataSpeed != null) SaveExcel(dgvDown, dataSpeed, "Tốc độ");
          break;
        case 2:
          var dataAccoustic = _managerParametterLog.GetDataByDate(11, dtmDownStart.Value.Date, dtmDownEnd.Value.Date);
          if (dataAccoustic != null) SaveExcel(dgvDown, dataAccoustic, "Âm thanh");
          break;
        case 3:
          //No code
          break;
      }
    }

    private void picLoadDataDown_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void picLoadDataUp_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    void SaveExcel(DataGridView dgv, List<ParametterLog> data, string NameSheet)
    {
      if (sdlUp.ShowDialog() == DialogResult.OK)
      {
        ToExcel.FromDatagridviewToExcel(dgv, sdlUp.FileName, NameSheet);
        DialogResult dr = MessageBox.Show("Xuất dữ liệu ra Excel thành công! \nBạn có muốn mở file ?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dr == DialogResult.Yes)
        {
         


        }
      }
      
    } 
  }
}
