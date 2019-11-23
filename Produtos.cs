public class Produto
{
    public Produto(int Id, string Descricao, string Categoria)
    {
        this.id = Id;
        this.descricao = Descricao;
        this.Categoria = Categoria;
                
    }
       private int Id { get; private set; }
       private string Descricao { get; private set; }
       private string Categoria {get ; private set;} 
       private string CodigoOriginal {get ; private set;} 


}
