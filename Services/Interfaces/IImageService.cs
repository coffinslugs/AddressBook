using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AddressBook.Services.Interfaces
{
    interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] filedata, string extension);

    }
}
