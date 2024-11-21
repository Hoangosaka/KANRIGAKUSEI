using KANRIGAKUSEI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KANRIGAKUSEI
{
    public partial class fログイン : Form
    {
        public fログイン()
        {
            InitializeComponent();
        }

        private void fログイン_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnログイン_Click(object sender, EventArgs e)
        {
            f学生 f = new f学生();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
