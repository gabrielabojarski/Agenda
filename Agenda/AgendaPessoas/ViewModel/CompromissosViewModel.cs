using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Agenda;
using System.Threading.Tasks;
namespace AgendaPessoas.ViewModel
{
    public class CompromissosViewModel
    {
        public ObservableCollection<Compromisso> Compromissos
        { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.CompromissoSelecionado != null;
            }
        }

        public Compromisso CompromissoSelecionado { get; set; }
        private ModelAgenda context { get; set; }
        public CompromissosViewModel()
        {
            context = new ModelAgenda();
            this.Compromissos =
                new ObservableCollection<Compromisso>(
                context.Compromissos.ToList());
            this.CompromissoSelecionado = context
                .Compromissos.FirstOrDefault();
        }

        public void Remover()
        {
            if (this.CompromissoSelecionado.Id != 0)
            {
                this.context.Compromissos.Remove(
                    this.CompromissoSelecionado);
            }
            this.Compromissos.Remove(this.CompromissoSelecionado);
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Adicionar()
        {
            Compromisso c = new Compromisso();
            this.Compromissos.Add(c);
            this.context.Compromissos.Add(c);
            this.CompromissoSelecionado = c;
        }
    }
}
