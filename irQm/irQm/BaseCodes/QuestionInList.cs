using System;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    [Serializable]

    public class QuestionInList< T> :IquestionInList where T:IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }

        public int Row { get; set; }
        [Required]
        public T Question { get; set; }
       
        //public QuestionList QuestionList { get; set; }
       // Exam Exam { get; set; }
        //[MaxLength(50)]
        //public string ExamId { get; set; }
    }
}
