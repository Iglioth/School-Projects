using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_App
{
    static class Program
    {
        static public Form Former { get; set; }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*FormLogIn2 LogInScreen = new FormLogIn2();
            FChallenges Challenges = new FChallenges();
            ChangePassword ChangePassword = new ChangePassword();
            ChosenDailyData ChosenDailyData = new ChosenDailyData();
            DailyDataComments DailyDataComments = new DailyDataComments();
            HomeScreen HomeScreen = new HomeScreen();*/
            Application.Run(new FormLogIn2());
            


        }
    }
}
