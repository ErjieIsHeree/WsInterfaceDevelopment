﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Buttons.Properties;

public class FileBtn : Button
{
    Image image = Resources.Folder;

    public FileBtn()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.Red;  // Color de fondo rojo
        this.Image = RedimensionarImagen(image, 25, 25);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        this.Text = ""; // No mostrar texto

        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, this.Width, this.Height);
        this.Region = new Region(path);

        // Dibujar un borde
        using (Pen pen = new Pen(ColorTranslator.FromHtml("#731101"), 6))
        {
            e.Graphics.DrawEllipse(pen, 1, 1, this.Width - 1, this.Height - 3);
        }
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
        base.SetBoundsCore(x, y, 40, 40, specified); // Siempre 40x40
    }
}
