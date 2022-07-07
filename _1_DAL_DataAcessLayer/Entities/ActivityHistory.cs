using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ACTIVITY_HISTORY")]
    public class ActivityHistory
    {
        [Key]
        public int Id { set; get; }
        public DateTime Time { set; get; }
        public bool Status { set; get; }
        public int? UserId { set; get; }
        public User User { get; set; }
        public int? ActivityId { set; get; }
        public virtual Activity Activity { get; set; }
    }
}