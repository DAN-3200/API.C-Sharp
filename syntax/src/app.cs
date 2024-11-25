namespace CRUD // Semelhante ao Package do Golang
{
   public static class SystemToDo
   {

      public static void RunApp()
      {
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
                  CreateToDo();
                  break;
               case 2:
                  ReadToDo();
                  break;
               case 3:
                  UpdateTodo();
                  break;
               case 4:
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
         Console.WriteLine("método [Create] do SystemToDo");
      }
      static void ReadToDo()
      {
         Console.WriteLine("método [Read] do SystemToDo");
      }
      static void UpdateTodo()
      {
         Console.WriteLine("método [Update] do SystemToDo");
      }
      static void DeleteToDo()
      {
         Console.WriteLine("metodo [Delete] do SystemToDo");
      }

   }
}