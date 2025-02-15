using System.Windows.Forms;
using System.Drawing;

class SubtitleLbl : Label
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        this.Text = "C# WPF Mp3 Music Player";
        this.Font = new Font("ExtraLight", 11);
    }
}
