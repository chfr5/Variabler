namespace Person
{
    public class Person
    {
        public string ForNavn { get; set; }
        private string efterNavn;

        public string Efternavn
        {
            get { return efterNavn; }
            set {
                efterNavn = "ikke udfyldt korrekt";
                if (value.Length >= 3) efterNavn = value;
            }
        }

        public string FuldtNavn()
        {
            return ForNavn + " " + Efternavn;
        }

    }
}
