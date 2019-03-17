using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace irQm.UserControls.Forms
{
    public partial class Exam : UserControl
    {
        public Exam()
        {
            InitializeComponent();
            try
            {
                using (var db = new irQm.BaseCodes.irQmDbContext())
                {
                    ucQuestionForPresentation1.Initialize(db.TFQuestions.Include(q => q.TrueOption).Include(q => q.FalseOption).Last(), false, true);


                }
            }
            catch { }
        }
    }
}
