using PexelsDotNetSDK.Api;

namespace LensEyed.Services
{
    public class ImageManager : PexelsClient
    {
       
        public ImageManager() : base(Utility.Constants.API_KEY)
        {
        }
    }
}
