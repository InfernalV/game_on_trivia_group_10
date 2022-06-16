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
    }
}
