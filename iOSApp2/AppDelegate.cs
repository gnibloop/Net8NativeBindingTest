using iOS.ZebraLinkOs;

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

            var printerConnection = new TcpPrinterConnection("192.168.1.134", 9100);

            var testBool = PreCheckPrinterStatus(printerConnection);
            Console.WriteLine(testBool.ToString());
            return true;
        }

        private bool PreCheckPrinterStatus(TcpPrinterConnection connection)
        {
            
            // Check the printer status prior to printing
            IZebraPrinter printer = ZebraPrinterFactory.GetInstance(connection, out NSError errFactory);
            PrinterStatus status = printer.GetCurrentStatus(out NSError errStatus);
            if (!status.IsReadyToPrint)
            {
                //System.Diagnostics.Debug.WriteLine("Unable to print. Printer is " + status.Status);
                return false;
            }
            return true;
        }
    }


}
