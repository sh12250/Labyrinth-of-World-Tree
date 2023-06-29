using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthOfWorldTree
{
    public class Item
    {
        protected List<ItemBase> Items { get; private set; }

        public Item()
        {
            Items = new List<ItemBase>();

            for (int i = 0; i < 22; i++)
            {
                Items.Add(new ItemBase());
            }

            Items[0].SetItemStatus(100, "큰 나대", 50, 14, 0, 0, 0, 1, 0, 0);
            Items[1].SetItemStatus(101, "쇼트 나대", 70, 21, 0, 0, 0, 0, 0, 0);
            Items[2].SetItemStatus(102, "코피스", 200, 28, 0, 0, 0, 0, 0, 0);
            Items[3].SetItemStatus(103, "시리우스의 요검", 320, 33, 0, 0, 0, 0, 0, 0);
            Items[4].SetItemStatus(104, "스크라마색스", 350, 37, 0, 0, 0, 0, 0, 0);
            Items[5].SetItemStatus(105, "커틀러스", 720, 44, 0, 0, 0, 0, 0, 0);
            Items[6].SetItemStatus(200, "서머 트위드", 70, 0, 7, 0, 0, 0, 0, 0);
            Items[7].SetItemStatus(201, "스케일 저킹", 170, 0, 9, 0, 0, 0, 0, 0);
            Items[8].SetItemStatus(202, "페더 아머", 250, 0, 16, 0, 0, 0, 0, 0);
            Items[9].SetItemStatus(203, "리퍼 블레이저", 330, 0, 18, 0, 0, 0, 0, 0);
            Items[10].SetItemStatus(204, "스파이크드 래더", 440, 0, 21, 0, 0, 0, 0, 0);
            Items[11].SetItemStatus(205, "가드 베스트", 480, 0, 24, 0, 0, 0, 0, 0);
            Items[12].SetItemStatus(206, "로리카 스콰마타", 550, 0, 28, 0, 0, 0, 0, 0);
            Items[13].SetItemStatus(300, "힘의 반지", 200, 0, 0, 3, 0, 0, 0, 0);
            Items[14].SetItemStatus(301, "기술의 부적", 200, 0, 0, 0, 3, 0, 0, 0);
            Items[15].SetItemStatus(302, "체력의 팔찌", 200, 0, 0, 0, 0, 3, 0, 0);
            Items[16].SetItemStatus(303, "지혜의 피어스", 200, 0, 0, 0, 0, 0, 3, 0);
            Items[17].SetItemStatus(304, "운의 네클리스", 200, 0, 0, 0, 0, 0, 0, 3);
            Items[18].SetItemStatus(400, "작고 붉은 비늘", 6, 0, 0, 0, 0, 0, 0, 0);
            Items[19].SetItemStatus(401, "미끈미끈한 다리", 8, 0, 0, 0, 0, 0, 0, 0);
            Items[20].SetItemStatus(402, "푸르른 가시관", 10, 0, 0, 0, 0, 0, 0, 0);
            Items[21].SetItemStatus(403, "스라소니의 흑조", 20, 0, 0, 0, 0, 0, 0, 0);
        }
    }
}
