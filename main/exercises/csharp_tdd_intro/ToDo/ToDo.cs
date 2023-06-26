using System;

namespace ToDo
{
    public class ToDoItem
    {
        private List<string> tasks;
        
       public ToDoItem()
       {
        tasks = new List<string>();
        
       }
       public void AddTask(string task)
       {
        tasks.Add(task);

       }
       public string[] GetTasks()
       {
        return tasks.ToArray();

       }
    }
}
