using Entities;

namespace UseCases
{
    public class ToDoListManager
    {
        private readonly IToDoItemRepository repository;
        public ToDoListManager(IToDoItemRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<ToDoItem> getTodoItems()
        {
            return repository.GetTodoItems();
        }

        public void AddTodoItem(ToDoItem item)
        {
            repository.AddTodoItem(item);
        }

        public void MarkComplete(int id)
        {
            var item = repository.GetById(id);
            if (item != null)
            {
                item.IsCompleted = true;
                
            }
            repository.Update(item);

        }
    }
}
