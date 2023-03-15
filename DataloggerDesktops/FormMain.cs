using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CodeBeautify;
using MQTTChanel;
using CodeBeautify;
//using System.Runtime.Intrinsics.X86;
using DataloggerDesktops.Models;
using DataloggerDesktops.User;
using DataloggerDesktops.Repository;

namespace DataloggerDesktops
{
  public partial class FormMain : Form
  {
    MQTTClass _mqttClass = new MQTTClass();
    public FormMain()
    {
      InitializeComponent();
      _mqttClass.OnMqttPayloadReceive += _mqttClass_OnMqttPayloadReceive;
    }

    private Task _mqttClass_OnMqttPayloadReceive(string data)
    {
      return ReadMQTT_WriteDB(data);
    }

    // Funstion off boading buttons
    private void OffButtonBord(Button button)
    {
      button.TabStop = false;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.TextAlign = ContentAlignment.MiddleLeft;
    }

    // Transfer forms
    private Form currentFormChild;
    private void openFormChild(Form formChild)
    {
      if (currentFormChild != null)
      {
        currentFormChild.Close();
      }
      currentFormChild = formChild;
      formChild.TopLevel = false;
      formChild.FormBorderStyle = FormBorderStyle.None;
      formChild.Dock = DockStyle.Fill;
      panelBody.Controls.Add(formChild);
      panelBody.Tag = formChild;
      formChild.BringToFront();
      formChild.Show();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      //var _login = new LogIn();
      //var _diaRe = _login.ShowDialog();
      //if (_diaRe == DialogResult.OK)
      //{
      //  //donothing
      //}
      //else
      //{
      //  Environment.Exit(0);
      //}


      // Tắt đường viền nút nhấn
      OffButtonBord(btnDashBoard);
      OffButtonBord(btnHistorical);
      OffButtonBord(btnStatistics);
      OffButtonBord(btnSetting);
      OffButtonBord(btnParameter);
      OffButtonBord(btnDevice);
      OffButtonBord(btnUser);
      OffButtonBord(btnTab);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;

      btnTab.BackColor = Color.FromArgb(8, 46, 112);


      // Khi chạy mặc định vào form dashboard
      //btnDashBoard.PerformClick();

      //btnSetting.PerformClick();
      //btnParameter.PerformClick();

      btnHistorical.PerformClick();

      //btnSetting.PerformClick();
      //btnUser.PerformClick();

      // load image
      //pictureBox_tab.Image = new Bitmap(Application.StartupPath + "\\Resources\\collapse_icon.png");
      //pictureBox_tab.SizeMode = PictureBoxSizeMode.StretchImage;

      _mqttClass.Connect();
    }

    private void btnDashBoard_Click(object sender, EventArgs e)
    {
      openFormChild(new DashBoard());
      btnDashBoard.BackColor = Color.FromArgb(8, 46, 112);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);
      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnHistorical_Click(object sender, EventArgs e)
    {
      openFormChild(new Historical());
      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(8, 46, 112);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);
      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnStatistics_Click(object sender, EventArgs e)
    {
      openFormChild(new Statistics());
      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(8, 46, 112);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);
      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnSetting_Click(object sender, EventArgs e)
    {
      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(8, 46, 112);
      btnParameter.Visible = true;
      btnDevice.Visible = true;
      btnUser.Visible = true;
    }

    private void btnParameter_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingParametter());
      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(8, 46, 112);
      btnParameter.BackColor = Color.FromArgb(8, 46, 112);
      btnDevice.BackColor = Color.FromArgb(4, 25, 61);
      btnUser.BackColor = Color.FromArgb(4, 25, 61);
    }

    private void btnDevice_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingDevice());
      btnParameter.BackColor = Color.FromArgb(4, 25, 61);
      btnDevice.BackColor = Color.FromArgb(8, 46, 112);
      btnUser.BackColor = Color.FromArgb(4, 25, 61);
    }

    private void btnUser_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingUser());

      btnParameter.BackColor = Color.FromArgb(4, 25, 61);
      btnDevice.BackColor = Color.FromArgb(4, 25, 61);
      btnUser.BackColor = Color.FromArgb(8, 46, 112);
    }
    bool _isStatusTab = true;
    private void btnTab_Click(object sender, EventArgs e)
    {
      _isStatusTab = !_isStatusTab;
      if (_isStatusTab)
      {
        panelControl.Size = new Size(155, 667);
        panelTab.Size = new Size(155, 50);
        btnTab.Location = new Point(115, 0);
        btnTab.Text = "<"; 
      }
      else
      {
        panelControl.Size = new Size(0, 667);
        panelTab.Size = new Size(100, 50);
        btnTab.Location = new Point(0, 0);
        btnTab.Text = ">";
      }
    }


    public string? jsonString = null;

    public async Task ReadMQTT_WriteDB(string data)
    {
      // Kiểm tra chuỗi Json
      if (string.IsNullOrWhiteSpace(data)) return;

      var dataFromMqtt = Welcome8.FromJson(data);

      if (dataFromMqtt != null)
      {
        // Lấy tất cả data của device
        var listObj = dataFromMqtt.Content.Devices.SelectMany(s => s.Solution).ToList();

        //Lấy data từng device
        //var listObj = welcome6.Content.Devices[0].Solution.ToList();

        // Convert to array
        var arrParametter = listObj.ToArray();

        RepositoryParametterSensors _managerParametterSensors = new RepositoryParametterSensors();

        var s = await _managerParametterSensors.GetAll();
        if (s != null)
        {
          if (s.Count < 13)
          {
            foreach (var item in arrParametter)
            {
              ParametterSensor parametterSensor = new ParametterSensor();

              parametterSensor.Name = item.Env.ToString();
              await _managerParametterSensors.Add(parametterSensor);
            }
          }
        }

        RepositoryParametterLog _managerParametterLog = new RepositoryParametterLog();
        foreach (var item in arrParametter)
        {
          ParametterLog parametterLog = new ParametterLog();
          parametterLog.Value = item.Value;
          parametterLog.DateCreate = DateTime.Now;

          int? SensorId = _managerParametterSensors.GetIdByName(item.Env.ToString());
          if (SensorId != null) parametterLog.ParametterSensorId = SensorId.Value;

          if (parametterLog!=null)
          {
            await _managerParametterLog.Add(parametterLog);
          }  
        }
      } 
    }

    private void picUser_Click(object sender, EventArgs e)
    {
      UserInfomation frmUser = new UserInfomation(this);
      frmUser.ShowDialog();
    }

  }
}
