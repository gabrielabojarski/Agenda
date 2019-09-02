using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public IList<Compromisso> Compromissos { get; set; }


    }
}
