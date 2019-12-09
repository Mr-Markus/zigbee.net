using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.DemandResponseAndLoadControl;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.DemandResponseAndLoadControl
{
    /// <summary>
    /// Report Event Status value object class.
    ///
    /// Cluster: Demand Response And Load Control. Command ID 0x00 is sent TO the server.
    /// This command is a specific command used for the Demand Response And Load Control cluster.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class ReportEventStatus : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0701;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x00;

        /// <summary>
        /// Issuer Event ID command message field.
        /// 
        /// Unique identifier generated by the Energy provider. The value of this field allows
        /// matching of Event reports with a specific Demand Response and Load Control event.
        /// It's expected the value contained in this field is a unique number managed by
        /// upstream systems or a UTC based time stamp (UTCTime data type) identifying when the
        /// Load Control Event was issued.
        /// </summary>
        public uint IssuerEventId { get; set; }

        /// <summary>
        /// Event Status command message field.
        /// 
        /// This lists the valid values returned in the Event Status field.
        /// </summary>
        public byte EventStatus { get; set; }

        /// <summary>
        /// Event Status Time command message field.
        /// 
        /// UTC Timestamp representing when the event status occurred. This field shall not
        /// use the value of 0x00000000.
        /// </summary>
        public DateTime EventStatusTime { get; set; }

        /// <summary>
        /// Criticality Level Applied command message field.
        /// 
        /// Criticality Level value applied by the device, see the corresponding field in the
        /// Load Control Event command for more information.
        /// </summary>
        public byte CriticalityLevelApplied { get; set; }

        /// <summary>
        /// Cooling Temperature Set Point Applied command message field.
        /// 
        /// Cooling Temperature Set Point value applied by the device, see the corresponding
        /// field in the Load Control Event command for more information. The value 0x8000
        /// means that this field has not been used by the end device.
        /// </summary>
        public ushort CoolingTemperatureSetPointApplied { get; set; }

        /// <summary>
        /// Heating Temperature Set Point Applied command message field.
        /// 
        /// Heating Temperature Set Point value applied by the device, see the corresponding
        /// field in the Load Control Event command for more information. The value 0x8000
        /// means that this field has not been used by the end device.
        /// </summary>
        public ushort HeatingTemperatureSetPointApplied { get; set; }

        /// <summary>
        /// Average Load Adjustment Percentage Applied command message field.
        /// 
        /// Average Load Adjustment Percentage value applied by the device, see the
        /// corresponding field in the Load Control Event command for more information. The
        /// value 0x80 means that this field has not been used by the end device.
        /// </summary>
        public sbyte AverageLoadAdjustmentPercentageApplied { get; set; }

        /// <summary>
        /// Duty Cycle Applied command message field.
        /// 
        /// Defines the maximum On state duty cycle applied by the device. The value 0xFF means
        /// that this field has not been used by the end device.
        /// </summary>
        public byte DutyCycleApplied { get; set; }

        /// <summary>
        /// Event Control command message field.
        /// 
        /// Identifies additional control options for the event.
        /// </summary>
        public byte EventControl { get; set; }

        /// <summary>
        /// Signature Type command message field.
        /// 
        /// An 8-bit Unsigned integer enumerating the type of algorithm use to create the
        /// Signature.
        /// </summary>
        public byte SignatureType { get; set; }

        /// <summary>
        /// Signature command message field.
        /// 
        /// A non-repudiation signature created by using the Matyas-Meyer-Oseas hash
        /// function used in conjunction with ECDSA.
        /// </summary>
        public ByteArray Signature { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ReportEventStatus()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(IssuerEventId, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(EventStatus, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            serializer.Serialize(EventStatusTime, ZclDataType.Get(DataType.UTCTIME));
            serializer.Serialize(CriticalityLevelApplied, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            serializer.Serialize(CoolingTemperatureSetPointApplied, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(HeatingTemperatureSetPointApplied, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(AverageLoadAdjustmentPercentageApplied, ZclDataType.Get(DataType.SIGNED_8_BIT_INTEGER));
            serializer.Serialize(DutyCycleApplied, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(EventControl, ZclDataType.Get(DataType.BITMAP_8_BIT));
            serializer.Serialize(SignatureType, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            serializer.Serialize(Signature, ZclDataType.Get(DataType.OCTET_STRING));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            IssuerEventId = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            EventStatus = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            EventStatusTime = deserializer.Deserialize<DateTime>(ZclDataType.Get(DataType.UTCTIME));
            CriticalityLevelApplied = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            CoolingTemperatureSetPointApplied = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            HeatingTemperatureSetPointApplied = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            AverageLoadAdjustmentPercentageApplied = deserializer.Deserialize<sbyte>(ZclDataType.Get(DataType.SIGNED_8_BIT_INTEGER));
            DutyCycleApplied = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            EventControl = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
            SignatureType = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            Signature = deserializer.Deserialize<ByteArray>(ZclDataType.Get(DataType.OCTET_STRING));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("ReportEventStatus [");
            builder.Append(base.ToString());
            builder.Append(", IssuerEventId=");
            builder.Append(IssuerEventId);
            builder.Append(", EventStatus=");
            builder.Append(EventStatus);
            builder.Append(", EventStatusTime=");
            builder.Append(EventStatusTime);
            builder.Append(", CriticalityLevelApplied=");
            builder.Append(CriticalityLevelApplied);
            builder.Append(", CoolingTemperatureSetPointApplied=");
            builder.Append(CoolingTemperatureSetPointApplied);
            builder.Append(", HeatingTemperatureSetPointApplied=");
            builder.Append(HeatingTemperatureSetPointApplied);
            builder.Append(", AverageLoadAdjustmentPercentageApplied=");
            builder.Append(AverageLoadAdjustmentPercentageApplied);
            builder.Append(", DutyCycleApplied=");
            builder.Append(DutyCycleApplied);
            builder.Append(", EventControl=");
            builder.Append(EventControl);
            builder.Append(", SignatureType=");
            builder.Append(SignatureType);
            builder.Append(", Signature=");
            builder.Append(Signature);
            builder.Append(']');

            return builder.ToString();
        }
    }
}