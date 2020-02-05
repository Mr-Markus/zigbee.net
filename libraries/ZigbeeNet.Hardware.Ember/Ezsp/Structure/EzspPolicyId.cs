//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Structure
{
    
    
    /// <summary>
    /// Class to implement the Ember Enumeration <b>EzspPolicyId</b>
    /// </summary>
    public enum EzspPolicyId
    {
        
        /// <summary>
        /// Default unknown value
        /// </summary>
        UNKNOWN = -1,
        
        /// <summary>
        ///  [0] Controls trust center behavior.
        /// </summary>
        EZSP_TRUST_CENTER_POLICY = 0x0000,
        
        /// <summary>
        ///  [1] Controls how external binding modification requests are handled.
        /// </summary>
        EZSP_BINDING_MODIFICATION_POLICY = 0x0001,
        
        /// <summary>
        ///  [2] Controls whether the Host supplies unicast replies.
        /// </summary>
        EZSP_UNICAST_REPLIES_POLICY = 0x0002,
        
        /// <summary>
        ///  [3] Controls whether pollHandler callbacks are generated.
        /// </summary>
        EZSP_POLL_HANDLER_POLICY = 0x0003,
        
        /// <summary>
        ///  [4] Controls whether the message contents are included in the messageSentHandler
        /// callback.
        /// </summary>
        EZSP_MESSAGE_CONTENTS_IN_CALLBACK_POLICY = 0x0004,
        
        /// <summary>
        ///  [5] Controls whether the Trust Center will respond to Trust Center link key requests.
        /// </summary>
        EZSP_TC_KEY_REQUEST_POLICY = 0x0005,
        
        /// <summary>
        ///  [6] Controls whether the Trust Center will respond to application link key requests.
        /// </summary>
        EZSP_APP_KEY_REQUEST_POLICY = 0x0006,
        
        /// <summary>
        ///  [7] Controls whether ZigBee packets that appear invalid are automatically dropped by the
        /// stack. A counter will be incremented when this occurs.
        /// </summary>
        EZSP_PACKET_VALIDATE_LIBRARY_POLICY = 0x0007,
        
        /// <summary>
        ///  [8] Controls whether the stack will process ZLL messages.
        /// </summary>
        EZSP_ZLL_POLICY = 0x0008,
        
        /// <summary>
        ///  [9] Controls whether Trust Center (insecure) rejoins for devices using the well-known link
        /// key are accepted. If rejoining using the well-known key is allowed, it is disabled again
        /// after emAllowTcRejoinsUsingWellKnownKeyTimeoutSec seconds.
        /// </summary>
        EZSP_TC_REJOINS_USING_WELL_KNOWN_KEY_POLICY = 0x0009,
    }
}