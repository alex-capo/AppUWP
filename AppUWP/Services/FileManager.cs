using System;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;

namespace AppUWP.Services
{
    public static class FileManager
    {
        static readonly string uri = "https://gotocon.com/dl/goto-aar-2014/slides/JamesMontemagno_XamarinFormsNativeIOSAndroidAndWindowsPhoneAppsFromONECCodebase.pdf";
        public static string fileName = "file.pdf";
        public static async Task DownloadFile()
        {
            try
            {
                Uri source = new Uri(uri);
                StorageFile destinationFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
                BackgroundDownloader downloader = new BackgroundDownloader();
                DownloadOperation download = downloader.CreateDownload(source, destinationFile);
                await download.StartAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

    }
}
