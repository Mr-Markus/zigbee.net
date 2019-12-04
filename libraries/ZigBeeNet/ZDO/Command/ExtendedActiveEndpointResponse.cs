using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZDO.Field;


namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
    /// Extended Active Endpoint Response value object class.
    ///
    ///
    /// The Extended_Active_EP_rsp is generated by a remote device in response to an
    /// Extended_Active_EP_req directed to the remote device. This command shall be unicast
    /// to the originator of the Extended_Active_EP_req command.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class ExtendedActiveEndpointResponse : ZdoResponse
    {
        /// <summary>
        /// The ZDO cluster ID.
        /// </summary>
        public const ushort CLUSTER_ID = 0x801E;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ExtendedActiveEndpointResponse()
        {
            ClusterId = CLUSTER_ID;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("ExtendedActiveEndpointResponse [");
            builder.Append(base.ToString());
            builder.Append(']');

            return builder.ToString();
        }
    }
}
