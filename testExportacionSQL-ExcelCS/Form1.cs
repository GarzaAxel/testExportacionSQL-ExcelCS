using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace testExportacionSQL_ExcelCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectarSQL_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("La conexion se ha realizado con exito.");

            string consulta = "select * from employee";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,Conexion.Conectar());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bntExportarExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int iColum = 0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                iColum++;
                excel.Cells[1, iColum] = col.Name;
            }

            int iFila = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                iFila++;
                iColum = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    iColum++;
                    excel.Cells[iFila +1, iColum] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
    }
}
