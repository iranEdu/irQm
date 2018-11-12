using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace irQm.BaseCodes
{
    public interface IQuestion
    {
        
        string Face { get; set; }
        float Score { get; set; }
        float GainedScore { get; set; }
       
        string LessonName { get; set; }
        Lesson Lesson { get; set; }   
       
    }
}
