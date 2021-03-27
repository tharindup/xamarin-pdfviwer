using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;
using Xamarin.Forms;

namespace PdfViewerApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PickAFile(object sender, EventArgs e)
        {
            try
            {
                var fileData = await CrossFilePicker.Current.PickFile();
                if (fileData == null)
                {
                    return;
                }

                var filename = fileData.FileName;

                if (!filename.EndsWith("pdf"))
                {
                    await DisplayAlert("Invalid file type", "Invalid file type. Please upload a valid PDF file.", "OK");
                    return;
                }

                var content = fileData.DataArray;
                FileNameLabel.Text = filename;

                var pdfWebView = new ExtendedWebView();
                pdfWebView.Base64String = Convert.ToBase64String(content);

                await Navigation.PushAsync(new ContentPage {Content = pdfWebView});
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
