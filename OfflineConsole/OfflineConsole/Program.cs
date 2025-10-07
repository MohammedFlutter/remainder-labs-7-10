

using OfflineConsole;

var ToDoService =  ToDoOfflineService.GetInstanse();
var toDos = ToDoService.GetAll();
toDos.ForEach(td => Console.WriteLine(td));
var newToDo = new ToDo { Title = "New Taskddddddddd", Body = "This is a new task." };

Console.WriteLine("ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
ToDoService.Add(newToDo);

//var oldTodo = toDos[0];
//oldTodo.Title = "Updated Task";
//oldTodo.Body = "This task has been updated.";
//ToDoService.Update(oldTodo);

//ToDoService.Delete(toDos[1].Id);


toDos = ToDoService.GetAll();
toDos.ForEach(td => Console.WriteLine(td));
Console.WriteLine("ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
         
ToDoService.SaveChanges();
toDos = ToDoService.GetAll();
toDos.ForEach(td => Console.WriteLine(td));
         




