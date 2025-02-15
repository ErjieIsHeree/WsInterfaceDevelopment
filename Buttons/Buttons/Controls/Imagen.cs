using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class Imagen : PictureBox
{
    Image img = Image.FromFile("C:\\Users\\erjie_dmjyixu\\DAM\\3.DesarrolloDeInterfaces\\2.Ejercicios\\WsEjercicios\\Buttons\\Buttons\\img\\MusicIcon.png");

    public Imagen()
    {
        this.Image = RedimensionarImagen(img, 200, 200);
    }

    private Image RedimensionarImagen(Image imagen, int ancho, int alto)
    {
        Bitmap nuevaImagen = new Bitmap(ancho, alto);
        using (Graphics g = Graphics.FromImage(nuevaImagen))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imagen, 0, 0, ancho, alto);
        }
        return nuevaImagen;
    }
    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
        base.SetBoundsCore(x, y, 200, 200, specified); // Siempre 280x200
    }
}
