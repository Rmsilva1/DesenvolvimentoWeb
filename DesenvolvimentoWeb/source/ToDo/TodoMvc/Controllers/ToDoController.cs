using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoMvc.Services;
using TodoMvc.Models.View;

namespace TodoMvc.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ITodoItemService _todoItemsService;

        public ToDoController(ITodoItemService todoItemsService)
        {
            _todoItemsService = todoItemsService;
        }

        public async Task<IActionResult> Index()
        {
            // Get todo items
            var todoItems = await _todoItemsService.GetIncompleteItemsAsync();
            //put into model
            var viewModel = new ToDoViewModel
            {
                Items = todoItems
            };
            //pass the view to model
            return View(viewModel);
        }
    }
}