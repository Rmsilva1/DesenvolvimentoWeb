using System.Collections.Generic;

namespace TodoMvc.Models.View
{

    public class ToDoViewModel
    {

        public IEnumerable<TodoItem> Items { get; set; }
    }
}