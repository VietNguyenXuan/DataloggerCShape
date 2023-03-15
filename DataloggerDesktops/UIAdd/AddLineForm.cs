using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.UI
{
  public partial class AddLineForm : Form
  {
    public AddLineForm()
    {
      InitializeComponent();
    }

    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryFactory _managerFactory = new RepositoryFactory();

    private async void btnAddLine_Click(object sender, EventArgs e)
    {
      Line line = new Line();

      line.Name = cbAddLine.SelectedItem+" - "+txbAddLine.Text;
      line.DateCreate = DateTime.Now;
      line.FactoryId = _managerFactory.GetIdFactoryByName(cbAddLine.SelectedItem.ToString())[0];

      await _managerLine.Add(line);

    }

    private void AddLineForm_Load(object sender, EventArgs e)
    {
      UpdateComboboxIdFactory();
    }


    
    public void UpdateComboboxIdFactory()
    {
      RepositoryFactory _managerFactory = new RepositoryFactory();
      var dbIdFactory = _managerFactory.GetNameFactory();
      cbAddLine.DataSource = dbIdFactory;
    }

  }
}
