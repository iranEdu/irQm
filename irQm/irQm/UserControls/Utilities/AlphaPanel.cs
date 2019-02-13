using System.Drawing;
using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{ 
public class AlphaPanel : Panel

{

    const int WS_EX_TRANSPARENT = 0x00000020;



    protected override CreateParams CreateParams

    {

        get

        {

            CreateParams cp = base.CreateParams;

            cp.ExStyle |= WS_EX_TRANSPARENT;

            return cp;

        }

    }



    protected override void OnPaintBackground(PaintEventArgs e)

    {//do not paint the background

    }



    protected override void OnPaint(PaintEventArgs e)

    {

        SolidBrush brush = new SolidBrush(Color.Transparent);

        e.Graphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));

    }
}
}

