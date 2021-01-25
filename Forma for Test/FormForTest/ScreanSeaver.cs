using System;
using System.Windows.Forms;

namespace FormForTest
{
    public partial class ScreanSeaver : Form
    {
        Timer Timer;
        public ScreanSeaver()
        {
            InitializeComponent();
            Timer.Interval = 250;
            Timer.Tick += new EventHandler(Tick);
            Timer.Start();
        }

        void Tick(object sender, EventArgs e)
        {
            this.Opacity -= 10;
        }
    }
}
