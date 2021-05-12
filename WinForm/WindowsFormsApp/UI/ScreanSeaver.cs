using System;
using System.Windows.Forms;

namespace WindowsFormsApp.UI
{
    public partial class ScreanSeaver : Form
    {
        Timer Timer;
        public ScreanSeaver()
        {
            Timer = new Timer();
            InitializeComponent();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(Tick);
            Timer.Start();
        }

        void Tick(object sender, EventArgs e)
        {
            this.Opacity -= 10;
        }
    }
}
