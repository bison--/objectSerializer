using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializer {
    public static class helper {
        public static T[] Redim<T>(T[] arr, bool preserved) {
            int arrLength = arr.Length;
            T[] arrRedimed = new T[arrLength + 1];
            if (preserved) {
                for (int i = 0; i < arrLength; i++) {
                    arrRedimed[i] = arr[i];
                }
            }
            return arrRedimed;
        }
    }

    public class item {
        public string itemName = "unknown";
        public int quantity = 1;
    }

    public class testObject {
        public string name = "NOBODY";
        public int age = 23;
        public enum genderEnum {
            male,
            female,
            cyborg,
            other
        }
        public genderEnum gender = genderEnum.other;
        public item[] itemAr = new item[0];
        public List<item> items = new List<item>();
        public void addItem(string name, int quantity) {
            item itm = new item();
            itm.itemName = name;
            itm.quantity = quantity;
            items.Add(itm);

            itemAr = helper.Redim<item>(itemAr, true);
            itemAr[itemAr.Length - 1] = itm;
        }

        // no dictionarys for you :*(
        //public Dictionary<int, string> clothes = new Dictionary<int, string>();
    }
}
