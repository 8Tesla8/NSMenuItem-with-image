using System;
using AppKit;
using Foundation;

namespace MenuIcon {

    [Register(nameof(MenuItem))]
    internal class MenuItem : NSMenuItem {
        public MenuItem(IntPtr handle) : base(handle) { }

        private nfloat _imageSize = 14;

        private string _blackImgName;
        private string _whiteImgName;


        public void SetImageName(string blackImgName, string whiteImgName) {
            _blackImgName = blackImgName;
            _whiteImgName = whiteImgName;

            SetBlackImg();
        }


        public void SetWhiteImg() {
            Image = GetImageByName(_whiteImgName);
        }


        public void SetBlackImg() {
            Image = GetImageByName(_blackImgName);
        }


        private NSImage GetImageByName(string imageName) {
            if (string.IsNullOrEmpty(imageName))
                return null;

            var size = new CoreGraphics.CGSize {
                Height = _imageSize,
                Width = _imageSize
            };

            var image = NSImage.ImageNamed(imageName);
            image.Size = size;

            return image;
        }
    }


    internal class MenuDelegate : NSMenuDelegate {

        NSMenuItem _prevMenuItem = null;

        public override void MenuWillHighlightItem(NSMenu menu, NSMenuItem item) {

            if (_prevMenuItem != null &&
               _prevMenuItem is MenuItem pmi)
                pmi.SetBlackImg();

            _prevMenuItem = item;

            if (item == null)
                return;

            if (item is MenuItem mi)
                mi.SetWhiteImg();
        }
    }
}
