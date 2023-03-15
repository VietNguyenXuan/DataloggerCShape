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

namespace DataloggerDesktops.UI
{
  public partial class AddFactoryForm : Form
  {
    public AddFactoryForm()
    {
      InitializeComponent();
    }

    RepositoryFactory _managerFactory = new RepositoryFactory();
    private async void btnAddFactory_Click(object sender, EventArgs e)
    {
      Factory factory = new Factory();
      factory.Name = txbAddFactory.Text;
      factory.DateCreate = DateTime.Now;
      await _managerFactory.Add(factory);
    }
  }
}
