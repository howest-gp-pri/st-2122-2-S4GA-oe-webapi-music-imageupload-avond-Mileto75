using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Pri.WebApi.Music.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Services
{
    public class ImageService : IImageService
    {
        private readonly IHostEnvironment _hostEnvironment;

        public ImageService(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        public async Task<string> AddImageAsync<T>(IFormFile image)
        {
            //generate unique filename
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(image.FileName)}";
            //generate path on disk (D:/....wwwroot/images/<entity>)
            var pathOnDisk = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot",
                "images", typeof(T).Name.ToLower());

            //check if directory exists
            if (!Directory.Exists(pathOnDisk))
            {
                Directory.CreateDirectory(pathOnDisk);
            }


            //store file
            var completePathWithFilename = Path.Combine(pathOnDisk, fileName);
            using (FileStream fileStream = new(completePathWithFilename, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            //return filename
            return fileName;
        }

        public string GetUrl(string filename)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateImageAsync<T>(IFormFile image, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
