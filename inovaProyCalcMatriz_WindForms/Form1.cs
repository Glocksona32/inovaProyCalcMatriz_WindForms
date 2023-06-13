using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inovaProyCalcMatriz_WindForms
{
    public partial class Form1 : Form
    {
        //declaramos una variable unica
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; i++)
                {
                    MC[i, j].Value = int.Parse(MA[i, j].Value.ToString()) 
                        * int.Parse(MB[i, j].Value.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//Boton de sumar cuendo se presiona   
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { 
            //Todos los datos que nos proporcione numericUpDown se guardaran en la variable "n"
            n = (int)numericUpDown1.Value;
            MA.Columns.Clear();
            MB.Columns.Clear();
            MC.Columns.Clear();

            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna1.Name = (i + 1).ToString();
                columna1.Width = 24;
                MA.Columns.Add(columna1);
                DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna2.Name = (i + 1).ToString();
                columna2.Width = 24;
                MB.Columns.Add(columna2);
                DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Name = (i + 1).ToString();
                columna3.Width = 24;
                MC.Columns.Add(columna3);
            }
            MA.Rows.Add(n);
            MB.Rows.Add(n);
            MC.Rows.Add(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0;i < n;i++)
            {
                for (int j = 0;j < n;j++)
                {
                    MA[i, j].Value = r.Next(10) + 1;
                    MB[i, j].Value = r.Next(10) + 1;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MA[i, j].Value = r.Next(10) + 1;
                    MB[i, j].Value = r.Next(10) + 1;
                }
            }
        }

        private void suma3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; i++)
                {
                    MC[i, j].Value = int.Parse(MA[i, j].Value.ToString())
                        + int.Parse(MB[i, j].Value.ToString());
                }
            }
        }
    }
}
