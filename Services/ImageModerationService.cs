using Google.Cloud.Vision.V1;

namespace EdirneGeziAPI.Services
{
    public class ImageModerationService
    {
        public async Task<bool> IsImageSafeAsync(IFormFile imageFile)
        {
            using var memoryStream = new MemoryStream();
            await imageFile.CopyToAsync(memoryStream);

            var image = Image.FromBytes(memoryStream.ToArray());
            var client = await ImageAnnotatorClient.CreateAsync();

            var safeSearch = await client.DetectSafeSearchAsync(image);

            return IsSafeLikelihood(safeSearch.Adult) &&
                   IsSafeLikelihood(safeSearch.Violence) &&
                   IsSafeLikelihood(safeSearch.Racy);
        }

        private bool IsSafeLikelihood(Likelihood likelihood)
        {
            return likelihood != Likelihood.Likely &&
                   likelihood != Likelihood.VeryLikely;
        }
    }
}