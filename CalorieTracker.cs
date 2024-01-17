using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class CalorieTracker
    {
        private User currentUser;
        private List<Product> products;
        private List<Activity> activities;

        public User User { get => currentUser; }
        public List<Product> Products { get => products; }
        public List<Activity> Activities { get => activities; }

        public void ShowCalendar(Calendar userCalendar)
        {

        }

        public void SetActiveUser(User user)
        {
            currentUser = user;
        }

        public void LoadProducts()
        {
            products = FileUtility.ReadDataFromFile<List<Product>>("/products") ?? new List<Product>();
        }

        public void LoadActivites() 
        { 
            activities = FileUtility.ReadDataFromFile<List<Activity>>("/activities") ?? new List<Activity>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            FileUtility.WriteDateToFile(products, "/products");
        }

        public void AddActivity(Activity activity)
        {
            activities.Add(activity);
            FileUtility.WriteDateToFile(activities, "/activities");
        }

        public Day GetDayInformation(DateTime date)
        {
            return null;
        }
    }
}
