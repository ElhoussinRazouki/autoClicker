using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoClicker
{
    public partial class Form1 : Form
    {

        private Click currentClick ;
        private Timer timerPosition, timerClick;
        private bool timerIsRuning = false;
        int timerClickKiller;

        public Form1()
        {
            InitializeComponent();
            currentClick = new Click() ;
            timerPosition = new Timer();
            timerPosition.Tick += new EventHandler(getPosition);
            timerPosition.Interval = 41;
            timerPosition.Start();

        }

        //dynamik link library
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlag, int axeX, int axeY, int cButtons, int dwExtraInfo);
        
        
        
        
        //get position of cursor
        private void getPosition(object sender, EventArgs e)
        {
            position_x.Text = MousePosition.X.ToString();
            position_y.Text = MousePosition.Y.ToString();
            
        }

        
        

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            SetCursorPos(currentClick.AxeX, currentClick.AxeY);
            timerClick = new Timer();
            timerClick.Interval = currentClick.Interval;
            timerClick.Tick += new EventHandler(eventClick);
            timerClickKiller = currentClick.NbrClicks;
            timerClick.Start();
        }

       


        //read click of keys
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {

                handleTimerPos();
                
            }
        }



        // click event
        public void mouseClick(int mouseButtonDown, int mouseButtonup, int axeX, int axeY)
        {
            mouse_event(mouseButtonDown, axeX, axeY, 0, 0);
            mouse_event(mouseButtonup, axeX, axeY, 0, 0);
        }

        private void nbr_click_ValueChanged(object sender, EventArgs e)
        {
            currentClick.NbrClicks = int.Parse(this.nbr_click.Value.ToString());
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMouseButton.Text)
            {
                case "Left":
                    currentClick.MouseButtonDown = currentClick.MOUSEEVENET_LEFTDOWN;
                    currentClick.MouseButtonUp = currentClick.MOUSEEVENET_LEFTUP;
                    break;
                case "Middle":
                    currentClick.MouseButtonDown = currentClick.MOUSEEVENTF_MIDDLEDOWN;
                    currentClick.MouseButtonUp = currentClick.MOUSEEVENTF_MIDDLEUP;
                    break;
                case "Right":
                    currentClick.MouseButtonDown = currentClick.MOUSEEVENTF_RIGHTDOWN;
                    currentClick.MouseButtonUp = currentClick.MOUSEEVENTF_RIGHTUP;
                    break;
            }
        }

        private void time_betw_ValueChanged(object sender, EventArgs e)
        {
            currentClick.Interval = int.Parse(this.time_betw.Value.ToString());
        }

        private void btnCleanPos_Click(object sender, EventArgs e)
        {
            handleTimerPos();
        }

        private void btnGetPos_Click(object sender, EventArgs e)
        {
            handleTimerPos();
        }




        // call click event (handled by the timer)
        public void eventClick(object sender, EventArgs e)
        {
            if(timerClickKiller > 0)
            {
                mouseClick(currentClick.MouseButtonDown, currentClick.MouseButtonUp, currentClick.AxeX, currentClick.AxeY);
                timerClickKiller--;
            }
            else
            {
                timerClick.Stop();
            }
            
            
        }

        private void handleTimerPos()
        {
            if (timerIsRuning)
            {
                timerPosition.Stop();
                timerIsRuning = false;
                btnGetPos.Enabled = false;
                btnCleanPos.Enabled = true;
                currentClick.AxeX = MousePosition.X;
                currentClick.AxeY = MousePosition.Y;
            }
            else
            {
                timerPosition.Start();
                timerIsRuning = true;
                btnGetPos.Enabled = true;
                btnCleanPos.Enabled = false;
            }
        }

    }
}
