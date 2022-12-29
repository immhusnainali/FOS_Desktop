using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DL
{
    class Registration_DL
    {
        private DBConnection _dbCon;

        public Registration_DL()
        {
            _dbCon = new DBConnection();
        }

        public User_DTO verifyuserfromDb(Registration_DTO lgDTO)
        {
            User_DTO retDTO = new User_DTO();
            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT * FROM myUser WHERE username=@UserID AND password=@Password;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@UserID", lgDTO.Username);
                com.Parameters.AddWithValue("@Password", lgDTO.Password);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.UserID = reader["username"].ToString();
                    retDTO.Role = reader["role"].ToString();
                    return retDTO;
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dbCon.Con.Close();
            }
            return null;
        }

        public bool createaccountn_db(User_DTO _user_dto)
        {
            
            try
            {
                _dbCon.Con.Open();
                string queryString = "INSERT INTO myUser VALUES(@UserID,@Password,@role);";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@UserID", _user_dto.UserID);
                com.Parameters.AddWithValue("@role", "Customer");
                com.Parameters.AddWithValue("@Password", _user_dto.Password);

                int roweffected = com.ExecuteNonQuery();
                return true;
                

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                _dbCon.Con.Close();
            }
            
        }
    }
}
