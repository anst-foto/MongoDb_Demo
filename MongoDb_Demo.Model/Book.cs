using System.Collections.ObjectModel;
using MongoDB.Bson;

namespace MongoDb_Demo.Model;

public class Book : NotifyModel
{
    private ObjectId _id;
    public ObjectId Id
    {
        get => _id; 
        set => SetField(ref _id, value);
    }

    private string _title;
    public required string Title
    {
        get => _title; 
        set => SetField(ref _title, value);
    }
    
    public required ObservableCollection<Person> Authors { get; set; }
    
    private string _annotation;
    public required string Annotation
    {
        get => _annotation; 
        set => SetField(ref _annotation, value);
    }
    
    private Publication _publication;
    public required Publication Publication
    {
        get => _publication;
        set => SetField(ref _publication, value);
    }
}