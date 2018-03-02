using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoMvc.Models;
using TodoMvc.Services;

namespace TodoMvc.Services
{
    public class FakeToDoItemService : ITodoItemService
    {
        public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<TodoItem> items = new[]{
                new TodoItem{
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },

                new TodoItem{
                    Title = "Build Awsome apps",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                }
            };
            return Task.FromResult(items);
        }
    }
}