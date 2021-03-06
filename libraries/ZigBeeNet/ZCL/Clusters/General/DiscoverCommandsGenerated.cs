using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.General;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.General
{
    /// <summary>
    /// Discover Commands Generated value object class.
    ///
    /// Cluster: General. Command ID 0x13 is sent TO the server.
    /// This command is a generic command used across the profile.
    ///
    /// The Discover Commands Generated command is generated when a remote device wishes to
    /// discover the commands that a cluster may generate on the device to which this command is
    /// directed.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class DiscoverCommandsGenerated : ZclCommand
    {
        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x13;

        /// <summary>
        /// Start Command Identifier command message field.
        /// </summary>
        public byte StartCommandIdentifier { get; set; }

        /// <summary>
        /// Maximum Command Identifiers command message field.
        /// </summary>
        public byte MaximumCommandIdentifiers { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DiscoverCommandsGenerated()
        {
            CommandId = COMMAND_ID;
            GenericCommand = true;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(StartCommandIdentifier, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(MaximumCommandIdentifiers, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            StartCommandIdentifier = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            MaximumCommandIdentifiers = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("DiscoverCommandsGenerated [");
            builder.Append(base.ToString());
            builder.Append(", StartCommandIdentifier=");
            builder.Append(StartCommandIdentifier);
            builder.Append(", MaximumCommandIdentifiers=");
            builder.Append(MaximumCommandIdentifiers);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
