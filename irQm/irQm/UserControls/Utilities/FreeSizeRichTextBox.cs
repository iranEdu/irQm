using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{
    class FreeSizeRichTextBox:RichTextBox
    {
          public FreeSizeRichTextBox():base()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.UserPaint, true);
            
        }
        protected override void OnContentsResized(ContentsResizedEventArgs e)
        {
            base.OnContentsResized(e);
            this.Height = e.NewRectangle.Height + 5;
        }
    }
}
