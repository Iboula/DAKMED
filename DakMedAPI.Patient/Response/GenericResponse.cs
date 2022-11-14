using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DakMedAPI.Patient.Response
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }
        public string Status { get; set; }
        public T Data { get; set; }
    }
}
