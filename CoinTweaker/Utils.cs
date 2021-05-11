using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTweaker.Utils
{
    public struct TestObject
    {
        public string EditorID;
        public string Name;
        public float Weight;
        public uint Value;

        public TestObject(string EditorID, string Name, float Weight, uint Value)
        {
            this.EditorID = EditorID;
            this.Name = Name;
            this.Weight = Weight;
            this.Value = Value;
        }
    }
}
