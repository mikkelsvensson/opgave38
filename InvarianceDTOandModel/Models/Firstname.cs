using System.Text.RegularExpressions;
 namespace ValidateTheNameModelBinding.Models{
    public class Firstname
    {

        // kan man gøre noget smart ift. at fornavn og firstname har den samme validering
        private String firstname;
        public Firstname(String firstname){
            isfirstnameValid(firstname);
            this.firstname = firstname;
        }

        public String GetValue() {
            return firstname; // kompleks type, men immutable
        }

        private void isfirstnameValid(string firstname){
            if (firstname.Length < 2){
                throw new ArgumentException("firstname must be longer than 2");
            }
            
            if (firstname.Length > 20){
                throw new ArgumentException("firstname cannot be longer than 20");
            }
            var pattern = @"^[a-zA-Z]+$";
            var regexMatch = Regex.IsMatch(firstname,pattern);
            if (!regexMatch){
                throw new ArgumentException("firstname must only contain charactors from a-z");
            }
        }
    }

}