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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaPessoas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ModelAviacao ctx = new ModelAviacao();
            //var pessoa = ctx.Pessoas.First();
            Contatos wp = new Contatos();
            //wp.Pessoa = pessoa;
            wp.Show();
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
    }
}
