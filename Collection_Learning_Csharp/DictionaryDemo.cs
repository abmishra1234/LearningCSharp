using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class DictionaryDemo
    {
        Dictionary<string, string> mDict;

        public DictionaryDemo()
        {
            mDict = new Dictionary<string, string>();
        }

        void PrintDictionary()
        {
            foreach(KeyValuePair<string, string> entry in mDict)
            {
                Console.WriteLine("The Pair element : {0} , {1}", entry.Key, entry.Value);
            }
        }

        public void Demo()
        {
            mDict[".bmp"] = "Bitmap File Type";
            mDict[".png"] = "PNG File Type";
            mDict[".html"] = "HTML File Type";
            mDict[".doc"] = "Word Document File Type";
            mDict[".txt"] = "Text File Type";

            // Check, how it is behaving for the existing key in dictionary
            //mDict.Add(".txt", "Text File Type"); // you will get Exception here for an item with same key already exist

            Console.WriteLine(mDict.Count);

            var result = mDict.TryAdd(".txt", "Text File Type");
            Console.WriteLine("Add failed because of existed of .txt = {0}", result); //  False because the Key is already exist

            // Check that the key is present in dictionary?
            result = mDict.ContainsKey(".html");
            Console.WriteLine("The key exist : {0}", result); // True

            result = mDict.ContainsKey(".htmt");
            Console.WriteLine("The key exist : {0}", result); // False

            // Check does Value already present in Dictionary?
            result = mDict.ContainsValue("PNG File Type");
            Console.WriteLine("The Value exist : {0}", result); // True

            // Check does Value already present in Dictionary?
            result = mDict.ContainsValue("PNG File");
            Console.WriteLine("The Value exist : {0}", result); // False

            // Let's see the Remove method
            mDict.Remove(".html");
            result = mDict.ContainsKey(".html");
            Console.WriteLine("The key exist : {0}", result); // False

            PrintDictionary();

        }

    }
}
