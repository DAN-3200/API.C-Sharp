using System.Collections.Generic;
using System;

namespace CRUD // Semelhante ao Package do Golang
{
   public static class SystemToDo
   {
      public static List<ToDo> DB = new List<ToDo>();
      public static void RunApp()
      {
         Console.Clear();
         do
         {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Read");
            Console.WriteLine("3 - Update");
            Console.WriteLine("4 - Delete");
            Console.Write("Choose the option: ");
            var choose = Console.ReadLine();

            switch (Convert.ToInt16(choose))
            {
               case 1:
                  Console.Clear();
                  CreateToDo();
                  break;
               case 2:
                  Console.Clear();
                  ReadToDo();
                  break;
               case 3:
                  Console.Clear();
                  UpdateTodo();
                  break;
               case 4:
                  Console.Clear();
                  DeleteToDo();
                  break;
            }
            if (Convert.ToInt16(choose) == -1)
            {
               break;
            }
         } while (true);
      }
      static void CreateToDo()
      {
         Console.Write("Title: ");
         string Title = Console.ReadLine() ?? "";
         Console.Write("Content: ");
         string Content = Console.ReadLine() ?? "";
         DB.Add(new ToDo(Title, Content));
      }
      static void ReadToDo()
      {
         if (DB.Count == 0)
         {
            Console.WriteLine("Não tem NADA no Banco");
            return;
         }

         Console.WriteLine("A - ToDo específico");
         Console.WriteLine("B - All ToDos");
         Console.Write("Choose the option: ");
         string choose = Console.ReadLine() ?? "";

         if (choose.ToUpper() == "A")
         {
            Console.Write("Read ToDo by ID: ");
            int nID = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            foreach (var item in DB)
            {
               if (item.Id == nID)
               {
                  System.Console.WriteLine(item);
               }
            }
            Console.WriteLine(DB);
         }
         else if (choose.ToUpper() == "B")
         {
            Console.Clear();
            foreach (var item in DB)
            {
               Console.WriteLine(item.ToString());
            }
         }

      }
      static void UpdateTodo()
      {
         Console.Write("Update the ToDo by ID: ");
         int nID = Convert.ToInt16(Console.ReadLine());
         foreach (var item in DB)
         {
            if (item.Id == nID)
            {
               Console.Write("new Title: ");
               item.Title = Console.ReadLine() ?? "";
               Console.Write("new Content: ");
               item.Content = Console.ReadLine() ?? "";
               Console.Write("new Status: ");
               item.Status = Convert.ToBoolean(Console.ReadLine());
            }
         }
      }
      static void DeleteToDo()
      {
         Console.Write("Delete the ToDo by ID: ");
         int nID = Convert.ToInt16(Console.ReadLine());
         for (int i = 0; i < DB.Count; i++)
         {
            if (DB[i].Id == nID)
            {
               DB.RemoveAt(i);
            }
         }
      }
   }
}