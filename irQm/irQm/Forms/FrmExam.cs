using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace irQm.Forms
{
    public partial class FrmExam : MasterForm
    {
        public FrmExam()
        {
            InitializeComponent();
            using (var db = new irQm.BaseCodes.irQmDbContext())
            {
                ucQuestionForPresentation1.Initialize( db.LongAnswerQuestions.First(),true,true);
              

            }
        }
    }
}
