using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_prefsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_prefsDatarefs(IXPlaneData data)
        {
            m_data = data;
            misc = new sim_operation_prefs_miscDatarefs(data);
        }
        public sim_operation_prefs_miscDatarefs misc { get; }

        /// <summary>
        ///  Start up with the plane running?
        /// </summary>
        public IXPDataRef<bool> startup_running { get { return m_data.GetBool("sim/operation/prefs/startup_running");} }

        /// <summary>
        ///  Warn if we exceed max airframe speed
        /// </summary>
        public IXPDataRef<bool> warn_overspeed { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed");} }

        /// <summary>
        ///  Warn if we exceed max g-forces on aircraft
        /// </summary>
        public IXPDataRef<bool> warn_overgforce { get { return m_data.GetBool("sim/operation/prefs/warn_overgforce");} }

        /// <summary>
        ///  Warn if we exceed max flap extended speed
        /// </summary>
        public IXPDataRef<bool> warn_overspeed_flaps { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_flaps");} }

        /// <summary>
        ///  Warn if we exceed max gear deployed speed
        /// </summary>
        public IXPDataRef<bool> warn_overspeed_gear { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_gear");} }

        /// <summary>
        ///  On crash, do we reset the AC to the nearest airport? - gone in v11, read only dref returns false for compatibility.
        /// </summary>
        public IXPDataRef<bool> reset_on_crash { get { return m_data.GetBool("sim/operation/prefs/reset_on_crash");} }

        /// <summary>
        ///  Show text warning for otherwise hard to see things like carb-icing?
        /// </summary>
        public IXPDataRef<bool> warn_nonobvious_stuff { get { return m_data.GetBool("sim/operation/prefs/warn_nonobvious_stuff");} }

        /// <summary>
        ///  show text ATC messages?
        /// </summary>
        public IXPDataRef<bool> text_out { get { return m_data.GetBool("sim/operation/prefs/text_out");} }

        /// <summary>
        ///  Controls whether the AI controls the user's plane
        /// </summary>
        public IXPDataRef<bool> ai_flies_aircraft { get { return m_data.GetBool("sim/operation/prefs/ai_flies_aircraft");} }
    }
}