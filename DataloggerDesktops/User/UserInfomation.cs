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
using static System.Windows.Forms.DataFormats;

namespace DataloggerDesktops.User
{
  public partial class UserInfomation : Form
  {
    FormMain frm = null;
    
    public UserInfomation()
    {
      InitializeComponent();
    }

    public UserInfomation(FormMain frm)
    {
      InitializeComponent();
      this.frm = frm;
    }
    RepositoryUserHisrorical _managerUserHisrorical=new RepositoryUserHisrorical();
    private void UserForm_Load(object sender, EventArgs e)
    {
      lbNameLogIn.Text= _managerUserHisrorical.GetNameLogInCurrent()[0];
    }

    
    private void btnLogOut_Click(object sender, EventArgs e)
    {
      //LogIn frmLogIn = new LogIn();

      //this.Hide();
      //this.frm.Visible = false;
      //this.frm.Close();
      this.Close();
      //this.frm.Close();
      //frmLogIn.ShowDialog();

      //Environment.Exit(0);



      //FormMain frmMain=new FormMain();
      //frmMain.Closed += (s, args) => this.Close();
      //frmMain.Close();


      //LogIn frmLogIn = new LogIn();

      //frmLogIn.ShowDialog();

      //this.Hide();
      //Form1 a = new Form1();
      //a.Closed += (s, args) => this.Close();
      //a.Show();
    }

    private void UserInfomation_FormClosed(object sender, FormClosedEventArgs e)
    {
      //FormMain frm =new FormMain();
      //frm.ShowDialog();

      //MessageBox.Show("Xong");
    }

    private void UserInfomation_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }
  }
}
