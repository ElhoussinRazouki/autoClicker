using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoClicker
{
    public partial class Form1 : Form
    {
        private Timer timer;
        
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(getPosition);
            timer.Interval = 41;
            timer.Start();
        }
        [DLLimport("user32")]
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void getPosition(object sender, EventArgs e)
        {
            position_x.Text ="X : " + MousePosition.X.ToString();
            position_y.Text ="Y : " + MousePosition.Y.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MousePosition.X.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.X)
            {
                this.timer.Stop();

            }
        }

        
  
    }
}
