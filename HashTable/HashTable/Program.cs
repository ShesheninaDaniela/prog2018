using System;
using System.Collections.Generic;

namespace Program
{
    public class HashTable
    {
        public List<int> hashList;
        public List<List<Information>> hashTable;

        public class Information

        {
            public object Key { get; set; }
            public object Value { get; set; }
        }
         /// Поиск индекса хэш-кода
       
        public int SearchHashIndex(int hashCode)
        {
            return hashList.IndexOf(hashCode);
        }
        /// Создание новой хэш-таблицы
        
        public void CreateNewHashTable(int size)
        {
            hashTable = new List<List<Information>>(size);
            hashList = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                hashTable.Add(new List<Information>());
            }
        }

       
        /// Получение хэш-кода ключа
        
        public int GetHashCode(object key)
        {
            return key.GetHashCode();
        }
     
        /// Добавление новой пары в хэш-таблицу
      
        public void PutPair(object key, object value)
        {
            var hashCode = GetHashCode(key);
            var hashIndex = SearchHashIndex(hashCode);
            var keyValue = new Information
              { Key = key, Value = value };
            if (hashIndex == -1 && hashTable.Count > hashList.Count)
            {
                hashList.Add(hashCode);
                hashIndex = SearchHashIndex(hashCode);
                hashTable[hashIndex].Add(keyValue);
                return;
            }
            foreach (var pair in hashTable[hashIndex])
            {
                if (pair.Key.Equals(key))
                    pair.Value = value;
            }
        }

         /// Получение значения по ключу
        
        public object GetValueByKey(object key)
        {
            var index = SearchHashIndex(GetHashCode(key));
            if (index == -1)
                return null;
            foreach (var pair in hashTable[index])
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }
            return null;
        }

        public static void Main()
        {
           
        }
    }
}


