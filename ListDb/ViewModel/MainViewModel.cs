using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ListDb.Model;
using System.Collections.Generic;

namespace ListDb.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region ItemCategoryView
        public ListContext ctx = new ListContext();

        public RelayCommand LoadItemCategoryView { get; set; }
        private List<ItemCategory> itemCategories;
        private ItemCategory selectedItemCategory;

        public List<ItemCategory> ItemCategories
        {
            get
            {
                return itemCategories;
            }

            set
            {
                itemCategories = value;
                RaisePropertyChanged("ItemCategories");
            }
        }

        public ItemCategory SelectedItemCategory
        {
            get
            {
                return selectedItemCategory;
            }

            set
            {
                selectedItemCategory = value;
                RaisePropertyChanged("SelectedItemCategory");
            }
        }

        private void GetItemCategories()
        {
            var Query = from a in ctx.ItemCategories
                        select a;
            //    using (var ctx = new ListDBEntities())
            //    {
            //        ItemCategory cat = new ItemCategory() { CategoryName = "Test", CategoryDescription = "desc" };

            //        ctx.ItemCategories.Add(cat);
            //        ctx.SaveChanges();
            //        MessageBox.Show(cat.CategoryName + "has been added");
        }

        private void _LoadItemCategoryView()
        {

            var win = new ItemCategoryView();
            win.Show();

            App.Current.MainWindow.Close();
            App.Current.MainWindow = win;
        }

#endregion


        public RelayCommand LoadMainWindow { get; set; }


        private void ReturnMainView()
        {
            var win = new MainWindow();
            win.Show();

            App.Current.MainWindow.Close();
            App.Current.MainWindow = win;
        }

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        { 
            LoadItemCategoryView = new RelayCommand(_LoadItemCategoryView);
            LoadMainWindow = new RelayCommand(ReturnMainView);
        }
#endregion
    }
}