using System;
using System.Windows.Forms;

namespace Clock
{
    internal class MyButton : Button
    {
        public event Action ClickAction;
        private readonly Timer _timer;

        public MyButton()
        {
            _timer = new Timer();
            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;
            MouseDown += MyButton_MouseDown;
            MouseUp += MyButton_MouseUp;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            ClickAction?.Invoke();
        }

        private void MyButton_MouseUp(object sender, MouseEventArgs e)
        {
            _timer.Stop();
        }

        private void MyButton_MouseDown(object sender, MouseEventArgs e)
        {
            _timer.Start();
        }
    }
}
