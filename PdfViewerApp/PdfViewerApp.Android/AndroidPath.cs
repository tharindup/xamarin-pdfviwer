using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PdfViewerApp.Droid
{
    class AndroidPath: IBasePath
    {
        public string BaseUrl => "file:///android_asset/";
        public string GetPath(string filename)
        {
            return BaseUrl + $"Content/{filename}";
        }
    }
}