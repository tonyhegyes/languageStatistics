using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace language_statistic.Models
{
    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public bool IsFree { get; set; }
        public string Website { get; set; }
        public string LowestFee { get; set; }
        public string EnglishName { get; set; }
        public string ShortDescription { get; set; }
        public string ResourceDescription { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
    public class CourseWebsite : Resource 
    {
        public string ISO639_3 { get; set; }
        public string Website_ISO639_3 { get; set; }
        
        public string EnglishType { get { return "CourseWebsite"; } }
    }
    public class Dictionary : Resource
    {
        public string TO_ISO639_3 { get; set; }
        public string FROM_ISO639_3 { get; set; }

        public string EnglishType { get { return "Dictionary"; } }
    }
    public class Forum : Resource
    {
        public string ISO639_3 { get; set; }
        public string Forum_ISO639_3 { get; set; }

        public string EnglishType { get { return "Forum"; } }
    }

    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public Guid ResourceID { get; set; }
        [ForeignKey("ResourceID")]
        public virtual Resource Resource { get; set; }
    }
}