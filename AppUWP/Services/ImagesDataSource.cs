using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Storage;
using Windows.Storage.Streams;

using Newtonsoft.Json;

namespace AppUWP.Services
{
    static class ImagesDataSource
    {
        static private IEnumerable<ImageDataItem> _images = null;
        static private IEnumerable<IEnumerable<ImageDataItem>> _groupedImages = null;

        public static IEnumerable<ImageDataItem> GetItems()
        {
            return _images;
        }

        public static IEnumerable<IEnumerable<ImageDataItem>> GetGroupedItems()
        {
            return _groupedImages;
        }

        static public async Task Load()
        {
            _images = await GetImages();
            _groupedImages = _images.GroupBy(x => x.Category);
        }

        private static async Task<IEnumerable<ImageDataItem>> GetImages()
        {
            var uri = new Uri("ms-appx:///Assets/Images.json");
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            IRandomAccessStreamWithContentType randomStream = await file.OpenReadAsync();

            using (StreamReader r = new StreamReader(randomStream.AsStreamForRead()))
            {
                return Parse(await r.ReadToEndAsync());                
            }
        }

        private static IEnumerable<ImageDataItem> Parse(string jsonData)
        {
            return JsonConvert.DeserializeObject<IList<ImageDataItem>>(jsonData);
        }
    }

    public class ImageDataItem
    {
        public string Title { get; set; }
        public string Category { get; set; }        
        public string Thumbnail { get; set; }
    }
}
