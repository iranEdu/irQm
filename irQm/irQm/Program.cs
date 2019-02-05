using irQm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var db = new irQm.BaseCodes.irQmDbContext();
            db.Database.EnsureCreated();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SelectChoiceForm login = new SelectChoiceForm();
            login.Show();
            Application.Run();
           




        }
    }
}
