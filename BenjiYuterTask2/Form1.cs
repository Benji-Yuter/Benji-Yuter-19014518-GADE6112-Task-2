using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTwoNamespace
{
	public partial class Form1 : Form
	{
        
        public Form1()
		{
			InitializeComponent();
            
        }
    
        private void startGame(int min_Width, int max_Width, int min_Height, int max_Height, int num_Enemies,int Gold)
        {
            lblErrorMessage.Text = "";

            PlayGame gp = new PlayGame(min_Width, max_Width, min_Height, max_Height, num_Enemies,false, Gold);
            gp.setCaller(this);
            gp.Show();
            this.Hide();
        }

		private void btnStartGame_Click(object sender, EventArgs e)
		{
            try
            {

                int minWidth = Convert.ToInt32(edtMinWidth.Text);
                int maxWidth = Convert.ToInt32(edtMaxWidth.Text);
                int minHeight = Convert.ToInt32(edtMinHeight.Text);
                int maxHeight = Convert.ToInt32(edtMaxHeight.Text);
                int Enemies = Convert.ToInt32(edtEnemies.Text);
                int Gold = Convert.ToInt32(edtGold.Text);
                startGame(minWidth, maxWidth, minHeight, maxHeight, Enemies,Gold);

            }
            catch (FormatException)
            {
                lblErrorMessage.Text = "Please input values";
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			
            PlayGame gp = new PlayGame(0, 0, 0, 0, 0,true,0);
            gp.setCaller(this);
            gp.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
