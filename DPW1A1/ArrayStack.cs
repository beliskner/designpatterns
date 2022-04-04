using System;

namespace DPW1A1

{
    public class ArrayStack : IStack
    {
        private int[] array;
        private int index;
        public int Count { 
            get
            {
                return index;
            }
        }

        public bool IsEmpty { 
            get
            {
                return index == 0;
            }
        }

        public bool Contains(int value)
        {
            foreach (int i in array)
            {
                if (i == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int Pop()
        {
            if(index > 0)
            {
                return array[index--];
            }
            throw new Exception();
        }

        public void Push(int value)
        {
            array[index] = value;
            index++;
        }

        public ArrayStack(int arrayLength)
        {
            this.array = new int[arrayLength];
            this.index = 0;
        }
    }
}
