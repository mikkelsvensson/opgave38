using ValidateTheNameModelBinding.Models;
using Xunit.Sdk;
namespace opgave36.test;
public class UnitTest1
{
    [Fact]
    public void Does_Not_Throw_Exception_When_Name_Length_Is_Valid()
    {
        Exception thrownException = Record.Exception(() => new Firstname("Mikkel"));

        Assert.Null(thrownException);
    }
    [Fact]
    public void Does_Throw__Argument_Length_ExceptionException_When_Name_Length_Is_Less_Than_Two_Characters_Shorts()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=> new Firstname("i"));
    }
    [Fact]
    public void Does_Not_Throw_Exception_When_Characters_In_Name_Is_Valid()
    {
        Exception thrownException = Record.Exception(() => new Firstname("Mikkel"));

        Assert.Null(thrownException);
    }
    [Fact]
    public void Does_Throw_Argument_Exception_When_Name_Contains_Illegal_Characters(){

        Assert.Throws<ArgumentException>(()=> new Firstname("m1kkel"));
    }
    [Fact]
    public void Does_Throw_Null_Argument_Exception_When_Name_String_Is_Null(){
        Assert.Throws<ArgumentNullException>(()=> new Firstname(null));
    }
}