using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AgendaPessoas
{
    /// <summary>
    /// Lógica interna para Contatos.xaml
    /// </summary>
    public partial class Contatos : Window
    {
       
    

        public ViewModel.PessoasViewModel PessoasViewModel { get; set; }


        public Contatos()
        {
            InitializeComponent();
            this.PessoasViewModel = new ViewModel.PessoasViewModel();
            this.DataContext = this;
        }

      

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }
        private void Ok1Button_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }
        private void Ok2Button_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Remover();
        }

        private void AdicionarButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Adicionar();
        }
        private void SalvarButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
