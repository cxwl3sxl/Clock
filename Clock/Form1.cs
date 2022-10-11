﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clock
{
    public sealed partial class Form1 : Form
    {
        #region 鼠标穿透

        // ReSharper disable once InconsistentNaming
        private const int GWL_EXSTYLE = (-20);
        // ReSharper disable once InconsistentNaming
        private const int WS_EX_TRANSPARENT = 0x20;
        // ReSharper disable once InconsistentNaming
        private const uint WS_EX_LAYERED = 0x80000;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        void PierceThrough()
        {
            var intExTemp = GetWindowLong(Handle, GWL_EXSTYLE);
            SetWindowLong(Handle, GWL_EXSTYLE, intExTemp | WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }

        #endregion

        private Font _clockFont;

        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            PierceThrough();
            _clockFont = new Font("微软雅黑", 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Height = Width;
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var currentContext = BufferedGraphicsManager.Current;
            using var bufferedGraphics =
                currentContext.Allocate(e.Graphics, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            using var g = bufferedGraphics.Graphics;
            g.Clear(Color.Black);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawEllipse(new Pen(BorderColor, 4), 5, 5, Width - 10, Height - 10);

            var now = DateTime.Now;
            var time = $"{now:HH:mm:ss fff}";
            var textSize = g.MeasureString(time, _clockFont);

            g.DrawString(time, _clockFont, new SolidBrush(TextColor), (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2);

            var p1 = new Pen(SecondColor, 2);
            p1.EndCap = LineCap.ArrowAnchor;
            p1.StartCap = LineCap.Round;

            //获取当前秒，并转换为int型
            var i = Convert.ToInt32(now.Second);

            var centerX = Width / 2;
            var centerY = Height / 2;
            var r = centerX;

            //计算点值
            var x1 = (float)(centerX + (r - r / 15) * Math.Sin(i * 2 * Math.PI / 60));
            var y1 = (float)(centerY - (r - r / 15) * Math.Cos(i * 2 * Math.PI / 60));
            var x2 = (float)(centerX + (r - r / 5) * Math.Sin(i * 2 * Math.PI / 60));
            var y2 = (float)(centerY - (r - r / 5) * Math.Cos(i * 2 * Math.PI / 60));
            var pointOut = new PointF(x1, y1);
            var pointInner = new PointF(x2, y2);
            g.DrawLine(p1, pointInner, pointOut);

            bufferedGraphics.Render(e.Graphics);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var f2 = new Form2(this);
            f2.Show(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        public Color BorderColor { get; set; } = Color.DeepSkyBlue;

        public Color TextColor { get; set; } = Color.DeepSkyBlue;

        public Color SecondColor { get; set; } = Color.Red;

        public int FontSize
        {
            get => (int)_clockFont.Size;
            set => _clockFont = new Font("微软雅黑", value);
        }
    }
}