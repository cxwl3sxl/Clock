using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form2 : Form
    {
        private readonly Form1 _form1;

        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
            btnBorderColor.ForeColor = form1.BorderColor;
            btnTextColor.ForeColor = form1.TextColor;
            btnSecondColor.ForeColor = _form1.SecondColor;
            iWindowSize.Value = form1.Width;
            iFontSize.Value = form1.FontSize;
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

        private void btnUp_ClickAction()
        {
            _form1.Top -= (int)iMoveStep.Value;
        }

        private void btnLeft_ClickAction()
        {
            _form1.Left -= (int)iMoveStep.Value;
        }

        private void btnDown_ClickAction()
        {
            _form1.Top += (int)iMoveStep.Value;
        }

        private void btnRight_ClickAction()
        {
            _form1.Left += (int)iMoveStep.Value;
        }

        private void btnSecondColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK) return;
            _form1.SecondColor = btnSecondColor.ForeColor = cd.Color;
        }
    }
}
