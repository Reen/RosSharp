//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-22T00:11:51+09:00
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
    public class UInt8MultiArray : IMessage
    {
        public UInt8MultiArray()
        {
            layout = new MultiArrayLayout();
            data = new List<byte>();
        }
        public UInt8MultiArray(BinaryReader br)
        {
            Deserialize(br);
        }
        public MultiArrayLayout layout { get; set; }
        public List<byte> data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/UInt8MultiArray"; }
        }
        public string Md5Sum
        {
            get { return "d4e9671f3dfa1f44cacc0bfc4a76093e"; }
        }
        public string MessageDefinition
        {
            get { return "MultiArrayLayout layout\nuint8[] data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            layout.Serialize(bw);
            bw.Write(data.Count); for(int i=0; i<data.Count; i++) { bw.Write(data[i]);}
        }
        public void Deserialize(BinaryReader br)
        {
            layout = new MultiArrayLayout(br);
            data = new List<byte>(br.ReadInt32()); for(int i=0; i<data.Count; i++) { data[i] = br.ReadByte();}
        }
        public int SerializeLength
        {
            get { return layout.SerializeLength + 4 + data.Sum(x => 1); }
        }
        public bool Equals(UInt8MultiArray other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.layout.Equals(layout) && other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(UInt8MultiArray)) return false;
            return Equals((UInt8MultiArray)obj);
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
