//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-22T00:11:46+09:00
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
    public class Bool : IMessage
    {
        public Bool()
        {
        }
        public Bool(BinaryReader br)
        {
            Deserialize(br);
        }
        public bool data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/Bool"; }
        }
        public string Md5Sum
        {
            get { return "8b94c1b53db61fb6aed406028ad6332a"; }
        }
        public string MessageDefinition
        {
            get { return "bool data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(data);
        }
        public void Deserialize(BinaryReader br)
        {
            data = br.ReadBoolean();
        }
        public int SerializeLength
        {
            get { return 1; }
        }
        public bool Equals(Bool other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Bool)) return false;
            return Equals((Bool)obj);
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
