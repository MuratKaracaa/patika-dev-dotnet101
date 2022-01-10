namespace project_1_phone_book
{
    public class Contact : IContact
    {
        private string name;
        private string lastName;
        private int phoneNumber;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        public Contact(string name, string lastName, int phoneNumber)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }
    }
}