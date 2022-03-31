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
using EquipmentRent3ISP9_7.HelperClass;

namespace EquipmentRent3ISP9_7.Windows
{
    /// <summary>
    /// Логика взаимодействия для EquipmentList.xaml
    /// </summary>
    public partial class EquipmentList : Window
    {
        public EquipmentList()
        {
            InitializeComponent();
            LV_Equipment.ItemsSource = HelperCl.Context.Product.ToList();
        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow();
            addEquipmentWindow.ShowDialog();
        }

        private void LV_Equipment_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void LV_Equipment_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
