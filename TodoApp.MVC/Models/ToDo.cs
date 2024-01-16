namespace TodoApp.MVC.Models;

public class ToDo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public DateTime Date { get; set; }

    public Category Category { get; set; }
    //Foreign key
    public int CategoryId { get; set; }

}
