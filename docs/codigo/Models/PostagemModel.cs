namespace BlogPessoal.Models
{
    public class PostagemModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime DataPostagem { get; set; } = DateTime.Now;
    }
}
