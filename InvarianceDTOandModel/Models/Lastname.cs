using System.Text.RegularExpressions;
public class Lastname
{

    // kan man gøre noget smart ift. at fornavn og lastname har den samme validering
    private String lastname;
    public Lastname(String lastname){
        islastnameValid(lastname);
        this.lastname = lastname;
    }

    public String GetValue() {
        return lastname; // kompleks type
    }

    private void islastnameValid(string lastname){
        if (lastname.Length < 2){
            throw new ArgumentException("lastname must be longer than 2");
        }
        
        if (lastname.Length > 20){
            throw new ArgumentException("lastname cannot be longer than 20");
        }
        var pattern = @"^[a-zA-Z]+$";
        var regexMatch = Regex.IsMatch(lastname,pattern);
        if (!regexMatch){
            throw new ArgumentException("lastname must only contain charactors from a-z");
        }
    }
}