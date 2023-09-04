using System.Data;

namespace WebApplicationExemplo01.Models
{
    public class Turma
    {
        public int Id {get;set;}
        public string Nome  {get;set;}
        public DateTime DataAbertura {get;set;}
        public  DateTime DataFechamento {get;set;}
        public string Turno { get;set; }
        public ICollection<Alunos>? Alunos { get;set;}
    }
}
