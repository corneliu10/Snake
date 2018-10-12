using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.MenuOptions = false;
            this.RelaxMode = false;
            GameRun Form2 = new GameRun(this);
            this.Hide();
            Form2.ShowDialog();
            //this.Close();
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_lbl_MouseHover(object sender, EventArgs e)
        {

        }

        private void RelaxMode_lbl_Click(object sender, EventArgs e)
        {
            this.MenuOptions = false;
            this.RelaxMode = true;
            GameRun Form2 = new GameRun(this);
            this.Hide();
            Form2.ShowDialog();
            //this.Close();
        }

        public bool MenuOptions { get; set; }

        public bool RelaxMode
        {
            get;
            set;
        }
    }
}
