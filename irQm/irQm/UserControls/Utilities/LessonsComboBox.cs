using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{
   public  class LessonsComboBox:ComboBox
    {
        public LessonsComboBox():base()
        {
          
        }
        public void LoadItems()
        {
            using (BaseCodes.irQmDbContext db = new BaseCodes.irQmDbContext())
            {
                foreach (var l in db.Lessons.OrderBy(l => l.LessonName))
                {
                    this.Items.Add(l.LessonName);
                }
            }
        }
    }
}
