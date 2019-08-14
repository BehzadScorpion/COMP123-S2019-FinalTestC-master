using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using COMP123_S2019_FinalTestC.Objects;

/*
 * STUDENT NAME: Seyed Behzad Afrasiabi
 * STUDENT ID: 300-605-726
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        TextReader FirstNameReader { get; set; }
        TextReader LastNameReader { get; set; }
        //Random Rand { get; set; }
        public CharacterPortfolio Portfolio { get; set; }
        //public Identity CurrentIdentity { get; set; }

        public CharacterGenerationForm()
        {
            InitializeComponent();
            //Rand = new Random();
            Portfolio = new CharacterPortfolio();
            //CurrentIdentity = new Identity();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event handler for the GenerateNameButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateName();

        }


        /// <summary>
        /// This is The random name-Generator method
        /// </summary>
        private void GenerateName()
        {
            Random Rand;
            Rand = new Random();
            using (FirstNameReader = new StreamReader(File.Open("..\\..\\Data\\firstNames.txt", FileMode.Open)))
            {
                List<string> names = new List<string>(); //List to store all the names from firstNames.txt
                int i = 0; //iteration for the looping statement             
                int randomFirstNameIndex; //index of the generated random number

                while (FirstNameReader.ReadLine() != null)
                {
                    names.Add(FirstNameReader.ReadLine());
                    i++;
                }

                randomFirstNameIndex = Rand.Next(i);//generating the random number for the First-Name Index
                Portfolio.Identity.FirstName = names[randomFirstNameIndex];//getting the randomized name from the list and setting it as the FirstName property
                FirstNameDataLabel.Text = Portfolio.Identity.FirstName; //displaying First Name 
                SheetFirstNameDataLabel.Text = Portfolio.Identity.FirstName; //displaying First Name 
                FirstNameReader.Close();
                FirstNameReader.Dispose();
                names.Clear();
            }

            using (LastNameReader = new StreamReader(File.Open("..//..//Data//lastNames.txt", FileMode.Open)))
            {
                List<string> names = new List<string>(); //List to store all the names from firstNames.txt
                int i = 0; //iteration for the looping statement
                int randomLastNameIndex; //index of the generated random number

                while (LastNameReader.ReadLine() != null)
                {
                    names.Add(LastNameReader.ReadLine());
                    i++;
                }

                randomLastNameIndex = Rand.Next(i); //generating the random number for the Last-Name Index
                Portfolio.Identity.LastName = names[randomLastNameIndex];//getting the randomized name from the list and setting it as the LastName property
                LastNameDataLabel.Text = Portfolio.Identity.LastName; //Displaying Last Name
                SheetLastNameDataLabel.Text = Portfolio.Identity.LastName; //Displaying Last Name in CharacterSheet
                LastNameReader.Close();
                LastNameReader.Dispose();
                names.Clear();
            }

        }

        /// <summary>
        /// This is the event handler for the GenerateAbilitiesButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();

        }

        /// <summary>
        /// This is the method that generates random numbers for the ability properties and writes them in the appropriate labels
        /// </summary>
        private void GenerateAbilities()
        {
            Random Rand = new Random();
            int maxSkill = 15; // maximum amount of ability points

            //Asigning random integers to the Portfolio properties
            Portfolio.Strength = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Portfolio.Dexterity = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Portfolio.Endurance = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Portfolio.Intellect = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Portfolio.Education = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Portfolio.SocialStanding = Convert.ToString(Rand.Next(1, maxSkill + 1));

            //Displaying the value of the Portfolio object properties in the appropriate labels
            StrengthDataLabel.Text = Portfolio.Strength;
            DexterityDataLabel.Text = Portfolio.Dexterity;
            EnduranceDataLabel.Text = Portfolio.Endurance;
            IntellectDataLabel.Text = Portfolio.Intellect;
            EducationDataLabel.Text = Portfolio.Education;
            SocialStandingDataLabel.Text = Portfolio.SocialStanding;

            //Displaying the same values in the CharacterSheet
            SheetStrengthDataLabel.Text = Portfolio.Strength;
            SheetDexterityDataLabel.Text = Portfolio.Dexterity;
            SheetEnduranceDataLabel.Text = Portfolio.Endurance;
            SheetIntellectDataLabel.Text = Portfolio.Intellect;
            SheetEducationDataLabel.Text = Portfolio.Education;
            SheetSocialStandingDataLabel.Text = Portfolio.SocialStanding;
        }

        /// <summary>
        /// This is the event handler for the load event of the CharacterGenerationForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }

    }
}
