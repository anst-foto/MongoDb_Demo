using System.Collections.ObjectModel;
using MongoDb_Demo.DbLib;
using MongoDb_Demo.Model;

namespace MongoDb_Demo.WPF.WindowModels;

public class MainWindowModel : BaseWindowModel
{
    public ObservableCollection<Book> Books { get; set; }

    private Book _selectedBook;
    public Book SelectedBook
    {
        get => _selectedBook; 
        set => SetField(ref _selectedBook, value);
    }

    public MainWindowModel()
    {
        var db_context = new DbContext();
        Books = new ObservableCollection<Book>(db_context.GetAll());
    }
}