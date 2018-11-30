//LUCAS BORNEGRIM
//2017-11-22
//Objektorienterad programmering I

namespace BornegrimLucas_Lab3
{
    /// <summary>
    /// Ett interface för kontakter. 
    /// </summary>
    public interface IContact
    {
        string FirstName { get; }
        string LastName { get; }
        string PhoneNumber { get; }
    }
}
