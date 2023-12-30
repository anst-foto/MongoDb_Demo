namespace MongoDb_Demo.Model;

public class Publication : NotifyModel
{
    private string _publisherHouse;
    public required string PublisherHouse
    {
        get => _publisherHouse;
        set => SetField(ref _publisherHouse, value);
    }

    private int _year;
    public required int Year
    {
        get => _year; 
        set => SetField(ref _year, value);
    }
}