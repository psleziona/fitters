using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitters.Models;
using Fitters.Services;

namespace Fitters
{
    public class CalorieTracker
    {
        private ProductsService productsService;
        private ActivitiesService activitiesService;
        private UserService userService;

        public ProductsService ProductsService { get => productsService; }
        public ActivitiesService ActivitiesService { get => activitiesService; }
        public UserService UserService { get => userService; }


        public CalorieTracker() {
            productsService = new ProductsService();
            activitiesService = new ActivitiesService();
            userService = new UserService();
        }

        public void AuthUser(User user)
        {
            userService.AuthUser(user);
        }
    }
}
