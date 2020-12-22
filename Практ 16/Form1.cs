using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практ_16
{
    public partial class Form1 : Form
    {
        int vector, score=0;
        Rectangle r1, r2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Игра <Собери капли>";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            boiler.Parent = fon;
            boiler.BackColor = Color.Transparent;
            water.Parent = fon;
            water.BackColor = Color.Transparent;
            Random r = new Random();
            water.Left = r.Next(100, 700);
            water.Top = -150;
            score = 1;
            vector = 0;
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            vector = 0;
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                vector = -3;
            }
            if (e.KeyCode == Keys.Right)
            {
                vector = 3;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int fall_speed = 2;
            water.Top = water.Top + fall_speed;
            boiler.Left = boiler.Left + vector;
            if (water.Top >= fon.Height)
            {
                timer1.Enabled = false;
                DialogResult result = MessageBox.Show("Вы проиграли.Начать заново? ", "Проигрыш",MessageBoxButtons.OKCancel);
                if (result==DialogResult.OK) 
                {
                    timer1.Enabled = true;
                    Random r = new Random();
                    water.Top = -150;
                    water.Left = r.Next(100, 700);
                }
                else this.Close();
            }
            r1 = water.DisplayRectangle;r2 = boiler.DisplayRectangle;
            r1.Location = water.Location;r2.Location = boiler.Location;
            if (r1.IntersectsWith(r2))
            {
                Random r = new Random();
                water.Top = -150;
                water.Left = r.Next(100, 700);
                score++;
                label1.Text = score.ToString();
            }
            if (boiler.Location.X < 0)
            {
                boiler.Location = new Point(900,boiler.Location.Y);
            }
            if (boiler.Location.X > 900)
            {
                boiler.Location = new Point(0, boiler.Location.Y);
            }
        }
    }
}
