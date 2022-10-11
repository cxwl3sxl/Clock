using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clock
{
    public sealed partial class Form1 : Form
    {
        private readonly bool _moveAble;

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

        public Form1(bool moveAble = false)
        {
            _moveAble = moveAble;
            DoubleBuffered = true;
            InitializeComponent();
            if (moveAble)
            {
                Opacity = 0.5;
                BackColor = SystemColors.Control;
            }
            else
            {
                TransparencyKey = BackColor = Color.Black;
                PierceThrough();
            }

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

            g.Clear(_moveAble ? SystemColors.Control : BackColor);

            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;        
            g.SmoothingMode = SmoothingMode.AntiAlias;


            g.DrawEllipse(new Pen(BorderColor, 4), 5, 5, Width - 10, Height - 10);

            var now = DateTime.Now;
            var line1 = $"{now:HH:mm:ss}";
            var line2 = $"{now:fff}";

            var textSize1 = g.MeasureString(line1, _clockFont);
            var textSize2 = g.MeasureString(line2, _clockFont);

            var centerX = Width / 2.0f;
            var centerY = Height / 2.0f;

            g.DrawString(line1, _clockFont, new SolidBrush(TextColor), (Width - textSize1.Width) / 2,
                centerY - textSize1.Height);
            g.DrawString(line2, _clockFont, new SolidBrush(TextColor), (Width - textSize2.Width) / 2, centerY);

            var p1 = new Pen(SecondColor, 4);
            p1.StartCap = LineCap.Round;
            p1.EndCap = LineCap.Round;
            p1.LineJoin = LineJoin.Round;

            p1.EndCap = LineCap.ArrowAnchor;
            p1.StartCap = LineCap.Round;

            //获取当前秒，并转换为int型
            var i = Convert.ToInt32(now.Second);


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

        public Color BorderColor { get; set; } = Color.DeepSkyBlue;

        public Color TextColor { get; set; } = Color.DeepSkyBlue;

        public Color SecondColor { get; set; } = Color.Red;

        public int FontSize
        {
            get => (int)_clockFont.Size;
            set => _clockFont = new Font("微软雅黑", value);
        }

        private int _lastX, _lastY;
        private bool _moving;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _lastX = e.X;
            _lastY = e.Y;
            _moving = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving) return;
            Left += e.X - _lastX;
            Top += e.Y - _lastY;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _moving = false;
        }
    }
}
