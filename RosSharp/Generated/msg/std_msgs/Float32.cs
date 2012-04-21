//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-22T00:11:47+09:00
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
    public class Float32 : IMessage
    {
        public Float32()
        {
        }
        public Float32(BinaryReader br)
        {
            Deserialize(br);
        }
        public float data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/Float32"; }
        }
        public string Md5Sum
        {
            get { return "73fcbf46b49191e672908e50842a83d4"; }
        }
        public string MessageDefinition
        {
            get { return "float32 data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(data);
        }
        public void Deserialize(BinaryReader br)
        {
            data = br.ReadSingle();
        }
        public int SerializeLength
        {
            get { return 4; }
        }
        public bool Equals(Float32 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Float32)) return false;
            return Equals((Float32)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ data.GetHashCode();
                return result;
            }
        }
    }
}
