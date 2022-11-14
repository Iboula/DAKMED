using DakMedAPI.Patient.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DakMedAPI.Patient.Repository
{
    public static class PatientRepository<T>
    {

        //private static string Environment   = ConfigurationManager.AppSettings["Environment"].ToString();
        //private static string Domain        = ConfigurationManager.AppSettings["Domain"].ToString();

        public static List<PatientDTO> GetListPatient()
        {
            try
            {
                List<PatientDTO> listPatient = new List<PatientDTO>();

                using (SqlConnection sqlConnection = new SqlConnection(""))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("PS_GET_LIST_PATIENT", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlConnection.Open();

                        SqlDataReader dr = sqlCommand.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                PatientDTO Patient = new PatientDTO
                                {
                                    PatientID = Int32.Parse(dr["PatientID"].ToString()),
                                    Prenom = dr["Prenom"].ToString(),
                                    Nom = dr["Nom"].ToString(),
                                    Age = dr["Age"].ToString(),
                                    Sexe = dr["Sexe"].ToString(),
                                    Telephone = dr["Telephone"].ToString(),
                                    Email = dr["Email"].ToString(),
                                    TypePiece = dr["TypePiece"].ToString(),
                                    NumeroPiece = dr["NumeroPiece"].ToString(),
                                    DateDelivrance = DBNull.Value == dr["DateDelivrance"] ? default(DateTime) : DateTime.Parse(dr["DateDelivrance"].ToString()),
                                    DateExpiration = DBNull.Value == dr["DateExpiration"] ? default(DateTime) : DateTime.Parse(dr["DateExpiration"].ToString()),
                                    Adresse = dr["Adresse"].ToString(),
                                    AccPrenom = dr["AccPrenom"].ToString(),
                                    AccNom = dr["AccNom"].ToString(),
                                    AccTelephone = dr["AccTelephone"].ToString(),
                                    AccEmail = dr["AccEmail"].ToString(),
                                    AccTypePiece = dr["AccTypePiece"].ToString(),
                                    AccNumeroPiece = dr["AccNumeroPiece"].ToString(),
                                    AccAdresse = dr["AccAdresse"].ToString(),
                                };

                                listPatient.Add(Patient);
                            }
                        }

                        sqlConnection.Close();

                        return listPatient;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static PatientDTO GetPatient()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(""))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("PS_GET_LIST_PATIENT", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        PatientDTO Patient = new PatientDTO();

                        sqlConnection.Open();

                        SqlDataReader dr = sqlCommand.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Patient.PatientID       = Int32.Parse(dr["PatientID"].ToString());
                                Patient.Prenom          = dr["Prenom"].ToString();
                                Patient.Nom             = dr["Nom"].ToString();
                                Patient.Age             = dr["Age"].ToString();
                                Patient.Sexe            = dr["Sexe"].ToString();
                                Patient.Telephone       = dr["Telephone"].ToString();
                                Patient.Email           = dr["Email"].ToString();
                                Patient.TypePiece       = dr["TypePiece"].ToString();
                                Patient.NumeroPiece     = dr["NumeroPiece"].ToString();
                                Patient.DateDelivrance  = DBNull.Value == dr["DateDelivrance"] 
                                                                        ? default(DateTime) 
                                                                        : DateTime.Parse(dr["DateDelivrance"].ToString());
                                Patient.DateExpiration  = DBNull.Value == dr["DateExpiration"] 
                                                                        ? default(DateTime) 
                                                                        : DateTime.Parse(dr["DateExpiration"].ToString());
                                Patient.Adresse         = dr["Adresse"].ToString();
                                Patient.AccPrenom       = dr["AccPrenom"].ToString();
                                Patient.AccNom          = dr["AccNom"].ToString();
                                Patient.AccTelephone    = dr["AccTelephone"].ToString();
                                Patient.AccEmail        = dr["AccEmail"].ToString();
                                Patient.AccTypePiece    = dr["AccTypePiece"].ToString();
                                Patient.AccNumeroPiece  = dr["AccNumeroPiece"].ToString();
                                Patient.AccAdresse      = dr["AccAdresse"].ToString();
                            }
                        }

                        sqlConnection.Close();

                        return Patient;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
