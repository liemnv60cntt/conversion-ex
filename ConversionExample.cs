using Aspose.Words;
using SkiaSharp;
//using Aspose.Words.Drawing;
//using ConversionExample;

//using ConvertApiDotNet;
//using System.Diagnostics;
using System.Drawing;

var fromDirectory = "D:\\INFOdation\\Workspace\\Conversion_DocToImg_cs\\From";
var savedDirectory = "D:\\INFOdation\\Workspace\\Conversion_DocToImg_cs\\SavedImg";
var fileName = "note3.txt";
var doc = new Document($"{fromDirectory}\\{fileName}");

ImageWatermarkOptions options = new ImageWatermarkOptions()
{
    Scale = 5,
    IsWashout = false
};

//doc.Watermark.SetImage(SKBitmap.DecodeBounds(File.OpenRead("dd")), options);
doc.Save($"{savedDirectory}\\Output_{DateTime.Now.ToString("ddMMyyyymmss")}.jpg");

//for (int page = 0; page < doc.PageCount; page++)
//{
//    Document extractedPage = doc.ExtractPages(page, 1);
//    extractedPage.Save($"{savedDirectory}\\Output_{DateTime.Now.ToString("ddMMyyyymmss")}.jpg");
//}
//https://www.convertapi.com/doc/dotnet-library
//https://www.e-iceblue.com/Tutorials/Spire.Doc/Spire.Doc-Program-Guide/NET-Word-Insert-Header/Footer-in-Word-Document.html

//Convert API
//using ConvertApiDotNet;

//var savedDirectory = "D:\\INFOdation\\Workspace\\Conversion_DocToImg_cs\\SavedImg";
//var fromDirectory = "D:\\INFOdation\\Workspace\\Conversion_DocToImg_cs\\From";
//var fileName = "note24-5.docx";
//var convertApi = new ConvertApi("fYFEzxxR2A1piwWA");
////Set input and output formats and pass file parameter. 
////Word to PDF API. Read more https://www.convertapi.com/docx-to-pdf
//var createThumbnails = await convertApi.ConvertAsync("docx", "jpg", new ConvertApiFileParam($"{fromDirectory}\\{fileName}"));
////Save PDF file 
//var files = await createThumbnails.SaveFilesAsync(savedDirectory);

//using ConversionExample;
//using System.Drawing;
//using System.Drawing.Text;
//var savedDirectory = "D:\\INFOdation\\Workspace\\Conversion_DocToImg_cs\\SavedImg\\output-new.png";

//Extension.DrawText("adasaad", new Font("Arial", 24, FontStyle.Bold), Color.MintCream, 500, savedDirectory);