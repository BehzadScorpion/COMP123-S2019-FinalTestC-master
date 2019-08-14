using COMP123_S2019_FinalTestC.Objects;
using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * STUDENT NAME: Seyed Behzad Afrasiabi
 * STUDENT ID: 300-605-726
 * DESCRIPTION: The main entry point for the application.
 */
namespace COMP123_S2019_FinalTestC
{
    public static class Program
    {
        public static CharacterPortfolio Portfolio;
        public static CharacterGenerationForm characterForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();
            Portfolio = new CharacterPortfolio();

            Application.Run(characterForm);
        }
    }
}
