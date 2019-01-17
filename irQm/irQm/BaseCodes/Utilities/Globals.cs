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
            public class QuestionType
            {
                public string Name { get; set; }
                public string Value { get; set; }
                public QuestionType(string name,string value)
                {
                    Name = name;Value = value;
                }
            }
            public static QuestionType[] Names = { new QuestionType( "چند گزینه‌ای", "multiOprion"),
               new QuestionType( "درست و نادرست","TrueOrFalse")
                    ,
                new QuestionType( "عملی","practical"),
                new QuestionType("کوتاه پاسخ","shorAnswer"),
                new QuestionType("بلند پاسخ","longAnswer"),
               new QuestionType( "جور کردنی","puzzle") };
           
        }

        public static User CurrentUser;
    }
}
