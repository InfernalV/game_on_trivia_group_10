using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blenderbenderquiz
{
    public partial class BlenderBenderQuizz : Form
    {
        private List<Circle> circles = new List<Circle>();



        public BlenderBenderQuizz()
        {
            new Settings();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private int _ticks;
        private int _count;


        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label5.Text = _ticks.ToString();

            if(_ticks == 30)
            {
                var form = new Form2();
                form.SetScore(_Count);
                Hide();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_correct= C)
            {
                _count++;
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (_correct = A)
            {
                _count++;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (_correct = B)
            {
                _count++;
            }
        }
    }
}
