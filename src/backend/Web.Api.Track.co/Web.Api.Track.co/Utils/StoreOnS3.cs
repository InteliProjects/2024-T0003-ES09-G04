using System.Text;
using Amazon.S3;
using Amazon.S3.Model;
using System.Threading.Tasks;

namespace Web.Api.Track.co.Utils
{
    public class StoreOnS3
    {
        public async Task Store(int id, string jsScript, string cssScript)
        {
            try
            {
                var s3Client = new AmazonS3Client(Amazon.RegionEndpoint.USEast1);
                var bucketName = "track-co-api";
                string _baseUrl = $"https://{bucketName}.s3.{s3Client.Config.RegionEndpoint.SystemName}.amazonaws.com/";

                var jsStream = new MemoryStream(Encoding.UTF8.GetBytes(jsScript));
                var cssStream = new MemoryStream(Encoding.UTF8.GetBytes(cssScript));
                
                    
                var jsUploadRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "widget-" + id + "-scripts.js",
                    InputStream = jsStream,
                    ContentType = "application/javascript"
                };

                var cssUploadRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "widget-" + id + "-styles.css",
                    InputStream = cssStream,
                    ContentType = "text/css"
                };

                var jsResponse = await s3Client.PutObjectAsync(jsUploadRequest);
                var cssResponse = await s3Client.PutObjectAsync(cssUploadRequest);

                Console.WriteLine($"JS upload response: {jsResponse.HttpStatusCode}");
                Console.WriteLine($"CSS upload response: {cssResponse.HttpStatusCode}");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine($"Error encountered on server. Message:'{e.Message}' when writing an object");
                throw;
            }
        }
    }
}