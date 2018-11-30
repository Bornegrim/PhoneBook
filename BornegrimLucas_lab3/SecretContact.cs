//LUCAS BORNEGRIM
//2017-11-22
//Objektorienterad programmering I

namespace BornegrimLucas_Lab3
{
    /// <summary>
    /// Klassen SecretContact ärver från Contact och hanterar hur hemliga kontakter ska skrivas ut.
    /// </summary>
    class SecretContact : Contact
    {
        /// <summary>
        /// Konstruktorn till klassen om gör samma sak som konstruktorn i Contact.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="l"></param>
        /// <param name="p"></param>
        public SecretContact(string f, string l, string p)
            :base(f, l, p)
        { }
        /// <summary>
        /// Overridar den vanliga ToString-metoden så vi får den att skriva ut det som en hemlig kontakt.
        /// </summary>
        /// <returns>returnerar i detta format: Efternamn, Förnamn, XXX-XXX XX XX</returns>
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName + ", " + "XXX-XXX XX XX";
        }
    }
}
