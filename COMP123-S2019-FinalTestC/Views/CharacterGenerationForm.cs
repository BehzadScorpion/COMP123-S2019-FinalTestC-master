using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        public TextReader FirstNameReader { get; set; }
        public TextReader LastNameReader { get; set; }
        public Random random { get; set; }

        public CharacterGenerationForm()
        {
            InitializeComponent();         
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

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            random = new Random();
            
            using (FirstNameReader= new StreamReader(File.Open("..\\..\\Data\\firstNames.txt", FileMode.Open)))
            {
                int i = 0; //iteration for the looping statement
                List<string> names = new List<string>(); //List to store all the names from firstNames.txt
                int lines; //number of lines in firstnames.txt
                int randomFirstNameIndex; //index of the generated random number

                while (FirstNameReader.ReadLine() != null)
                {
                    names.Add(FirstNameReader.ReadLine());
                    i++;
                }
                lines = i-1;
                randomFirstNameIndex = random.Next(lines);
                FirstNameDataLabel.Text = names[lines];
                FirstNameReader.Close();
                FirstNameReader.Dispose();
            }
           

            
            //LastNameReader.Read();
            //int randomFirstNameIndex = random.Next();
            //int randomLastNameIndex;

           
            
        }
    }
}
