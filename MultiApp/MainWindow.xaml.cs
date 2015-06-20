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

namespace MultiApp
{

    public class CabTabDado
    {
        public string Titulo { get; set; }

        public object TabItemObj { get; set; }

    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RemoverTab(sender);
        }

        private void CriarTab(string titulo, object conteudo)
        {
            var tabNovo = new TabItem
            {
                HeaderTemplate = (DataTemplate)this.Resources["itemTab"]
            };

            var cabecalho = new CabTabDado
            {
                Titulo = titulo,
                TabItemObj = tabNovo
            };

            tabNovo.Header = cabecalho;

            tabNovo.Content = conteudo;

            tabControl.Items.Add(tabNovo);

            tabNovo.Focus();
        }

        private void RemoverTab(object sender)
        {
            var btn = sender as Button;

            var tab = btn.Tag as TabItem;

            tabControl.Items.Remove(tab);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            CriarTab("TELA 1", new UserControl1());
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            CriarTab("TELA 2", new UserControl1());
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            CriarTab("TELA 3", new UserControl1());

        }
    }
}
