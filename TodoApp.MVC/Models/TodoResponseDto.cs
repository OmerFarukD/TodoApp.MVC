﻿namespace TodoApp.MVC.Models;

public class TodoResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public DateTime Date { get; set; }

    public string CategoryName { get; set; }

}
