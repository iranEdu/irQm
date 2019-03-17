using System;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    [Serializable]

    public class TagInQuestion<T> where T:IQuestion 
    {
       [Required]
       public T Question { get; set; }
        [Required]
        public string TagId { get; set; }
        public Tag Tag { get; set; }
        [Required]
        public string QuestionId { get; set; }
    }
}
