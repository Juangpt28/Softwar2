using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwar2
{
    public partial class grbEmpleado : Form
    {
        public grbEmpleado()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            //VARIABLE PARA LAS COLUMNAS Y FILAS
            DataColumn column;
            //DataRow row;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Codigo";
            tabla.Columns.Add(column);
            //SE TIENE QUE CREAR PRIMERO LA COLUMNA ASIGNADOLE
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nombre";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "Direccion";
            tabla.Columns.Add(column);
            //CREE UNA FILA POR CADA REGISTRO QUE NECESITEMOS

            dgvDatos.DataSource = tabla;

        }
        private void add_Data(object sender, EventArgs e)
        {
            dgvDatos.ColumnCount = 3;
            dgvDatos.Columns[0].Name = "ID";
            dgvDatos.Columns[1].Name = "Course Name";
            dgvDatos.Columns[2].Name = "Marks";

            string[] row = new string[] { "1", "OOP", "75" };
            dgvDatos.Rows.Add(row);
            row = new string[] { "2", "DSA", "86" };
            dgvDatos.Rows.Add(row);
            row = new string[] { "3", "AOA", "67" };
            dgvDatos.Rows.Add(row);
        }
        public void updateGrid()
        {
            //Update the data grid view here dynamically
            //Add columns
            dgvDatos.ColumnCount = 4;
            dgvDatos.Columns[0].Name = "Bus Id";
            dgvDatos.Columns[1].Name = "Bus Name";
            dgvDatos.Columns[2].Name = "Bus Model";
            dgvDatos.Columns[3].Name = "Bus Color";

            //Now adding rows
            ArrayList arrRow = new ArrayList();
            arrRow.Add("1");
            arrRow.Add("School bus");
            arrRow.Add("2000");
            arrRow.Add("Yellow");
            dgvDatos.Rows.Add(arrRow.ToArray());

            arrRow = new ArrayList();
            arrRow.Add("2");
            arrRow.Add("Speedo bus");
            arrRow.Add("2014");
            arrRow.Add("Red");
            dgvDatos.Rows.Add(arrRow.ToArray());

            arrRow = new ArrayList();
            arrRow.Add("3");
            arrRow.Add("Metro bus");
            arrRow.Add("205");
            arrRow.Add("Orange");
            dgvDatos.Rows.Add(arrRow.ToArray());
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            updateGrid();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rtbListaFup_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

