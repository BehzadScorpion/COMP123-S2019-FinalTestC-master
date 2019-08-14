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
        TextReader SkillsReader { get; set; }
        Random Rand { get; set; }
        CharacterPortfolio Character { get; set; }
        

        public CharacterGenerationForm()
        {
            InitializeComponent();
            //Rand = new Random();
            Character = new CharacterPortfolio();
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
            NameGenerator();

        }


        /// <summary>
        /// This is The random name-Generator method
        /// </summary>
        private void NameGenerator()
        {
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
                Character.Identity.FirstName = names[randomFirstNameIndex];//getting the randomized name from the list and setting it as the FirstName property
                FirstNameDataLabel.Text = Character.Identity.FirstName; //displaying First Name 
                SheetFirstNameDataLabel.Text = Character.Identity.FirstName; //displaying First Name 
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
                Character.Identity.LastName = names[randomLastNameIndex];//getting the randomized name from the list and setting it as the LastName property
                LastNameDataLabel.Text = Character.Identity.LastName; //Displaying Last Name
                SheetLastNameDataLabel.Text = Character.Identity.LastName; //Displaying Last Name in CharacterSheet
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
            int maxSkill = 15; // maximum amount of ability points

            //Asigning random integers to the Portfolio properties
            Character.Strength = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Character.Dexterity = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Character.Endurance = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Character.Intellect = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Character.Education = Convert.ToString(Rand.Next(1, maxSkill + 1));
            Character.SocialStanding = Convert.ToString(Rand.Next(1, maxSkill + 1));

            //Displaying the value of the Portfolio object properties in the appropriate labels
            StrengthDataLabel.Text = Character.Strength;
            DexterityDataLabel.Text = Character.Dexterity;
            EnduranceDataLabel.Text = Character.Endurance;
            IntellectDataLabel.Text = Character.Intellect;
            EducationDataLabel.Text = Character.Education;
            SocialStandingDataLabel.Text = Character.SocialStanding;

            //Displaying the same values in the CharacterSheet
            SheetStrengthDataLabel.Text = Character.Strength;
            SheetDexterityDataLabel.Text = Character.Dexterity;
            SheetEnduranceDataLabel.Text = Character.Endurance;
            SheetIntellectDataLabel.Text = Character.Intellect;
            SheetEducationDataLabel.Text = Character.Education;
            SheetSocialStandingDataLabel.Text = Character.SocialStanding;
        }

        /// <summary>
        /// This is the event handler for the load event of the CharacterGenerationForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            NameGenerator();
        }

        /// <summary>
        /// This is the event handler for the click event of the GenerateSkillsButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            SkillsGenerator();
        }

        /// <summary>
        /// This is the method for generating a random list of skills using the skills.txt file
        /// </summary>
        private void SkillsGenerator()
        {
            Character.Skills.Clear(); // clearing the list to make room for a new list of skills
            using (SkillsReader = new StreamReader(File.Open("..//..//Data//skills.txt", FileMode.Open)))
            {
                List<string> skills = new List<string>(); //List to store all the skills from skills.txt
                int i = 0; //iteration for the looping statement   
                int n = 0;//iteration for the second looping statement 
                int randomSkillIndex; //index of the generated random number

                while (SkillsReader.ReadLine() != null)
                {
                    if (SkillsReader.ReadLine() != "")
                    {
                        skills.Add(SkillsReader.ReadLine());
                        i++;
                    }

                }
                //Adding 4 randomly generated skills to the Character Skills list property
                while (n <= 4)
                {
                    randomSkillIndex = Rand.Next(i);
                    Character.Skills.Add(skills[randomSkillIndex]);
                    n++;
                }
                //Writing the Character Skills on the skills sheet
                SkillsLabel1.Text = Character.Skills[0];
                SkillsLabel2.Text = Character.Skills[1];
                SkillsLabel3.Text = Character.Skills[2];
                SkillsLabel4.Text = Character.Skills[3];
                //Writing the Character Skills on the Character sheet\
                SheetSkillsLabel1.Text = Character.Skills[0];
                SheetSkillsLabel2.Text = Character.Skills[1];
                SheetSkillsLabel3.Text = Character.Skills[2];
                SheetSkillsLabel4.Text = Character.Skills[3];

                SkillsReader.Close();
                SkillsReader.Dispose();
                skills.Clear();

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CharacterSaveFileDialog.FileName= "Character.txt";
            CharacterSaveFileDialog.InitialDirectory= "..//..//Data";
            CharacterSaveFileDialog.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            CharacterOpenFileDialog.FileName = "Character.txt";
            CharacterOpenFileDialog.InitialDirectory = "..//..//Data";
            CharacterOpenFileDialog.ShowDialog();
        }
    }
}
