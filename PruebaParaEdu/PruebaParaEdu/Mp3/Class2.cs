using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Boton : Button
{
    [Browsable(true)]
    [Category("Apariencia")]
    [Description("Color del borde del botón.")]
    public Color ColorBorde { get; set; } = Color.Transparent;

    [Browsable(true)]
    [Category("Apariencia")]
    [Description("Color de fondo del botón.")]
    public Color ColorFondo { get; set; } = Color.OrangeRed;

    [Browsable(true)]
    [Category("Apariencia")]
    [Description("Color del icono de 'Play'.")]
    public Color ColorIcono { get; set; } = Color.White;

    [Browsable(true)]
    [Category("Apariencia")]
    [Description("Grosor del borde del botón.")]
    public int GrosorBorde { get; set; } = 2;

    public Boton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0; // Elimina borde predeterminado
        Text = "jksda"; // No mostrar texto
        Size = new Size(50, 50); // Tamaño inicial
        ResizeRedibujar();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Dibujar fondo circular
        using (SolidBrush brushFondo = new SolidBrush(ColorFondo))
        {
            pevent.Graphics.FillEllipse(brushFondo, 0, 0, Width, Height);
        }

        // Dibujar borde circular si tiene grosor
        if (GrosorBorde > 0)
        {
            using (Pen penBorde = new Pen(ColorBorde, GrosorBorde))
            {
                pevent.Graphics.DrawEllipse(penBorde, GrosorBorde / 2, GrosorBorde / 2, Width - GrosorBorde, Height - GrosorBorde);
            }
        }

        // Dibujar el icono "Play"
        DibujarIconoPlay(pevent.Graphics);
    }

    private void DibujarIconoPlay(Graphics g)
    {
        int iconSize = Width / 3; // Tamaño del icono relativo al botón
        Point[] puntosTriangulo = {
                new Point(Width / 2 + iconSize / 2, Height / 2), // Punta del triángulo
                new Point(Width / 2 - iconSize / 2, Height / 2 - iconSize / 2),
                new Point(Width / 2 - iconSize / 2, Height / 2 + iconSize / 2)
            };

        using (SolidBrush brushIcono = new SolidBrush(ColorIcono))
        {
            g.FillPolygon(brushIcono, puntosTriangulo);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        ResizeRedibujar();
    }

    private void ResizeRedibujar()
    {
        if (Width > 0 && Height > 0)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }
    }
}