using DataloggerDesktops.Repository;
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

namespace DataloggerDesktops.Report
{
  public partial class ReviewData : Form
  {
    RepositoryParametterLog _managerParametterLog = new RepositoryParametterLog();
    public ReviewData()
    {
      InitializeComponent();
    }
    public ReviewData(string locationBtn, int Page, DateTime dateStart, DateTime dateEnd)
    {
      InitializeComponent();

      if (locationBtn=="btnUp")
      {
        switch (Page)
        {
          case 1:
            // Nhiệt độ
            var dataTemp = _managerParametterLog.GetDataByDate(10, dateStart.Date, dateEnd.Date);
            if (dataTemp != null) dgvReviewData.DataSource = dataTemp;
            break;
          case 2:
            // Độ rung
            var dataVibration = _managerParametterLog.GetDataByDate(7, dateStart.Date, dateEnd.Date);
            if (dataVibration != null) dgvReviewData.DataSource = dataVibration;
            break;
          case 3:
            // Từ trường
            var dataMagFd = _managerParametterLog.GetDataByDate(1, dateStart.Date, dateEnd.Date);
            if (dataMagFd != null) dgvReviewData.DataSource = dataMagFd;
            break;
        }
      } 
      else if (locationBtn == "btnDown")
      {
        switch (Page)
        {
          case 1:
            // Tốc độ
            var dataTemp = _managerParametterLog.GetDataByDate(4, dateStart.Date, dateEnd.Date);
            if (dataTemp != null) dgvReviewData.DataSource = dataTemp;
            break;
          case 2:
            // Âm thanh
            var dataVibration = _managerParametterLog.GetDataByDate(11, dateStart.Date, dateEnd.Date);
            if (dataVibration != null) dgvReviewData.DataSource = dataVibration;
            break;
          case 3:
            // no code
            break;
        }
      }  
      

    }
  }
}
