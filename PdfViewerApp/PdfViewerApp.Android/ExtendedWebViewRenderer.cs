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
using Java.IO;
using PdfViewerApp;
using PdfViewerApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedWebView), typeof(ExtendedWebViewRenderer))]
namespace PdfViewerApp.Droid
{
    public class ExtendedWebViewRenderer : WebViewRenderer
    {
        public ExtendedWebViewRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
            {
                return;
            }
            
            var pdfView = Element as ExtendedWebView;
            LoadPdfFile(pdfView?.Base64String);

        }

        private void LoadPdfFile(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return;
            }

            var htmlPath = "file:///android_asset/pdfjs/web/viewer.html";
            var file = new File(htmlPath);

            Control.LoadUrl($"{htmlPath}?base={data}");

            
        }
    }
}