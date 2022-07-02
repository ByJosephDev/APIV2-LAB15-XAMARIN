using System.Collections.Generic;
using System.Threading.Tasks;
using TodoRestV2.Model;

namespace TodoRestV2.Data
{
    public interface IRestService
    {

        Task<List<TodoItem>> RefreshDataAsync();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);

    }
}

