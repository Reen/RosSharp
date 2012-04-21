//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-22T00:11:48+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp.std_msgs
{
    public class Int16MultiArray : IMessage
    {
        public Int16MultiArray()
        {
            layout = new MultiArrayLayout();
            data = new List<short>();
        }
        public Int16MultiArray(BinaryReader br)
        {
            Deserialize(br);
        }
        public MultiArrayLayout layout { get; set; }
        public List<short> data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/Int16MultiArray"; }
        }
        public string Md5Sum
        {
            get { return "36f495a42e21554252b6e9401035f4e7"; }
        }
        public string MessageDefinition
        {
            get { return "MultiArrayLayout layout\nint16[] data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            layout.Serialize(bw);
            bw.Write(data.Count); for(int i=0; i<data.Count; i++) { bw.Write(data[i]);}
        }
        public void Deserialize(BinaryReader br)
        {
            layout = new MultiArrayLayout(br);
            data = new List<short>(br.ReadInt32()); for(int i=0; i<data.Count; i++) { data[i] = br.ReadInt16();}
        }
        public int SerializeLength
        {
            get { return layout.SerializeLength + 4 + data.Sum(x => 2); }
        }
        public bool Equals(Int16MultiArray other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.layout.Equals(layout) && other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Int16MultiArray)) return false;
            return Equals((Int16MultiArray)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ layout.GetHashCode();
                result = (result * 397) ^ data.GetHashCode();
                return result;
            }
        }
    }
}
