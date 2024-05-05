using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ToDoList.Models;

public class TaskCategoryViewModel
{
    public List<Task>? Tasks { get; set; }
    public SelectList? Categories { get; set; }
    public string? TaskCategory {  get; set; }
    public string? SearchString { get; set; }
}
