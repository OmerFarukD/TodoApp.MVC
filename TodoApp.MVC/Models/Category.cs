namespace TodoApp.MVC.Models;
public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<ToDo> Todos { get; set; }
}
