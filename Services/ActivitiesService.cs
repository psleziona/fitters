using Fitters.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Services
{
    public class ActivitiesService
    {
        List<Activity> activities;
        public List<Activity> Activities { get => activities; }
        
        public ActivitiesService() 
        {
            activities = FileUtility.ReadDataFromFile<List<Activity>>("/activities") ?? new List<Activity>();
        }
        

        public void AddActivity(Activity activity)
        {
            activities.Add(activity);
            FileUtility.WriteDateToFile(activities, "/activities");
        }
    }
}
