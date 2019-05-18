using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSmanager
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FCFSButton_Click(object sender, EventArgs e)
        {
            FormSO Interface = new FormSO(this, 0);
            Interface.Show();
            this.Hide();
        }

        private void RRButton_Click(object sender, EventArgs e)
        {
            FormSO Interface = new FormSO(this, 1);
            Interface.Show();
            this.Hide();
        }
    }
}
