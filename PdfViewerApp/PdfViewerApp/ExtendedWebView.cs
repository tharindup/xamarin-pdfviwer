using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PdfViewerApp
{
    public class ExtendedWebView : WebView
    {
        public static readonly BindableProperty Base64StringProperty = BindableProperty.Create(
            propertyName: nameof(Base64String),
            returnType: typeof(string),
            declaringType: typeof(ExtendedWebView));

        public string Base64String
        {
            get => (string) GetValue(Base64StringProperty);
            set => SetValue(Base64StringProperty, value);
        }
    }
}
