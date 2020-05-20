using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Workers
{
    class Serializator
    {
        private static BinaryFormatter _bin = new BinaryFormatter();
                
        public static void Serialize(string file, object objToSerialize)
        {
            using (Stream stream = File.Open(file, FileMode.Create))
            {
                try
                {
                    _bin.Serialize(stream, objToSerialize);                    
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Serialization fail. Reason: " + e.Message);
                    throw;
                }
            }
        }
        public static T Deserialize<T>(string file)
        {
            T items;

            using (Stream stream = File.Open(file, FileMode.Open))
            {
                try
                {
                    items = (T)_bin.Deserialize(stream);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("deserialization failed. Reason: " + e.Message);
                    throw;
                }
            }
            return items;
        }
    }
}
