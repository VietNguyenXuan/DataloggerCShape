using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataloggerDesktops
{
  public partial class SettingParametter : Form
  {
    public SettingParametter()
    {
      InitializeComponent();
      LoadDataGridView();
    }

    RepositoryParametterSetting _managerParametterSetting = new RepositoryParametterSetting();
    RepositorySensor _managerSensor = new RepositorySensor();

    public string[] statusActive = { "switch_off_48px", "switch_on_48px" };
    public bool activeTemp=false;
    public bool activeAcoustic = false;
    public bool activeVibration = false;
    public bool activeSpeed = false;
    public bool activeMagneticField = false;


    private void SettingParametter_Load(object sender, EventArgs e)
    {
      LoadAllData();  // Load data cũ lên
    }

    private void btnChange_Click(object sender, EventArgs e)
    {
      LoadAllData();
    }

    public void btnSave_Click(object sender, EventArgs e)
    {
      SaveAll();
      LoadAllData();
    }

    public async Task SaveData(DataGridView dgv, bool nameAction, string nameFind, System.Windows.Forms.ComboBox comboBox)
    {
      try
      {
        ParametterSetting parametterSetting = new ParametterSetting();

        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgv.Rows[0].Cells["conditionCol"];
        if (cell != null) parametterSetting.Condition = cell.Value.ToString();
        if (dgv.Rows[0].Cells["thresholdCol"].Value.ToString()!="") parametterSetting.Threshold = dgv.Rows[0].Cells["thresholdCol"].Value.ToString();
       
        parametterSetting.Action = nameAction;

        if (dgv.Rows[0].Cells["itemCol"].Value.ToString()!="") parametterSetting.Item = dgv.Rows[0].Cells["itemCol"].Value.ToString();

        parametterSetting.SensorId = _managerSensor.GetIdDeviceByName(nameFind);

        parametterSetting.DateCreate = DateTime.Now;
        parametterSetting.UnitId = comboBox.SelectedIndex;
        await _managerParametterSetting.Add(parametterSetting);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
    }
    public async Task SaveAll()
    {
      await SaveData(dgvMagneticField, activeMagneticField, "Magnetometer", cbMagneticField);
      await SaveData(dgvVibration, activeVibration, "Accelerometer (Primary)", cbVibration);
      await SaveData(dgvSpeed, activeSpeed, "Accelerometer (Secondary)", cbSpeed);
      await SaveData(dgvTemp, activeTemp, "Temperature", cbTemp);
      await SaveData(dgvAcoustic, activeAcoustic, "Microphone", cbAcoustic);
    }
    public void LoadData(int idSensor, DataGridView dgv, PictureBox picture, System.Windows.Forms.ComboBox comboBox)
    {
      var data = _managerParametterSetting.GetData(idSensor);
      if (data != null)
      {
        if (data.Action == true)
        {
          Image imageOn = Image.FromFile(Application.StartupPath + $"\\Resources\\{statusActive[1]}.png");
          dgv.Rows[0].Cells["Active"].Value = imageOn;
          picture.Image = imageOn;
        }
        else if (data.Action == false)
        {
          Image imageOff = Image.FromFile(Application.StartupPath + $"\\Resources\\{statusActive[0]}.png");
          dgv.Rows[0].Cells["Active"].Value = imageOff;
          picture.Image = imageOff;
        }
        DataGridViewComboBoxCell? comboBoxCell = dgv.Rows[0].Cells["conditionCol"] as DataGridViewComboBoxCell;
        if (comboBoxCell != null)
        {
          comboBoxCell.Value = data.Condition;
        }
        dgv.Rows[0].Cells["thresholdCol"].Value = data.Threshold;
        dgv.Rows[0].Cells["itemCol"].Value = data.Item;

        comboBox.SelectedIndex = data.UnitId.Value;
      }
    }
    public void LoadAllData()
    {
      LoadData(1, dgvMagneticField, picMagneticField,cbMagneticField);
      LoadData(2, dgvSpeed, picSpeed,cbSpeed);
      LoadData(3, dgvVibration, picVibration, cbVibration);
      LoadData(4, dgvTemp, picTemp, cbTemp);
      LoadData(5, dgvAcoustic, picAcoustic, cbAcoustic);
    }

    void AddColId_StatusName(DataGridView dgv,string col1Name, string col2Name, string status)
    {
      DataTable dt = new DataTable();
      dt.Columns.Add(col1Name, typeof(int));
      dt.Columns.Add(col2Name, typeof(string));
      DataRow row;
      row = dt.NewRow();
      row[col1Name] = 1;
      row[col2Name] = status;
      dt.Rows.Add(row);
      dgv.DataSource = dt;
    }
    void AddColActive(DataGridView dgv, string headerCol, string NameCol, string linkPic)
    {
      DataGridViewImageColumn ImgCol = new DataGridViewImageColumn();
      Image image = Image.FromFile(Application.StartupPath + $"\\Resources\\{linkPic}.png");
      ImgCol.Image = image;
      ImgCol.HeaderText = headerCol;
      ImgCol.Name = NameCol;
      dgv.Columns.Add(ImgCol);
      ImgCol.Width = 150;
    }
    void AddColCondition(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewComboBoxColumn CbCol = new DataGridViewComboBoxColumn();
      CbCol.HeaderText = headerCol;
      CbCol.Name = NameCol;
      CbCol.Items.Add(">");
      CbCol.Items.Add("<");
      CbCol.Items.Add(">=");
      CbCol.Items.Add("<=");
      dgv.Columns.Add(CbCol);
      CbCol.Width = 150;
    }
    void AddColThreshold(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewTextBoxColumn thresholdCol = new DataGridViewTextBoxColumn();
      thresholdCol.HeaderText = headerCol;
      thresholdCol.Name = NameCol;
      dgv.Columns.Add(thresholdCol);
    }
    void AddColItem(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewTextBoxColumn itemCol = new DataGridViewTextBoxColumn();
      itemCol.HeaderText = headerCol;
      itemCol.Name = NameCol;
      dgv.Columns.Add(itemCol);
    }

    
   
    private void picTemp_Click(object sender, EventArgs e)
    {
      activeTemp = !activeTemp;
      Action(activeTemp, picTemp);
    }

    public void picVibration_Click(object sender, EventArgs e)
    {
      activeVibration=!activeVibration;
      Action(activeVibration, picVibration);
    }

    public void picAcoustic_Click(object sender, EventArgs e)
    {
      activeAcoustic=!activeAcoustic;
      Action(activeAcoustic, picAcoustic);
    }

    public void picMagneticField_Click(object sender, EventArgs e)
    {
      activeMagneticField=!activeMagneticField;
      Action(activeMagneticField, picMagneticField);
    }

    public void picSpeed_Click(object sender, EventArgs e)
    {
      activeSpeed=!activeSpeed;

      Action(activeSpeed, picSpeed);
    }


    public void Action(bool nameAction,PictureBox picture)
    {
      if (nameAction == true)
      {
        Image image = Image.FromFile(Application.StartupPath + $"\\Resources\\{statusActive[1]}.png");
        picture.Image = image;
      }
      else
      {
        Image image = Image.FromFile(Application.StartupPath + $"\\Resources\\{statusActive[0]}.png");
        picture.Image = image;
      }
    }

    public void LoadDataGridView()
    {
      // tắt hiển thị dòng cuối datagridview
      dgvTemp.AllowUserToAddRows = false;
      dgvAcoustic.AllowUserToAddRows = false;
      dgvMagneticField.AllowUserToAddRows = false;
      dgvSpeed.AllowUserToAddRows = false;
      dgvVibration.AllowUserToAddRows = false;

      //Dgv temp
      AddColId_StatusName(dgvTemp, "ID", "StatusName", "High temperature");    // Thêm cột ID và status name
      AddColActive(dgvTemp, "Kích hoạt", "Active", statusActive[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvTemp, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvTemp, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvTemp, "Item", "itemCol");                                 // Thêm cột Item
      dgvTemp.Columns["ID"].Width = 30;
      dgvTemp.Columns["StatusName"].Width = 120;


      //Acoustic Data | Dữ liệu âm thanh
      AddColId_StatusName(dgvAcoustic, "ID", "StatusName", "High Acoustic");    // Thêm cột ID và status name
      AddColActive(dgvAcoustic, "Kích hoạt", "Active", statusActive[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvAcoustic, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvAcoustic, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvAcoustic, "Item", "itemCol");                                 // Thêm cột Item
      dgvAcoustic.Columns["ID"].Width = 30;
      dgvAcoustic.Columns["StatusName"].Width = 120;


      //Vibration Data | Dữ liệu độ rung
      AddColId_StatusName(dgvVibration, "ID", "StatusName", "High Vibration");    // Thêm cột ID và status name
      AddColActive(dgvVibration, "Kích hoạt", "Active", statusActive[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvVibration, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvVibration, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvVibration, "Item", "itemCol");                                 // Thêm cột Item
      dgvVibration.Columns["ID"].Width = 30;
      dgvVibration.Columns["StatusName"].Width = 120;

      // Magnetic Field Data | Dữ liệu từ trường
      AddColId_StatusName(dgvMagneticField, "ID", "StatusName", "High Field Data");    // Thêm cột ID và status name
      AddColActive(dgvMagneticField, "Kích hoạt", "Active", statusActive[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvMagneticField, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvMagneticField, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvMagneticField, "Item", "itemCol");                                 // Thêm cột Item
      dgvMagneticField.Columns["ID"].Width = 30;
      dgvMagneticField.Columns["StatusName"].Width = 120;

      //// Magnetic Speed | Dữ liệu tốc độ
      AddColId_StatusName(dgvSpeed, "ID", "StatusName", "High Speed");    // Thêm cột ID và status name
      AddColActive(dgvSpeed, "Kích hoạt", "Active", statusActive[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvSpeed, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvSpeed, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvSpeed, "Item", "itemCol");                                 // Thêm cột Item
      dgvSpeed.Columns["ID"].Width = 30;
      dgvSpeed.Columns["StatusName"].Width = 120;
    }

    
  }
}
