using System.Drawing;
using System.Windows.Forms;

namespace Galactus.Util.Controles
{
    class TabControlGalactus : TabControl
    {
        public TabControlGalactus() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(30, 120);
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Left;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Height, Width);
            Graphics g = Graphics.FromImage(b);
            Rectangle tabRectangulo = new Rectangle(0,0,b.Width,b.Height);

            g.Clear(Color.Gainsboro);

            for (var i = 0; i <= TabCount -1; i++)
            {
                tabRectangulo = GetTabRect(i);
 
                if (i == SelectedIndex)
                {
                    g.FillRectangle(Brushes.WhiteSmoke, tabRectangulo);
                }
                else {
                    g.FillRectangle(Brushes.LightGray, tabRectangulo);
                }

                g.DrawString(TabPages[i].Text, Font, Brushes.Black, tabRectangulo, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            } 

            e.Graphics.DrawImage(b, 0, 0);

            g.Dispose(); b.Dispose();
            base.OnPaint(e);
        }

    }
}
