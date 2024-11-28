// Alocada no NameSpace Global - portanto, posso usa-la em qualquer lugar do projeto
public class ToDo
{
   static int count_Id = 0;
   public int Id { get; }
   public string Title { get; set; }
   public string Content { get; set; }
   public bool Status { get; set; }
   public DateTime _Date { get; private set; }

   // Atributo data
   public ToDo(string Title, string Content)
   {
      count_Id++;
      this.Id = count_Id;
      this.Title = Title;
      this.Content = Content;
      this.Status = false;
      this._Date = DateTime.Now;
   }

   override public string ToString()
   {
      return $"Id: {this.Id}/ Title: {this.Title}/ Content: {this.Content}/ Status: {this.Status}/ DateTime: {this._Date}";
   }
}
