﻿using RestaurantKiosk.Model;
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
        public List<Food> LoadDummyDefaultData()
        {
            List<Food> foods = new List<Food>();

            foods.Add(new Food
            {
                Category = CategoryType.DRINK,
                Name = "코카콜라",
                Quantity = 0,
                Price = 1000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/Coke.jpg",
                Notice = "언제 어디서나 이 맛, 이 느낌! 코카콜라!",
                Barcode = "8801094017200"
            });

            foods.Add(new Food
            {
                Category = CategoryType.DRINK,
                Name = "펩시",
                Quantity = 0,
                Price = 1000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/Pepsi.jpg",
                Notice = "젊은 열정 그대로! 펩시!",
                Barcode = "8801056070809"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "돈까스김밥",
                Quantity = 0,
                Price = 3000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/PorkCutletGIMBAP.jpg",
                Notice = "주문 즉시 튀겨진 생등심 돈까스로 바삭한 식감의 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "떡갈비김밥",
                Quantity = 0,
                Price = 3000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/GrilledPattyGIMBAP.jpg",
                Notice = "떡갈비와 신선한 야채의 담백한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "새우튀김김밥",
                Quantity = 0,
                Price = 3000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/FiredShrimpGIMBAP.jpg",
                Notice = "주문 즉시 튀겨진 새우와 참깨 소스의 고소한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "치즈김밥",
                Quantity = 0,
                Price = 2500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/CheeseGIMBAP.jpg",
                Notice = "체다치즈의 부드럽고 신선한 야채가 가득한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "참치김밥",
                Quantity = 0,
                Price = 2500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/TunaGIMBAP.jpg",
                Notice = "참치와 깻잎을 넣어 고소한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "킹소세지김밥",
                Quantity = 0,
                Price = 2500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/KingSausageGIMBAP.jpg",
                Notice = "매콤한 킹소세지와 야채가 가득한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.GIMBAP,
                Name = "소불고기김밥",
                Quantity = 0,
                Price = 2500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/PorkCutletGIMBAP.jpg",
                Notice = "불향 가득한 불고기와 야채가 어우러진 화끈한 김밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "유부우동",
                Quantity = 0,
                Price = 4000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/FiredTofuUdon.jpg",
                Notice = "유부와 진한 우동의 개운한 맛의 우동"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "냉모밀",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/Soba.jpg",
                Notice = "메밀면에 시원한 장국육수의 담백한 냉모밀"
            });

            foods.Add(new Food
            {
                Category = CategoryType.NOODLE,
                Name = "냉면",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/ColdNoodle.jpg",
                Notice = "진한 동치미육수와 쫄깃한 면발의 냉면"
            });
            
            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "가츠동",
                Quantity = 0,
                Price = 5000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/katsudon.jpg",
                Notice = "생등심 돈까스를 이용하여 만든 부드러운 맛의 가츠돈"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "돈가스 김치볶음밥",
                Quantity = 0,
                Price = 6500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/PorkCutletKimchiFriedRice.jpg",
                Notice = "생등심 돈까스와 김치볶음밥 두가지를 맛볼 수 있는 세트"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "오므라이스",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/OmeletRice.jpg",
                Notice = "신선한 야채와 계란 지단이 어우러진 담백한 오므라이스"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "김치볶음밥",
                Quantity = 0,
                Price = 4000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/KimchiFriedRice.jpg",
                Notice = "김치의 감칠맛과 고소한 맛이 더한 김치볶음밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "직화낙지덮밥",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/FriedOctopusRice.jpg",
                Notice = "불맛이 가득한 낙지와 매콤한 특제소스가 일품인 덮밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "직화소고기덮밥",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/FriedBeefRice.jpg",
                Notice = "불맛이 가득한 소고기와 매콤한 특제소스가 일품인 덮밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "직화닭가슴살덮밥",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/ChickenBreastRice.jpg",
                Notice = "불맛이 가득한 닭가슴살과 매콤한 특제소스가 일품인 덮밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.RICE,
                Name = "직화제육덮밥",
                Quantity = 0,
                Price = 6000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/SpicyPorkRice.jpg",
                Notice = "불맛이 가득한 제육과 매콤한 특제소스가 일품인 덮밥"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "순두부찌개",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/SoftTofuStew.jpg",
                Notice = "바지락과 야채와 순두부의 개운한 맛의 찌개"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "된장찌개",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/BeanPasteStew.jpg",
                Notice = "신선한 야채와 바지락이 잘 어우러진 깔끔한 찌개"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "김치찌개",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/KimchiStew.jpg",
                Notice = "신선한 야채와 돼지고기가 잘 어우러진 담백한 찌개"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "부대찌개",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/SausageStew.jpg",
                Notice = "모듬햄과 라면사리가 어우러진 맛있는 부대찌개"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "육개장",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/SpicyBeefStew.jpg",
                Notice = "소고기와 고사리가 잘 어우러진 얼큰한 육개장"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "뚝배기불고기",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/HotPotBulgogi.jpg",
                Notice = "소불고기와 당면사리 신선한 야채의 담백한 뚝배기불고기"
            });

            foods.Add(new Food
            {
                Category = CategoryType.STEW,
                Name = "한우사골 떡만두국",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/TteokDumplingStew.jpg",
                Notice = "한우 사골의 담백한 육수와 쌀떡,만두가 가득한 만두국"
            });

            foods.Add(new Food
            {
                Category = CategoryType.SNACK,
                Name = "갈비만두",
                Quantity = 0,
                Price = 4500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/RipDumpling.jpg",
                Notice = "갈비가 가득 들어있는 갈비만두"
            });

            foods.Add(new Food
            {
                Category = CategoryType.SNACK,
                Name = "왕만두",
                Quantity = 0,
                Price = 4500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/BigDumpling.jpg",
                Notice = "왕만두"
            });

            foods.Add(new Food
            {
                Category = CategoryType.SNACK,
                Name = "치즈라볶이",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/CheeseRabboki.jpg",
                Notice = "떡볶이와 라면사리 위에 치즈가 가득! 매콤함과 치즈의 고소한맛을 느낄수 있는 메뉴"
            });

            foods.Add(new Food
            {
                Category = CategoryType.SNACK,
                Name = "라볶이",
                Quantity = 0,
                Price = 5000,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/Rabboki.jpg",
                Notice = "떡볶이와 라면사리에 매콤한 특제소스가 더해진 메뉴"
            });

            foods.Add(new Food
            {
                Category = CategoryType.SNACK,
                Name = "치즈돈가스",
                Quantity = 0,
                Price = 5500,
                Image = "pack://application:,,,/RestaurantKiosk;component/Resources/CheesePorkCutlet.jpg",
                Notice = "모짜렐라 치즈를 가득 머금고 있는 치즈돈까스"
            });

            Adds(foods);

            return foods;
        }
    }
}
