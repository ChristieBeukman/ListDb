using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ListDb.ViewModel;

namespace ListDb.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand LoadItemCategoryView { get; set; }

        public RelayCommand LoadMainWindow { get; set; }

        private void loadCategoryView()
        {
            
            var win = new ItemCategoryView();
            win.Show();

            App.Current.MainWindow.Close();
            App.Current.MainWindow = win;
        }

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
            //if (IsInDesignMode)
            //{
            //    // Code runs in Blend --> create design time data.
            //}
            //else
            //{
            //    // Code runs "for real"

            //}

            LoadItemCategoryView = new RelayCommand(loadCategoryView);
            LoadMainWindow = new RelayCommand(ReturnMainView);
        }
#endregion
    }
}