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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        ппEntities1 context;
        public Window5(ппEntities1 context, ДПО newДПО)
        {
            InitializeComponent();
            this.context = context;
            Cmbобласть_проф_деятельности.ItemsSource = context.область_проф_деятельности.ToList();
            Cmbгр_специальностей.ItemsSource = context.гр_специальностей.ToList();
            CmbУровень_образования1.ItemsSource = context.Уровень_образования.ToList();
            this.DataContext = newДПО;

        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
