using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace irQm.BaseCodes
{
    public class Exam
    {
        
        public Exam()
        {
            RegisterTime = DateTime.UtcNow;
        }

        public string ExamName { get ; set ; }
        public bool Shuffle { get;  set; }
       
       // public List<QuestionInList<IQuestion>> Questions { get;private set; } = 
        public ICollection<QuestionInList<TFQuestion>> TFQuestions { get;  set; } = new List<QuestionInList<TFQuestion>>();
        public ICollection<QuestionInList<ShortAnswer>> ShortAnswerQuestions { get; set; }=new List<QuestionInList<ShortAnswer>>();
        public ICollection<QuestionInList<LongAnswer>> LongAnswerQuestions { get; set; } = new List<QuestionInList<LongAnswer>>();
        public ICollection<QuestionInList<Practical>> PracticalQuestions { get; set; } = new List<QuestionInList<Practical>>();
        public ICollection<QuestionInList<Puzzle>> PuzzleQuestions { get; set; } = new List<QuestionInList<Puzzle>>();
        public ICollection<QuestionInList<MultiChoices>> MultiChoicesQuestions { get; set; } = new List<QuestionInList<MultiChoices>>();

        [NotMapped]
        public bool Started { get; private set; }
        [NotMapped]
        public bool Finished { get; private set; }
        [NotMapped]
        public bool PasswordForExamTime { get; set; }
        [NotMapped]
        public bool PasswordForEvaluationTime { get; set; }

        [MaxLength(50)]
        public string Id { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

        public DateTime RegisterTime { get; private set; }
        

        public DateTime StartTime { get; set; }
        public TimeSpan Time { get; set; }

        [NotMapped]
        public List<IquestionInList> Questions
        {
            get
            {
                var list = new List<IquestionInList>();
                list.AddRange(TFQuestions.ToList());
                list.AddRange(ShortAnswerQuestions.ToList());
                list.AddRange(LongAnswerQuestions.ToList());
                list.AddRange(PracticalQuestions.ToList());
                list.AddRange(PuzzleQuestions.ToList());
                list.AddRange(MultiChoicesQuestions.ToList());
                if(Shuffle)
                {
                    Random rnd = new Random();
                    list.ForEach(q => q.Row = rnd.Next(10 * list.Count()));
                    list = list.OrderBy(itm => itm.Row).ToList();
                    int i = 1;
                    list.ForEach(q => q.Row = i++);
                }
                return list.OrderBy(q => q.Row).ToList();
            }
        }
        
        [NotMapped]
        public float TotalMark
        {
            get
            {
                return Questions.Sum(q => ((IQuestion)q).Score);
            }
        }
        
        [NotMapped]
        public float Mark
        {
            get
            {
                return Questions.Sum(q => ((IQuestion)q).GainedScore);
            }
        }

        internal void AddQuestion(IQuestion q,int row)
        {
            var id =  Guid.NewGuid().ToString();
           
            
            if(q is MultiChoices)
            {
                var qil = new QuestionInList<MultiChoices>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (MultiChoices)q;


                MultiChoicesQuestions.Add(qil);
            }
            else if(q is TFQuestion)
            {
                var qil = new QuestionInList<TFQuestion>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (TFQuestion)q;
                TFQuestions.Add(qil);

            }
            else if (q is ShortAnswer)
            {
                var qil = new QuestionInList<ShortAnswer>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (ShortAnswer)q;
                ShortAnswerQuestions.Add(qil);

            }
            else if (q is Puzzle)
            {
                var qil = new QuestionInList<Puzzle>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (Puzzle)q;
                PuzzleQuestions.Add(qil);

            }
            else if (q is Practical)
            {
                var qil = new QuestionInList<Practical>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (Practical)q;

                PracticalQuestions.Add(qil);

            }
            else if (q is LongAnswer)
            {
                var qil = new QuestionInList<LongAnswer>();
                qil.Id = id;
                qil.Row = row;
                qil.Question = (LongAnswer)q;
                LongAnswerQuestions.Add(qil);

            }
        }
        
       
        public bool Start(Func<bool> startExamMethod)
        {
            var r = startExamMethod?.Invoke() ?? true;
            if(r)
            {
                Started = true;
            }
            return r;
             
        }

        public bool Finish(Func<bool> saveMethod)
        {
            Finished = true;
          return  saveMethod?.Invoke()?? true;
        }

   
    }
}
