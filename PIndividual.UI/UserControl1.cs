using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIndividual.BL;

namespace PIndividual.UI
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

       
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Prueba p = new Prueba();

           
            dataGridView1.DataSource = p;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Prueba p = new Prueba();           
            
            dataGridView1.DataSource = p.ToString();
        }
    }
}
