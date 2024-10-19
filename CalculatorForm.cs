using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
        private double resultado = 0;
        private string operacion = "";
        private bool operacionPresionada = false;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
        }
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacionPresionada)
                textBox1.Clear();

            operacionPresionada = false;
            Button boton = (Button)sender;
            textBox1.Text = textBox1.Text + boton.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    textBox1.Text = (resultado + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultado - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultado * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultado / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            operacion = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultado = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = Double.Parse(textBox1.Text);
            operacionPresionada = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = Double.Parse(textBox1.Text);
            operacionPresionada = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = Double.Parse(textBox1.Text);
            operacionPresionada = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = Double.Parse(textBox1.Text);
            operacionPresionada = true;
        }
    }
}
