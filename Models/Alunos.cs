namespace WebApplicationExemplo01.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Turma turma {  get; set; } 
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
