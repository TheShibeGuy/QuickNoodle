using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNoodle
{
    class Utilities
    {
        // Adds key with Value to d 
        public static dynamic addOrUpdateElement(dynamic d, string key, dynamic value, JType type)
        {
            
            if (d.ContainsKey(key))
            {
                switch (type)
                {
                    case JType.JProp:
                        d[key] = new JProperty(value);
                        break;
                    case JType.JArray:
                        d[key] = new JArray(value);
                        break;
                    case JType.JObj:
                        d[key] = value;
                        break;
                    case JType.JValue:
                        d[key] = new JValue(value);
                        break;
                }
                
            }
            else
            {
                if(type == JType.JObj)
                {
                    d.Add(key, value);
                    return d;
                }
                d.Add(new JProperty(key, value));
            }

            return d;
        }
        public static bool elementDoesHaveKey(JObject element, string key)
        {
            return element.ContainsKey(key);
        }
        public enum JType
        {
            JProp, JArray, JObj, JValue
        }
        public static int[] DecodeHexColor(string hexColor)
        {
            // Theres probably a better way to do this but idc
            hexColor = hexColor.Replace("#", string.Empty);
            // Split the Hex string into parts of 2
            IEnumerable<string> bytes = hexColor.SplitInParts(2);
                int[] bytesAsInts = bytes.ToArray().Select(x => Convert.ToInt32(x, 16)).ToArray();
                return bytesAsInts;
            
            
        }

        internal static void addFloatArrayToNoteObject(JObject gameObject, int type, int defaultValue, string name, float[] array)
        {
            if((int) gameObject["type"] == type)
            {
                if (array[0] != defaultValue)
                {
                    addOrUpdateElement(((JObject)gameObject["_customData"]), name, array, JType.JArray);
                }
                else
                {
                    if(elementDoesHaveKey((JObject)gameObject["_customData"], name))
                    {
                        ((JObject)gameObject["_customData"]).Remove(name);
                    }
                }
            }
        }
        internal static void addFloatToNoteObject(JObject gameObject, int type, int defaultValue, string name, float value)
        {
            if ((int)gameObject["type"] == type || type == -1)
            {
                if (value != defaultValue)
                {
                    addOrUpdateElement(((JObject)gameObject["_customData"]), name, value, JType.JValue);
                }
                else
                {
                    if (elementDoesHaveKey((JObject) gameObject["_customData"], name))
                    {
                        ((JObject) gameObject["_customData"]).Remove(name);
                    }
                }
            }
        }
    }
    public struct RotationValue
    {
        public RotationValue(int value, int rotation)
        {
            Rotation = rotation;
            Value = value;
        
        }
        public int Rotation { get; set; }
        public int Value { get; set; }

        

    }
}
