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
  public partial class UpdateFactory : Form
  {
    public UpdateFactory()
    {
      InitializeComponent();
    }

    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    public UpdateFactory(int index)
    {
      InitializeComponent();

      txbNameFactory.Text = _managerFactory.GetNameFactory()[index];
    }

    private void btnUpdateFactory_Click(object sender, EventArgs e)
    {
      Factory factory=new Factory();


      factory.Id = _managerFactory.GetIdFactoryByName(txbNameFactory.Text)[0];

      factory.Name = txbUpdateFactory.Text;

      _managerFactory.UpdateFactory(factory);

    }
  }
}
