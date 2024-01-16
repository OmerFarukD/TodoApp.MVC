using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.MVC.Models;
using TodoApp.MVC.Repository;

namespace TodoApp.MVC.Controllers;

public class ToDoController : Controller
{
    private readonly DbBaglantisi _db;
    private readonly IMapper _mapper;

    public ToDoController(DbBaglantisi db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(ToDo toDo)
    {
        _db.Todos.Add(toDo);
        _db.SaveChanges();

        return RedirectToAction("Index","Home");
    }


    [HttpGet]
    public ActionResult GetAll()
    {
        List<ToDo> data = _db.Todos
            .Include(x=> x.Category)
            .ToList();

        //List<TodoResponseDto> responses =
        //    _mapper.Map<List<TodoResponseDto>>(data);

        List<TodoResponseDto> responses = new List<TodoResponseDto>();
        foreach ( var todo in data)
        {
            TodoResponseDto todoResponseDto = new TodoResponseDto()
            {
                CategoryName = todo.Category.Name,
                Date = todo.Date,
                Description = todo.Description,
                Name = todo.Name,
                Id = todo.Id
            };
            responses.Add(todoResponseDto);
        }

        return View(responses);

    }
}
