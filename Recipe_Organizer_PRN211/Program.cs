using Recipe_Organizer_PRN211.Authentication;

using Recipe_Organizer_PRN211.Plan;

namespace Recipe_Organizer_PRN211
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new /*Homepage*/PlanView());
            //Application.Run(new Recipe.SearchRecipe());

        }
    }
}