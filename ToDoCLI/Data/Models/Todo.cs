﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoCLI.Data.Context;

namespace ToDoCLI.Models
{
    [Table("Todos")]
    public class Todo: BaseClass
    {
        public string Title { get; set; }

        public List<Todo> Complete(Todo todo, TodoContext context)
        {
            context.Todos.Remove(todo);
            context.SaveChanges();
            return context.Todos.ToList<Todo>();
        }

        public void Add(Todo todo, TodoContext context)
        {
             context.Todos.Add(todo);
             context.SaveChanges();
        }
    }
}
