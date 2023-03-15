using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataloggerDesktops.User
{
  public partial class CreateUser : Form
  {
    RepositoryUser _managerUser = new RepositoryUser();
    public CreateUser()
    {
      InitializeComponent();
    }

    private void CreateUser_Load(object sender, EventArgs e)
    {
      lbPass.Visible = false;
      lbMobile.Visible = false;
    }

    
    private void btnSubmit_Click(object sender, EventArgs e)
    {
      if (CheckCollectData() != "")
      {
        MessageBox.Show(CheckCollectData(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      }
      else
      {
                Models.Users user = new Models.Users();
        user.NameLogIn = txbLogInName.Text;
        user.Fullname = txbFullName.Text;
        user.BirthDay = dtmBirthDay.Text;
        user.Email = txbEmail.Text;
        user.Mobile = txbMobile.Text;
        user.DateCreate = DateTime.Now;
        user.Password = txbPass.Text;
        _managerUser.Add(user);
      }
    }

    
    public string CheckCollectData()
    {
      string err = "";
      // 1. Kiểm tra hập tên đăng nhập
      if (txbLogInName.Text.Trim() == "")
      {
        err += "Vui lòng nhập tên đăng nhập ! \n";
      }
      // 2. Kiểm tra nhập họ và tên
      if (txbFullName.Text.Trim() == "")
      {
        err += "Vui lòng nhập họ và tên ! \n";
      }

      // 4. Kiểm tra nhập email
      if (txbEmail.Text.Trim() == "")
      {
        err += "Vui lòng nhập Email ! \n";
      }
      // 5. Kiểm tra nhập Passwords
      if (txbPass.Text.Trim() == "")
      {
        err += "Vui lòng nhập Passwords ! \n";
      }
      else if (txbPass.Text.Length < 8)
      {
        err += "Vui lòng nhập Passwords lớn hơn 8 kí tự ! \n";
      }
      else if (txbPass.Text != txbRepass.Text)
      {
        err += "Mật khẩu không khớp ! \n";
      }

      // 6. Kiểm tra số điện thoại
      int checkstringnumber = 0;
      if ((int.TryParse(txbMobile.Text, out checkstringnumber) == false))
      {
        err += "Vui lòng nhập đúng định dạng số điện thoại !\n";
      }

      return err.Trim();
    }




    private void txbRepass_TextChanged(object sender, EventArgs e)
    {
      if (txbRepass.Text != txbPass.Text)
      {
        txbRepass.BackColor = Color.Red;
      }
      else
      {
        txbRepass.BackColor = Color.White;
      }
    }

    

    private void txbPass_TextChanged(object sender, EventArgs e)
    {
      if (txbPass.Text.Length < 8)
      {
        lbPass.Visible = true;
        lbPass.Text = "Passwords phải lớn hơn 8 kí tự";
      }
      else lbPass.Visible = false;

    }


    private void txbMobile_TextChanged(object sender, EventArgs e)
    {
      int checkstringnumber = 0;
      if ((int.TryParse(txbMobile.Text, out checkstringnumber) == false))
      {
        lbMobile.Visible = true;
        lbMobile.Text = "Số điện thoại không đúng định dạng";
      }
      else
      {
        lbMobile.Visible = false;
      }
    }

    private void txbRepass_TextChanged_1(object sender, EventArgs e)
    {
      if (txbPass.Text != txbRepass.Text)
      {
        txbRepass.BackColor = Color.Red;
      }
      else txbRepass.BackColor = Color.White;
    }
  }
}
