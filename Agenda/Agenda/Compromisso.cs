using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Compromisso
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Local { get; set; }

        public DateTime DataDeInicio { get; set; }

        public DateTime DataDeTermino { get; set; }

        public IList<Pessoa> Participantes { get; set; }
    }
}
