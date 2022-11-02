using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    internal class MyCustomArray
    {
        public int length { get; private set; }
        private int capacity;
        public int[] array { get; private set; }

        public void AddValue(int value)
        {
            if (length + 1 > capacity)
            {
                int[] newArray = new int[Convert.ToInt32(capacity * 1.5)];
                for (int i = 0; i < length; i++) newArray[i] = array[i];
                array = newArray;
            }
            array[length] = value;
            length++;
        }

        public void Output()
        {
            for (int i = 0; i < length; i++) Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void RemoveElementAt(int index)
        {
            for (int i = index; i < length - 1; i++)
                array[i] = array[i + 1];
            array[length-1] = 0;
            length--;
        }

        public int FindFirstElement(int value)
        {
            for (int i = 0; i < length; i++)
                if (array[i] == value) return i;
            return -1;
        }

        public int RemoveElement(int value)
        {
            int index = FindFirstElement(value);
            if (index != -1)
            {
                this.RemoveElementAt(index);
                return 0;
            }
            else return -1;
        }
        public MyCustomArray(int length)
        {
            this.capacity = length;
            this.array = new int[length];
            this.length = 0;
        }

    }
}
