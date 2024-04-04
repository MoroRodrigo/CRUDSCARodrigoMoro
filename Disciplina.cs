using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSCARodrigoMoro
{
    public class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int Creditos { get; set; }
        public string Descricao { get; set; }

        // Métodos CRUD
        public static void Criar(Disciplina disciplina)
        {
            // Implementação para criar uma nova disciplina no banco de dados
        }

        public static Disciplina Ler(string codigo)
        {
            // Implementação para ler uma disciplina do banco de dados
            return null;
        }

        public void Atualizar()
        {
            // Implementação para atualizar uma disciplina no banco de dados
        }

        public void Deletar()
        {
            // Implementação para deletar uma disciplina do banco de dados
        }
    }

}
