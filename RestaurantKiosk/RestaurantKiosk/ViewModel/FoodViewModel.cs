using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RestaurantKiosk.ViewModel
{
    public partial class FoodViewModel
    {
        public ObservableCollection<Food> Items { get; }

        public FoodViewModel()
        {
            Items = new ObservableCollection<Food>();
#if false
            LoadDefaultData();
#else
            LoadDummyDefaultData();
#endif
        }

        public void LoadDefaultData()
        {
            //TODO: 
        }

        public void Adds(List<Food> foods)
        {
            foreach(Food food in foods)
            {
                Add(food);
            }
        }

        public void Add(Food food)
        {
            Items.Add(food);
        }
    }
}
