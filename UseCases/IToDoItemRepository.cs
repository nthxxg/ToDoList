using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
    public interface IToDoItemRepository
    {
        void AddTodoItem(ToDoItem item);
        ToDoItem GetById(int id);
        IEnumerable<ToDoItem> GetTodoItems();
        void Update(object item);
    }
}
