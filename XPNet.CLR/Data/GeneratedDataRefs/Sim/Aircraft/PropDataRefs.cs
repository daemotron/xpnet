using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_propDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_propDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}