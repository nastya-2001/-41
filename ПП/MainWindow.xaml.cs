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

namespace ПП
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ппEntities1 context;
        //
        public string SearchText { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            context = new ппEntities1();
            ShowTable();

        }
        private void ShowTable()
        {
            DataGridДПО.ItemsSource = context.ДПО.ToList();
        }

        private void BtnAdeteData_Click(object sender, RoutedEventArgs e)
        {
            var NewДПО = new ДПО();
            context.ДПО.Add(NewДПО);
            var EditWindow = new Window5(context, NewДПО);
            EditWindow.ShowDialog();
            ShowTable();

        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            var currentДПО = DataGridДПО.SelectedItem as ДПО;
            if (currentДПО == null)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.ДПО.Remove(currentДПО);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void Btnser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btnsercli_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btnsercli_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Btnstyd_Click(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window2();
            EditWindo.ShowDialog();
        }

        private void Btndoc_Click(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window3();
            EditWindo.ShowDialog();
        }

        private void Btnrep_Click(object sender, RoutedEventArgs e)
        {
            var EditWindo = new Window4();
            EditWindo.ShowDialog();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentДПО = BtnEdit.DataContext as ДПО;
            var EditWindow = new Window5(context, currentДПО);
            EditWindow.ShowDialog();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxSearch.Text))
            {
                DataGridДПО.ItemsSource = context.ДПО.ToList();
            }
            else
            {
                DataGridДПО.ItemsSource = context.ДПО.Where(dpo =>
             dpo.Фамилия_указанная_в_дипломе.ToLower().Contains( TextBoxSearch.Text.ToLower())).ToList();
            }

            


        }
    }
}
