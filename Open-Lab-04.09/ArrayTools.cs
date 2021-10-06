using System;
using System.Collections;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            ArrayList arrayList = new ArrayList();

            foreach (string word in strings)
            {
                if (!arrayList.Contains(word))
                {
                    arrayList.Add(word);
                }
            }
            strings = arrayList.ToArray(typeof(string)) as string[];
            return strings;
        }
    }
}
