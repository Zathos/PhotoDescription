using System;
using System.Data.Entity;
using System.Windows.Forms;
using PhotoDescription.EFEntityFramework;
using PhotoDescription.Persistent;
using PhotoDescription.Popups;

namespace PhotoDescription
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PhotoContext>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var repository = new EFPhotoRepository();
            var repository = new XMLPhotoRepository();

            var newTripFrom = new NewTripForm();
            var process = new MainProcess(repository, newTripFrom);

            Application.Run(new MainWindow(process));
        }
    }
}