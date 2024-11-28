namespace ServicesToDoAPI
{
   public class ToDoAPI
   {
      // DataBase Temporária
      public static List<ToDo> DB = new List<ToDo>();

      static public int CreateToDo(ToDo info)
      {
         DB.Add(info);

         return 200;
      }

      static public dynamic ReadToDo()
      {
         return Results.Json(DB);
      }
      static public int UpdateToDo(ToDo info, int Id)
      {
         for (int i = 0; i < DB.Count; i++)
         {
            if (DB[i].Id == Id)
            {
               DB[i].Title = info.Title;
               DB[i].Content = info.Content;
               DB[i].Status = info.Status;
            }
         }

         return 200;
      }
      static public int DeleteToDo(int Id)
      {
         for (int i = 0; i < DB.Count; i++)
         {
            if (DB[i].Id == Id)
            {
               DB.RemoveAt(i);
            }
         }
         return 200;
      }
   }
}