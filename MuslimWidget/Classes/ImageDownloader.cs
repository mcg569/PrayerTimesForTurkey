
using System.Drawing;
using System.Net;
using System.Threading.Tasks;

public class ImageDownloader
    {
        public Bitmap[] DownloadImages(string[] uris)
        {            
            Bitmap[] bitmaps = new Bitmap[uris.Length];
            for (int i = 0;i < bitmaps.Length;i++)
            {
                bitmaps[i] = DownloadImage(uris[i]);
            }
            return bitmaps;
        }
        public  Bitmap DownloadImage(string uri)
        {
            try
            {          
                WebRequest rs = WebRequest.Create(uri);
                return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
            }
            catch
            {
                return null;
            }
        }

    public Task<Bitmap> DownloadımageAsync(string uri)
    {
     Task<Bitmap> bmp =  Task<Bitmap>.Run(() => {
            WebRequest rs = WebRequest.Create(uri);
            return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
        }) ;
        return bmp;
    }

    public Task<Bitmap[]> DownloadImagesAsync(string[] uris)
    {
        Task<Bitmap[]> bmps = Task<Bitmap[]>.Run(()=> 
        {
            Bitmap[] bitmaps = new Bitmap[uris.Length];
            for (int i = 0; i < bitmaps.Length; i++)
            {
                bitmaps[i] = DownloadImage(uris[i]);
            }
            return bitmaps;
        });
        return bmps;
    }

}
