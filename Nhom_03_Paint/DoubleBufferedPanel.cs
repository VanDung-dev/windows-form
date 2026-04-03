using System.Windows.Forms;

namespace Nhom_03_Paint
{
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | 
                         ControlStyles.UserPaint | 
                         ControlStyles.Opaque, true);
            this.ResizeRedraw = true;
        }
    }
}
