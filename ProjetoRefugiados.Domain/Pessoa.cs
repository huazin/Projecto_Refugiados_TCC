using System;

namespace ProjetoRefugiados.Domain
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
