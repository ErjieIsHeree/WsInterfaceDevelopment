using System.Windows.Forms;
using System.Drawing;

class TitleLbl : Label
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        this.Text = "Song name";
        this.Font = new Font("SemiBold", 19, FontStyle.Bold);
    }
}
