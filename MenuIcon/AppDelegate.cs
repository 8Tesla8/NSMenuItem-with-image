using AppKit;
using Foundation;

namespace MenuIcon {
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate {
        public AppDelegate() {
        }

        public override void DidFinishLaunching(NSNotification notification) {

            //in Xcode set MenuItem class to menu items
            mn_icons.Submenu.Delegate = new MenuDelegate();

            foreach (MenuItem mn in mn_icons.Submenu.ItemArray()) 
                mn.SetImageName("Refresh-bl.PNG", "Refresh-w.PNG");
        }

        public override void WillTerminate(NSNotification notification) {
            // Insert code here to tear down your application
        }
    }
}
