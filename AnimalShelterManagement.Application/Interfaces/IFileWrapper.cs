using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Interfaces
{
    public  interface IFileWrapper
    {
        void WriteAllBytes(string outputFile, byte[] content);
    }
}
