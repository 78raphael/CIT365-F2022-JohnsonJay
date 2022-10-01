using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Johnson
{
    public partial class AddQuote : Form
    {
        public event EventHandler Enter;
        private string depthInput = string.Empty;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void DepthBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DepthBox_Validated(object sender, CancelEventArgs e)
        {
            int MINDEPTH = 12;
            int MAXDEPTH = 48;

            TextBox depthTxt = sender as TextBox;
            depthInput = depthTxt.Text;

            if ( Convert.ToInt32(depthInput) < MINDEPTH || Convert.ToInt32(depthInput) > MAXDEPTH)
            {
                MessageBox.Show("Outside of range. Please enter a number between 12 & 48");
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
