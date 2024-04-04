using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSCARodrigoMoro
{
    public class DisciplinaController
    {
        private DisciplinaView view;

        public DisciplinaController()
        {
            view = new DisciplinaView();
        }

        public void CriarDisciplina(Disciplina disciplina)
        {
            Disciplina.Criar(disciplina);
            view.MostrarMensagem("Disciplina criada com sucesso!");
        }

        public void LerDisciplina(string codigo)
        {
            Disciplina disciplina = Disciplina.Ler(codigo);
            if (disciplina != null)
            {
                view.MostrarDisciplina(disciplina);
            }
            else
            {
                view.MostrarMensagem("Disciplina não encontrada!");
            }
        }

        public void AtualizarDisciplina(Disciplina disciplina)
        {
            disciplina.Atualizar();
            view.MostrarMensagem("Disciplina atualizada com sucesso!");
        }

        public void DeletarDisciplina(Disciplina disciplina)
        {
            disciplina.Deletar();
            view.MostrarMensagem("Disciplina deletada com sucesso!");
        }
    }

}
