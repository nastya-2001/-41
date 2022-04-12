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

namespace ПП
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ппEntities1 context;
        public Window2()
        {
            InitializeComponent();
            context = new ппEntities1();
            ShowTable();
        }
        private void  ShowTable()
        {
            DataGridОбучающиеся.ItemsSource = context.Обучающиеся.ToList();  
        }
        private void BtnAdeteData_Click(object sender, RoutedEventArgs e)
        {
            var NewОбучающиеся = new Обучающиеся();
            context.Обучающиеся.Add(NewОбучающиеся);
            var EditWindow = new Window6(context, NewОбучающиеся);
            EditWindow.ShowDialog();
            ShowTable();
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
            var currentОбучающиеся = DataGridОбучающиеся.SelectedItem as Обучающиеся;
            if (currentОбучающиеся == null)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Обучающиеся.Remove(currentОбучающиеся);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentОбучающиеся = BtnEdit.DataContext as Обучающиеся;
            var EditWindow = new Window6(context, currentОбучающиеся);
            EditWindow.ShowDialog();
        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cmbform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cmbform.SelectedIndex == 0)
            {
                ShowTable();
            }
            if (Cmbform.SelectedIndex == 1)
            {
                DataGridОбучающиеся.ItemsSource = context.Обучающиеся.Where(x => x.Форма_обучения.Contains("1")).ToList();
            }
            if (Cmbform.SelectedIndex == 2)
            {
                DataGridОбучающиеся.ItemsSource = context.Обучающиеся.Where(x => x.Форма_обучения.Contains("2")).ToList();

            }
            if (Cmbform.SelectedIndex == 3)
            {
                DataGridОбучающиеся.ItemsSource = context.Обучающиеся.Where(x => x.Форма_обучения.Contains("3")).ToList();

            }
        }
    }
}
