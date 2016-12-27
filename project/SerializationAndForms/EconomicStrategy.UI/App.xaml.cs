using EconomicStrategy.Model;
using EconomicStrategy.UI.ViewModel;
using EconomicStrategy.UI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EconomicStrategy.UI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        private MainWindow window;

        public App()
        {
            var model = MainWindowDataModel.Load();
            window = new MainWindow(model) { DataContext = model };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                window.getModel().Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }

    }
}
