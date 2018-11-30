//LUCAS BORNEGRIM
//2017-11-22
//Objektorienterad programmering I

using System.Collections.Generic;

namespace BornegrimLucas_Lab3
{
    /// <summary>
    /// Klassen PhoneBook som hanterar tillägg, borttagande och hämtning av kontaktlistan.
    /// </summary>
    class PhoneBook
    {

        private List<IContact> contactList;
        /// <summary>
        /// Konstruktorn till klassen.
        /// </summary>
        public PhoneBook()
        {
            contactList = new List<IContact>();
        }
        /// <summary>
        /// Metoden tar emot en string array (Med kontakt information) och en bool för att avgöra om det ska läggas en 
        /// vanliga kontakt eller en "Secret Contact".
        /// </summary>
        /// <param name="a"></param>
        /// <param name="check"></param>
        public void Add(string[] a, bool check)
        {
            if (check == false)
            {
                Contact newContact = new Contact(a[0], a[1], a[2]);
                contactList.Add(newContact);
            }
            else
            {
                SecretContact newSecretContact = new SecretContact(a[0], a[1], a[2]);
                contactList.Add(newSecretContact);
            }   
        }
        /// <summary>
        /// Metoden tar bort en kontakt ur listan med hjälp av indexet som man matar in i metoden.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            contactList.RemoveAt(index);
        }
        /// <summary>
        /// Metoden returnerar hela kontaktlistan.
        /// </summary>
        /// <returns>Returnerar en lista av typen IContact</returns>
        public List<IContact> GetAll()
        {
            return contactList;
        }
    }
}
