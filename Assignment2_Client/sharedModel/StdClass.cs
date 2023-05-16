using System.ComponentModel.DataAnnotations;

namespace sharedModel
{
    public class StdClass
    {
        [Key]
        public int Rollnumber { get; set; }
        public String Name { get; set; }

    }
}
