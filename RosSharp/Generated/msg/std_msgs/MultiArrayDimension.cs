//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-22T00:11:49+09:00
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
    public class MultiArrayDimension : IMessage
    {
        public MultiArrayDimension()
        {
            label = string.Empty;
        }
        public MultiArrayDimension(BinaryReader br)
        {
            Deserialize(br);
        }
        public string label { get; set; }
        public uint size { get; set; }
        public uint stride { get; set; }
        public string MessageType
        {
            get { return "std_msgs/MultiArrayDimension"; }
        }
        public string Md5Sum
        {
            get { return "4cd0c83a8683deae40ecdac60e53bfa8"; }
        }
        public string MessageDefinition
        {
            get { return "string label\nuint32 size\nuint32 stride"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.WriteUtf8String(label);
            bw.Write(size);
            bw.Write(stride);
        }
        public void Deserialize(BinaryReader br)
        {
            label = br.ReadUtf8String();
            size = br.ReadUInt32();
            stride = br.ReadUInt32();
        }
        public int SerializeLength
        {
            get { return 4 + label.Length + 4 + 4; }
        }
        public bool Equals(MultiArrayDimension other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.label.Equals(label) && other.size.Equals(size) && other.stride.Equals(stride);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(MultiArrayDimension)) return false;
            return Equals((MultiArrayDimension)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ label.GetHashCode();
                result = (result * 397) ^ size.GetHashCode();
                result = (result * 397) ^ stride.GetHashCode();
                return result;
            }
        }
    }
}
