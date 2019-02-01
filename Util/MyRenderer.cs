using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = e.Item.Selected ? Color.DarkSeaGreen : Color.Transparent;
           using(SolidBrush brush = new SolidBrush(c)){
                e.Graphics.FillRectangle(brush, rc);
            }
          
      }
    }
}
