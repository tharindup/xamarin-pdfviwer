using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace PdfViewerApp.iOS
{
    class IosPath: IBasePath
    {
        public string BaseUrl => NSBundle.MainBundle.BundlePath;
        public string GetPath(string filename)
        {
            return BaseUrl + "Content/" + filename;
        }
    }
}