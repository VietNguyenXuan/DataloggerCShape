using DataloggerDesktops.Repository;
using DataloggerDesktops.UI;
using DataloggerDesktops.User;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataloggerDesktops
{
  public partial class SettingUser : Form
  {
    RepositoryUser _managerUsers = new RepositoryUser();
    public SettingUser()
    {
      InitializeComponent();
    }

    // transfer forms
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
      pnlBodySettingUser.Controls.Add(formChild);
      pnlBodySettingUser.Tag = formChild;
      formChild.BringToFront();
      formChild.Show();
    }


    private void btnAccount_Click(object sender, EventArgs e)
    {
      openFormChild(new Account());
    }

    private void btnDecentralization_Click(object sender, EventArgs e)
    {
      openFormChild(new Decentralization());
    }

    private void SettingUser_Load(object sender, EventArgs e)
    {
      btnAccount.PerformClick();
    }
  }
}
