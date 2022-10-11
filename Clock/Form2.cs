using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        private bool _requestExit;

        public Form2()
        {
            _form1 = new Form1();
            InitializeComponent();
            btnBorderColor.ForeColor = _form1.BorderColor;
            btnTextColor.ForeColor = _form1.TextColor;
            btnSecondColor.ForeColor = _form1.SecondColor;
            iWindowSize.Value = _form1.Width;
            iFontSize.Value = _form1.FontSize;
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK) return;
            _form1.BorderColor = btnBorderColor.ForeColor = cd.Color;
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK) return;
            _form1.TextColor = btnTextColor.ForeColor = cd.Color;
        }

        private void btnApplyWindowSize_Click(object sender, EventArgs e)
        {
            _form1.Width = _form1.Height = (int)iWindowSize.Value;
        }

        private void btnApplyFontSize_Click(object sender, EventArgs e)
        {
            _form1.FontSize = (int)iFontSize.Value;
        }

        private void btnSecondColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK) return;
            _form1.SecondColor = btnSecondColor.ForeColor = cd.Color;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _form1.Show();
            HideMe();
        }

        async void HideMe()
        {
            WindowState = FormWindowState.Minimized;
            await Task.Delay(500);
            Hide();
        }

        private async void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            await Task.Delay(500);
            WindowState = FormWindowState.Normal;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_requestExit)
            {
                notifyIcon1.Visible = false;
                return;
            }

            e.Cancel = true;
            HideMe();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _requestExit = true;
            Close();
        }

        private void cbFixed_CheckedChanged(object sender, EventArgs e)
        {
            var left = _form1.Left;
            var top = _form1.Top;
            _form1.Close();
            _form1 = new Form1(!cbFixed.Checked);
            _form1.StartPosition = FormStartPosition.Manual;
            _form1.Left = left;
            _form1.Top = top;
            _form1.Show();
        }
    }
}
