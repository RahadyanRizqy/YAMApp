using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMApp
{
    public partial class NotesPage : Form
    {
        public NotesPage()
        {
            InitializeComponent();
        }
        private void CloseButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
