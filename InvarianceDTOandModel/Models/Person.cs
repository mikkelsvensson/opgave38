namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private Firstname firstName;
        private Lastname lastName;

        public Person(Firstname firstName, Lastname lastName)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
        }
    }
}
