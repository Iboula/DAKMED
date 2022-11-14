using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DakMedAPI.Patient.Request
{
    public class PatientDTO
    {
        public int PatientID { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Age { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string TypePiece { get; set; }
        public string NumeroPiece { get; set; }
        public DateTime DateDelivrance { get; set; }
        public DateTime DateExpiration { get; set; }
        public string Adresse { get; set; }
        public string AccPrenom { get; set; }
        public string AccNom { get; set; }
        public string AccTelephone { get; set; }
        public string AccEmail { get; set; }
        public string AccTypePiece { get; set; }
        public string AccNumeroPiece { get; set; }
        public string AccAdresse { get; set; }
    }
}
