using DataloggerDesktops.Repository;
using DataloggerDesktops.User;
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
  public partial class Account : Form
  {
    public Account()
    {
      InitializeComponent();
    }
    RepositoryUser _managerUsers = new RepositoryUser();
    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      CreateUser frmCreateUser = new CreateUser();
      frmCreateUser.ShowDialog();
    }

    public void UpdateData()
    {
      RepositoryUser _managerUsers = new RepositoryUser();
      dgvDisplayUser.DataSource = _managerUsers.GetAll();
    }
 
    private void Account_Load(object sender, EventArgs e)
    {
      UpdateData();

      // Thêm button edit và remove
      DataGridViewImageColumn imgEdit = new DataGridViewImageColumn();
      Image image1 = Image.FromFile(Application.StartupPath + "\\Resources\\edit_property_24px.png");
      imgEdit.Image = image1;
      imgEdit.HeaderText = "Edit";
      imgEdit.Name = "imgEdit";
      dgvDisplayUser.Columns.Add(imgEdit);

      DataGridViewImageColumn imgRemove = new DataGridViewImageColumn();
      Image image2 = Image.FromFile(Application.StartupPath + "\\Resources\\remove_24px.png");
      imgRemove.Image = image2;
      imgRemove.HeaderText = "Delete";
      imgRemove.Name = "imgDelete";
      dgvDisplayUser.Columns.Add(imgRemove);
    }

    private void dgvDisplayUser_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        UpdateUser frmUsers = new UpdateUser(e.RowIndex);
        frmUsers.ShowDialog();
      }
      else if (e.ColumnIndex == 1)
      {
        var idUser = _managerUsers.GetAllIdUser();
        _managerUsers.Delete(idUser[e.RowIndex]);
      }
    }

    private void tmrUpdateData_Tick(object sender, EventArgs e)
    {
      UpdateData();
    }
  }
}
