//LUCAS BORNEGRIM
//2017-11-22
//Objektorienterad programmering I

namespace BornegrimLucas_Lab3
{
    /// <summary>
    /// Klassen Contact som ärver av interfacet IContact.
    /// Deklarerar 3 variabler som går att hämta utifrån men inte ändra utifrån. 
    /// </summary>
    class Contact : IContact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        /// <summary>
        /// Konstruktorn till klassen. Tar emot 3 input (förnamn, efternamn och telefonnummer)
        /// </summary>
        /// <param name="f"></param>
        /// <param name="l"></param>
        /// <param name="p"></param>
        public Contact(string f, string l, string p)
        {
            this.FirstName = f;
            this.LastName = l;
            this.PhoneNumber = p;
        }
        /// <summary>
        /// Overridar den vanliga ToString-metoden så vi får den att skriva ut rätt.
        /// </summary>
        /// <returns>returnerar i detta format: Efternamn, Förnamn, Telefonnummer</returns>
        public override string ToString()
        {
            return this.LastName +", " + this.FirstName + ", " + this.PhoneNumber;
        }
    }
}
