//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectTheDotsGadgeteer {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The USB Client DP module using socket 1 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.USBClientDP usbClientDP;
        
        /// <summary>The LightSense module using socket 10 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.LightSense lightSense;
        
        /// <summary>The TempHumid SI70 module using socket 11 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.TempHumidSI70 tempHumidSI70;
        
        /// <summary>The Ethernet J11D module using socket 7 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.EthernetJ11D ethernetJ11D;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZSpider Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZSpider)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.usbClientDP = new GTM.GHIElectronics.USBClientDP(1);
            this.lightSense = new GTM.GHIElectronics.LightSense(10);
            this.tempHumidSI70 = new GTM.GHIElectronics.TempHumidSI70(11);
            this.ethernetJ11D = new GTM.GHIElectronics.EthernetJ11D(7);
        }
    }
}
