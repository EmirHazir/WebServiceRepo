using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UrunServiceReference;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceOf_UrunDTOClient client = new ServiceOf_UrunDTOClient();
            dataGridView1.DataSource = client.Listele();
            client.Close();
        }
    }
}
