using System.ComponentModel.DataAnnotations;

namespace cafe_try_two.Models
{
    public class Feedback
    {
        [Key]
        public int Fid { get; set; }
        public int rating { get; set; }
        public int CustId { get; set; }
    }
}
