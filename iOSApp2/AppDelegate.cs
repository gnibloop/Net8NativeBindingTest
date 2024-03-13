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

            var endPoint = @"wss://" + "192.168.1.59" + @":12345/remote_pay";
            var remoteAppId = @"7YDCJVN5ZP6Q2.ZNCG71D25TPMW";//@"com.clover.ios.example.app";
            var posName = @"POS#1";
            var posSerial = @"Serial-1"; //serial code to id it
            var CloverManager = new iOS.CloverRemotePay.ConnectionManager();

            if (CloverManager == null) Console.WriteLine("Error initialize");
            else CloverManager.ConnectWithEndPoint(endPoint, remoteAppId, posName, posSerial, "");

            // make the window visible
            Window.MakeKeyAndVisible();
            return true;
        }

    }

}
