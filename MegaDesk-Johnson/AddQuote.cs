using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Johnson
{
    public partial class AddQuote : Form
    {
        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

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

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void WidthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Return))
            {
                WidthBox.BackColor = Color.White;
            }

            if(Convert.ToInt32(e.KeyChar) < Convert.ToInt32(Keys.D0) || Convert.ToInt32(e.KeyChar) > Convert.ToInt32(Keys.D9))
            {
                WidthBox.BackColor = Color.Salmon;
            }
            else
            {
                WidthBox.BackColor = Color.White;
            }
        }

        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            int MINDEPTH = 12;
            int MAXDEPTH = 48;

            string depthInput = DepthBox.Text;

            try
            {
                if (Convert.ToInt32(depthInput) < MINDEPTH || Convert.ToInt32(depthInput) > MAXDEPTH)
                {
                    DepthBox.BackColor = Color.Salmon;
                    MessageBox.Show("Outside of range. Please enter a number between 12 & 48");
                    DepthBox.Clear();
                    DepthBox.Focus();
                }
                else
                {
                    DepthBox.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong.");
            }
        }
    }
}
