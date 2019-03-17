using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
  

    public class User
    {
        [MaxLength(50),Required]
        public string UserName { get; set; }

        [MaxLength(50),Key]
        public string UserId { get; set; }
        [MaxLength(50),Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime RegisterTime = DateTime.UtcNow;
        public Roles.RoleSNames Role { get; set; }
        public string Email { get; set; }

        public ICollection< MultiChoices> MultiChoicesQuestions { get; set; }
        public ICollection<LongAnswer> LongAnswerQuestions { get; set; }
        public ICollection<ShortAnswer> ShortAnswerQuestions { get; set; }
        public ICollection<Puzzle> PuzzleQuestions { get; set; }
        public ICollection<Practical> PracticalQuestions { get; set; }
        public ICollection<TFQuestion> TFQuestions { get; set; }
    }
}
