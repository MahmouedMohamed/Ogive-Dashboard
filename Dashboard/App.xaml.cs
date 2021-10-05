using Dashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Dashboard.MainWindow window = new MainWindow();
            AchievementViewModel VM = new AchievementViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
