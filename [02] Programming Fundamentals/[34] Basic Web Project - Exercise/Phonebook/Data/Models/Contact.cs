namespace Phonebook.Data.Models
{
    public class Contact
    {
        public Contact(int num, string photoUrl)
        {
            this.Number = num;
            this.PhotoURL = photoUrl;
        }

        public int Number { get; set; }
        public string PhotoURL { get; set; }
    }
}
