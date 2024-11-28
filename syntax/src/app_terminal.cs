using System.Collections.Generic;
using System;

// CRUD CLI 
namespace CRUD // Semelhante ao Package do Golang
{
   public static class SystemToDo
   {
      // variável para armazenar as informações
      public static List<ToDo> DB = new List<ToDo>();

      // Função para rodar o sistema
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
            Console.Clear();
            try
            {
               switch (Convert.ToInt16(choose))
               {
                  case 1:
                     CreateToDo();
                     break;
                  case 2:
                     ReadToDo();
                     break;
                  case 3:
                     UpdateToDo();
                     break;
                  case 4:
                     DeleteToDo();
                     break;
               }
               if (Convert.ToInt16(choose) == -1)
               {
                  break;
               }
            }
            catch
            {
               Console.WriteLine("type choose invalid");
            }

         } while (true);
      }

      // Métodos de operação
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
      static void UpdateToDo()
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