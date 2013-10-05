using PhotoDescription.EFEntityFramework;
using PhotoDescription.Persistent;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoDescription.Popups;

namespace PhotoDescription
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PhotoContext>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new PhotoRepository();
            var newTripFrom = new NewTripForm();
            var process = new MainProcess(repository, newTripFrom);

            Application.Run(new MainWindow(process));
        }
    }
}
