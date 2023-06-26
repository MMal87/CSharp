using NUnit.Framework;

using ToDo;//This should be the NAMESPACE for the file to be imported

namespace ToDo.Tests
{
  public class ToDoTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }
    [Test]
    public void Initialize_Empty_List()
    {
    ToDoItem todo = new ToDoItem();
    string[] expected = new string[0];
    string[] actual = todo.GetTasks();
    Assert.AreEqual(expected, actual);
    }

    [Test]
    public void add_one_task()
    {
        ToDoItem todo = new ToDoItem();
        string[] expected = new string [] { "walk dog" };
        todo.AddTask("walk dog");
        string[] actual = todo.GetTasks();
        Assert.AreEqual(expected, actual);
    }

  }
}
