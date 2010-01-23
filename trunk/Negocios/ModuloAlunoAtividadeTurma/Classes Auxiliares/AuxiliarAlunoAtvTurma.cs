using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloAlunoAtividadeTurma.Classes_Auxiliares
{
    public class AuxiliarAlunoAtvTurma
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string turma;

        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
        private string mensagem;

        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }
    }
}
