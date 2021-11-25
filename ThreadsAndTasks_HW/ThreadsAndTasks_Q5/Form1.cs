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
        Thread thread;
        bool isSuspended = false;
        AutoResetEvent ResetEvent = new AutoResetEvent(false);
        public Form1()
        {
            InitializeComponent();
            Search.GetPath += (path) =>
            {
                filesNamesListBox.Items.Add(path);
            };

            Search.ExceptionMessage += (message) =>
            {
                MessageBox.Show(message);
            };
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                if (isSuspended)
                {
                    isSuspended = false;
                    ResetEvent.WaitOne();
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        Search search = new Search(diskDriveCmb.Text, fileNametxt.Text);
                        search.SearchFiles();
                    }));
                }
            });
            thread.Start();
        }

        private void canlebtn_Click(object sender, EventArgs e)
        {
            isSuspended = true;
        }
    }
}
