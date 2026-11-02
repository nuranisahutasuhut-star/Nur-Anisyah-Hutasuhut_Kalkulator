using System;
using System.Windows.Forms;

namespace GUIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
        }

        private bool AmbilAngka(out double angka1, out double angka2)
        {
            angka1 = 0;
            angka2 = 0;

            if (!double.TryParse(textBox1.Text, out angka1) ||
                !double.TryParse(textBox2.Text, out angka2))
            {
                MessageBox.Show("Masukkan angka yang valid pada kedua kotak!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Tombol TAMBAH
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "+";
            if (AmbilAngka(out double a, out double b))
            {
                textBox3.Text = (a + b).ToString();
            }
        }

        // Tombol KURANG
        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "-";
            if (AmbilAngka(out double a, out double b))
            {
                textBox3.Text = (a - b).ToString();
            }
        }

        // Tombol KALI
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "×";
            if (AmbilAngka(out double a, out double b))
            {
                textBox3.Text = (a * b).ToString();
            }
        }

        // Tombol BAGI
        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "÷";
            if (AmbilAngka(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Tidak bisa membagi dengan nol!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                textBox3.Text = (a / b).ToString();
            }
        }
    }
}