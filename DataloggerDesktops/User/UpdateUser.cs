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
  public partial class UpdateUser : Form
  {
    RepositoryUser _managerUser = new RepositoryUser();
    public UpdateUser()
    {
      InitializeComponent();
    }
    public int idChoose;
    public UpdateUser(int index)
    {
      InitializeComponent();
      idChoose=index;
    }

    string passwords;
    private void UpdateUser_Load(object sender, EventArgs e)
    {
      lbMobile.Visible= false;

            // Hiển thị giá trị cũ lên màn hình update
            Models.Users userOld = _managerUser.GetDatabyId(_managerUser.GetAllIdUser()[idChoose]);
      txbLogInName.Text = userOld.NameLogIn;
      txbFullName.Text = userOld.Fullname;
      //dtmBirthDay.
      txbEmail.Text = userOld.Email;
      txbMobile.Text = userOld.Mobile;

      passwords = userOld.Password;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (passwords==txbPass.Text)
      {
        if (CheckCollectData() != "")
        {
          MessageBox.Show(CheckCollectData(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        else
        {
                    Models.Users userNew = new Models.Users();
          // Lấy id vị trí cần update
          userNew.Id = _managerUser.GetAllIdUser()[idChoose];
          userNew.NameLogIn = txbLogInName.Text;
          userNew.Fullname = txbFullName.Text;
          userNew.BirthDay = dtmBirthDay.Text;
          userNew.Email = txbEmail.Text;
          userNew.Mobile = txbMobile.Text;
          userNew.DateCreate = DateTime.Now;
          userNew.Password = txbPass.Text;

          _managerUser.UpdateUser(userNew);
          this.Close();
        }
      }  
      else
      {
        MessageBox.Show("Sai passwords", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        txbPass.Text= string.Empty;
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

      // 6. Kiểm tra số điện thoại
      int checkstringnumber = 0;
      if ((int.TryParse(txbMobile.Text, out checkstringnumber) == false))
      {
        err += "Vui lòng nhập đúng định dạng số điện thoại !\n";
      }

      return err.Trim();
    }

    private void txbMobile_TextChanged(object sender, EventArgs e)
    {
      int checkstringnumber = 0;
      if ((int.TryParse(txbMobile.Text, out checkstringnumber) == false))
      {
        lbMobile.Text = "Vui lòng nhập đúng định dạng số điện thoại";
      }
    }
  }
}
