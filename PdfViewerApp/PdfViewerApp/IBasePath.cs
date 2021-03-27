using System;
using System.Collections.Generic;
using System.Text;

namespace PdfViewerApp
{
    public interface IBasePath
    {
        string BaseUrl { get; }

        string GetPath(string filename);
    }
}
