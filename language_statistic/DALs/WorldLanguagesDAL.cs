using System;
using System.Data.Entity;
using language_statistic.Models;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace language_statistic.DALs
{
    public class LanguageContext : DbContext
    {
        public LanguageContext()
            : base("WorldLanguagesDatabase")
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<CountrySpokenLanguage> CountrySpokenLanguages { get; set; }

        public DbSet<CountryNameLocalization> CountryNameLocalizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class LanguageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LanguageContext> 
    {
        protected override void Seed(LanguageContext context)
        {
            #region Countries
                var countries = new List<Country>
                {
                    #region A
                        new Country { ISO3166_1 = "ABW", EnglishName = "Aruba", Population = 102911, PopulationSource = "http://esa.un.org/wpp/" },
                        new Country { ISO3166_1 = "AFG", EnglishName = "Afghanistan", Population = 31108077, PopulationSource = "http://web.archive.org/web/20140427025327/https://www.cia.gov/library/publications/the-world-factbook/geos//af.html" },
                        new Country { ISO3166_1 = "AGO", EnglishName = "Angola", Population = 21566100, PopulationSource = "http://www.google.com/publicdata/explore?ds=n4ff2muj8bh2a_&ctype=l&strail=false&nselm=h&met_y=POP&hl=en&dl=en#ctype=l&strail=false&nselm=h&met_y=POP&fdim_y=scenario:1&scale_y=lin&ind_y=false&rdim=world&idim=country:AO&hl=en&dl=en" },
                        new Country { ISO3166_1 = "AIA", EnglishName = "Anguilla", Population = 13452, PopulationSource = "http://en.wikipedia.org/wiki/Anguilla" },
                        new Country { ISO3166_1 = "ALA", EnglishName = "Åland Islands", Population = 28666, PopulationSource = "http://en.wikipedia.org/wiki/%C3%85land_Islands" },
                        new Country { ISO3166_1 = "ALB", EnglishName = "Albania", Population = 3011405, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/al.html" },
                        new Country { ISO3166_1 = "AND", EnglishName = "Andorra", Population = 85082, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/an.html" },
                        new Country { ISO3166_1 = "ARE", EnglishName = "United Arab Emirates", Population = 9205651, PopulationSource = "http://data.worldbank.org/indicator/SP.POP.TOTL" },
                        new Country { ISO3166_1 = "ARG", EnglishName = "Argentina", Population = 41660417, PopulationSource = "http://www.indec.gov.ar/nuevaweb/cuadros/2/e020301.xls" },
                        new Country { ISO3166_1 = "ARM", EnglishName = "Armenia", Population = 3018854, PopulationSource = "http://www.armstat.am/file/doc/99475033.pdf" },
                        new Country { ISO3166_1 = "ASM", EnglishName = "American Samoa", Population = 55519, PopulationSource = "http://en.wikipedia.org/wiki/American_Samoa" },
                        new Country { ISO3166_1 = "ATA", EnglishName = "Antarctica", Population = 0, PopulationSource = String.Empty },
                        new Country { ISO3166_1 = "ATF", EnglishName = "French Southern Territories", Population = 140, PopulationSource = "http://en.wikipedia.org/wiki/French_Southern_and_Antarctic_Lands" },
                        new Country { ISO3166_1 = "ATG", EnglishName = "Antigua and Barbuda", Population = 81799, PopulationSource = "http://en.wikipedia.org/wiki/Antigua_and_Barbuda" },
                        new Country { ISO3166_1 = "AUS", EnglishName = "Australia", Population = 23523622, PopulationSource = "http://www.abs.gov.au/ausstats/abs@.nsf/94713ad445ff1425ca25682000192af2/1647509ef7e25faaca2568a900154b63?OpenDocument" },
                        new Country { ISO3166_1 = "AUT", EnglishName = "Austria", Population = 8504850, PopulationSource = "http://en.wikipedia.org/wiki/Austria" },
                        new Country { ISO3166_1 = "AZE", EnglishName = "Azerbaijan", Population = 9494600, PopulationSource = "http://www.stat.gov.az/" },
                    #endregion
                    #region B
                        new Country { ISO3166_1 = "BDI", EnglishName = "Burundi", Population = 8749000, PopulationSource = "http://en.wikipedia.org/wiki/Burundi" },
                        new Country { ISO3166_1 = "BEL", EnglishName = "Belgium", Population = 11099554, PopulationSource = "http://statbel.fgov.be/nl/statistieken/cijfers/bevolking/loop/" },
                        new Country { ISO3166_1 = "BEN", EnglishName = "Benin", Population = 10323000, PopulationSource = "http://en.wikipedia.org/wiki/Benin" },
                        new Country { ISO3166_1 = "BES", EnglishName = "Bonaire", Population = 17408, PopulationSource = "http://statline.cbs.nl/StatWeb/publication/?DM=SLNL&PA=80539ned&D1=0-1,9-10&D2=a&D3=a&HDR=T&STB=G1,G2&CHARTTYPE=1&VW=T" },
                        new Country { ISO3166_1 = "BFA", EnglishName = "Burkina Faso", Population = 15730977, PopulationSource = "http://www.insd.bf/fr/" },
                        new Country { ISO3166_1 = "BGD", EnglishName = "Bangladesh", Population = 150039000, PopulationSource = "http://www.imf.org/external/pubs/ft/weo/2013/02/weodata/weorept.aspx?pr.x=85&pr.y=9&sy=2013&ey=2013&scsm=1&ssd=1&sort=country&ds=.&br=1&c=513&s=NGDPD%2CNGDPDPC%2CPPPGDP%2CPPPPC%2CLP&grp=0&a=" },
                        new Country { ISO3166_1 = "BGR", EnglishName = "Bulgaria", Population = 7364570, PopulationSource = "http://en.wikipedia.org/wiki/Bulgaria" },
                        new Country { ISO3166_1 = "BHR", EnglishName = "Bahrain", Population = 1317827, PopulationSource = "http://data.worldbank.org/indicator/SP.POP.TOTL" },
                        new Country { ISO3166_1 = "BHS", EnglishName = "Bahamas", Population = 319031, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/bf.html" },
                        new Country { ISO3166_1 = "BIH", EnglishName = "Bosnia and Herzegovina", Population = 3871643, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/bk.html" },
                        new Country { ISO3166_1 = "BLM", EnglishName = "Saint Barthelemy", Population = 9035, PopulationSource = "http://www.insee.fr/fr/ppp/bases-de-donnees/recensement/populations-legales/france-departements.asp?annee=2011" },
                        new Country { ISO3166_1 = "BLR", EnglishName = "Belarus", Population = 9468154, PopulationSource = "http://www.citypopulation.de/Belarus.html" },
                        new Country { ISO3166_1 = "BLZ", EnglishName = "Belize", Population = 338597, PopulationSource = "https://web.archive.org/web/20130513185850/https://www.cia.gov/library/publications/the-world-factbook/geos/bh.html" },
                        new Country { ISO3166_1 = "BMU", EnglishName = "Bermuda", Population = 64237, PopulationSource = "http://www.govsubportal.com/ministries/2012-02-10-14-05-02/cabinet-office/statistics/publications" },
                        new Country { ISO3166_1 = "BOL", EnglishName = "Bolivia", Population = 10556102, PopulationSource = "http://countrymeters.info/en/Bolivia/" },
                        new Country { ISO3166_1 = "BRA", EnglishName = "Brazil", Population = 201032714, PopulationSource = "http://saladeimprensa.ibge.gov.br/en/noticias?view=noticia&id=1&busca=1&idnoticia=2204" },
                        new Country { ISO3166_1 = "BRB", EnglishName = "Barbados", Population = 277821, PopulationSource = "http://www.geohive.com/cntry/barbados.aspx" },
                        new Country { ISO3166_1 = "BRN", EnglishName = "Brunei", Population = 415717, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/bx.html" },
                        new Country { ISO3166_1 = "BTN", EnglishName = "Bhutan", Population = 742737, PopulationSource = "http://countrymeters.info/en/Bhutan" },
                        new Country { ISO3166_1 = "BVT", EnglishName = "Bouvet Island", Population = 0, PopulationSource = String.Empty },
                        new Country { ISO3166_1 = "BWA", EnglishName = "Botswana", Population = 2155784, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/bc.html" },
                    #endregion
                    #region C
                        new Country { ISO3166_1 = "CAF", EnglishName = "Central African Republic", Population = 4422000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "CAN", EnglishName = "Canada", Population = 35427524, PopulationSource = "http://www5.statcan.gc.ca/cansim/a26?lang=eng&retrLang=eng&id=0510005&paSer=&pattern=&stByVal=1&p1=1&p2=31&tabMode=dataTable&csid=" },
                        new Country { ISO3166_1 = "CCK", EnglishName = "Cocos [Keeling] Islands", Population = 596, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ck.html" },
                        new Country { ISO3166_1 = "CHE", EnglishName = "Switzerland", Population = 8014000, PopulationSource = "http://www.bfs.admin.ch/bfs/portal/en/index/themen/01/02/blank/key/bevoelkerungsstand/01.html" },
                        new Country { ISO3166_1 = "CHL", EnglishName = "Chile", Population = 17772871, PopulationSource = "http://en.wikipedia.org/wiki/Chile#cite_note-2" },
                        new Country { ISO3166_1 = "CHN", EnglishName = "China", Population = 1350695000, PopulationSource = "http://data.worldbank.org/indicator/SP.POP.TOTL" },
                        new Country { ISO3166_1 = "CIV", EnglishName = "Ivory Coast", Population = 22400835, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/iv.html" },
                        new Country { ISO3166_1 = "CMR", EnglishName = "Cameroon", Population = 22534532, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/cm.html" },
                        new Country { ISO3166_1 = "COD", EnglishName = "Democratic Republic of the Congo", Population = 77433744, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/cg.html" },              
                        new Country { ISO3166_1 = "COG", EnglishName = "Republic of the Congo", Population = 4662446, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/cf.html" },
                        new Country { ISO3166_1 = "COK", EnglishName = "Cook Islands", Population = 19569, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "COL", EnglishName = "Colombia", Population = 47425437, PopulationSource = "http://www.dane.gov.co/reloj/reloj_animado.php" },
                        new Country { ISO3166_1 = "COM", EnglishName = "Comoros", Population = 798000, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "CPV", EnglishName = "Cape Verde", Population = 512096, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "CRI", EnglishName = "Costa Rica", Population = 4586353, PopulationSource = "http://www.elfinancierocr.com/economia-y-politica/Censo_2011-INEC-Centro_Centroamericano_de_Poblacion-correccion_0_266373372.html" },
                        new Country { ISO3166_1 = "CUB", EnglishName = "Cuba", Population = 11167325, PopulationSource = "http://en.wikipedia.org/wiki/Cuba#cite_note-6" },
                        new Country { ISO3166_1 = "CUW", EnglishName = "Curacao", Population = 152760, PopulationSource = "http://www.cbs.cw/images/SO_2013.pdf" },
                        new Country { ISO3166_1 = "CXR", EnglishName = "Christmas Island", Population = 2072, PopulationSource = "http://www.censusdata.abs.gov.au/census_services/getproduct/census/2011/quickstat/SSC90001" },
                        new Country { ISO3166_1 = "CYM", EnglishName = "Cayman Islands", Population = 56732, PopulationSource = "http://en.wikipedia.org/wiki/Cayman_Islands" },
                        new Country { ISO3166_1 = "CYP", EnglishName = "Cyprus", Population = 1117000, PopulationSource = "http://esa.un.org/unpd/wpp/Documentation/pdf/WPP2010_Highlights.pdf" },
                        new Country { ISO3166_1 = "CZE", EnglishName = "Czechia", Population = 10513209, PopulationSource = "http://www.czso.cz/eng/redakce.nsf/i/population" },
                    #endregion
                    #region D
                        new Country { ISO3166_1 = "DEU", EnglishName = "Germany", Population = 80716000, PopulationSource = "http://www.statistik-portal.de/Statistik-Portal/de_zs01_bund.asp" },
                        new Country { ISO3166_1 = "DJI", EnglishName = "Djibouti", Population = 810179, PopulationSource = "http://en.wikipedia.org/wiki/Djibouti" },
                        new Country { ISO3166_1 = "DMA", EnglishName = "Dominica", Population = 71293, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "DNK", EnglishName = "Denmark", Population = 5627235, PopulationSource = "http://www.noegletal.dk/" },
                        new Country { ISO3166_1 = "DOM", EnglishName = "Dominican Republic", Population = 9445281, PopulationSource = "http://www.one.gov.do/index.php?module=articles&func=display&aid=2387" },
                        new Country { ISO3166_1 = "DZA", EnglishName = "Algeria", Population = 38700000, PopulationSource = "http://www.ons.dz/-Demographie-.html" },
                    #endregion
                    #region E
                        new Country { ISO3166_1 = "ECU", EnglishName = "Ecuador", Population = 15223680, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ec.html" },
                        new Country { ISO3166_1 = "EGY", EnglishName = "Egypt", Population = 86502500, PopulationSource = "http://www.capmas.gov.eg/?lang=2" },
                        new Country { ISO3166_1 = "ERI", EnglishName = "Eritrea", Population = 6233682, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "ESH", EnglishName = "Western Sahara", Population = 548000, PopulationSource = "http://data.un.org/CountryProfile.aspx?crName=Western%20Sahara%7Ctitle=Western" },
                        new Country { ISO3166_1 = "ESP", EnglishName = "Spain", Population = 46704314, PopulationSource = "http://www.ine.es/en/prensa/np788_en.pdf" },
                        new Country { ISO3166_1 = "EST", EnglishName = "Estonia", Population = 1315819, PopulationSource = "http://www.stat.ee/34277" },
                        new Country { ISO3166_1 = "ETH", EnglishName = "Ethiopia", Population = 93877025, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/et.html" }, 
                    #endregion
                    #region F
                        new Country { ISO3166_1 = "FIN", EnglishName = "Finland", Population = 5457429, PopulationSource = "http://vrk.fi/default.aspx?docid=8506&site=3&id=0" },
                        new Country { ISO3166_1 = "FJI", EnglishName = "Fiji", Population = 858038, PopulationSource = "http://web.archive.org/web/20111113144319/http://www.statsfiji.gov.fj/Key%20Stats/Population/1.2%20pop%20by%20ethnicity.pdf" },
                        new Country { ISO3166_1 = "FLK", EnglishName = "Falkland Islands", Population = 2932, PopulationSource = "http://www.falklands.gov.fk/assets/Headline-Results-from-Census-2012.pdf" },
                        new Country { ISO3166_1 = "FRA", EnglishName = "France", Population = 66616416, PopulationSource = "http://www.insee.fr/fr/themes/tableau.asp?ref_id=NATnon02145" },
                        new Country { ISO3166_1 = "FRO", EnglishName = "Faroe Islands", Population = 49709, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/fo.html" },
                        new Country { ISO3166_1 = "FSM", EnglishName = "Micronesia", Population = 531823, PopulationSource = "http://en.wikipedia.org/wiki/Micronesia" },
                    #endregion
                    #region G
                        new Country { ISO3166_1 = "GAB", EnglishName = "Gabon", Population = 1475000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "GBR", EnglishName = "United Kingdom", Population = 64100000, PopulationSource = "http://www.ons.gov.uk/ons/rel/pop-estimate/population-estimates-for-uk--england-and-wales--scotland-and-northern-ireland/2013/index.html" },
                        new Country { ISO3166_1 = "GEO", EnglishName = "Georgia", Population = 4935880, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/gg.html" },
                        new Country { ISO3166_1 = "GGY", EnglishName = "Guernsey", Population = 65345, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "GHA", EnglishName = "Ghana", Population = 20009153, PopulationSource = "http://www.touringghana.com/facts.asp" },
                        new Country { ISO3166_1 = "GIB", EnglishName = "Gibraltar", Population = 30001, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "GIN", EnglishName = "Guinea", Population = 10057975, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/gv.html" },
                        new Country { ISO3166_1 = "GLP", EnglishName = "Guadeloupe", Population = 405739, PopulationSource = "http://www.insee.fr/fr/ppp/bases-de-donnees/donnees-detaillees/estim-pop/estim-pop-reg-sexe-gca-1975-2013.xls" },
                        new Country { ISO3166_1 = "GMB", EnglishName = "Gambia", Population = 1882450, PopulationSource = "http://en.wikipedia.org/wiki/The_Gambia" },
                        new Country { ISO3166_1 = "GNB", EnglishName = "Guinea-Bissau", Population = 1647000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "GNQ", EnglishName = "Equatorial Guinea", Population = 1622000, PopulationSource = "http://www.guineaecuatorialpress.com/estadistica.php" },
                        new Country { ISO3166_1 = "GRC", EnglishName = "Greece", Population = 11280000, PopulationSource = "http://www.statistics.gr/portal/page/portal/ESYE/BUCKET/General/FEK_monimos_rev.pdf" },
                        new Country { ISO3166_1 = "GRD", EnglishName = "Grenada", Population = 109590, PopulationSource = "http://en.wikipedia.org/wiki/Grenada" },
                        new Country { ISO3166_1 = "GRL", EnglishName = "Greenland", Population = 56968, PopulationSource = "http://countrymeters.info/en/Greenland/" },
                        new Country { ISO3166_1 = "GTM", EnglishName = "Guatemala", Population = 15806675, PopulationSource = "http://www.ine.gob.gt/index.php/estadisticas/tema-indicadores" }, 
                        new Country { ISO3166_1 = "GUF", EnglishName = "French Guiana", Population = 250109, PopulationSource = "http://en.wikipedia.org/wiki/French_Guiana" },
                        new Country { ISO3166_1 = "GUM", EnglishName = "Guam", Population = 159358, PopulationSource = "http://2010.census.gov/news/releases/operations/cb11-cn179.html" },
                        new Country { ISO3166_1 = "GUY", EnglishName = "Guyana", Population = 735554, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/gy.html" },
                    #endregion
                    #region H
                        new Country { ISO3166_1 = "HKG", EnglishName = "Hong Kong", Population = 7184000, PopulationSource = "http://www.censtatd.gov.hk/press_release/pressReleaseDetail.jsp?charsetID=1&pressRID=3159" },
                        new Country { ISO3166_1 = "HMD", EnglishName = "Heard Island and McDonald Island", Population = 0, PopulationSource = String.Empty },
                        new Country { ISO3166_1 = "HND", EnglishName = "Honduras", Population = 8249574, PopulationSource = "http://en.wikipedia.org/wiki/Honduras" },
                        new Country { ISO3166_1 = "HRV", EnglishName = "Croatia", Population = 4284889, PopulationSource = "http://www.dzs.hr/Eng/censuses/census2011/results/htm/E01_01_01/e01_01_01.html" },
                        new Country { ISO3166_1 = "HTI", EnglishName = "Haiti", Population = 9996731, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ha.html" },
                        new Country { ISO3166_1 = "HUN", EnglishName = "Hungary", Population = 9879000, PopulationSource = "http://www.ksh.hu/docs/eng/xstadat/xstadat_long/h_wdsd001a.html" },
                    #endregion
                    #region I
                        new Country { ISO3166_1 = "IDN", EnglishName = "Indonesia", Population = 237424363, PopulationSource = "http://www.imf.org/external/pubs/ft/weo/2013/02/weodata/weorept.aspx?pr.x=70&pr.y=2&sy=2013&ey=2013&scsm=1&ssd=1&sort=country&ds=.&br=1&c=536&s=NGDPD%2CNGDPDPC%2CPPPGDP%2CPPPPC&grp=0&a=" },
                        new Country { ISO3166_1 = "IMN", EnglishName = "Isle of Man", Population = 84497, PopulationSource = "http://en.wikipedia.org/wiki/Isle_of_Man" },
                        new Country { ISO3166_1 = "IND", EnglishName = "India", Population = 1250000000, PopulationSource = "http://en.wikipedia.org/wiki/India#CITEREFMinistry_of_Home_Affairs2014" },
                        new Country { ISO3166_1 = "IOT", EnglishName = "British Indian Ocean Territory", Population = 3000, PopulationSource = "http://www.biotpostoffice.com/about-1.asp" },
                        new Country { ISO3166_1 = "IRL", EnglishName = "Ireland", Population = 6378000, PopulationSource = "http://www.nisra.gov.uk/Census/Historic_Population_Trends_(1841-2011)_NI_and_RoI.pdf" },
                        new Country { ISO3166_1 = "IRN", EnglishName = "Iran", Population = 77176930, PopulationSource = "http://www.farsnews.com/newstext.php?nn=13911203000204" },
                        new Country { ISO3166_1 = "IRQ", EnglishName = "Iraq", Population = 36004552, PopulationSource = "http://www.mofamission.gov.iq/nld/ab/articledisplay.aspx?gid=1&id=14075" },
                        new Country { ISO3166_1 = "ISL", EnglishName = "Iceland", Population = 325671, PopulationSource = "http://www.statice.is/Statistics/Population/Citizenship-and-country-of-birth" },
                        new Country { ISO3166_1 = "ISR", EnglishName = "Israel", Population = 8146300, PopulationSource = "http://www1.cbs.gov.il/webpub/pub/text_page_eng.html?publ=93" },
                        new Country { ISO3166_1 = "ITA", EnglishName = "Italy", Population = 60782668, PopulationSource = "http://www.istat.it/en/archive/125852" },
                    #endregion 
                    #region J
                        new Country { ISO3166_1 = "JAM", EnglishName = "Jamaica", Population = 2889187, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/jm.html" },
                        new Country { ISO3166_1 = "JEY", EnglishName = "Jersey", Population = 97857, PopulationSource = "http://www.gov.je/Government/Census/Census2011/Pages/2011CensusResults.aspx" },
                        new Country { ISO3166_1 = "JOR", EnglishName = "Jordan", Population = 7930491, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/jo.html" }, 
                        new Country { ISO3166_1 = "JPN", EnglishName = "Japan", Population = 126659683, PopulationSource = "http://japandailypress.com/japanese-population-decreases-for-third-year-in-a-row-098767/" },
                    #endregion 
                    #region K
                        new Country { ISO3166_1 = "KAZ", EnglishName = "Kazakhstan", Population = 17948816, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/kz.html" },
                        new Country { ISO3166_1 = "KEN", EnglishName = "Kenya", Population = 44037656, PopulationSource = "http://www.indexmundi.com/kenya/demographics_profile.html" },
                        new Country { ISO3166_1 = "KGZ", EnglishName = "Kyrgyzstan", Population = 5776500, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "KHM", EnglishName = "Cambodia", Population = 15205539, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/cb.html" },
                        new Country { ISO3166_1 = "KIR", EnglishName = "Kiribati", Population = 103500, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "KNA", EnglishName = "Saint Kitts and Nevis", Population = 51538, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "KOR", EnglishName = "South Korea", Population = 50219669, PopulationSource = "http://kosis.kr/gen_etl/install_miplatform_etc.jsp?orgId=101&tblId=DT_1B35001&scrId=&seqNo=&lang_mode=en&obj_var_id=&itm_id=&path=&vw_cd=MT_ETITLE&list_id=&url_param=http://kosis.kr:80/gen_etl/install_miplatform.jsp?orgId=101&tblId=DT_1B35001&vw_cd=MT_ETITLE&list_id=&empId=&scrId=&seqNo=&dbkind=ETLDB&lang_mode=en&dsu=nsi&conn_path=A6&conn_path=A6" },
                        new Country { ISO3166_1 = "KWT", EnglishName = "Kuwait", Population = 3965022, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                    #endregion 
                    #region L
                        new Country { ISO3166_1 = "LAO", EnglishName = "Laos", Population = 6695166, PopulationSource = "http://www.state.gov/r/pa/ei/bgn/2770.htm" },
                        new Country { ISO3166_1 = "LBN", EnglishName = "Lebanon", Population = 4822000, PopulationSource = "http://esa.un.org/unpd/wpp/Documentation/pdf/WPP2012_HIGHLIGHTS.pdf" },
                        new Country { ISO3166_1 = "LBR", EnglishName = "Liberia", Population = 4128572, PopulationSource = "http://www.worldbank.org/en/country/liberia" },
                        new Country { ISO3166_1 = "LBY", EnglishName = "Libya", Population = 6244174, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ly.html" },
                        new Country { ISO3166_1 = "LCA", EnglishName = "Saint Lucia", Population = 173765, PopulationSource = "http://en.wikipedia.org/wiki/Saint_Lucia" },
                        new Country { ISO3166_1 = "LIE", EnglishName = "Liechtenstein", Population = 36281, PopulationSource = "http://www.llv.li/pdf-llv-as-bevoelkerungsstatistik_30.06.2011" },
                        new Country { ISO3166_1 = "LKA", EnglishName = "Sri Lanka", Population = 20277597, PopulationSource = "http://www.statistics.gov.lk/PopHouSat/CPH2011/Pages/sm/CPH%202011_R1.pdf" },                
                        new Country { ISO3166_1 = "LSO", EnglishName = "Lesotho", Population = 2067000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "LTU", EnglishName = "Lithuania", Population = 2944459, PopulationSource = "http://db1.stat.gov.lt/statbank/selectvarval/saveselections.asp?MainTable=M3010101&PLanguage=1&TableStyle=&Buttons=&PXSId=7743&IQY=&TC=&ST=ST&rvar0=&rvar1=&rvar2=&rvar3=&rvar4=&rvar5=&rvar6=&rvar7=&rvar8=&rvar9=&rvar10=&rvar11=&rvar12=&rvar13=&rvar14=" },
                        new Country { ISO3166_1 = "LUX", EnglishName = "Luxembourg", Population = 549680, PopulationSource = "http://www.lequotidien.lu/politique-et-societe/55384.html" },
                        new Country { ISO3166_1 = "LVA", EnglishName = "Latvia", Population = 1997500, PopulationSource = "http://www.csb.gov.lv/en/notikumi/number-population-decreasing-mark-has-dropped-below-2-million-39639.html" },
                    #endregion 
                    #region M
                        new Country { ISO3166_1 = "MAC", EnglishName = "Macao", Population = 614500, PopulationSource = "http://www.dsec.gov.mo/Statistic/Demographic/DemographicStatistics/DemographicStatistics2014Q1.aspx" },
                        new Country { ISO3166_1 = "MAF", EnglishName = "Saint Martin", Population = 77741, PopulationSource = "http://en.wikipedia.org/wiki/Saint_Martin" },
                        new Country { ISO3166_1 = "MAR", EnglishName = "Morocco", Population = 33250000, PopulationSource = "http://www.hcp.ma/" },
                        new Country { ISO3166_1 = "MCO", EnglishName = "Monaco", Population = 36371, PopulationSource = "http://www.imsee.mc/Population-et-emploi" },
                        new Country { ISO3166_1 = "MDA", EnglishName = "Moldova", Population = 3557600, PopulationSource = "http://www.statistica.md/newsview.php?l=en&id=4347&idc=168" },
                        new Country { ISO3166_1 = "MDG", EnglishName = "Madagascar", Population = 22005222, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "MDV", EnglishName = "Maldives", Population = 393500, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/mv.html" },
                        new Country { ISO3166_1 = "MEX", EnglishName = "Mexico", Population = 118395054, PopulationSource = "http://www.conapo.gob.mx/es/CONAPO/Proyecciones" },
                        new Country { ISO3166_1 = "MHL", EnglishName = "Marshall Islands", Population = 68000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "MKD", EnglishName = "Macedonia", Population = 2058539, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "MLI", EnglishName = "Mali", Population = 14517176, PopulationSource = "http://instat.gov.ml/voir_actu.aspx?lactu=44" },
                        new Country { ISO3166_1 = "MLT", EnglishName = "Malta", Population = 452515, PopulationSource = "https://web.archive.org/web/20121116230853/http://www.mjha.gov.mt/MediaCenter/PDFs/1_Population%20Statistics.pdf" },
                        new Country { ISO3166_1 = "MMR", EnglishName = "Myanmar [Burma]", Population = 61120000, PopulationSource = "http://www.adb.org/publications/myanmar-fact-sheet" },
                        new Country { ISO3166_1 = "MNE", EnglishName = "Montenegro", Population = 625266, PopulationSource = "http://en.wikipedia.org/wiki/Montenegro" },
                        new Country { ISO3166_1 = "MNG", EnglishName = "Mongolia", Population = 2954283, PopulationSource = "http://www.nso.mn/" },
                        new Country { ISO3166_1 = "MNP", EnglishName = "Northern Mariana Islands", Population = 77000, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "MOZ", EnglishName = "Mozambique", Population = 23929708, PopulationSource = "http://databank.worldbank.org/data/DDP_Error.html?aspxerrorpath=/data/views/reports/tableview.aspx" },
                        new Country { ISO3166_1 = "MRT", EnglishName = "Mauritania", Population = 3359185, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/mr.html" },
                        new Country { ISO3166_1 = "MSR", EnglishName = "Montserrat", Population = 5164, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "MTQ", EnglishName = "Martinique", Population = 386486, PopulationSource = "http://www.insee.fr/fr/ppp/bases-de-donnees/donnees-detaillees/estim-pop/estim-pop-reg-sexe-gca-1975-2013.xls" },
                        new Country { ISO3166_1 = "MUS", EnglishName = "Mauritius", Population = 1259838, PopulationSource = "http://statsmauritius.gov.mu/English/Documents/ei1058/population.pdf" },
                        new Country { ISO3166_1 = "MWI", EnglishName = "Malawi", Population = 16407000, PopulationSource = "http://www.fao.org/countryprofiles/index/en/?iso3=MWI" },
                        new Country { ISO3166_1 = "MYS", EnglishName = "Malaysia", Population = 30204000, PopulationSource = "http://www.statistics.gov.my/portal/index.php?option=com_content&view=article&id=213&lang=en" },
                        new Country { ISO3166_1 = "MYT", EnglishName = "Mayotte", Population = 212645, PopulationSource = "http://www.insee.fr/fr/themes/document.asp?ref_id=19214" },
                    #endregion 
                    #region N
                        new Country { ISO3166_1 = "NAM", EnglishName = "Namibia", Population = 2113077, PopulationSource = "http://www.geohive.com/cntry/namibia.aspx" },
                        new Country { ISO3166_1 = "NCL", EnglishName = "New Caledonia", Population = 256000, PopulationSource = "http://www.isee.nc/chiffresc/chiffresc.html" },
                        new Country { ISO3166_1 = "NER", EnglishName = "Niger", Population = 17138707, PopulationSource = "http://en.wikipedia.org/wiki/Niger" },
                        new Country { ISO3166_1 = "NFK", EnglishName = "Norfolk Island", Population = 2302, PopulationSource = "http://en.wikipedia.org/wiki/Norfolk_Island" },
                        new Country { ISO3166_1 = "NGA", EnglishName = "Nigeria", Population = 174507539, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ni.html" },
                        new Country { ISO3166_1 = "NIC", EnglishName = "Nicaragua", Population = 6071045, PopulationSource = "http://www.inide.gob.ni/estadisticas/Cifras%20municipales%20a%C3%B1o%202012%20INIDE.pdf" },
                        new Country { ISO3166_1 = "NIU", EnglishName = "Niue", Population = 1611, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ne.html" },
                        new Country { ISO3166_1 = "NLD", EnglishName = "Netherlands", Population = 16819595, PopulationSource = "http://statline.cbs.nl/StatWeb/publication/?VW=T&DM=SLEN&PA=37943eng&LA=EN" },
                        new Country { ISO3166_1 = "NOR", EnglishName = "Norway", Population = 5136700, PopulationSource = "http://ssb.no/befolkning/statistikker/folkendrkv/kvartal/2013-11-21?fane=tabell#content" },
                        new Country { ISO3166_1 = "NPL", EnglishName = "Nepal", Population = 26494504, PopulationSource = "http://cbs.gov.np/wp-content/uploads/2012/11/National%20Report.pdf" },
                        new Country { ISO3166_1 = "NRU", EnglishName = "Nauru", Population = 9378, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/nr.html" },
                        new Country { ISO3166_1 = "NZL", EnglishName = "New Zealand", Population = 4537081, PopulationSource = "http://www.stats.govt.nz/tools_and_services/population_clock.aspx" },
                    #endregion 
                    #region O
                        new Country { ISO3166_1 = "OMN", EnglishName = "Oman", Population = 4013391, PopulationSource = "http://www.ncsi.gov.om/NCSI_website/NCSI_EN.aspx" },
                    #endregion 
                    #region P
                        new Country { ISO3166_1 = "PAK", EnglishName = "Pakistan", Population = 186693907, PopulationSource = "http://www.census.gov.pk/" },
                        new Country { ISO3166_1 = "PAN", EnglishName = "Panama", Population = 3608431, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/pm.html" },
                        new Country { ISO3166_1 = "PCN", EnglishName = "Pitcairn Islands", Population = 56, PopulationSource = "http://www.citypopulation.de/Pitcairn.html" },
                        new Country { ISO3166_1 = "PER", EnglishName = "Peru", Population = 30814175, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "PHL", EnglishName = "Philippines", Population = 99912000, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "PLW", EnglishName = "Palau", Population = 20956, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "PNG", EnglishName = "Papua New Guinea", Population = 7059653, PopulationSource = "http://www.postcourier.com.pg/20130625/tuhome.htm#.U9J0O_mSz4Y" },
                        new Country { ISO3166_1 = "POL", EnglishName = "Poland", Population = 38186860, PopulationSource = "http://stat.gov.pl/5840_655_ENG_HTML.htm" },
                        new Country { ISO3166_1 = "PRI", EnglishName = "Puerto Rico", Population = 3667084, PopulationSource = "http://www.census.gov/popest/data/national/totals/2012/index.html" },
                        new Country { ISO3166_1 = "PRK", EnglishName = "North Korea", Population = 24895000, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "PRT", EnglishName = "Portugal", Population = 10427301, PopulationSource = "http://www.ine.pt/xportal/xmain?xpid=INE&xpgid=ine_destaques&DESTAQUESdest_boui=211394338&DESTAQUESmodo=2" },
                        new Country { ISO3166_1 = "PRY", EnglishName = "Paraguay", Population = 6800284, PopulationSource = "http://www.un.org/esa/population/publications/wpp2012/wpp2012_text_tables.pdf" },
                        new Country { ISO3166_1 = "PSE", EnglishName = "Palestine", Population = 4047000, PopulationSource = "http://data.worldbank.org/indicator/SP.POP.TOTL" },
                        new Country { ISO3166_1 = "PYF", EnglishName = "French Polynesia", Population = 268270, PopulationSource = "http://www.insee.fr/fr/themes/detail.asp?ref_id=populegalescom&page=recensement/populegalescom/popcomseupolynesie.htm" },
                    #endregion 
                    #region Q
                        new Country { ISO3166_1 = "QAT", EnglishName = "Qatar", Population = 2155446, PopulationSource = "http://www.qsa.gov.qa/eng/PopulationStructure.htm" },
                    #endregion 
                    #region R
                        new Country { ISO3166_1 = "REU", EnglishName = "Reunion", Population = 840974, PopulationSource = "http://www.insee.fr/fr/ppp/bases-de-donnees/donnees-detaillees/estim-pop/estim-pop-reg-sexe-gca-1975-2013.xls" },
                        new Country { ISO3166_1 = "ROU", EnglishName = "Romania", Population = 20121641, PopulationSource = "http://www.recensamantromania.ro/wp-content/uploads/2013/07/REZULTATE-DEFINITIVE-RPL_2011.pdf" },
                        new Country { ISO3166_1 = "RUS", EnglishName = "Russia", Population = 143800000, PopulationSource = "http://www.gks.ru/bgd/free/B14_00/IssWWW.exe/Stg//%3Cextid%3E/%3Cstoragepath%3E::%7Cdk06/8-0.doc" },
                        new Country { ISO3166_1 = "RWA", EnglishName = "Rwanda", Population = 12012589, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/rw.html" },
                    #endregion 
                    #region S
                        new Country { ISO3166_1 = "SAU", EnglishName = "Saudi Arabia", Population = 29994272, PopulationSource = "http://www.cdsi.gov.sa/english/" },
                        new Country { ISO3166_1 = "SDN", EnglishName = "Sudan", Population = 30894000, PopulationSource = "http://www.news24.com/World/News/Discontent-over-Sudan-census-20090521" },
                        new Country { ISO3166_1 = "SEN", EnglishName = "Senegal", Population = 13567338, PopulationSource = "http://www.ansd.sn/senegal_indicateurs.html" },
                        new Country { ISO3166_1 = "SGP", EnglishName = "Singapore", Population = 5399200, PopulationSource = "http://www.singstat.gov.sg/statistics/latest_data.html#14" },
                        new Country { ISO3166_1 = "SGS", EnglishName = "South Georgia and the South Sandwich Islands", Population = 30, PopulationSource = "http://en.wikipedia.org/wiki/South_Georgia_and_the_South_Sandwich_Islands" },
                        new Country { ISO3166_1 = "SHN", EnglishName = "Saint Helena", Population = 4255, PopulationSource = "http://unstats.un.org/unsd/demographic/sources/census/2010_PHC/Saint_Helena/Saint_Helena.pdf" },
                        new Country { ISO3166_1 = "SJM", EnglishName = "Svalbard and Jan Mayen", Population = 2256, PopulationSource = "http://www.web-calendar.org/en/world/europe/svalbard-and-jan-mayen" },
                        new Country { ISO3166_1 = "SLB", EnglishName = "Solomon Islands", Population = 523000, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "SLE", EnglishName = "Sierra Leone", Population = 6190280, PopulationSource = "http://www.statistics.sl/2004_pop._&_hou._census_analytical_reports/2004_population_and_housing_census_report_on_projection_for_sierra_leone.pdf" },
                        new Country { ISO3166_1 = "SLV", EnglishName = "El Salvador", Population = 6134000, PopulationSource = "http://data.un.org/CountryProfile.aspx?crName=El%20Salvador" },
                        new Country { ISO3166_1 = "SMR", EnglishName = "San Marino", Population = 32576, PopulationSource = "http://www.statistica.sm/on-line/home/dati-statistici/popolazione.html?Categoria=2&nodo=/on-line/Home/DatiStatistici/Popolazione/Strutturademografica.html" },
                        new Country { ISO3166_1 = "SOM", EnglishName = "Somalia", Population = 10428043, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/so.html" },
                        new Country { ISO3166_1 = "SPM", EnglishName = "Saint Pierre and Miquelon", Population = 6080, PopulationSource = "http://www.insee.fr/fr/ppp/bases-de-donnees/recensement/populations-legales/france-departements.asp?annee=2011" }, 
                        new Country { ISO3166_1 = "SRB", EnglishName = "Serbia", Population = 7186862, PopulationSource = "http://en.wikipedia.org/wiki/Serbia" },
                        new Country { ISO3166_1 = "SSD", EnglishName = "South Sudan", Population = 8260490, PopulationSource = "http://en.wikipedia.org/wiki/South_Sudan#cite_note-n24-3" },
                        new Country { ISO3166_1 = "STP", EnglishName = "Sao Tome and Principe", Population = 187356, PopulationSource = "http://en.wikipedia.org/wiki/S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe" },
                        new Country { ISO3166_1 = "SUR", EnglishName = "Suriname", Population = 566846, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ns.html" },
                        new Country { ISO3166_1 = "SVK", EnglishName = "Slovakia", Population = 5415949, PopulationSource = "http://portal.statistics.sk/showdoc.do?docid=82252" },
                        new Country { ISO3166_1 = "SVN", EnglishName = "Slovenia", Population = 2061085, PopulationSource = "http://www.stat.si/eng/novica_prikazi.aspx?id=6200" },
                        new Country { ISO3166_1 = "SWE", EnglishName = "Sweden", Population = 9658301, PopulationSource = "https://www.ethnologue.com/country/SE/status" },
                        new Country { ISO3166_1 = "SWZ", EnglishName = "Swaziland", Population = 1106000, PopulationSource = "http://www.imf.org/external/pubs/ft/weo/2014/01/weodata/weorept.aspx?pr.x=47&pr.y=10&sy=2012&ey=2019&scsm=1&ssd=1&sort=country&ds=.&br=1&c=734&s=NGDPD%2CNGDPDPC%2CPPPGDP%2CPPPPC%2CLP&grp=0&a=" },
                        new Country { ISO3166_1 = "SXM", EnglishName = "Saint Maarten", Population = 37429, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "SYC", EnglishName = "Seychelles", Population = 90024, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "SYR", EnglishName = "Syria", Population = 17951639, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/sy.html" },
                    #endregion 
                    #region T
                        new Country { ISO3166_1 = "TCA", EnglishName = "Turks and Caicos Islands", Population = 31458, PopulationSource = "http://en.wikipedia.org/wiki/Turks_and_Caicos_Islands" },
                        new Country { ISO3166_1 = "TCD", EnglishName = "Chad", Population = 10329208, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/cd.html" },
                        new Country { ISO3166_1 = "TGO", EnglishName = "Togo", Population = 7154237, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/to.html" },
                        new Country { ISO3166_1 = "THA", EnglishName = "Thailand", Population = 66720153, PopulationSource = "https://web.archive.org/web/20110716001724/http://203.113.86.149/stat/pk/pk53/pk_53.pdf" },
                        new Country { ISO3166_1 = "TJK", EnglishName = "Tajikistan", Population = 8000000, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ti.html#People" },
                        new Country { ISO3166_1 = "TKL", EnglishName = "Tokelau", Population = 1411, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "TKM", EnglishName = "Turkmenistan", Population = 5171943, PopulationSource = "http://www.un.org/esa/population/publications/wpp2008/wpp2008_text_tables.pdf" },
                        new Country { ISO3166_1 = "TLS", EnglishName = "East Timor", Population = 1172390, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/tt.html" },
                        new Country { ISO3166_1 = "TON", EnglishName = "Tonga", Population = 103036, PopulationSource = "http://web.archive.org/web/20120413224257/http://www.pmo.gov.to/press-releases/3220-tonga-national-population-census-2011-preliminary-count" },
                        new Country { ISO3166_1 = "TTO", EnglishName = "Trinidad and Tobago", Population = 1223916, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/td.html" },
                        new Country { ISO3166_1 = "TUN", EnglishName = "Tunisia", Population = 10777500, PopulationSource = "http://www.ins.nat.tn/indexen.php" },
                        new Country { ISO3166_1 = "TUR", EnglishName = "Turkey", Population = 76667864, PopulationSource = "http://www.turkstat.gov.tr/Start.do" },
                        new Country { ISO3166_1 = "TUV", EnglishName = "Tuvalu", Population = 10837, PopulationSource = "http://www.undp.org/content/dam/undp/library/MDG/MDG%20Acceleration%20Framework/MAF%20Reports/RBAP/MAF%20Tuvalu-FINAL-%20April%204.pdf" },
                        new Country { ISO3166_1 = "TWN", EnglishName = "Taiwan", Population = 23373517, PopulationSource = "http://sowf.moi.gov.tw/stat/month/m1-01.xls" },
                        new Country { ISO3166_1 = "TZA", EnglishName = "Tanzania", Population = 44928923, PopulationSource = "http://web.archive.org/web/20131015224549/http://www.nbs.go.tz/sensa/PDF/Census%20General%20Report%20-%2029%20March%202013_Combined_Final%20for%20Printing.pdf" },
                    #endregion 
                    #region U
                        new Country { ISO3166_1 = "UGA", EnglishName = "Uganda", Population = 35873253, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ug.html" },
                        new Country { ISO3166_1 = "UKR", EnglishName = "Ukraine", Population = 44291413, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/up.html" },
                        new Country { ISO3166_1 = "UMI", EnglishName = "US Minor Outlying Islands", Population = 300, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "URY", EnglishName = "Uruguay", Population = 3324460, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/uy.html" },
                        new Country { ISO3166_1 = "USA", EnglishName = "United States", Population = 310232863, PopulationSource = "http://www.census.gov/popclock/" },
                        new Country { ISO3166_1 = "UZB", EnglishName = "Uzbekistan", Population = 30183400, PopulationSource = "http://www.stat.uz/press/1/6875/" },
                    #endregion 
                    #region V
                        new Country { ISO3166_1 = "VAT", EnglishName = "Vatican City", Population = 839, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/vt.html" },
                        new Country { ISO3166_1 = "VCT", EnglishName = "Saint Vincent and the Grenadines", Population = 103000, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/vc.html" },
                        new Country { ISO3166_1 = "VEN", EnglishName = "Venezuela", Population = 28946101, PopulationSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population" },
                        new Country { ISO3166_1 = "VGB", EnglishName = "British Virgin Islands", Population = 27800, PopulationSource = "http://www.bviplatinum.com/news.php?page=Article&articleID=1331602904" },
                        new Country { ISO3166_1 = "VIR", EnglishName = "US Virgin Islands", Population = 106405, PopulationSource = "http://en.wikipedia.org/wiki/United_States_Virgin_Islands" },
                        new Country { ISO3166_1 = "VNM", EnglishName = "Vietnam", Population = 89693000, PopulationSource = "http://www.imf.org/external/pubs/ft/weo/2013/02/weodata/weorept.aspx?pr.x=73&pr.y=7&sy=2013&ey=2013&scsm=1&ssd=1&sort=country&ds=.&br=1&c=582&s=NGDPD%2CNGDPDPC%2CPPPGDP%2CPPPPC%2CLP&grp=0&a=" },
                        new Country { ISO3166_1 = "VUT", EnglishName = "Vanuatu", Population = 224564, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/nh.html" },
                    #endregion 
                    #region W
                        new Country { ISO3166_1 = "WLF", EnglishName = "Wallis and Futuna", Population = 15500, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/wf.html" },
                        new Country { ISO3166_1 = "WSM", EnglishName = "Samoa", Population = 194320, PopulationSource = "https://www.cia.gov/library/publications/the-world-factbook/geos/ws.html" },
                    #endregion 
                    #region X
                        new Country { ISO3166_1 = "XKX", EnglishName = "Kosovo", Population = 1733842, PopulationSource = "http://en.wikipedia.org/wiki/Kosovo" },
                    #endregion 
                    #region Y
                        new Country { ISO3166_1 = "YEM", EnglishName = "Yemen", Population = 23833000, PopulationSource = "http://en.wikipedia.org/wiki/Yemen#cite_note-yearbook2011-1" },
                    #endregion 
                    #region Z
                        new Country { ISO3166_1 = "ZAF", EnglishName = "South Africa", Population = 52981991, PopulationSource = "http://www.statssa.gov.za/publications/P0302/P03022013.pdf" },
                        new Country { ISO3166_1 = "ZMB", EnglishName = "Zambia", Population = 14309466, PopulationSource = "http://www.zamstats.gov.zm/" },
                        new Country { ISO3166_1 = "ZWE", EnglishName = "Zimbabwe", Population = 12973808, PopulationSource = "http://www.zimstat.co.zw/dmdocuments/CensusPreliminary2012.pdf" }
                    #endregion
                };
            #endregion
            countries.ForEach(c => context.Countries.Add(c));
            context.SaveChanges();

            #region Languages
                var languages = new List<Language>
                {
                    #region A
                        new Language { ISO639_3 = "abk", EnglishName = "Abkhaz", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "aar", EnglishName = "Afar", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "afr", EnglishName = "Afrikaans", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "aka", EnglishName = "Akan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sqi", EnglishName = "Albanian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "amh", EnglishName = "Amharic", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ara", EnglishName = "Arabic", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "arg", EnglishName = "Aragonese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hye", EnglishName = "Armenian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "asm", EnglishName = "Assamese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ava", EnglishName = "Avaric", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ave", EnglishName = "Avestan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "aym", EnglishName = "Aymara", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "aze", EnglishName = "Azerbaijani", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region B
                        new Language { ISO639_3 = "bam", EnglishName = "Bambara", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bak", EnglishName = "Bashkir", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "baq", EnglishName = "Basque", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bel", EnglishName = "Belarusian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bjs", EnglishName = "Bajan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ben", EnglishName = "Bengali", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 220000000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Bengali_language", NumberOfL2Speakers = 30000000, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Bengali_language" } },
                        new Language { ISO639_3 = "bih", EnglishName = "Bihari", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bis", EnglishName = "Bislama", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kxd", EnglishName = "Brunei Malay", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bos", EnglishName = "Bosnian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bre", EnglishName = "Breton", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bul", EnglishName = "Bulgarian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mya", EnglishName = "Burmese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region C
                        new Language { ISO639_3 = "cat", EnglishName = "Catalan / Valencian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cha", EnglishName = "Chamorro", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "che", EnglishName = "Chechen", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nya", EnglishName = "Chichewa", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cmn", EnglishName = "Chinese, Mandarin", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nan", EnglishName = "Chinese, Nan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "yue", EnglishName = "Chinese, Yue", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "chv", EnglishName = "Chuvash", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "zdj", EnglishName = "Comorian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cor", EnglishName = "Cornish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cos", EnglishName = "Corsican", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cre", EnglishName = "Cree", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hrv", EnglishName = "Croatian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ces", EnglishName = "Czech", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ctg", EnglishName = "Chittagonian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region D
                        new Language { ISO639_3 = "dan", EnglishName = "Danish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "prs", EnglishName = "Dari", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "div", EnglishName = "Divehi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nld", EnglishName = "Dutch", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "dzo", EnglishName = "Dzongkha", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region E
                        new Language { ISO639_3 = "eng", EnglishName = "English", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "epo", EnglishName = "Esperanto", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "est", EnglishName = "Estonian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ewe", EnglishName = "Ewe", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region F
                        new Language { ISO639_3 = "fan", EnglishName = "Fang", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fao", EnglishName = "Faroese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fij", EnglishName = "Fijan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fin", EnglishName = "Finnish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fra", EnglishName = "French", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ful", EnglishName = "Fula", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fil", EnglishName = "Filipino", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region G
                        new Language { ISO639_3 = "gil", EnglishName = "Gilbertese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "glg", EnglishName = "Galician", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kat", EnglishName = "Georgian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "deu", EnglishName = "German", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ell", EnglishName = "Greek", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "grn", EnglishName = "Guaraní", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "guj", EnglishName = "Gujarati", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region H
                        new Language { ISO639_3 = "hat", EnglishName = "Haitian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hau", EnglishName = "Hausa", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "haz", EnglishName = "Hazāragī", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "heb", EnglishName = "Hebrew", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "her", EnglishName = "Herero", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hin", EnglishName = "Hindi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hmo", EnglishName = "Hiri Motu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "hun", EnglishName = "Hungarian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region I
                        new Language { ISO639_3 = "ina", EnglishName = "Interlingua", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ind", EnglishName = "Indonesian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ile", EnglishName = "Interlingue", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "gle", EnglishName = "Irish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ibo", EnglishName = "Igbo", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ipk", EnglishName = "Inupiaq", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ido", EnglishName = "Ido", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "isl", EnglishName = "Icelandic", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ita", EnglishName = "Italian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "iku", EnglishName = "Inuktitut", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region J
                        new Language { ISO639_3 = "jpn", EnglishName = "Japanese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "jav", EnglishName = "Javanese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "dyu", EnglishName = "Jula", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region K
                        new Language { ISO639_3 = "kal", EnglishName = "Kalaallisut / Greenlandic", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kan", EnglishName = "Kannada", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kau", EnglishName = "Kanuri", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kas", EnglishName = "Kashmiri", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kaz", EnglishName = "Kazakh", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kea", EnglishName = "Kabuverdianu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "khm", EnglishName = "Khmer", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kik", EnglishName = "Kikuyu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kin", EnglishName = "Kinyarwanda", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kir", EnglishName = "Kyrgyz", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "swh", EnglishName = "Kishwahili", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kmb", EnglishName = "Kimbundu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kom", EnglishName = "Komi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kon", EnglishName = "Kongo", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kor", EnglishName = "Korean", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kur", EnglishName = "Kurdish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "kua", EnglishName = "Kwanyama", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mkw", EnglishName = "Kituba", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region L
                        new Language { ISO639_3 = "lat", EnglishName = "Latin", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lvs", EnglishName = "Latvian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lyz", EnglishName = "Luxembourgish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lug", EnglishName = "Ganda", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lim", EnglishName = "Limburgish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lin", EnglishName = "Lingala", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lao", EnglishName = "Lao", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lit", EnglishName = "Lithuanian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lub", EnglishName = "Luba-Katanga", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "lav", EnglishName = "Latvian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region M
                        new Language { ISO639_3 = "glv", EnglishName = "Manx", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mkd", EnglishName = "Macedonian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mlg", EnglishName = "Malagasy", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "msa", EnglishName = "Malay", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mal", EnglishName = "Malayalam", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mlt", EnglishName = "Maltese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mri", EnglishName = "Māori", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mar", EnglishName = "Marathi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mah", EnglishName = "Marshallese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mey", EnglishName = "Hassaniyya", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "mon", EnglishName = "Mongolian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region N
                        new Language { ISO639_3 = "nau", EnglishName = "Nauru", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nav", EnglishName = "Navajo", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "npi", EnglishName = "Nepali", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nde", EnglishName = "Northern Ndebele", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nep", EnglishName = "Nepali", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ndo", EnglishName = "Ndonga", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nob", EnglishName = "Norwegian Bokmål", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nno", EnglishName = "Norwegian Nynorsk", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nor", EnglishName = "Norwegian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "iii", EnglishName = "Nuosu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "nbl", EnglishName = "Southern Ndebele", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region O
                        new Language { ISO639_3 = "oci", EnglishName = "Occitan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "oji", EnglishName = "Okibwe", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "chu", EnglishName = "Old Church Slavonic / Old Bulgarian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "orm", EnglishName = "Oromo", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ori", EnglishName = "Oriya", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "oss", EnglishName = "Ossetian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region P
                        new Language { ISO639_3 = "pan", EnglishName = "Panjabi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "pap", EnglishName = "Papiamento", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "pli", EnglishName = "Pāli", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fas", EnglishName = "Persian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "pol", EnglishName = "Polish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "pus", EnglishName = "Pashto", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "por", EnglishName = "Portuguese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region Q
                        new Language { ISO639_3 = "que", EnglishName = "Quechua", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region R
                        new Language { ISO639_3 = "roh", EnglishName = "Romansch", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "run", EnglishName = "Kirundi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10150000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/language/run", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "rkt", EnglishName = "Rangpuri", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/language/rkt", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "rmn", EnglishName = "Romani, Balkan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ron", EnglishName = "Romanian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "rus", EnglishName = "Russian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region S
                        new Language { ISO639_3 = "san", EnglishName = "Sanskrit", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "srd", EnglishName = "Sardinian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "snd", EnglishName = "Sindhi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sme", EnglishName = "Northern Sami", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "smo", EnglishName = "Samoan", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sag", EnglishName = "Sango", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "srp", EnglishName = "Serbian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "gla", EnglishName = "Scottish Gaelic", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sna", EnglishName = "Shona", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sin", EnglishName = "Sinhala", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "slk", EnglishName = "Slovak", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "slv", EnglishName = "Slovene", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "som", EnglishName = "Somali", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sot", EnglishName = "Southern Sotho", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "spa", EnglishName = "Spanish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "sun", EnglishName = "Sundanese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "swa", EnglishName = "Swahili", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ssw", EnglishName = "Swati", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "swe", EnglishName = "Swedish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "syl", EnglishName = "Sylheti", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region T
                        new Language { ISO639_3 = "tam", EnglishName = "Tamil", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tel", EnglishName = "Telugu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tgk", EnglishName = "Tajik", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tha", EnglishName = "Thai", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tir", EnglishName = "Tigrinya", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tly", EnglishName = "Talysh", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "bod", EnglishName = "Tibetan Standard", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tuk", EnglishName = "Turkmen", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tgl", EnglishName = "Tagalog", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tsn", EnglishName = "Tswana", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ton", EnglishName = "Tonga", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tur", EnglishName = "Turkish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tsj", EnglishName = "Tshangla", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tso", EnglishName = "Tsonga", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tat", EnglishName = "Tatar", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "twi", EnglishName = "Twi", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "tah", EnglishName = "Tahitian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region U
                        new Language { ISO639_3 = "uig", EnglishName = "Uyghur", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "ukr", EnglishName = "Ukrainian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "urd", EnglishName = "Urdu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "uzb", EnglishName = "Uzbek", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region V
                        new Language { ISO639_3 = "ven", EnglishName = "Venda", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "vie", EnglishName = "Vietnamese", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "vol", EnglishName = "Volapük", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region W
                        new Language { ISO639_3 = "wln", EnglishName = "Walloon", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "cym", EnglishName = "Welsh", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "wol", EnglishName = "Wolof", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "fry", EnglishName = "Western Frisian", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region X
                        new Language { ISO639_3 = "xho", EnglishName = "Xhosa", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region Y
                        new Language { ISO639_3 = "yid", EnglishName = "Yiddish", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "yor", EnglishName = "Yoruba", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region Z
                        new Language { ISO639_3 = "zha", EnglishName = "Zhuang", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new Language { ISO639_3 = "zul", EnglishName = "Zulu", NumberOfTotalSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } }
                    #endregion
                };
            #endregion
            languages.ForEach(l => context.Languages.Add(l));
            context.SaveChanges();

            #region SpokenLanguages / Country
                var countrySpokenLanguages = new List<CountrySpokenLanguage>
                {
                    #region A
                        /*Aruba*/
                        new CountrySpokenLanguage { CountryID = "ABW", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5290, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AW/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "ABW", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AW/languages", NumberOfL2Speakers = 35000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AW/languages" } },
                        new CountrySpokenLanguage { CountryID = "ABW", LanguageID = "pap", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AW/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Afghanistan*/
                        new CountrySpokenLanguage { CountryID = "AFG", LanguageID = "prs", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AF/languages", NumberOfL2Speakers = 8000000, NumberOfL2SpeakersSource = "http://lcweb2.loc.gov/frd/cs/profiles/Afghanistan.pdf" } },
                        new CountrySpokenLanguage { CountryID = "AFG", LanguageID = "haz", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1770000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AF/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AFG", LanguageID = "pus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10850000, NumberOfL1SpeakersSource = "http://lcweb2.loc.gov/frd/cs/profiles/Afghanistan.pdf", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AFG", LanguageID = "tuk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AF/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AFG", LanguageID = "uzb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2910000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AF/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Angola*/
                        new CountrySpokenLanguage { CountryID = "AGO", LanguageID = "kon", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AO/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AGO", LanguageID = "kmb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AO/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AGO", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8626440, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AO/languages", NumberOfL2Speakers = 4313220, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AO/languages" } },
                        /*Anguilla*/
                        new CountrySpokenLanguage { CountryID = "AIA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 950, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AI/languages", NumberOfL2Speakers = 11500, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AI/languages" } },
                        /*Åland Islands*/
                        new CountrySpokenLanguage { CountryID = "ALA", LanguageID = "swe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 28666, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/%C3%85land_Islands", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Albania*/
                        new CountrySpokenLanguage { CountryID = "ALB", LanguageID = "sqi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2770000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AL/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Andorra*/
                        new CountrySpokenLanguage { CountryID = "AND", LanguageID = "cat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 30000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AND", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AND", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 11700, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AND", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 27600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*United Arab Emirates*/
                        new CountrySpokenLanguage { CountryID = "ARE", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8000000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/United_Arab_Emirates#Languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "ARE", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 8000000, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/United_Arab_Emirates#Languages" } },
                        /*Argentina*/
                        new CountrySpokenLanguage { CountryID = "ARG", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 39500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AR/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "ARG", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "ARG", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Armenia*/
                        new CountrySpokenLanguage { CountryID = "ARM", LanguageID = "hye", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3140000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AM", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*American Samoa*/
                        new CountrySpokenLanguage { CountryID = "ASM", LanguageID = "smo", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 56700, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AS/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "ASM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AS/languages", NumberOfL2Speakers = 65000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AS/languages" } },
                        /*Antigua and Barbuda*/
                        new CountrySpokenLanguage { CountryID = "ATG", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 66000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AG/languages", NumberOfL2Speakers = 69000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AG/languages" } },
                        /*Australia*/
                        new CountrySpokenLanguage { CountryID = "AUS", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AU/languages", NumberOfL2Speakers = 3500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AU/languages" } },
                        /*Austria*/
                        new CountrySpokenLanguage { CountryID = "AUT", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7830000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AT/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Azerbaijan*/
                        new CountrySpokenLanguage { CountryID = "AZE", LanguageID = "aze", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AZ/languages", NumberOfL2Speakers = 8000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/AZ/languages" } },
                        new CountrySpokenLanguage { CountryID = "AZE", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 475000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AZ/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "AZE", LanguageID = "tly", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/AZ/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region B
                        /*Burundi*/
                        new CountrySpokenLanguage { CountryID = "BDI", LanguageID = "run", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BI/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Belgium*/
                        new CountrySpokenLanguage { CountryID = "BEL", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6215750, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium", NumberOfL2Speakers = 1664933, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium" } },
                        new CountrySpokenLanguage { CountryID = "BEL", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4217830, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium", NumberOfL2Speakers = 5327785, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium" } },
                        new CountrySpokenLanguage { CountryID = "BEL", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 110995, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium", NumberOfL2Speakers = 2996879, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium" } },
                        new CountrySpokenLanguage { CountryID = "BEL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 6548736, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium" } },
                        new CountrySpokenLanguage { CountryID = "BEL", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 665973, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Belgium" } },
                        /*Benin*/
                        new CountrySpokenLanguage { CountryID = "BEN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        //MORE RESEARCH FOR BENIN
                        /*Bonaire*/
                        new CountrySpokenLanguage { CountryID = "BES", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BQ/languages", NumberOfL2Speakers = 15800, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BQ/languages" } },
                        new CountrySpokenLanguage { CountryID = "BES", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 3300, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BQ/languages" } },
                        new CountrySpokenLanguage { CountryID = "BES", LanguageID = "pap", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BQ/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Burkina Faso*/
                        new CountrySpokenLanguage { CountryID = "BFA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        //MORE RESEARCH FOR BURKINA FASO
                        /*Bangladesh*/
                        new CountrySpokenLanguage { CountryID = "BGD", LanguageID = "ben", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 110000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BD/languages", NumberOfL2Speakers = 30000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BD/languages" } },
                        new CountrySpokenLanguage { CountryID = "BGD", LanguageID = "ctg", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 13000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BGD", LanguageID = "syl", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BD/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BGD", LanguageID = "rkt", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Rangpuri_language", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Bulgaria*/
                        new CountrySpokenLanguage { CountryID = "BGR", LanguageID = "bul", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7020000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BG/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BGR", LanguageID = "rmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 281000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BG/languages", NumberOfL2Speakers = 200000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BG/languages" } },
                        new CountrySpokenLanguage { CountryID = "BGR", LanguageID = "tur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 606000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BG/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Bahrain*/
                        new CountrySpokenLanguage { CountryID = "BHR", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 917827, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BH/languages", NumberOfL2Speakers = 400000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BH/languages" } },
                        new CountrySpokenLanguage { CountryID = "BHR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BH/languages", NumberOfL2Speakers = 1317827, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BH/languages" } },
                        /*Bahamas*/
                        new CountrySpokenLanguage { CountryID = "BHS", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 49300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BS/languages", NumberOfL2Speakers = 225000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BS/languages" } },
                        /*Bosnia and Herzegovina*/
                        new CountrySpokenLanguage { CountryID = "BIH", LanguageID = "bos", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BA/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BIH", LanguageID = "hrv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 469000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BA/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BIH", LanguageID = "srp", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1480000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BA/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Saint Berthelemy*/
                        new CountrySpokenLanguage { CountryID = "BLM", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6750, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BL/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Belarus*/
                        new CountrySpokenLanguage { CountryID = "BLR", LanguageID = "bel", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2220000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BY/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BLR", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6670000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BY/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Belize*/
                        new CountrySpokenLanguage { CountryID = "BLZ", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BZ/languages", NumberOfL2Speakers = 56000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BZ/languages" } },
                        new CountrySpokenLanguage { CountryID = "BLZ", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 101000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BZ/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Bermuda*/
                        new CountrySpokenLanguage { CountryID = "BMU", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 63000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BM/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BMU", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2610, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BM/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Bolivia*/
                        new CountrySpokenLanguage { CountryID = "BOL", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BO/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BOL", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 160000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BO/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BOL", LanguageID = "aym", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2808000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BO/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Brazil*/
                        new CountrySpokenLanguage { CountryID = "BRA", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 50000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRA", LanguageID = "jpn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 380000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRA", LanguageID = "kor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 37000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRA", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BR", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRA", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 187000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BR/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Barbados*/
                        new CountrySpokenLanguage { CountryID = "BRB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 13000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BB/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRB", LanguageID = "bjs", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 256000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BB/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Brunei*/
                        new CountrySpokenLanguage { CountryID = "BRN", LanguageID = "kxd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 215000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BN/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BRN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BN/languages", NumberOfL2Speakers = 134000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BN/languages" } },
                        /*Bhutan*/
                        new CountrySpokenLanguage { CountryID = "BTN", LanguageID = "dzo", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 160000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BT/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BTN", LanguageID = "tsj", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 140000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BT/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BTN", LanguageID = "npi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 160000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BT/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "BTN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = String.Empty, NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        /*Botswana*/
                        new CountrySpokenLanguage { CountryID = "BWA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BW/languages", NumberOfL2Speakers = 630000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/BW/languages" } },
                        new CountrySpokenLanguage { CountryID = "BWA", LanguageID = "tsn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1070000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/BW/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                    #endregion
                    #region C
                        /*Central African Republic*/
                        new CountrySpokenLanguage { CountryID = "CAF", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CAF", LanguageID = "sag", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 350000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CF/status", NumberOfL2Speakers = 1600000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CF/status" } },
                        /*Canada*/
                        new CountrySpokenLanguage { CountryID = "CAN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 19400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CA/status", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CA/status" } },
                        new CountrySpokenLanguage { CountryID = "CAN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cocos Islands*/
                        new CountrySpokenLanguage { CountryID = "CCK", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 596, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Switzerland*/
                        new CountrySpokenLanguage { CountryID = "CHE", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1490000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CHE", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4640000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CHE", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 471000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Chile*/
                        new CountrySpokenLanguage { CountryID = "CHL", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 13800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*China*/
                        new CountrySpokenLanguage { CountryID = "CHN", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 840000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CN/status", NumberOfL2Speakers = 178000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CN/status" } },
                        new CountrySpokenLanguage { CountryID = "CHN", LanguageID = "yue", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 52000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Ivory Coast*/
                        new CountrySpokenLanguage { CountryID = "CIV", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 17500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CIV", LanguageID = "bam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CIV", LanguageID = "dyu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CI/status", NumberOfL2Speakers = 7000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CI/status" } },
                        /*Cameroon*/                      
                        new CountrySpokenLanguage { CountryID = "CMR", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4500000, NumberOfL1SpeakersSource = "http://www.20mars.francophonie.org/IMG/pdf/FICHE_03_Nombre_de_francophones.pdf", NumberOfL2Speakers = 7000000, NumberOfL2SpeakersSource = "http://www.20mars.francophonie.org/IMG/pdf/FICHE_03_Nombre_de_francophones.pdf" } },
                        /*Democratic Republic of Congo*/
                        new CountrySpokenLanguage { CountryID = "COD", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7700000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Democratic_Republic_of_the_Congo#cite_note-2", NumberOfL2Speakers = 23100000, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Democratic_Republic_of_the_Congo#cite_note-2" } },
                        /*Republic of Congo*/
                        new CountrySpokenLanguage { CountryID = "COG", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 28000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "COG", LanguageID = "lin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 90600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "COG", LanguageID = "mkw", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1160000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cook Islands*/
                        new CountrySpokenLanguage { CountryID = "COK", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 680, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CK/status", NumberOfL2Speakers = 17000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CK/status" } },
                        /*Colombia*/
                        new CountrySpokenLanguage { CountryID = "COL", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 42300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Comoros*/
                        new CountrySpokenLanguage { CountryID = "COM", LanguageID = "zdj", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 774060, NumberOfL1SpeakersSource = "http://www.axl.cefan.ulaval.ca/afrique/comores.htm", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "COM", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000, NumberOfL1SpeakersSource = "http://www.axl.cefan.ulaval.ca/afrique/comores.htm", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cape Verde*/
                        new CountrySpokenLanguage { CountryID = "CPV", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CPV", LanguageID = "kea", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 492000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CV/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Costa Rica*/
                        new CountrySpokenLanguage { CountryID = "CRI", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cuba*/
                        new CountrySpokenLanguage { CountryID = "CUB", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 11400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Curacao*/
                        new CountrySpokenLanguage { CountryID = "CUW", LanguageID = "pap", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 115000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CW/status", NumberOfL2Speakers = 20000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CW/status" } },
                        new CountrySpokenLanguage { CountryID = "CUW", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 11400, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Christmas Island*/
                        new CountrySpokenLanguage { CountryID = "CXR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2072, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Christmas_Island", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cayman Islands*/
                        new CountrySpokenLanguage { CountryID = "CYM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 20000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KY/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "CYM", LanguageID = "hat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 20800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KY", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cyprus*/
                        new CountrySpokenLanguage { CountryID = "CYP", LanguageID = "ell", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CY/languages", NumberOfL2Speakers = 57000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CY/languages" } },
                        new CountrySpokenLanguage { CountryID = "CYP", LanguageID = "tur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 177000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CY/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Czechia*/
                        new CountrySpokenLanguage { CountryID = "CZE", LanguageID = "ces", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "CZE", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 40800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CZ/status", NumberOfL2Speakers = 1580000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CZ/status" } },
                        new CountrySpokenLanguage { CountryID = "CZE", LanguageID = "pol", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 50900, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = String.Empty } },
                        new CountrySpokenLanguage { CountryID = "CZE", LanguageID = "slk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 235000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/CZ/status", NumberOfL2Speakers = 1690000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/CZ/status" } },
                    #endregion
                    #region D
                        /*Germany*/
                        new CountrySpokenLanguage { CountryID = "DEU", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 69800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DE/status", NumberOfL2Speakers = 8000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/DE/status" } },
                        /*Djibouti*/
                        new CountrySpokenLanguage { CountryID = "DJI", LanguageID = "som", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 297200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/dj/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DJI", LanguageID = "aar", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 99200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/dj/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DJI", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/dj/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DJI", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/dj/languages", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Dominica*/
                        new CountrySpokenLanguage { CountryID = "DMA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DMA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 42600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Denmark*/
                        new CountrySpokenLanguage { CountryID = "DNK", LanguageID = "dan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5380000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DNK", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 25900, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DK/status", NumberOfL2Speakers = 2630000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/DK/status" } },
                        new CountrySpokenLanguage { CountryID = "DNK", LanguageID = "swe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 728000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/DK/status" } },
                        new CountrySpokenLanguage { CountryID = "DNK", LanguageID = "fao", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 66000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Dominican Republic*/
                        new CountrySpokenLanguage { CountryID = "DOM", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "DOM", LanguageID = "hat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 159000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Algeria*/
                        new CountrySpokenLanguage { CountryID = "DZA", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 26000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DZ/status", NumberOfL2Speakers = 3000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/DZ/status" } },
                        new CountrySpokenLanguage { CountryID = "DZA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/DZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region E
                        /*Ecuador*/
                        new CountrySpokenLanguage { CountryID = "ECU", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 13200000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/EC/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Egypt*/
                        new CountrySpokenLanguage { CountryID = "EGY", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 52500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/EG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Eritrea*/
                        new CountrySpokenLanguage { CountryID = "ERI", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ERI", LanguageID = "tir", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2540000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ER/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Western Sahara*/
                        new CountrySpokenLanguage { CountryID = "ESH", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 548000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/EH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Spain*/
                        new CountrySpokenLanguage { CountryID = "ESP", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 38400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ES/status", NumberOfL2Speakers = 7490000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ES/status" } },
                        new CountrySpokenLanguage { CountryID = "ESP", LanguageID = "baq", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 468000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ES/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ESP", LanguageID = "cat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3750000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ES/status", NumberOfL2Speakers = 5150000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ES/status" } },
                        new CountrySpokenLanguage { CountryID = "ESP", LanguageID = "glg", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2340000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ES/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Estonia*/
                        new CountrySpokenLanguage { CountryID = "EST", LanguageID = "est", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1040000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/EE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "EST", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 383000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/EE/status", NumberOfL2Speakers = 725000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/EE/status" } },
                        /*Ethiopia*/
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "amh", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 21600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 4000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ET/status" } },
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "aar", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1280000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 22800, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ET/status" } },
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "orm", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 25500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "som", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4610000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 95600, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ET/status" } },
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "tir", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4320000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 147000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ET/status" } },
                        new CountrySpokenLanguage { CountryID = "ETH", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1990, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ET/status", NumberOfL2Speakers = 170000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ET/status" } },
                    #endregion
                    #region F
                        /*Finland*/
                        new CountrySpokenLanguage { CountryID = "FIN", LanguageID = "fin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FIN", LanguageID = "swe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 271000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FI/status", NumberOfL2Speakers = 2390000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/FI/status" } },
                        /*Fiji*/
                        new CountrySpokenLanguage { CountryID = "FJI", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FJ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FJI", LanguageID = "hin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 380000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FJ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FJI", LanguageID = "fij", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 320000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FJ/status", NumberOfL2Speakers = 320000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/FJ/status" } },
                        /*Falkland Islands*/
                        new CountrySpokenLanguage { CountryID = "FLK", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2630, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Falkland_Islands", NumberOfL2Speakers = 300, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Falkland_Islands" } },
                        new CountrySpokenLanguage { CountryID = "FLK", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 300, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Falkland_Islands", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*France*/
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 750000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 8400000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/FR/status" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "cat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "lyz", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 40000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRA", LanguageID = "baq", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 76200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/FR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Faroe Islands*/
                        new CountrySpokenLanguage { CountryID = "FRO", LanguageID = "fao", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRO", LanguageID = "dan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRO", LanguageID = "nor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRO", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FRO", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Micronesia*/
                        new CountrySpokenLanguage { CountryID = "FSM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 200000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Micronesia", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FSM", LanguageID = "cha", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 35420, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Micronesia", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FSM", LanguageID = "mah", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 65000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Micronesia", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "FSM", LanguageID = "nau", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9300, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Micronesia", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region G
                        /*Gabon*/
                        new CountrySpokenLanguage { CountryID = "GAB", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 37500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GAB", LanguageID = "fan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 588000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*United Kingdom*/
                        new CountrySpokenLanguage { CountryID = "GBR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 55600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GB/status", NumberOfL2Speakers = 1500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GB/status" } },
                        new CountrySpokenLanguage { CountryID = "GBR", LanguageID = "cym", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 508000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GBR", LanguageID = "gle", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 116000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GBR", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 12000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GB/status" } },
                        /*Georgia*/
                        new CountrySpokenLanguage { CountryID = "GEO", LanguageID = "kat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3900000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GEO", LanguageID = "abk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 101000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GEO", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 372000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GEO", LanguageID = "hye", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 448000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GEO", LanguageID = "aze", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 360000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guernsey*/
                        new CountrySpokenLanguage { CountryID = "GGY", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Bailiwick_of_Guernsey", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GGY", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Bailiwick_of_Guernsey", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_the_Bailiwick_of_Guernsey" } },
                        /*Ghana*/
                        new CountrySpokenLanguage { CountryID = "GHA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GH/status" } },
                        new CountrySpokenLanguage { CountryID = "GHA", LanguageID = "aka", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GH/status", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GH/status" } },
                        new CountrySpokenLanguage { CountryID = "GHA", LanguageID = "ewe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2250000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GH/status", NumberOfL2Speakers = 500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GH/status" } },
                        /*Gibraltar*/
                        new CountrySpokenLanguage { CountryID = "GIB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 28000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GI/status", NumberOfL2Speakers = 2000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GI/status" } },
                        new CountrySpokenLanguage { CountryID = "GIB", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guinea*/
                        new CountrySpokenLanguage { CountryID = "GIN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guadeloupe*/
                        new CountrySpokenLanguage { CountryID = "GLP", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GP/status", NumberOfL2Speakers = 430000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GP/status" } },
                        /*Gambia*/
                        new CountrySpokenLanguage { CountryID = "GMB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guinea-Bissau*/
                        new CountrySpokenLanguage { CountryID = "GNB", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 167000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Equatorial Guinea*/
                        new CountrySpokenLanguage { CountryID = "GNQ", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 100000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GQ/status" } },
                        new CountrySpokenLanguage { CountryID = "GNQ", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GQ/status" } },
                        /*Greece*/
                        new CountrySpokenLanguage { CountryID = "GRC", LanguageID = "ell", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GRC", LanguageID = "tur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 128000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Grenada*/
                        new CountrySpokenLanguage { CountryID = "GRD", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 750, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GD/status", NumberOfL2Speakers = 89200, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GD/status" } },
                        /*Greenland*/
                        new CountrySpokenLanguage { CountryID = "GRL", LanguageID = "dan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7830, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GRL", LanguageID = "kal", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 50000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guatemala*/
                        new CountrySpokenLanguage { CountryID = "GTM", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*French Guiana*/
                        new CountrySpokenLanguage { CountryID = "GUF", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 250109, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Guam*/
                        new CountrySpokenLanguage { CountryID = "GUM", LanguageID = "cha", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 62500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "GUM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 58000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/GU/status", NumberOfL2Speakers = 100000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GU/status" } },
                        /*Guyana*/
                        new CountrySpokenLanguage { CountryID = "GUY", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 650000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/GY/status" } },
                    #endregion
                    #region H
                        /*Hong Kong*/
                        new CountrySpokenLanguage { CountryID = "HKG", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60900, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "HKG", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 187000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HK/status", NumberOfL2Speakers = 2200000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/HK/status" } },
                        new CountrySpokenLanguage { CountryID = "HKG", LanguageID = "yue", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6030000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Honduras*/
                        new CountrySpokenLanguage { CountryID = "HND", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "HND", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 31500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Croatia*/
                        new CountrySpokenLanguage { CountryID = "HRV", LanguageID = "hrv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4200000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "HRV", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 600000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/HR/status" } },
                        /*Haiti*/
                        new CountrySpokenLanguage { CountryID = "HTI", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HT/status", NumberOfL2Speakers = 400000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/HT/status" } },
                        new CountrySpokenLanguage { CountryID = "HTI", LanguageID = "hat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6960000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Hungary*/
                        new CountrySpokenLanguage { CountryID = "HUN", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9840000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "HUN", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 132000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/HU/status", NumberOfL2Speakers = 1790000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/HU/status" } },
                    #endregion
                    #region I
                        /*Indonesia*/
                        new CountrySpokenLanguage { CountryID = "IDN", LanguageID = "ind", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 22800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ID/status", NumberOfL2Speakers = 140000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ID/status" } },
                        new CountrySpokenLanguage { CountryID = "IDN", LanguageID = "jav", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 84300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ID/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IDN", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 460000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ID/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Isle of Man*/
                        new CountrySpokenLanguage { CountryID = "IMN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 85000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IMN", LanguageID = "glv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 500, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IM/status" } },
                        /*India*/
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 350000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 200000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IN/status" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "hin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 258000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 120000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IN/status" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "asm", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 12800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "ben", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 82500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "guj", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 45700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "kan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 37700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 9000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IN/status" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "mal", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 33000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "mar", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 71780660, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 3000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IN/status" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "npi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2870000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "ori", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 32100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "pan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 28200000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "tam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 8000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IN/status" } },
                        new CountrySpokenLanguage { CountryID = "IND", LanguageID = "urd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 51500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*British Indian Ocean Territories*/
                        new CountrySpokenLanguage { CountryID = "IOT", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Ireland*/
                        new CountrySpokenLanguage { CountryID = "IRL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4270000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IE/status", NumberOfL2Speakers = 275000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IE/status" } },
                        new CountrySpokenLanguage { CountryID = "IRL", LanguageID = "gle", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 138000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IE/status", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IE/status" } },
                        /*Iran*/
                        new CountrySpokenLanguage { CountryID = "IRN", LanguageID = "fas", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 45000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRN", LanguageID = "aze", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRN", LanguageID = "kur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3250000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRN", LanguageID = "tuk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Iraq*/
                        new CountrySpokenLanguage { CountryID = "IRQ", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 17800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IQ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRQ", LanguageID = "kur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IQ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRQ", LanguageID = "fas", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 227000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IQ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "IRQ", LanguageID = "aze", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IQ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Iceland*/
                        new CountrySpokenLanguage { CountryID = "ISL", LanguageID = "isl", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 230000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Israel*/
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 910000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "heb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4850000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 70000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "pol", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "ron", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 250000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ISR", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 750000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Italian*/
                        new CountrySpokenLanguage { CountryID = "ITA", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 57700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ITA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IT/status", NumberOfL2Speakers = 9510000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/IT/status" } },
                        new CountrySpokenLanguage { CountryID = "ITA", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 225000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ITA", LanguageID = "slv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/IT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region J
                        /*Jamaica*/
                        new CountrySpokenLanguage { CountryID = "JAM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 2889187, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/JM/status" } },
                        /*Jersey*/
                        new CountrySpokenLanguage { CountryID = "JEY", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 92000, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Jersey", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "JEY", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6200, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Jersey", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Jordan*/
                        new CountrySpokenLanguage { CountryID = "JOR", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 4250000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/JO/status" } },
                        /*Japan*/
                        new CountrySpokenLanguage { CountryID = "JPN", LanguageID = "jpn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 121000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/JP/status", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/JP/status" } },
                        new CountrySpokenLanguage { CountryID = "JPN", LanguageID = "kor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 905000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/JP/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region K
                        /*Kazakhstan*/
                        new CountrySpokenLanguage { CountryID = "KAZ", LanguageID = "kaz", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5290000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "KAZ", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6230000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "KAZ", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 958000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "KAZ", LanguageID = "ukr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 898000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Kenya*/
                        new CountrySpokenLanguage { CountryID = "KEN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 24300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KE/status", NumberOfL2Speakers = 2700000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/KE/status" } },
                        new CountrySpokenLanguage { CountryID = "KEN", LanguageID = "swa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 131000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "KEN", LanguageID = "som", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2386000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Kyrgyzstan*/
                        new CountrySpokenLanguage { CountryID = "KGZ", LanguageID = "kir", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2450000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "KGZ", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1410000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Cambodia*/
                        new CountrySpokenLanguage { CountryID = "KHM", LanguageID = "khm", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 12900000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KH/status", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/KH/status" } },
                        new CountrySpokenLanguage { CountryID = "KHM", LanguageID = "vie", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 72800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Kiribati*/
                        new CountrySpokenLanguage { CountryID = "KIR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 490, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KI/status", NumberOfL2Speakers = 23000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/KI/status" } },
                        new CountrySpokenLanguage { CountryID = "KIR", LanguageID = "gil", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 58300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Kitts and Nevis*/
                        new CountrySpokenLanguage { CountryID = "KNA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KN/status", NumberOfL2Speakers = 39000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/KN/status" } },
                        /*South Korea*/
                        new CountrySpokenLanguage { CountryID = "KOR", LanguageID = "kor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 48400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Kuwait*/
                        new CountrySpokenLanguage { CountryID = "KWT", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/KW/status" } },
                    #endregion
                    #region L
                        /*Laos*/
                        new CountrySpokenLanguage { CountryID = "LAO", LanguageID = "lao", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3070000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LA/status", NumberOfL2Speakers = 800000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LA/status" } },
                        /*Lebanon*/
                        new CountrySpokenLanguage { CountryID = "LBN", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 3900000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LB/status" } },
                        new CountrySpokenLanguage { CountryID = "LBN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LB/status" } },
                        new CountrySpokenLanguage { CountryID = "LBN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 16600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LBN", LanguageID = "hye", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 235000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LBN", LanguageID = "kur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 75000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LB/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Liberia*/
                        new CountrySpokenLanguage { CountryID = "LBR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 70000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LR/status", NumberOfL2Speakers = 1500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LR/status" } },
                        /*Libya*/
                        new CountrySpokenLanguage { CountryID = "LBY", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 4000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LY/status" } },
                        /*Saint Lucia*/
                        new CountrySpokenLanguage { CountryID = "LCA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LC/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LCA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 158000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LC/status" } },
                        /*Liechtenstein*/
                        new CountrySpokenLanguage { CountryID = "LIE", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 29000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LI/status" } },
                        /*Sri Lanka*/
                        new CountrySpokenLanguage { CountryID = "LKA", LanguageID = "sin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LK/status", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LK/status" } },
                        new CountrySpokenLanguage { CountryID = "LKA", LanguageID = "tam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3770000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LKA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LK/status", NumberOfL2Speakers = 1900000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LK/status" } },
                        /*Lesotho*/
                        new CountrySpokenLanguage { CountryID = "LSO", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LS/status" } },
                        new CountrySpokenLanguage { CountryID = "LSO", LanguageID = "sot", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1770000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Lithuania*/
                        new CountrySpokenLanguage { CountryID = "LTU", LanguageID = "lit", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LTU", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 344000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LT/status", NumberOfL2Speakers = 2430000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LT/status" } },
                        new CountrySpokenLanguage { CountryID = "LTU", LanguageID = "bel", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 63000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "LTU", LanguageID = "pol", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 258000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LT/status", NumberOfL2Speakers = 454000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LT/status" } },
                        new CountrySpokenLanguage { CountryID = "LTU", LanguageID = "ukr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 45000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Luxembourg*/
                        new CountrySpokenLanguage { CountryID = "LUX", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 82000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LU/status", NumberOfL2Speakers = 414000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LU/status" } },
                        new CountrySpokenLanguage { CountryID = "LUX", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LU/status", NumberOfL2Speakers = 353000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LU/status" } },
                        new CountrySpokenLanguage { CountryID = "LUX", LanguageID = "lyz", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 266000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LU/status", NumberOfL2Speakers = 50000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LU/status" } },
                        /*Latvia*/
                        new CountrySpokenLanguage { CountryID = "LVA", LanguageID = "lvs", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1552260, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LV/status", NumberOfL2Speakers = 497000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LV/status" } },
                        new CountrySpokenLanguage { CountryID = "LVA", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 862000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/LV/status", NumberOfL2Speakers = 1390000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/LV/status" } },
                    #endregion 
                    #region M
                        /*Macao*/
                        new CountrySpokenLanguage { CountryID = "MAC", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6660, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MAC", LanguageID = "yue", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 373000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MAC", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2810, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Martin*/
                        new CountrySpokenLanguage { CountryID = "MAF", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MAF", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MF/status", NumberOfL2Speakers = 14000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MF/status" } },
                        new CountrySpokenLanguage { CountryID = "MAF", LanguageID = "hat", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Morocco*/
                        new CountrySpokenLanguage { CountryID = "MAR", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 18800000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MA/status", NumberOfL2Speakers = 5000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MA/status" } },
                        new CountrySpokenLanguage { CountryID = "MAR", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 80000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MA/status", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MA/status" } },
                        /*Monaco*/
                        new CountrySpokenLanguage { CountryID = "MCO", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 17400, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MC/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Moldova*/
                        new CountrySpokenLanguage { CountryID = "MDA", LanguageID = "ron", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2660000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MD/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDA", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 562000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MD/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDA", LanguageID = "ukr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MD/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDA", LanguageID = "bul", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 395000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MD/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Madagascar*/
                        new CountrySpokenLanguage { CountryID = "MDG", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 18000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDG", LanguageID = "mlg", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 14520000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDG", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Maldives*/
                        new CountrySpokenLanguage { CountryID = "MDV", LanguageID = "div", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 331000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MV/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MDV", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MV/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Mexico*/
                        new CountrySpokenLanguage { CountryID = "MEX", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 104000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MX/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Marshall Islands*/
                        new CountrySpokenLanguage { CountryID = "MHL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 60000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MH/status" } },
                        new CountrySpokenLanguage { CountryID = "MHL", LanguageID = "mah", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 43900, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MH/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Macedonia*/
                        new CountrySpokenLanguage { CountryID = "MKD", LanguageID = "mkd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1340000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MKD", LanguageID = "sqi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 508000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MKD", LanguageID = "tur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 71800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Mali*/
                        new CountrySpokenLanguage { CountryID = "MLI", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ML/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MLI", LanguageID = "dyu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 50000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ML/status", NumberOfL2Speakers = 278000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ML/status" } },
                        new CountrySpokenLanguage { CountryID = "MLI", LanguageID = "bam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ML/status", NumberOfL2Speakers = 10000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/ML/status" } },
                        /*Malta*/
                        new CountrySpokenLanguage { CountryID = "MLT", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 16200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MT/status", NumberOfL2Speakers = 360000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MT/status" } },
                        new CountrySpokenLanguage { CountryID = "MLT", LanguageID = "mlt", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 393000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Burma*/
                        new CountrySpokenLanguage { CountryID = "MMR", LanguageID = "mya", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 32000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MM/status", NumberOfL2Speakers = 10000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MM/status" } },
                        new CountrySpokenLanguage { CountryID = "MMR", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Montenegro*/
                        new CountrySpokenLanguage { CountryID = "MNE", LanguageID = "srp", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 198000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ME/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MNE", LanguageID = "sqi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 80000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ME/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MNE", LanguageID = "bos", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 48000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/ME/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Mongolia*/
                        new CountrySpokenLanguage { CountryID = "MNG", LanguageID = "mon", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2350000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MNG", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MNG", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 35000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Northern Mariana Islands*/
                        new CountrySpokenLanguage { CountryID = "MNP", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6820, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MP/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MNP", LanguageID = "cha", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 14200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MP/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Mozambique*/
                        new CountrySpokenLanguage { CountryID = "MOZ", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1340000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MZ/status", NumberOfL2Speakers = 6300000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MZ/status" } },
                        /*Mauritania*/
                        new CountrySpokenLanguage { CountryID = "MRT", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MRT", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MRT", LanguageID = "mey", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2770000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Montserrat*/
                        new CountrySpokenLanguage { CountryID = "MSR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MS/status", NumberOfL2Speakers = 7570, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MS/status" } },
                        /*Martinique*/
                        new CountrySpokenLanguage { CountryID = "MTQ", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MQ/status", NumberOfL2Speakers = 418000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MQ/status" } },
                        /*Mauritius*/
                        new CountrySpokenLanguage { CountryID = "MUS", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MU/status", NumberOfL2Speakers = 200000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MU/status" } },
                        new CountrySpokenLanguage { CountryID = "MUS", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 37000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MUS", LanguageID = "urd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 64000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Malawi*/
                        new CountrySpokenLanguage { CountryID = "MWI", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 16000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MW/status", NumberOfL2Speakers = 540000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MW/status" } },
                        new CountrySpokenLanguage { CountryID = "MWI", LanguageID = "nya", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Malaysia*/
                        new CountrySpokenLanguage { CountryID = "MYS", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MYS", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 380000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MY/status", NumberOfL2Speakers = 7000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MY/status" } },
                        new CountrySpokenLanguage { CountryID = "MYS", LanguageID = "yue", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1070000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MYS", LanguageID = "msa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 13100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MY/status", NumberOfL2Speakers = 6000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/MY/status" } },
                        new CountrySpokenLanguage { CountryID = "MYS", LanguageID = "tam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3780000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/MY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Mayotte*/
                        new CountrySpokenLanguage { CountryID = "MYT", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2450, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/YT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "MYT", LanguageID = "zdj", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 92800, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/YT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region N
                        /*Namibia*/
                        new CountrySpokenLanguage { CountryID = "NAM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10200, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NA/status", NumberOfL2Speakers = 300000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NA/status" } },
                        new CountrySpokenLanguage { CountryID = "NAM", LanguageID = "afr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 89900, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NAM", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 22500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NAM", LanguageID = "her", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 206000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*New Caledonia*/
                        new CountrySpokenLanguage { CountryID = "NCL", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 68300, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NC/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Niger*/
                        new CountrySpokenLanguage { CountryID = "NER", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NER", LanguageID = "hau", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5460000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Norfolk Island*/
                        new CountrySpokenLanguage { CountryID = "NFK", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1680, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Nigeria*/
                        new CountrySpokenLanguage { CountryID = "NGA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 60000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NG/status" } },
                        new CountrySpokenLanguage { CountryID = "NGA", LanguageID = "hau", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 18500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NG/status", NumberOfL2Speakers = 15000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NG/status" } },
                        new CountrySpokenLanguage { CountryID = "NGA", LanguageID = "yor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 18900000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NG/status", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NG/status" } },
                        /*Nicaragua*/
                        new CountrySpokenLanguage { CountryID = "NIC", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Niue*/
                        new CountrySpokenLanguage { CountryID = "NIU", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 78, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NU/status", NumberOfL2Speakers = 2080, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NU/status" } },
                        /*Netherlands*/
                        new CountrySpokenLanguage { CountryID = "NLD", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NLD", LanguageID = "lim", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 700000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Norway*/
                        new CountrySpokenLanguage { CountryID = "NOR", LanguageID = "nor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4640000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NOR", LanguageID = "sme", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Nepal*/
                        new CountrySpokenLanguage { CountryID = "NPL", LanguageID = "npi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 12300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NP/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "NPL", LanguageID = "hin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 77600, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NP/status", NumberOfL2Speakers = 490000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NP/status" } },
                        new CountrySpokenLanguage { CountryID = "NPL", LanguageID = "urd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 692000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NP/status", NumberOfL2Speakers = 22900, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NP/status" } },
                        /*Nauru*/
                        new CountrySpokenLanguage { CountryID = "NRU", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 710, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NR/status", NumberOfL2Speakers = 10700, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NR/status" } },
                        new CountrySpokenLanguage { CountryID = "NRU", LanguageID = "nau", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NR/status", NumberOfL2Speakers = 1000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NR/status" } },
                        /*New Zealand*/
                        new CountrySpokenLanguage { CountryID = "NZL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3820000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NZ/status", NumberOfL2Speakers = 150000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/NZ/status" } },
                        new CountrySpokenLanguage { CountryID = "NZL", LanguageID = "mri", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 148000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/NZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region O
                        /*Oman*/
                        new CountrySpokenLanguage { CountryID = "OMN", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 1263000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/OM/status" } },
                        new CountrySpokenLanguage { CountryID = "OMN", LanguageID = "fas", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 25000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/OM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "OMN", LanguageID = "swa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 22000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/OM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region P
                        /*Pakistan*/
                        new CountrySpokenLanguage { CountryID = "PAK", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 17000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PK/status" } },
                        new CountrySpokenLanguage { CountryID = "PAK", LanguageID = "urd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PK/status", NumberOfL2Speakers = 94000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PK/status" } },
                        new CountrySpokenLanguage { CountryID = "PAK", LanguageID = "snd", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 18500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "PAK", LanguageID = "pus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 23280000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "PAK", LanguageID = "prs", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Panama*/
                        new CountrySpokenLanguage { CountryID = "PAN", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3200000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Pitcairn Islands*/
                        new CountrySpokenLanguage { CountryID = "PCN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 56, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Peru*/
                        new CountrySpokenLanguage { CountryID = "PER", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 26000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "PER", LanguageID = "que", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4400000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Philippines*/
                        new CountrySpokenLanguage { CountryID = "PHL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 20000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PH/status", NumberOfL2Speakers = 40000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PH/status" } },
                        new CountrySpokenLanguage { CountryID = "PHL", LanguageID = "fil", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 45000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PH/status" } },
                        /*Palau*/
                        new CountrySpokenLanguage { CountryID = "PLW", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 500, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PW/status", NumberOfL2Speakers = 18000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PW/status" } },
                        /*Papua New Guinea*/
                        new CountrySpokenLanguage { CountryID = "PNG", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 150000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PG/status", NumberOfL2Speakers = 3000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PG/status" } },
                        /*Poland*/
                        new CountrySpokenLanguage { CountryID = "POL", LanguageID = "pol", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 36600000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "POL", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PL/status", NumberOfL2Speakers = 7330000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PL/status" } },
                        new CountrySpokenLanguage { CountryID = "POL", LanguageID = "bel", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 220000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "POL", LanguageID = "ukr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 150000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "POL", LanguageID = "epo", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PL/status" } },
                        /*Puerto Rico*/
                        new CountrySpokenLanguage { CountryID = "PRI", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PR/status", NumberOfL2Speakers = 1840000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PR/status" } },
                        new CountrySpokenLanguage { CountryID = "PRI", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3900000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*North Korea*/
                        new CountrySpokenLanguage { CountryID = "PRK", LanguageID = "kor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 23300000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/KP/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Portugal*/
                        new CountrySpokenLanguage { CountryID = "PRT", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PT/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Paraguay*/
                        new CountrySpokenLanguage { CountryID = "PRY", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3500000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "PRY", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 166000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "PRY", LanguageID = "grn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4650000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Palestine*/
                        new CountrySpokenLanguage { CountryID = "PSE", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 1600000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PS/status" } },
                        /*French Polynesia*/
                        new CountrySpokenLanguage { CountryID = "PYF", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 178000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PF/status", NumberOfL2Speakers = 74000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/PF/status" } },
                        new CountrySpokenLanguage { CountryID = "PYF", LanguageID = "tah", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 63000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/PF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion 
                    #region Q
                        /*Qatar*/
                        new CountrySpokenLanguage { CountryID = "QAT", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/QA/status", NumberOfL2Speakers = 104000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/QA/status" } },
                    #endregion 
                    #region R
                        /*Reunion*/
                        new CountrySpokenLanguage { CountryID = "REU", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2400, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RE/status", NumberOfL2Speakers = 716000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/RE/status" } },
                        /*Romania*/
                        new CountrySpokenLanguage { CountryID = "ROU", LanguageID = "ron", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 19900000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ROU", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1450000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ROU", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 45100, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RO/status", NumberOfL2Speakers = 1300000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/RO/status" } },
                        new CountrySpokenLanguage { CountryID = "ROU", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2560, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RO/status", NumberOfL2Speakers = 1500000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/RO/status" } },
                        /*Russia*/
                        new CountrySpokenLanguage { CountryID = "RUS", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 137000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Rwanda*/
                        new CountrySpokenLanguage { CountryID = "RWA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 20000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/RW/status" } },
                        new CountrySpokenLanguage { CountryID = "RWA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 2300, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/RW/status" } },
                        new CountrySpokenLanguage { CountryID = "RWA", LanguageID = "kin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6490000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/RW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region S
                        /*Saudi Arabia*/
                        new CountrySpokenLanguage { CountryID = "SAU", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 206000000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SA/status", NumberOfL2Speakers = 246000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/SA/status" } },
                        /*Sudan*/
                        new CountrySpokenLanguage { CountryID = "SDN", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 16833000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SD/status", NumberOfL2Speakers = 29000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/SD/status" } },
                        new CountrySpokenLanguage { CountryID = "SDN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Senegal*/
                        new CountrySpokenLanguage { CountryID = "SEN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 20000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SEN", LanguageID = "wol", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3930000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Singapore*/
                        new CountrySpokenLanguage { CountryID = "SGP", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1100000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SG/status", NumberOfL2Speakers = 2000000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/SG/status" } },
                        new CountrySpokenLanguage { CountryID = "SGP", LanguageID = "msa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 414000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SGP", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1210000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SG/status", NumberOfL2Speakers = 880000, NumberOfL2SpeakersSource = "http://www.ethnologue.com/country/SG/status" } },
                        new CountrySpokenLanguage { CountryID = "SGP", LanguageID = "tam", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 111000, NumberOfL1SpeakersSource = "http://www.ethnologue.com/country/SG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*South Georgia and the South Sandwich Islands*/
                        new CountrySpokenLanguage { CountryID = "SGS", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 30, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/South_Georgia_and_the_South_Sandwich_Islands", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Helena*/
                        new CountrySpokenLanguage { CountryID = "SHN", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4255, NumberOfL1SpeakersSource = "http://unstats.un.org/unsd/demographic/sources/census/2010_PHC/Saint_Helena/Saint_Helena.pdf", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Svalbard and Jan Mayen*/
                        new CountrySpokenLanguage { CountryID = "SJM", LanguageID = "nor", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1645, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Svalbard", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SJM", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 747, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/Languages_of_Svalbard", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Solomon Islands*/
                        new CountrySpokenLanguage { CountryID = "SLB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SB/status", NumberOfL2Speakers = 165000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SB/status" } },
                        /*Sierra Leone*/
                        new CountrySpokenLanguage { CountryID = "SLE", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 500000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SL/status", NumberOfL2Speakers = 4400000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SL/status" } },
                        /*El Salvador*/
                        new CountrySpokenLanguage { CountryID = "SLV", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6700000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SV/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*San Marino*/
                        new CountrySpokenLanguage { CountryID = "SMR", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 25000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Somalia*/
                        new CountrySpokenLanguage { CountryID = "SOM", LanguageID = "som", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6460000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SOM", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SOM", LanguageID = "swa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 184000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Pierre and Miquelon*/
                        new CountrySpokenLanguage { CountryID = "SPM", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5110, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/PM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SPM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 190, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/PM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Serbia*/
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "srp", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6620000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "sqi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1630000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "bul", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 60000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "hrv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 114000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 287000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "ron", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 200000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "slk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 80000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SRB", LanguageID = "bos", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 135000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/RS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*South Sudan*/
                        new CountrySpokenLanguage { CountryID = "SSD", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 800000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SS/status" } },
                        /*Sao Tome and Principe*/
                        new CountrySpokenLanguage { CountryID = "STP", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2580, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ST/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Suriname*/
                        new CountrySpokenLanguage { CountryID = "SUR", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 200000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Slovakia*/
                        new CountrySpokenLanguage { CountryID = "SVK", LanguageID = "slk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4750000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SVK", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 521000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SVK", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5410, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SK/status", NumberOfL2Speakers = 1190000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SK/status" } },
                        /*Slovenia*/
                        new CountrySpokenLanguage { CountryID = "SVN", LanguageID = "slv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1910000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SVN", LanguageID = "hun", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 9240, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SVN", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4010, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SI/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SVN", LanguageID = "hrv", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 155000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SI/status", NumberOfL2Speakers = 1250000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SI/status" } },
                        new CountrySpokenLanguage { CountryID = "SVN", LanguageID = "deu", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1540, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SI/status", NumberOfL2Speakers = 861000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SI/status" } },
                        /*Sweden*/
                        new CountrySpokenLanguage { CountryID = "SWE", LanguageID = "swe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8840000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SWE", LanguageID = "fin", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 201000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Swaziland*/
                        new CountrySpokenLanguage { CountryID = "SWZ", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7500, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SZ/status", NumberOfL2Speakers = 50000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SZ/status" } },
                        new CountrySpokenLanguage { CountryID = "SWZ", LanguageID = "ssw", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 980000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Maarten*/
                        new CountrySpokenLanguage { CountryID = "SXM", LanguageID = "nld", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SX/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SXM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 5000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SX/status", NumberOfL2Speakers = 12000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SX/status" } },
                        new CountrySpokenLanguage { CountryID = "SXM", LanguageID = "pap", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 7000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SX/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Seychelles*/
                        new CountrySpokenLanguage { CountryID = "SYC", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SC/status", NumberOfL2Speakers = 30000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SC/status" } },
                        new CountrySpokenLanguage { CountryID = "SYC", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 980, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SC/status", NumberOfL2Speakers = 72700, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SC/status" } },
                        /*Syria*/
                        new CountrySpokenLanguage { CountryID = "SYR", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 9600000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/SY/status" } },
                        new CountrySpokenLanguage { CountryID = "SYR", LanguageID = "hye", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 320000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "SYR", LanguageID = "kur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 938000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/SY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion 
                    #region T
                        /*Turks and Caicos Islands*/
                        new CountrySpokenLanguage { CountryID = "TCA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 920, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TC/status", NumberOfL2Speakers = 10700, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TC/status" } },
                        /*Chad*/
                        new CountrySpokenLanguage { CountryID = "TCD", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 896000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TD/status" } },
                        new CountrySpokenLanguage { CountryID = "TCD", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TD/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Togo*/
                        new CountrySpokenLanguage { CountryID = "TGO", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "TGO", LanguageID = "ewe", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 862000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Thailand*/
                        new CountrySpokenLanguage { CountryID = "THA", LanguageID = "tha", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 20200000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TH/status", NumberOfL2Speakers = 40000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TH/status" } },
                        /*Tajikistan*/
                        new CountrySpokenLanguage { CountryID = "TJK", LanguageID = "tgk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3340000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TJ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "TJK", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 237000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TJ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "TJK", LanguageID = "uzb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 873000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TJ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Tokelau*/
                        new CountrySpokenLanguage { CountryID = "TKL", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 40, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TK/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Turkmenistan*/
                        new CountrySpokenLanguage { CountryID = "TKM", LanguageID = "tuk", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3430000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "TKM", LanguageID = "uzb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 317000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TM/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*East Timor*/
                        new CountrySpokenLanguage { CountryID = "TLS", LanguageID = "por", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 600, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TL/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Tonga*/
                        new CountrySpokenLanguage { CountryID = "TON", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 30000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TO/status" } },
                        new CountrySpokenLanguage { CountryID = "TON", LanguageID = "ton", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 96300, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TO/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Trinidad and Tobago*/
                        new CountrySpokenLanguage { CountryID = "TTO", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1300000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TT/status", NumberOfL2Speakers = 1300000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TT/status" } },
                        /*Tunisia*/
                        new CountrySpokenLanguage { CountryID = "TUN", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 9000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TN/status" } },
                        new CountrySpokenLanguage { CountryID = "TUN", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 11000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Turkey*/
                        new CountrySpokenLanguage { CountryID = "TUR", LanguageID = "tur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 66500000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TR/status", NumberOfL2Speakers = 350000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TR/status" } },
                        new CountrySpokenLanguage { CountryID = "TUR", LanguageID = "kur", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TR/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Tuvalu*/
                        new CountrySpokenLanguage { CountryID = "TUV", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 800, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TV/status" } },
                        /*Taiwan*/
                        new CountrySpokenLanguage { CountryID = "TWN", LanguageID = "cmn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4320000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TW/status", NumberOfL2Speakers = 15000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TW/status" } },
                        new CountrySpokenLanguage { CountryID = "TWN", LanguageID = "nan", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Tanzania*/
                        new CountrySpokenLanguage { CountryID = "TZA", LanguageID = "swa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 15000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/TZ/status", NumberOfL2Speakers = 32400000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TZ/status" } },
                        new CountrySpokenLanguage { CountryID = "TZA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 4000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/TZ/status" } },
                    #endregion
                    #region U
                        /*Uganda*/
                        new CountrySpokenLanguage { CountryID = "UGA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 2500000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/UG/status" } },
                        new CountrySpokenLanguage { CountryID = "UGA", LanguageID = "swa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2330, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UG/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "UGA", LanguageID = "lug", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4130000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UG/status", NumberOfL2Speakers = 1000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/UG/status" } },
                        /*Ukraine*/
                        new CountrySpokenLanguage { CountryID = "UKR", LanguageID = "ukr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 32000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "UKR", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8330000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "UKR", LanguageID = "ron", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 319000, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*US Minor Outlying Islands*/
                        new CountrySpokenLanguage { CountryID = "UMI", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 300, NumberOfL1SpeakersSource = "http://en.wikipedia.org/wiki/List_of_countries_by_population", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Uruguay*/
                        new CountrySpokenLanguage { CountryID = "URY", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 3450000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UY/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*United States of America*/
                        new CountrySpokenLanguage { CountryID = "USA", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 225000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/US/status", NumberOfL2Speakers = 25600000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/US/status" } },
                        new CountrySpokenLanguage { CountryID = "USA", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 34200000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/US/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "USA", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1300000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/US/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Uzbekistan*/
                        new CountrySpokenLanguage { CountryID = "UZB", LanguageID = "uzb", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 16500000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "UZB", LanguageID = "rus", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1660000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/UZ/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region V
                        /*Vatican City*/
                        new CountrySpokenLanguage { CountryID = "VAT", LanguageID = "ita", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 839, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VA/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Saint Vincent and the Grenadines*/
                        new CountrySpokenLanguage { CountryID = "VCT", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 400, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VC/status", NumberOfL2Speakers = 138000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/VC/status" } },
                        /*Venezuela*/
                        new CountrySpokenLanguage { CountryID = "VEN", LanguageID = "spa", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 26000000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VE/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*British Virgin Islands*/
                        new CountrySpokenLanguage { CountryID = "VGB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VG/status", NumberOfL2Speakers = 19700, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/VG/status" } },
                        /*US Virgin Islands*/
                        new CountrySpokenLanguage { CountryID = "VIR", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 98000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VI/status", NumberOfL2Speakers = 15000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/VI/status" } },
                        /*Vietnam*/
                        new CountrySpokenLanguage { CountryID = "VNM", LanguageID = "vie", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 65800000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VN/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Vanautu*/
                        new CountrySpokenLanguage { CountryID = "VUT", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1900, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "VUT", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6300, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "VUT", LanguageID = "bis", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/VU/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region W
                        /*Wallis and Futuna*/
                        new CountrySpokenLanguage { CountryID = "WLF", LanguageID = "fra", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 120, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/WF/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        /*Samoa*/
                        new CountrySpokenLanguage { CountryID = "WSM", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 200, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/WS/status", NumberOfL2Speakers = 93000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/WS/status" } },
                        new CountrySpokenLanguage { CountryID = "WSM", LanguageID = "smo", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 199000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/WS/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region X
                        /*Kosovo*/
                        new CountrySpokenLanguage { CountryID = "XKX", LanguageID = "sqi", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1500000, NumberOfL1SpeakersSource = "http://beinkosovo.com/en/languages-spoken-in-kosovo", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "XKX", LanguageID = "srp", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 100000, NumberOfL1SpeakersSource = "http://beinkosovo.com/en/languages-spoken-in-kosovo", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                    #endregion
                    #region Y
                        /*Yemen*/
                        new CountrySpokenLanguage { CountryID = "YEM", LanguageID = "ara", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 0, NumberOfL1SpeakersSource = "", NumberOfL2Speakers = 14630000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/YE/status" } },
                    #endregion
                    #region Z
                        /*South Africa*/
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "afr", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 6860000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 10300000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4890000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 11000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "nbl", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1090000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 1400000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "ssw", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1300000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 2400000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "tso", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 2280000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 3400000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "tsn", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 4070000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 7700000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "ven", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1210000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 1700000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "xho", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 8150000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 11000000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        new CountrySpokenLanguage { CountryID = "ZAF", LanguageID = "zul", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 11600000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZA/status", NumberOfL2Speakers = 15700000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZA/status" } },
                        /*Zambia*/
                        new CountrySpokenLanguage { CountryID = "ZMB", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 110000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZM/status", NumberOfL2Speakers = 1800000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZM/status" } },
                        /*Zimbabwe*/
                        new CountrySpokenLanguage { CountryID = "ZWE", LanguageID = "eng", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 250000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZW/status", NumberOfL2Speakers = 5300000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZW/status" } },
                        new CountrySpokenLanguage { CountryID = "ZWE", LanguageID = "nbl", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 1550000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZW/status", NumberOfL2Speakers = 0, NumberOfL2SpeakersSource = "" } },
                        new CountrySpokenLanguage { CountryID = "ZWE", LanguageID = "sna", NumberOfSpeakers = new NumberOfSpeakers { NumberOfL1Speakers = 10700000, NumberOfL1SpeakersSource = "https://www.ethnologue.com/country/ZW/status", NumberOfL2Speakers = 1800000, NumberOfL2SpeakersSource = "https://www.ethnologue.com/country/ZW/status" } },
                    #endregion
                };
            #endregion
            countrySpokenLanguages.ForEach(p => context.CountrySpokenLanguages.Add(p));
            context.SaveChanges();
        }
    }
}