using System;

namespace Key_Value_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();

            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            d["Cats"] = 42;
            d["Dogs"] = 17;

            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }

    class MyDictionary
    {
        KeyValue[] keyValue = new KeyValue[20];
        int numberOfValues = 0;

        public object this[string key]
        {
            get 
            {
                for (int i = 0; i < keyValue.Length-1; i++)
                {
                    if (key == keyValue[i].Key)
                    {
                        return keyValue[i].Value;
                    }
                }
                return "KeyNotFoundException";
            }
            set 
            {
                for (int i = 0; i < keyValue.Length-1; i++)
                {
                    if (key == keyValue[i].Key)
                    {
                        keyValue[i] = new KeyValue(key, value);
                        return;
                    }
                }
                keyValue[numberOfValues] = new KeyValue(key, value);
                numberOfValues++;
             }
        }
    }

    public struct KeyValue
    {
        public string Key { get; }
        public object Value { get; }

        public KeyValue(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
