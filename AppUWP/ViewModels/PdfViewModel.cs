using AppUWP.Base;
using AppUWP.Services;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Windows.Data.Pdf;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace AppUWP.ViewModels
{
    public class PdfViewModel : ViewModelBase
    {
        StorageFile file = null;
        public PdfViewModel()
        {
            Title = "Pdf View";
        }
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            file = null;
            PdfPages.Clear();
            return null;
        }

        public override async Task OnNavigatedTo(NavigationEventArgs args)
        {
            if(!File.Exists($"{ApplicationData.Current.LocalFolder.Path}/{FileManager.fileName}"))
            {
                IsBusy = true;
                await Task.Delay(500);
                await FileManager.DownloadFile();
            }
            file = await ApplicationData.Current.LocalFolder.GetFileAsync(FileManager.fileName);            
            PdfDocument pdf = await PdfDocument.LoadFromFileAsync(file);
            LoadPdf(pdf);
            IsBusy = false;
        }

        public ObservableCollection<BitmapImage> PdfPages { get; set; } = new ObservableCollection<BitmapImage>();

        async void LoadPdf(PdfDocument pdfDoc)
        {
            PdfPages.Clear();

            for (uint i = 0; i < pdfDoc.PageCount; i++)
            {
                BitmapImage image = new BitmapImage();

                var page = pdfDoc.GetPage(i);

                using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
                {
                    await page.RenderToStreamAsync(stream);
                    await image.SetSourceAsync(stream);
                }

                PdfPages.Add(image);
            }
        }
    }
}
