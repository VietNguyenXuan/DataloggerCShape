using DataloggerDesktops.Properties;
using DataloggerDesktops.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataloggerDesktops.UI
{
  public partial class ViewSettingDeviceForm : Form
  {
    public ViewSettingDeviceForm()
    {
      InitializeComponent();
    }

    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    public int status = 0;
    public ViewSettingDeviceForm(string name)
    {
      InitializeComponent();

      UpdateData(name);
      // Thêm button edit và remove
      DataGridViewImageColumn imgEdit = new DataGridViewImageColumn();
      Image image1 = Image.FromFile(Application.StartupPath + "\\Resources\\edit_property_24px.png");
      imgEdit.Image = image1;
      imgEdit.HeaderText = "Edit";
      imgEdit.Name = "imgEdit";
      dgvViewSettingDevice.Columns.Add(imgEdit);

      DataGridViewImageColumn imgRemove = new DataGridViewImageColumn();
      Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\remove_24px.png");
      imgRemove.Image = image2;
      imgRemove.HeaderText = "Delete";
      imgRemove.Name = "imgDelete";
      dgvViewSettingDevice.Columns.Add(imgRemove);


      //DataGridViewButtonColumn Remove = new DataGridViewButtonColumn();
      //Remove.HeaderText = "Delete";
      //Remove.Name = "imgDelete";
      //dgvViewSettingDevice.Columns.Add(Remove);
    }


    private void dgvViewSettingDevice_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        switch (status)
        {
          case 1:
            UpdateFactory frmUpdateFactory = new UpdateFactory(e.RowIndex);
            frmUpdateFactory.ShowDialog();
            break;

          case 2:
            UpdateLine frmUpdateLine = new UpdateLine(e.RowIndex);
            frmUpdateLine.ShowDialog();
            break;

          case 3:
            UpdateDevice frmUpdateDevice = new UpdateDevice(e.RowIndex);
            frmUpdateDevice.ShowDialog();
            break;
        }

      }
      else if (e.ColumnIndex == 1)
      {
        switch(status)
        {
          case 1:
            try
            {
              var idFactory = _managerFactory.GetAllIdFactory();
              _managerFactory.Delete(idFactory[e.RowIndex]);
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            break;
          
          case 2:
            try
            {
              var idLine = _managerLine.GetAllIdLine();
              _managerLine.Delete(idLine[e.RowIndex]);
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            break;

          case 3:
            try
            {
              var idDevice = _managerDevice.GetAllIdDevice();
              _managerDevice.Delete(idDevice[e.RowIndex]);
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            break;
        }
        //UpdateData(status.ToString());
      }

      
    }


    public void UpdateData(string name)
    {
      RepositoryFactory _managerFactory = new RepositoryFactory();
      RepositoryLine _managerLine = new RepositoryLine();
      RepositoryDevice _managerDevice = new RepositoryDevice();

      switch (name)
      {
        case "1":
          lbViewsSettingDevice.Text = "Danh sách các nhà máy";
          dgvViewSettingDevice.DataSource = _managerFactory.GetAll();

          status = 1;
          break;
        case "2":
          lbViewsSettingDevice.Text = "Danh sách các line";
          dgvViewSettingDevice.DataSource = _managerLine.GetAll();

          status = 2;
          break;
        case "3":
          lbViewsSettingDevice.Text = "Danh sách các thiết bị";
          dgvViewSettingDevice.DataSource = _managerDevice.GetAll();

          status = 3;
          break;
      }
      
    }

    private void tmrUpdateData_Tick(object sender, EventArgs e)
    {
      UpdateData(status.ToString());
    }
  }
}
