using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_engineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_engineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the inverter providing power (was one per engine, now 2 max.)
        /// </summary>
        public IXPDataRef<bool[]> inverter_on { get { return m_data.GetBoolArray("sim/cockpit/engine/inverter_on");} }

        /// <summary>
        ///  Does this cockpit have inverter switches?
        /// </summary>
        public IXPDataRef<bool> inverter_eq { get { return m_data.GetBool("sim/cockpit/engine/inverter_eq");} }

        /// <summary>
        ///  Is the fuel pump on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> fuel_pump_on { get { return m_data.GetBoolArray("sim/cockpit/engine/fuel_pump_on");} }

        /// <summary>
        ///  Is the fadec on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> fadec_on { get { return m_data.GetBoolArray("sim/cockpit/engine/fadec_on");} }

        /// <summary>
        ///  Idle speed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> idle_speed { get { return m_data.GetBoolArray("sim/cockpit/engine/idle_speed");} }

        /// <summary>
        ///  ignition key position 0 = off, 1 = left, 2 = right, 3 = both
        /// </summary>
        public IXPDataRef<int[]> ignition_on { get { return m_data.GetIntArray("sim/cockpit/engine/ignition_on");} }

        /// <summary>
        ///  starter ignition
        /// </summary>
        public IXPDataRef<bool[]> igniters_on { get { return m_data.GetBoolArray("sim/cockpit/engine/igniters_on");} }

        /// <summary>
        ///  time since ignition was pressed or something
        /// </summary>
        public IXPDataRef<float[]> starter_duration { get { return m_data.GetFloatArray("sim/cockpit/engine/starter_duration");} }

        /// <summary>
        ///  APU starter switch 0 = off, 1 = on, 2 = start
        /// </summary>
        public IXPDataRef<int> APU_switch { get { return m_data.GetInt("sim/cockpit/engine/apu_switch");} }

        /// <summary>
        ///  APU running - 1 = on, 0 = off.
        /// </summary>
        public IXPDataRef<bool> APU_running { get { return m_data.GetBool("sim/cockpit/engine/apu_running");} }
    }
}