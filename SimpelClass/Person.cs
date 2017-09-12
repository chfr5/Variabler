using System;

namespace SimpelClass
{
    class Person
    {
        public string forNavn;
        public string efterNavn;
        public int fødselsår;
        /// <summary>
        /// FuldtNavn
        /// </summary>
        /// <returns>fornavn efternavn</returns>
        public string FuldtNavn()
        {
            return $"{forNavn} {efterNavn}";
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            this.forNavn = "";
            this.efterNavn = "";

        }
        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="efternavn">ovesættes til store bogstaver</param>
        /// <param name="fornavn">ovesættes til store bogstaver</param>
        /// <param name="fødtår">format YYYY</param>
        public Person(string efternavn, string fornavn, int fødtår)
        {
            this.efterNavn = efternavn.ToUpper();
            this.forNavn = fornavn.ToUpper();
            this.fødselsår = fødtår;

        }
        /// <summary>
        /// gæt alder årstal minus årstal
        /// </summary>
        /// <returns></returns>
        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.fødselsår;
        }
    }
}
