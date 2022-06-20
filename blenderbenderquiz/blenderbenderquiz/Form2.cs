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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetScore(int score)
        {
            label2.Text = score.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
