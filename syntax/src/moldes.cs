public class ToDo
{  
   static int count_Id = 0;
   public int Id;
   public string Title;
   public string Content;
   public bool Status;
   public ToDo(string Title, string Content)
   {  
      count_Id++;
      this.Id = count_Id;
      this.Title = Title;
      this.Content = Content;
      this.Status = false;
   }
}
