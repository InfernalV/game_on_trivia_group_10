using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace MySqlLite
{
      class DataClass
      {
        private SQLiteConnection sqlite;

        public DataClass()
        {
              sqlite = new SQLiteConnection("Data Source=/C:/Users/stijn/source/repos/game_on_trivia_group_10/blenderbenderquiz/blenderbenderquiz/basis.db");

        }

        public DataTable selectQuery(string query)
        {
              SQLiteDataAdapter ad;
              DataTable dt = new DataTable();

              try
              {
                    SQLiteCommand cmd;
                    sqlite.Open();  
                    cmd = sqlite.CreateCommand();
                    cmd.CommandText = query;  
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
              }
              catch(SQLiteException ex)
              {
                   
              }
              sqlite.Close();
              return dt;
  }
}
namespace blenderbenderquiz
{
    public partial class BlenderBenderQuizz : Form
    {

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label5.Text = _ticks.ToString();

            if(_ticks == 45)
            {
                var form = new Form2();
                form.SetScore(_count);
                Hide();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (C = correct)
            {
                _count++;
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (A = correct)
            {
                _count++;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (B = correct)
            {
                _count++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
