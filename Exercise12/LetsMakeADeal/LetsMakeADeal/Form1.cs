using System;
using System.Windows.Forms;

namespace LetsMakeADeal
{
    public partial class Form1 : Form
    {

        string[] prizes = new string[3] { "Car", "Big Screen T.V.", "Live Goat" };
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        

        private void door1_Click(object sender, EventArgs e)
        {

            //Upon click started randomly pick between option (in array) 1 and 2 indeces. Do not include in random range the Car. Show try again checkbox. Echo out the prize according to selected index.
            
            int prize_won = Convert.ToInt32(rnd.Next(1, 3));
            door1.Text = Convert.ToString(prizes[prize_won]);

            //Show message box that displays in text the prize as well as a provided image
            if (prize_won == 1)
            {
                displayBigScreenTV();

            }
            else if (prize_won == 2)
            {

                displayLiveGoat();
            }

            checkBox1.Visible = true;
            door1.Enabled = false;
            door2.Enabled = false;
            door3.Enabled = false;

  

        }

        private void door2_Click(object sender, EventArgs e)
        {
            //Upon click started randomly pick between option (in array) 1 and 2 indeces. Do not include in random range the Car. Show try again checkbox. Echo out the prize according to selected index.
           
            int prize_won = Convert.ToInt32(rnd.Next(1, 3));
            door2.Text = Convert.ToString(prizes[prize_won]);

            //Show message box that displays in text the prize as well as a provided image
            if (prize_won == 1)
            {
                displayBigScreenTV();

            }
            else if (prize_won == 2)
            {

                displayLiveGoat();
            }

            checkBox1.Visible = true;
            door1.Enabled = false;
            door2.Enabled = false;
            door3.Enabled = false;



        }

        private void door3_Click(object sender, EventArgs e)
        {
            //Upon click started randomly pick between option (in array) 1 and 2 indeces. Do not include in random range the Car. Show try again checkbox. Echo out the prize according to selected index.
         
            int prize_won = Convert.ToInt32(rnd.Next(1, 3));
            door3.Text = Convert.ToString(prizes[prize_won]);
            //Show message box that displays in text the prize as well as a provided image
            if (prize_won == 1)
            {
                displayBigScreenTV();

            }
            else if(prize_won == 2)
            {

                displayLiveGoat();
            }


            checkBox1.Visible = true;
            door1.Enabled = false;
            door2.Enabled = false;
            door3.Enabled = false;

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //Plan is to try to flag when one of the door's text is the same as an index in the array. 
                //If it matches, switch the text to the other option but never the car.
                if (door1.Text == prizes[1])
                {
                    door1.Text = prizes[2];

                    //Show message box that displays in text the prize as well as a provided image
                    displayLiveGoat();

                }
                else if (door1.Text == prizes[2])
                {
                    door1.Text = prizes[1];

                    //Show message box that displays in text the prize as well as a provided image
                    displayBigScreenTV();


                };//End door 1 check



                if(door2.Text == prizes[1])
                {
                    door2.Text = prizes[2];

                    //Show message box that displays in text the prize as well as a provided image
                    displayLiveGoat();

                }
                else if (door2.Text == prizes[2])
                {
                    door2.Text = prizes[1];

                    //Show message box that displays in text the prize as well as a provided image
                    displayBigScreenTV();

                };//End door 2 check


                if (door3.Text == prizes[1])
                {
                    door3.Text = prizes[2];

                    //Show message box that displays in text the prize as well as a provided image
                    displayLiveGoat();

                }
                else if (door3.Text == prizes[2])
                {
                    door3.Text = prizes[1];

                    //Show message box that displays in text the prize as well as a provided image
                    displayBigScreenTV();

                }//End door 3 check

            }

            if (checkBox1.Checked == false)
            {
                door1.Text = "Door 1";
                door2.Text = "Door 2";
                door3.Text = "Door 3";


                door1.Enabled = true;
                door2.Enabled = true;
                door3.Enabled = true;

            }

        }

        public static void displayBigScreenTV()
        {

            BigScreenTv bigScreenTvForm = new BigScreenTv();
            bigScreenTvForm.ShowDialog();


        }

        public void displayLiveGoat()
        {

            LiveGoat liveGoatForm = new LiveGoat();
            liveGoatForm.ShowDialog();


        }
    }
   
}
