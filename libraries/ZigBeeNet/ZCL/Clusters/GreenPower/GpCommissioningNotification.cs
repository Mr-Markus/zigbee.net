using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.GreenPower;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.GreenPower
{
    /// <summary>
    /// Gp Commissioning Notification value object class.
    ///
    /// Cluster: Green Power. Command ID 0x04 is sent TO the server.
    /// This command is a specific command used for the Green Power cluster.
    ///
    /// The GP Commissioning Notification command is used by the proxy in commissioning mode to
    /// forward commissioning data to the sink(s).
    /// On receipt of the GP Commissioning Notification command, a device is informed about a
    /// GPD device seeking to manage a pairing. Also the device which received this frame is
    /// informed of bidirectional commissioning capability of the sender.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class GpCommissioningNotification : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0021;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x04;

        /// <summary>
        /// Options command message field.
        /// </summary>
        public ushort Options { get; set; }

        /// <summary>
        /// Gpd Src ID command message field.
        /// </summary>
        public uint GpdSrcId { get; set; }

        /// <summary>
        /// Gpd IEEE command message field.
        /// </summary>
        public IeeeAddress GpdIeee { get; set; }

        /// <summary>
        /// Endpoint command message field.
        /// </summary>
        public byte Endpoint { get; set; }

        /// <summary>
        /// Gpd Security Frame Counter command message field.
        /// </summary>
        public uint GpdSecurityFrameCounter { get; set; }

        /// <summary>
        /// Gpd Command ID command message field.
        /// </summary>
        public byte GpdCommandId { get; set; }

        /// <summary>
        /// Gpd Command Payload command message field.
        /// </summary>
        public ByteArray GpdCommandPayload { get; set; }

        /// <summary>
        /// Gpp Short Address command message field.
        /// </summary>
        public ushort GppShortAddress { get; set; }

        /// <summary>
        /// Gpp Link command message field.
        /// </summary>
        public byte GppLink { get; set; }

        /// <summary>
        /// Mic command message field.
        /// </summary>
        public uint Mic { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GpCommissioningNotification()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Options, ZclDataType.Get(DataType.BITMAP_16_BIT));
            serializer.Serialize(GpdSrcId, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(GpdIeee, ZclDataType.Get(DataType.IEEE_ADDRESS));
            serializer.Serialize(Endpoint, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(GpdSecurityFrameCounter, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(GpdCommandId, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(GpdCommandPayload, ZclDataType.Get(DataType.OCTET_STRING));
            serializer.Serialize(GppShortAddress, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(GppLink, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(Mic, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Options = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.BITMAP_16_BIT));
            GpdSrcId = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            GpdIeee = deserializer.Deserialize<IeeeAddress>(ZclDataType.Get(DataType.IEEE_ADDRESS));
            Endpoint = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            GpdSecurityFrameCounter = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            GpdCommandId = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            GpdCommandPayload = deserializer.Deserialize<ByteArray>(ZclDataType.Get(DataType.OCTET_STRING));
            GppShortAddress = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            GppLink = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            Mic = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("GpCommissioningNotification [");
            builder.Append(base.ToString());
            builder.Append(", Options=");
            builder.Append(Options);
            builder.Append(", GpdSrcId=");
            builder.Append(GpdSrcId);
            builder.Append(", GpdIeee=");
            builder.Append(GpdIeee);
            builder.Append(", Endpoint=");
            builder.Append(Endpoint);
            builder.Append(", GpdSecurityFrameCounter=");
            builder.Append(GpdSecurityFrameCounter);
            builder.Append(", GpdCommandId=");
            builder.Append(GpdCommandId);
            builder.Append(", GpdCommandPayload=");
            builder.Append(GpdCommandPayload);
            builder.Append(", GppShortAddress=");
            builder.Append(GppShortAddress);
            builder.Append(", GppLink=");
            builder.Append(GppLink);
            builder.Append(", Mic=");
            builder.Append(Mic);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
