using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsAndTasks_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Search.GetPath += (path) =>
            {

            };
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Search search = new Search(diskDriveCmb.Text, fileNametxt.Text);

        }
    }
}
