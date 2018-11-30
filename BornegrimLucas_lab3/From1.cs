//LUCAS BORNEGRIM
//2017-11-22
//Objektorienterad programmering I

using System;
using System.Windows.Forms;

namespace BornegrimLucas_Lab3
{
    /// <summary>
    /// Klassen Form1, Här hanteras all in- och output till och från användaren.
    /// </summary>
    public partial class From1 : Form
    {
        PhoneBook currentPhoneBook;
        /// <summary>
        /// Konstruktorn.
        /// </summary>
        public From1()
        {
            InitializeComponent();

            currentPhoneBook = new PhoneBook();
        }
        /// <summary>
        /// Metod till save-knappen. Metoden ovandlar det användaren skriver in till en string array som är delad på alla ",".
        /// Metoden skapar även en bool som är = IsSecretcheckbox.
        /// Om metoden är 3 lång så använder den sig av Add-metoden i phonebook.
        /// Annars skickar den tillbaka ett meddelande som säger att man måste skriva in i rätt format.
        /// Sedan uppdaterar den listan med refresh-metoden. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            string input = txtNewContact.Text;
            
            string[] inputsplitted = input.Split(new [] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            bool check = chkIsSecret.Checked;

            if ( inputsplitted.Length == 3 )
            {
                currentPhoneBook.Add(inputsplitted, check);
            }
            else
            {
                MessageBox.Show("You've to write it in this format: Firstname, Lastname, Phonenumber.");
            }
            refresh();
        }

        /// <summary>
        /// Metod till listboxen. Metoden typomvandlar de valda objektet i listan till en instans av typen IContact.
        /// Och sätter firstname, lastname och phonenumber till de 3 fälten, från den valda kontakten.
        /// Samtidigt om den försäkrar sig om att man klickar på något i listan med en if-sats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex >= 0)
            {
                IContact currentContact = (Contact)lstContacts.SelectedItem;

                txtFirstName.Text = currentContact.FirstName;
                txtLastName.Text = currentContact.LastName;
                txtPhoneNumber.Text = currentContact.PhoneNumber;
            }
        }

        /// <summary>
        /// Metod till deletknappen, metoden tar den index man har markerat i listboxen och skickar den till remove metoden i PhoneBook. 
        /// Samtidigt som den försäkrar sig om att man har markerat något. 
        /// Den uppdaterar även hela listan och de 3 fälten. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            int index = lstContacts.SelectedIndex;
            if (index <= -1)
            {
                MessageBox.Show("You've to select an item to delete!");
            }
            else
            {
                currentPhoneBook.Remove(index);
                refresh();
            }

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }

        /// <summary>
        /// Metod som uppdaterar listboxen genom att först rensa den och sedan fylla den igen med GetAll-metoden.
        /// </summary>
        private void refresh()
        {
            lstContacts.Items.Clear();
            foreach (Contact c in currentPhoneBook.GetAll())
            {
                lstContacts.Items.Add(c);
            }
        }
    }
}
