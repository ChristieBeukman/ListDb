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
using ListDb.EntityModel;

namespace ListDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    using (var ctx = new ListDBEntities())
        //    {
        //        ItemCategory cat = new ItemCategory() { CategoryName = "Test", CategoryDescription = "desc" };

        //        ctx.ItemCategories.Add(cat);
        //        ctx.SaveChanges();
        //        MessageBox.Show(cat.CategoryName + "has been added");
        //    }
        //}
    }
}
