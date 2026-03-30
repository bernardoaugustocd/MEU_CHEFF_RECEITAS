using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMeuChef
{
    public class CredenciaisFuncionarios
    {
        public int funcionario {  get; set; }
        public int senha { get; set; }
        public int cargo { get; set; }

        public CredenciaisFuncionarios(int NomeFuncionario, string SenhaFuncionario)
        {
            funcionario = NomeFuncionario;
            senha = SenhaFuncionario;
            cargo = Funcao;
        }

        public bool CredenciaisAjudante()
        {
            return funcionario == "Fábio" && senha == "123" && cargo == "Ajudante";
        }
    }
}
