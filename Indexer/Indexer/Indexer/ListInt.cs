using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Indexer
{
    internal class ListInt
    {
        private int[] _arr;

        
        public int this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                return _arr[_arr.Length - 1];
            }
            set { if (index < _arr.Length) { _arr[index] = value; } }
        }
        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(int length)
        {
            _arr = new int[length];
            
        }
        public int[] Add(int num)
        {
            
            Array.Resize(ref _arr,_arr.Length+1);
            _arr[_arr.Length-1] = num;

           return _arr;
        }
        public void AddRangge(params int[] nums)
        {
            if (_arr is null)
            {
                _arr = nums;

            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Array.Resize(ref _arr, _arr.Length + 1);
                    _arr[_arr.Length - 1] = nums[i];
                }

            }
          
        }
        public bool Contains(int num)
        {
            foreach (var item in _arr)
            {
                if(item== num)
                {
                    return true;
                }
               
            }
            return false;
        }
        public void Sum()
        {
            int sum = 0;
            foreach (var item in _arr)
            {
                sum += item;
            }
        }
        public int[] Remove(int num)
        {
            
            foreach (var item in _arr)
            {
                if (item!=num)
                {
                    Array.Resize(ref _arr,_arr.Length+1);
                    _arr[_arr.Length] = item;

                }

            }

            
            return _arr;
        }
        public void Removerange(params int[] nums)
        {
            if (_arr is null)
            {
                _arr = nums;

            }

            else
            {
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if (_arr[i] != nums[i])
                      Array.Resize(ref _arr, _arr.Length + 1);
                    _arr[_arr.Length - 1] = nums[i];
                }
            }
        }

        public override string ToString()
        {
            return String.Join(", ", _arr); 
        }









    }
}
 