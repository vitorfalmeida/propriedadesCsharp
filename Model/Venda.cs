namespace propriedadesCsharp.Model
{
  public class Venda
    {
        
        public Venda(int id, String produto, double preco, DateTime data){
            Id = id;
            Produto = produto;
            Preco = preco;
            Data = data;
        }
        public int Id { get; set; }
        public String Produto { get; set; }
        public double Preco { get; set; }
        public DateTime Data { get; set; }
    }
}