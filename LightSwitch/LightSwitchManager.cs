namespace LightSwitch
{
    public class LightSwitchManager
    {
        public bool ProcessOneSwitch(ILightSwitch lightSwitch)
        {
           return !lightSwitch.IsUp;
        }
    }
}