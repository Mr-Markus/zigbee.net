//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Ieee Address High ".
    /// AT Command <b>SH</b></p>Displays the upper 32 bits of the unique IEEE 64-bit extended
    /// address assigned to the XBee in the factory. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeIeeeAddressHighResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int[] _ieeeAddress;
        
        /// <summary>
        ///  Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        ///  Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        ///  Return the ieeeAddress as <see cref="System.Int32"/>
        /// </summary>
        public int[] GetIeeeAddress()
        {
            return _ieeeAddress;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _frameId = DeserializeInt8();
            DeserializeAtCommand();
            _commandStatus = DeserializeCommandStatus();
            if (_commandStatus != CommandStatus.OK || IsComplete())
            {
                    return;
            }
            _ieeeAddress = DeserializeData();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(477);
            builder.Append("XBeeIeeeAddressHighResponse [frameId=");
            builder.Append(_frameId);
            builder.Append(", commandStatus=");
            builder.Append(_commandStatus);
            if (_commandStatus == CommandStatus.OK)
            {
                builder.Append(", ieeeAddress=");
                if (_ieeeAddress == null)
                {
                builder.Append("null");
                }
                else
                {
                    for (int cnt = 0
                    ; cnt < _ieeeAddress.Length; cnt++
                    )
                    {
                        if (cnt > 0)
                        {
                        builder.Append(' ');
                        }
                        builder.Append(string.Format("0x{0:X2}", _ieeeAddress[cnt]));
                    }
                }
            }
            builder.Append(_commandStatus);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
