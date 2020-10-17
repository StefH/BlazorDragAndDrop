using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDragAndDrop.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDragAndDrop.Pages
{
    public partial class Index : ComponentBase
    {
        public List<TodoItem> MyToDoList = new List<TodoItem>()
        {
            new TodoItem { Title = "1 Drag this item" },
            new TodoItem { Title = "2 Add another item" },
            new TodoItem { Title = "3 Remove this item" }
        };

        private string newTodo;

        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                MyToDoList.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }

        private void Save()
        {
            Console.WriteLine(string.Join(", ", MyToDoList.Select(x => $"'{x.Title}'")));
        }

        public void ItemDropped(TodoItem item)
        {
            Console.WriteLine("ItemDropped = '{0}'", item.Title);

            StateHasChanged();
        }
    }
}