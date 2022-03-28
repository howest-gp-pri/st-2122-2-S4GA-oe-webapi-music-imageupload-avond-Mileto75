using Microsoft.AspNetCore.Http;
using Pri.WebApi.Music.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Services
{
    public class ImageService : IImageService
    {
        public async Task<string> AddImageAsync(IFormFile image)
        {
            
        }

        public string GetUrl(string filename)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateImageAsync(IFormFile image, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
