using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Interfaces.Services
{
    public interface IImageService
    {
        Task<string> AddImageAsync(IFormFile image);
        Task<string> UpdateImageAsync(IFormFile image,string filename);
        string GetUrl(string filename);

    }
}
