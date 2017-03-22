using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOfVision
{
    public partial class Form1 : Form
    {
        static Timer displayTimer;
        static Timer hideTimer;
        static Random random;
        static int gridSize;
        static int blockSize;

        public Form1()
        {
            InitializeComponent();

            displayTimer = new Timer();
            displayTimer.Enabled = true;
            displayTimer.Interval = 1000;
            displayTimer.Tick += new EventHandler(DisplayTimerEventProcessor);

            hideTimer = new Timer();
            hideTimer.Enabled = true;
            hideTimer.Interval = 250;
            hideTimer.Tick += new EventHandler(HideTimerEventProcessor);

            gridSize = 10;
            blockSize = 50;

            picBars.Size = new Size(blockSize, blockSize);
            this.Size = new Size(blockSize * gridSize, blockSize * gridSize);

            random = new Random(DateTime.Now.Millisecond);

            displayTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayTimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            picBars.Location = new Point(random.Next(0, gridSize - 1) * blockSize, random.Next(0, gridSize - 1) * blockSize);
            picBars.Visible = true;
            displayTimer.Stop();
            hideTimer.Start();
        }

        private void HideTimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            picBars.Visible = false;
            hideTimer.Stop();
            displayTimer.Start();
        }
    }
}
