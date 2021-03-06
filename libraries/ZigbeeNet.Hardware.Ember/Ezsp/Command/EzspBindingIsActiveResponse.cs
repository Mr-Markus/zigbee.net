//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " bindingIsActive ".
    /// Indicates whether any messages are currently being sent using this binding table entry.
    /// Note that this command does not indicate whether a binding is clear. To determine whether a
    /// binding is clear, check whether the type field of the EmberBindingTableEntry has the value
    /// EMBER_UNUSED_BINDING.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspBindingIsActiveResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 46;
        
        /// <summary>
        ///  True if the binding table entry is active, false otherwise.
        /// </summary>
        private bool _active;
        
        public EzspBindingIsActiveResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _active = deserializer.DeserializeBool();
        }
        
        /// <summary>
        /// The active to set as <see cref="bool"/> </summary>
        public void SetActive(bool active)
        {
            _active = active;
        }
        
        /// <summary>
        ///  True if the binding table entry is active, false otherwise.
        /// Return the active as <see cref="System.Boolean"/>
        /// </summary>
        public bool GetActive()
        {
            return _active;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspBindingIsActiveResponse [active=");
            builder.Append(_active);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
