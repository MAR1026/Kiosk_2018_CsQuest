using RestaurantKiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RestaurantKiosk.ViewModel
{
    public partial class FoodViewModel
    {
        private void LoadDummyDefaultData()
        {
            List<Food> foods = new List<Food>();

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "돈까스김밥",
                Quantity = 0,
                Price = 3000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/PorkCutletGIMBAP.jpg", UriKind.Relative)),
                Notice = "주문 즉시 튀겨진 생등심 돈까스로 바삭한 식감의 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "떡갈비김밥",
                Quantity = 0,
                Price = 3000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/GrilledPattyGIMBAP.jpg", UriKind.Relative)),
                Notice = "떡갈비와 신선한 야채의 담백한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "새우튀김김밥",
                Quantity = 0,
                Price = 3000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/FiredShrimpGIMBAP.jpg", UriKind.Relative)),
                Notice = "주문 즉시 튀겨진 새우와 참깨 소스의 고소한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "치즈김밥",
                Quantity = 0,
                Price = 2500,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/CheeseGIMBAP.jpg", UriKind.Relative)),
                Notice = "체다치즈의 부드럽고 신선한 야채가 가득한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "참치김밥",
                Quantity = 0,
                Price = 2500,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/TunaGIMBAP.jpg", UriKind.Relative)),
                Notice = "참치와 깻잎을 넣어 고소한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "킹소세지김밥",
                Quantity = 0,
                Price = 2500,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/KingSausageGIMBAP.jpg", UriKind.Relative)),
                Notice = "매콤한 킹소세지와 야채가 가득한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "소불고기김밥",
                Quantity = 0,
                Price = 2500,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/PorkCutletGIMBAP.jpg", UriKind.Relative)),
                Notice = "불향 가득한 불고기와 야채가 어우러진 화끈한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "유부우동",
                Quantity = 0,
                Price = 4000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/FiredTofuUdon.jpg", UriKind.Relative)),
                Notice = "유부와 진한 우동의 개운한 맛의 우동"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "냉모밀",
                Quantity = 0,
                Price = 6000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/Soba.jpg", UriKind.Relative)),
                Notice = "메밀면에 시원한 장국육수의 담백한 냉모밀"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "냉면",
                Quantity = 0,
                Price = 6000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/ColdNoodle.jpg", UriKind.Relative)),
                Notice = "진한 동치미육수와 쫄깃한 면발의 냉면"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "돈가스 김치볶음밥",
                Quantity = 0,
                Price = 6500,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/PorkCutletKimchiFriedRice.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스와 김치볶음밥 두가지를 맛볼 수 있는 세트"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = new BitmapImage(new Uri("Assets/Image/GIMBAP/katsudon.jpg", UriKind.Relative)),
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });
        }
    }
}
