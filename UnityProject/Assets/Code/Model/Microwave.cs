namespace UnityProject
{
    public class Microwave
    {
        public bool IsDoorOpen { get; set; }
        public bool IsLightOn { get; set; }

        public Microwave(bool IsDoorOpen, bool IsLightOn)
        {
            this.IsDoorOpen = IsDoorOpen;
            this.IsLightOn = IsLightOn;
        }

        public Microwave() : this(false, false) {}

        override public string ToString() {
            return string.Format("The door is {0}, the light is {1}"
                , this.IsDoorOpen ? "open" : "closed"
                , this.IsLightOn ? "on" : "off");
        }
    }
}