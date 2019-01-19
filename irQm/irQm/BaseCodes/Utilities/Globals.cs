using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes.Utilities
{
   public class Globals
    {
        public class QuestionTypes
        {
            public enum QType { multiOption , trueOrFalse, practical, shortAnswer, longAnswer, puzzle }
            public class QuestionType
            {
                public string Name { get; set; }
                public QType Value { get; set; }
                public QuestionType(string name,QType value)
                {
                    Name = name;Value = value;
                }
            }
            public static QuestionType[] Names = { new QuestionType( "چند گزینه‌ای", QType.multiOption),
               new QuestionType( "درست و نادرست",QType.trueOrFalse)
                    ,
                new QuestionType( "عملی",QType.practical),
                new QuestionType("کوتاه پاسخ",QType.shortAnswer),
                new QuestionType("بلند پاسخ",QType.longAnswer),
               new QuestionType( "جور کردنی",QType.puzzle) };
           
        }

        public static User CurrentUser;
    }
}
