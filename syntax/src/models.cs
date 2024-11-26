// Alocada no NameSpace Global - portanto, posso usa-la em qualquer lugar do projeto
public class ToDo
{
   static int count_Id = 0;
   public int Id;
   public string Title;
   public string Content;
   public bool Status;
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
