namespace MongoDb_Demo.Model;

public class Person : NotifyModel
{
    private string _firstName;
    public required string FirstName
    {
        get => _firstName; 
        set => SetField(ref _firstName, value);
    }
    
    private string _lastName;
    public required string LastName
    {
        get => _lastName;
        set => SetField(ref _lastName, value);
    }
}