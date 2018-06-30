//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace SinoStar.App
//{
//    public class FileManager
//    {
//        public static async Task<Stream> GetFileStreamAsync(string filePath)
//        {
//            var file=File.OpenRead
//            var openAsync = (await FileSystem.Current.GetFileFromPathAsync(filePath))?.OpenAsync(PCLStorage.FileAccess.Read);
//            if (openAsync == null)
//            {
//                return null;
//            }
//            return await openAsync;
//        }

//        public static async Task SaveFileAsync(string fileName, MemoryStream inputStream)
//        {
//            var file = await FileSystem.Current.LocalStorage.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
//            using (var stream = await file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite))
//            {
//                inputStream.WriteTo(stream);
//            }
//        }

//        public static string GetFilePathFromRoot(string fileName) => Path.Combine(FileSystem.Current.LocalStorage.Path, fileName);

//        public static async Task<bool> ExistsAsync(string fileName) => await FileSystem.Current.LocalStorage.CheckExistsAsync(fileName) == ExistenceCheckResult.FileExists;

//        public static async Task DownloadDocumentsAsync(PdfDocEntity pdfDocEntity)
//        {
//            var stream = await DownloadFileAsync(pdfDocEntity.Url);
//            if (stream == null)
//            {
//                return;
//            }
//            await SaveFileAsync(pdfDocEntity.FileName, stream);
//        }


//        public static async Task<MemoryStream> DownloadFileAsync(string url)
//        {
//            if (CrossConnectivity.Current.IsConnected == false)
//            {
//                return null;
//            }

//            try
//            {
//                var stream = new MemoryStream();
//                using (var httpClient = new HttpClient())
//                {
//                    var downloadStream = await httpClient.GetStreamAsync(new Uri(url));
//                    if (downloadStream != null)
//                    {
//                        await downloadStream.CopyToAsync(stream);
//                    }
//                }

//                return stream;
//            }
//            catch (Exception exception)
//            {
//                Debug.WriteLine(exception);
//                return null;
//            }
//        }
//    }
//}
