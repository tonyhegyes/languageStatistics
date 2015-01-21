using System.Data.Entity;
using language_statistic.Models;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;


namespace language_statistic.DALs
{
    public class ResourceContext : DbContext
    {
        public ResourceContext()
            : base("ResourcesDatabase")
        {

        }

        public DbSet<CourseWebsite> CourseWebsites { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<Forum> Forums { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class ResourceInitializer : DropCreateDatabaseIfModelChanges<ResourceContext>
    {
        protected override void Seed(ResourceContext context)
        {
            var courseWebsites = new List<CourseWebsite>
            {
                new CourseWebsite() { ID = Guid.NewGuid(), ISO639_3 = "eng", EnglishName = "lingoda - Learn English Online!", Website = "https://www.lingoda.com/", Website_ISO639_3 = "eng|deu", ShortDescription = "Lingoda is about learning languages online with qualified native speaking teachers that you can see and speak with.", ResourceDescription = "Our goal is to create a learning experience as convenient, easy and accessible as possible. We offer real teachers and fun. Learning a language with Lingoda has all the advantages of traditional education as well as extra benefits. Lingoda English offers personal interaction or group conversations, all while you learn from home or work.", IsFree = false, LowestFee = "99&euro; per month" },
                new CourseWebsite() { ID = Guid.NewGuid(), ISO639_3 = "eng", EnglishName = "LEO Network - Learn English Online!", Website = "http://www.learnenglish.de/", Website_ISO639_3 = "eng", ShortDescription = "The Learn English Network has been offering free English sessions and resources since 1999, and we've never charged a penny.", ResourceDescription = "The Learn English Network is a not-for-profit organisation registered in the UK. We have been providing support to ESL learners and teachers since 1999.<br/>The Learn English Network offers English grammar and extensive British English vocabulary sections along with a free English magazine, diary, games, lessons and tests and an insight into British culture, tradtions and customs.", IsFree = true },
            };
            courseWebsites.ForEach(c => context.CourseWebsites.Add(c));
            context.SaveChanges();

            var dictionaries = new List<Dictionary>
            {
                new Dictionary() { ID = Guid.NewGuid(), FROM_ISO639_3 = "eng", TO_ISO639_3 = "eng", EnglishName = "Dictionary.com", Website = "http://dictionary.reference.com/", ShortDescription = "Dictionary.com, an IAC (NASDAQ; IACI) company, is the world’s leading, definitive online and mobile resource for everything word related.", ResourceDescription = "Our mission is to delight and inspire anyone using the English language by being the most innovative and comprehensive digital source for everything related to words. We provide resources that enhance people’s lives, whether while working, doing homework or playing Scrabble, with the ability to accurately define, pronounce and apply words in the moment.", IsFree = true },
                new Dictionary() { ID = Guid.NewGuid(), FROM_ISO639_3 = "eng|ron", TO_ISO639_3 = "ron|eng", EnglishName = "Dictionar englez roman online", Website = "http://dictionar-englez-roman.ro/", ShortDescription = "Dictionar englez roman online", ResourceDescription = "Dictionar englez roman online cu pronuntie audio pentru cele mai populare cuvinte, transcriere fonetica, sinonime, antonime, dictionar explicativ englez, corector ortografic, zeci de mii de expresii uzuale in ambele limbi (engleza & romana) si translator automat.", IsFree = true }
            };
            dictionaries.ForEach(c => context.Dictionaries.Add(c));
            context.SaveChanges();

            var forums = new List<Forum>
            {
                new Forum() { ID = Guid.NewGuid(), ISO639_3 = "eng", EnglishName = "UsingEnglish.com Forum", Website = "http://www.usingenglish.com/forum/", Forum_ISO639_3 = "eng", ShortDescription = "A forum dedicated to learning English and administered by UsingEnglish.com, a general English language site specialising in ESL (English as a Second Language)", ResourceDescription = "UsingEnglish.com is a general English language site, specialising in ESL (English as a Second Language) with a wide range of resources for learners and teachers of English, and has been running since the beginning of 2002. Different varieties of English are used; there are contributors from the United States, Canada, Pakistan and non-native speakers, but much of the site uses British English as it was set up in the UK.", IsFree = true },
                new Forum() { ID = Guid.NewGuid(), ISO639_3 = "eng", EnglishName = "Forum de limba engleza", Website = "http://forum-engleza.academia-de-engleza.ro/", Forum_ISO639_3 = "ron", ShortDescription = "Invata engleza gratis pe net!", ResourceDescription = "", IsFree = true }
            };
            forums.ForEach(c => context.Forums.Add(c));
            context.SaveChanges();
        }
    }
}