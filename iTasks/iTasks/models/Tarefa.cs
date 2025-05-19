using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.models
{
    internal class Tarefa
    {
        public int Id { get; set; }
        // IdGestor

        // IdProgramador


        public int OrdemExecucao { get; set;}
        public string Descricao { get; set; }
        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim { get; set; }
        // idTipoTarefa

        public string StoryPoints { get; set; }
        public DateTime DataRealInicio { get; set; }
        public DateTime DataRealFim { get; set; }
        public DateTime DataCriacao { get; set;}
        public string EstadoAtual {  get; set; }

    }
}
