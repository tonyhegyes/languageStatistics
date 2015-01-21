using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace language_statistic.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ISO3166_1 { get; set; }
        public string EnglishName { get; set; }

        public int Population { get; set; }
        public string PopulationSource { get; set; }

        public virtual ICollection<CountryNameLocalization> CountryNameLocalizations {get; set; }
        public virtual ICollection<CountrySpokenLanguage> CountrySpokenLanguages { get; set; }
    }
    public class CountryNameLocalization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Value { get; set; }

        public string CountryID { get; set; }
        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        public string LanguageID { get; set; }
        [ForeignKey("LanguageID")]
        public virtual Language Language { get; set; }
    }



    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ISO639_3 { get; set; }
        public string EnglishName { get; set; }
        public NumberOfSpeakers NumberOfTotalSpeakers { get; set; }

        public virtual ICollection<CountrySpokenLanguage> CountrySpokenLanguages { get; set; }
        public virtual ICollection<CountryNameLocalization> CountryNameLocalizations { get; set; }
    }
    public class NumberOfSpeakers
    {
        public int NumberOfL1Speakers { get; set; }
        public string NumberOfL1SpeakersSource { get; set; }

        public int NumberOfL2Speakers { get; set; }
        public string NumberOfL2SpeakersSource { get; set; }
    }

    public class CountrySpokenLanguage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public NumberOfSpeakers NumberOfSpeakers { get; set; }

        public string CountryID { get; set; }
        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        public string LanguageID { get; set; }
        [ForeignKey("LanguageID")]
        public virtual Language Language { get; set; }
    }
}