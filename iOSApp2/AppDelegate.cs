using iOS.StarIO;
using iOS.StarIOExt;
using UIKit;

namespace iOSApp2
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow? Window
        {
            get; 
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // create a new window instance based on the screen size
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            // create a UIViewController with a single UILabel
            var vc = new UIViewController();
            vc.View!.AddSubview(new UILabel(Window!.Frame)
            {
                BackgroundColor = UIColor.SystemBackground,
                TextAlignment = UITextAlignment.Center,
                Text = "Hello, iOS!",
                AutoresizingMask = UIViewAutoresizing.All,
            });
            Window.RootViewController = vc;

            // make the window visible
            Window.MakeKeyAndVisible();


            var printerConnected = new SMPrinter("192.168.1.156");
            if(printerConnected != null) {
                Console.WriteLine("Failed");
                 }
            return true;
        }

        public class SMPrinter : IDisposable
        {
            public string Address { get; set; }
            public SMPort Port;
            public StarPrinterStatus_2 Status;
            public bool IsBusy { get; set; }
            public DateTime LatestErrorBuzzTime { get; set; }

            public SMPrinter(string address)
            {
                Address = address;
                Port = SMPort.GetPort(address, "", 10000); //10 sec timeout
                if (Port == null) throw new Exception("Can't connect to port");
                Status = new StarPrinterStatus_2();
            }
            public void Dispose()
            {
                if (Port != null)
                {
                    SMPort.ReleasePort(Port);
                }
                Port?.Dispose();
            }
        }

    }

}
