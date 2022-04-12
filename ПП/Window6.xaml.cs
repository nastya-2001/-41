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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        ппEntities1 context;
        public Window6(ппEntities1 context, Обучающиеся newОбучающиеся)
        {
            InitializeComponent();
            this.context = context;
            CmbПол1.ItemsSource = context.Пол.ToList();
            CmbФорма_обучения1.ItemsSource = context.Форма_обучения.ToList();
            CmbФинансирования1.ItemsSource = context.Финансирования.ToList();
            CmbФорма_получения_образования__на_момент_прекращения_образ_отношений.ItemsSource = context.Форма_получения_образования__на_момент_прекращения_образ_отношений.ToList();
            this.DataContext = newОбучающиеся;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
