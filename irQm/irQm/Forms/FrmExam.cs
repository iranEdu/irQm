using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                ucQuestionForPresentation1.Question = db.MultiChoicesQuestions.Include(q=>q.Options).First();
              

            }
        }
    }
}
