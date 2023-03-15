using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Report
{
  public class ToExcel
  {
    public void FromDatagridviewToExcel(DataGridView dataGridView, string fileName, string nameWorksheet)
    {
      //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
      Microsoft.Office.Interop.Excel.Application excel;
      Microsoft.Office.Interop.Excel.Workbook workbook;
      Microsoft.Office.Interop.Excel.Worksheet worksheet, worksheet2;
      try
      {
        //Tạo đối tượng COM.
        excel = new Microsoft.Office.Interop.Excel.Application();
        excel.Visible = false;
        excel.DisplayAlerts = false;

        //tạo mới một Workbooks bằng phương thức add()
        workbook = excel.Workbooks.Add(Type.Missing);
        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

        //đặt tên cho sheet
        worksheet.Name = nameWorksheet;

        // export header trong DataGridView
        for (int i = 0; i < dataGridView.ColumnCount; i++)
        {
          worksheet.Cells[2, i + 2] = dataGridView.Columns[i].HeaderText;
        }

        // export nội dung trong DataGridView
        for (int i = 0; i < dataGridView.RowCount; i++)
        {
          for (int j = 0; j < dataGridView.ColumnCount; j++)
          {
            worksheet.Cells[i + 3, j + 2] = dataGridView.Rows[i].Cells[j].Value;
          }
        }
        // sử dụng phương thức SaveAs() để lưu workbook với filename
        workbook.SaveAs(fileName);
        //đóng workbook
        workbook.Close();
        excel.Quit();
        //MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        workbook = null;
        worksheet = null;
      }
    }

  }
}
