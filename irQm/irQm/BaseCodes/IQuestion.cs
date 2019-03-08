using System;

namespace irQm.BaseCodes
{
    public interface IQuestion
    {
     
        string Id { get; set; }
        string Face { get; set; }
        byte[] Image { get; set; }
        float Score { get; set; }
        float GainedScore { get; set; }
       
        string LessonName { get; set; }
        Lesson Lesson { get; set; }
        DateTime RegisterTime { get; set; }
        DateTime EditTime { get; set; }
        
         User CreatorUser { get; set; }
        string CreatorUserId { get; set; }

        bool JustInList { get; set; }
        void DeleteFromDb();
        IQuestion Clone();
       
    }
}
