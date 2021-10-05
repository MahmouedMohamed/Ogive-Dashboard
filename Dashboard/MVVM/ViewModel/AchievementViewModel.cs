using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Dashboard.MVVM.Models;
using System.Net.Http;
namespace Dashboard.MVVM.ViewModel
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    class AchievementViewModel
    {
        private IList<Achievement> achievements;
        static async Task<Product> GetProductAsync(string path)
        {
            HttpClient client = new HttpClient();
            Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }
        public AchievementViewModel()
        {
            achievements = new List<Achievement>
            {
                new Achievement{Number1 = 1},
                new Achievement{Number1 = 12},
            };
        }
        public IList<Achievement> Achievements
        {
            get { return achievements; }
            set { achievements = value; }
        }
        private ICommand updater;
        public ICommand UpdateCommand
        {
            get
            {
                if (updater == null)
                    updater = new Updater();
                return updater;
            }
            set
            {
                updater = value;
            }
        }
        private class Updater : ICommand
        {
            #region ICommand Members 

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                
            }
            #endregion

        }
    }
}
