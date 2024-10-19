using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaintForm : Form
    {
        private Color currentColor = Color.Black;
        private Color colorSeleccionado = Color.Black; // Color inicial
        private bool dibujando = false; // Estado de dibujo
        private Point puntoAnterior; // Almacena el punto anterior
        public PaintForm()
        {
            InitializeComponent();
            pictureBoxDibujo.MouseDown += PictureBoxDibujo_MouseDown;
            pictureBoxDibujo.MouseMove += PictureBoxDibujo_MouseMove;
            pictureBoxDibujo.MouseUp += PictureBoxDibujo_MouseUp;
        }

        private void PictureBoxDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            dibujando = true;
            puntoAnterior = e.Location; // Guarda la posición inicial
        }

        private void PictureBoxDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = pictureBoxDibujo.CreateGraphics())
                {
                    g.DrawLine(new Pen(colorSeleccionado, 2), puntoAnterior, e.Location); // Dibuja la línea
                }
                puntoAnterior = e.Location; // Actualiza el punto anterior
            }
        }
        private void PictureBoxDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false; // Deja de dibujar
        }

        private void btnSeleccionarColor_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = pictureBoxDibujo.CreateGraphics())
                {
                    g.FillEllipse(new SolidBrush(currentColor), e.X, e.Y, 10, 10);
                }
            }
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnColor1_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color; // Actualiza el color seleccionado
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDibujo.BackColor = colorDialog.Color;
            }
        }
    }
}
