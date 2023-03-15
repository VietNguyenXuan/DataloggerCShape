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

namespace DataloggerDesktops.User
{
  public partial class LogIn : Form
  {
    public LogIn()
    {
      InitializeComponent();
    }


    private void btnLogIn_Click(object sender, EventArgs e)
    {
      try
      {
        var _name = txbLogInName.Text;
        var _pass = txbPass.Text;
        // check logic
        //check usser name
        if (_name == null)
        {
          // msg
          return;
        }
        if (_pass == null)
        {
          // msg
          return;
        }
        //check pass


        // db
        RepositoryUser _managerUsers = new RepositoryUser();

        var _user = _managerUsers.LogIn(_name, _pass);

        if (_user != null)
        {
          // Thêm dữ liệu xuống db lịch sử đăng nhập vào app
          RepositoryUserHisrorical _managerUserHisrorical = new RepositoryUserHisrorical();
          UserHistorical user = new UserHistorical();
          user.NameLogIn = txbLogInName.Text;
          user.DateLogIn = DateTime.Now;
          _managerUserHisrorical.Add(user);

          this.DialogResult = DialogResult.OK;
        }
        else
        {
          //this.DialogResult = DialogResult.Cancel;
          MessageBox.Show("Tài khoản không tồn tại");
        }

      }
      catch (Exception ex)
      {
        // msg
        this.DialogResult = DialogResult.Cancel;
        //throw;
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
    {

    }

    private void LogIn_Load(object sender, EventArgs e)
    {
      lbErr.Visible= false;
    }

    private void txbPass_TextChanged(object sender, EventArgs e)
    {
      lbErr.Visible = true;
      if (txbPass.Text.Length < 8)
      {
        lbErr.Text = "Passwords phải lớn hơn 8 kí tự";
        lbErr.ForeColor = Color.Red;
      }

      else
      {
        lbErr.Text = "Passwords hợp lệ"; 
        lbErr.ForeColor = Color.Green;
      } 
    }
  }
}
