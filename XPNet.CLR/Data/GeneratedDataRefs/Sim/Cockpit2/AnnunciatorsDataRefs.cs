using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_AnnunciatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_AnnunciatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This goes off any time there is a major problem with the bird: like it is on fire or something    // array of annunciators... kept as array for UDP IO
        /// </summary>
        public IXPDataRef<bool> Master_caution { get { return m_data.GetBool("sim/cockpit2/annunciators/master_caution");} }

        /// <summary>
        ///  This goes off whenever there is some more moderate problem with the bird... maybe lo fuel pressure ot qty
        /// </summary>
        public IXPDataRef<bool> Master_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/master_warning");} }

        /// <summary>
        ///  Hit this button to CLEAR the master caution and warning: it says that you hear the buzzer and to shut it up already
        /// </summary>
        public IXPDataRef<bool> Master_accept { get { return m_data.GetBool("sim/cockpit2/annunciators/master_accept");} }

        /// <summary>
        ///  This goes off for a few moments when the autopilot disconnects.. you wanna KNOW if otto just quit on you!
        /// </summary>
        public IXPDataRef<bool> Autopilot_disconnect { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_disconnect");} }

        /// <summary>
        ///  The vacuum pressure, which drives the instruments in the old prop planes, is low: the artificial horizon may loose it is orientation!
        /// </summary>
        public IXPDataRef<bool> Low_vacuum { get { return m_data.GetBool("sim/cockpit2/annunciators/low_vacuum");} }

        /// <summary>
        ///  The voltage os too high or low on one of the electrical buses
        /// </summary>
        public IXPDataRef<bool> Low_voltage { get { return m_data.GetBool("sim/cockpit2/annunciators/low_voltage");} }

        /// <summary>
        ///  Fuel qty. no points for guessing if it is too high or too low to trigger this one
        /// </summary>
        public IXPDataRef<bool> Fuel_quantity { get { return m_data.GetBool("sim/cockpit2/annunciators/fuel_quantity");} }

        /// <summary>
        ///  Hydraulic pressure. should indicate if press is lo or hi
        /// </summary>
        public IXPDataRef<bool> Hydraulic_pressure { get { return m_data.GetBool("sim/cockpit2/annunciators/hydraulic_pressure");} }

        /// <summary>
        ///  Speedbrake deployed: good to know so you do not forget it..
        /// </summary>
        public IXPDataRef<bool> Speedbrake { get { return m_data.GetBool("sim/cockpit2/annunciators/speedbrake");} }

        /// <summary>
        ///  Ground proximity warning system: PULL UP! PULL UP! my lancair does this during my typical red-baron approaches!
        /// </summary>
        public IXPDataRef<bool> GPWS { get { return m_data.GetBool("sim/cockpit2/annunciators/gpws");} }

        /// <summary>
        ///  Ice detected on the plane.. most people agree this is NOT a good thing.
        /// </summary>
        public IXPDataRef<bool> Ice { get { return m_data.GetBool("sim/cockpit2/annunciators/ice");} }

        /// <summary>
        ///  Rotor rpm on the helo has dropped below normal operating: power availability will be reduced!
        /// </summary>
        public IXPDataRef<bool> Low_rotor { get { return m_data.GetBool("sim/cockpit2/annunciators/low_rotor");} }

        /// <summary>
        ///  Rotor rpm on the helo has exceeded normal operating: power availability will be reduced, and god knows if the blades will stay ON!
        /// </summary>
        public IXPDataRef<bool> High_rotor { get { return m_data.GetBool("sim/cockpit2/annunciators/high_rotor");} }

        /// <summary>
        ///  Pitot heat is OFF (YUP! OFF!) turn it on to heat up the pitot tube, which measures air pressure to give you air speed.
        /// </summary>
        public IXPDataRef<bool> Pitot_heat { get { return m_data.GetBool("sim/cockpit2/annunciators/pitot_heat");} }

        /// <summary>
        ///  You are about to break the speed of sound when accelerating, or drop below the speed of sound if decelerating! the handling of the plane will change!
        /// </summary>
        public IXPDataRef<bool> Transonic { get { return m_data.GetBool("sim/cockpit2/annunciators/transonic");} }

        /// <summary>
        ///  slats deployed
        /// </summary>
        public IXPDataRef<bool> Slats { get { return m_data.GetBool("sim/cockpit2/annunciators/slats");} }

        /// <summary>
        ///  flight director failure
        /// </summary>
        public IXPDataRef<bool> Flight_director { get { return m_data.GetBool("sim/cockpit2/annunciators/flight_director");} }

        /// <summary>
        ///  autopilot failure
        /// </summary>
        public IXPDataRef<bool> Autopilot { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot");} }

        /// <summary>
        ///  yaw damper failure
        /// </summary>
        public IXPDataRef<bool> Yaw_damper { get { return m_data.GetBool("sim/cockpit2/annunciators/yaw_damper");} }

        /// <summary>
        ///  fuel pressure low - per engine
        /// </summary>
        public IXPDataRef<bool[]> Fuel_pressure_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/fuel_pressure_low");} }

        /// <summary>
        ///  fuel pressure low - per engine
        /// </summary>
        public IXPDataRef<bool[]> Oil_pressure_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/oil_pressure_low");} }

        /// <summary>
        ///  oil temperature high - per engine
        /// </summary>
        public IXPDataRef<bool[]> Oil_temperature_high { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/oil_temperature_high");} }

        /// <summary>
        ///  generator off - per engine
        /// </summary>
        public IXPDataRef<bool[]> Generator_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/generator_off");} }

        /// <summary>
        ///  chip detected - per engine
        /// </summary>
        public IXPDataRef<bool[]> Chip_detected { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/chip_detected");} }

        /// <summary>
        ///  engine fire - per engine
        /// </summary>
        public IXPDataRef<bool[]> Engine_fires { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/engine_fires");} }

        /// <summary>
        ///  igniter on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Igniter_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/igniter_on");} }

        /// <summary>
        ///  reverser on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Reverser_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/reverser_on");} }

        /// <summary>
        ///  burner on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Burner_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/burner_on");} }

        /// <summary>
        ///  inverter off - per 2 inverters
        /// </summary>
        public IXPDataRef<bool[]> Inverter_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/inverter_off");} }

        /// <summary>
        ///  N1 of engine is too low for AC - per engine
        /// </summary>
        public IXPDataRef<bool[]> N1_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/n1_low");} }

        /// <summary>
        ///  N1 too high - per engine
        /// </summary>
        public IXPDataRef<bool[]> N1_high { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/n1_high");} }

        /// <summary>
        ///  reversers not ready
        /// </summary>
        public IXPDataRef<bool[]> Reverser_not_ready { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/reverser_not_ready");} }

        /// <summary>
        ///  ice vain extended (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Ice_vane_extend { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/ice_vane_extend");} }

        /// <summary>
        ///  ice vain failed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Ice_vane_fail { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/ice_vane_fail");} }

        /// <summary>
        ///  bleed air off (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Bleed_air_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/bleed_air_off");} }

        /// <summary>
        ///  bleed air failed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Bleed_air_fail { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/bleed_air_fail");} }

        /// <summary>
        ///  auto feather armed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Auto_feather_arm { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/auto_feather_arm");} }

        /// <summary>
        ///  fuel transfer on (per tank)
        /// </summary>
        public IXPDataRef<bool[]> Fuel_transfer { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/fuel_transfer");} }

        /// <summary>
        ///  duct overheated
        /// </summary>
        public IXPDataRef<bool> Hvac { get { return m_data.GetBool("sim/cockpit2/annunciators/hvac");} }

        /// <summary>
        ///  battery is charging too rapidly - may overheat
        /// </summary>
        public IXPDataRef<bool> Battery_charge_hi { get { return m_data.GetBool("sim/cockpit2/annunciators/battery_charge_hi");} }

        /// <summary>
        ///  cabin altitude at or above 12500
        /// </summary>
        public IXPDataRef<bool> Cabin_altitude_12500 { get { return m_data.GetBool("sim/cockpit2/annunciators/cabin_altitude_12500");} }

        /// <summary>
        ///  autopilot trim failure
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_fail { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_fail");} }

        /// <summary>
        ///  electric trim is off
        /// </summary>
        public IXPDataRef<bool> Electric_trim_off { get { return m_data.GetBool("sim/cockpit2/annunciators/electric_trim_off");} }

        /// <summary>
        ///  crossfeed on
        /// </summary>
        public IXPDataRef<bool> Crossfeed_on { get { return m_data.GetBool("sim/cockpit2/annunciators/crossfeed_on");} }

        /// <summary>
        ///  landing or taxiway light on but gear up
        /// </summary>
        public IXPDataRef<bool> Landing_taxi_lite { get { return m_data.GetBool("sim/cockpit2/annunciators/landing_taxi_lite");} }

        /// <summary>
        ///  cabin door is open
        /// </summary>
        public IXPDataRef<bool> Cabin_door_open { get { return m_data.GetBool("sim/cockpit2/annunciators/cabin_door_open");} }

        /// <summary>
        ///  external power is on
        /// </summary>
        public IXPDataRef<bool> External_power_on { get { return m_data.GetBool("sim/cockpit2/annunciators/external_power_on");} }

        /// <summary>
        ///  passenger oxygen on
        /// </summary>
        public IXPDataRef<bool> Passenger_oxy_on { get { return m_data.GetBool("sim/cockpit2/annunciators/passenger_oxy_on");} }

        /// <summary>
        ///  gear is unsafe
        /// </summary>
        public IXPDataRef<bool> Gear_unsafe { get { return m_data.GetBool("sim/cockpit2/annunciators/gear_unsafe");} }

        /// <summary>
        ///  autopilot trimming down
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_down { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_down");} }

        /// <summary>
        ///  autopilot trimming up
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_up { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_up");} }

        /// <summary>
        ///  autopilot bank limit is turned ON, autopilot will keep bank below 12.5 degrees of bank
        /// </summary>
        public IXPDataRef<bool> Autopilot_bank_limit { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_bank_limit");} }

        /// <summary>
        ///  autopilot soft ride is on
        /// </summary>
        public IXPDataRef<bool> Autopilot_soft_ride { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_soft_ride");} }

        /// <summary>
        ///  no inverters are on
        /// </summary>
        public IXPDataRef<bool> No_inverters { get { return m_data.GetBool("sim/cockpit2/annunciators/no_inverters");} }

        /// <summary>
        ///  Stall warning going off, yes or no.
        /// </summary>
        public IXPDataRef<bool> Stall_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/stall_warning");} }

        /// <summary>
        ///  For aircraft with variable stall warnings, 0 = no stall, 1 = full stall
        /// </summary>
        public IXPDataRef<float> Stall_warning_ratio { get { return m_data.GetFloat("sim/cockpit2/annunciators/stall_warning_ratio");} }

        /// <summary>
        ///  Gear warning going off, yes or no.
        /// </summary>
        public IXPDataRef<bool> Gear_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/gear_warning");} }

        /// <summary>
        ///  No smoking alert on, yes or no.
        /// </summary>
        public IXPDataRef<bool> No_smoking { get { return m_data.GetBool("sim/cockpit2/annunciators/no_smoking");} }

        /// <summary>
        ///  Seatbelt sign on, yes or no.
        /// </summary>
        public IXPDataRef<bool> Fasten_seatbelt { get { return m_data.GetBool("sim/cockpit2/annunciators/fasten_seatbelt");} }
    }
}