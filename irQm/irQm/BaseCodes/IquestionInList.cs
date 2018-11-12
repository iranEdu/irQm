using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public  interface IquestionInList
    {
       [MaxLength(50)]
         string Id { get; set; }

         int Row { get; set; }
       
    }
}
