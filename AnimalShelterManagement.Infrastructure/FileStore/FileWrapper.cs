using AnimalShelterManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Infrastructure.FileStore
{
    public class FileWrapper : IFileWrapper
    {
        public void WriteAllBytes(string outputFile, byte[] content)
        {
            File.WriteAllBytes(outputFile, content);
        }
    }
}
