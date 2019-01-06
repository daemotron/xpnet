using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_TemperatureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_TemperatureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  outside air temperature, pilot selects units
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_deg { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_deg");} }

        /// <summary>
        ///  outside air temperature, celsius
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_degc { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degc");} }

        /// <summary>
        ///  outside air temperature, fahrenheit
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_degf { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degf");} }

        /// <summary>
        ///  outside air temperature with leading edge, pilot selects units
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_deg { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_deg");} }

        /// <summary>
        ///  outside air temperature with leading edge, celsius
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_degc { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degc");} }

        /// <summary>
        ///  outside air temperature with leading edge, fahrenheit
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_degf { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degf");} }

        /// <summary>
        ///  1 if thermo is metric, 0 if fahrenheit.
        /// </summary>
        public IXPDataRef<bool> Outside_air_temp_is_metric { get { return m_data.GetBool("sim/cockpit2/temperature/outside_air_temp_is_metric");} }
    }
}