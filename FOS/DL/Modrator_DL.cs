using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DL
{
    class Modrator_DL
    {
        DBConnection _dbCon;

        public Modrator_DL()
        {
            _dbCon = new DBConnection();
        }

        public bool addFoodin_DB(Item_DTO aditemDTO)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "INSERT INTO MenuItem VALUES(@TypeName,@Name,@Price);";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@TypeName", aditemDTO.Type);
                com.Parameters.AddWithValue("@Name", aditemDTO.Name);
                com.Parameters.AddWithValue("@Price", aditemDTO.Price);

                int RowEffected= com.ExecuteNonQuery();
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
        public DataTable getMenuItemsfrom_db ()
        {
            DataTable dt = new DataTable();
            
            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT TypeName,Name,Price FROM MenuItem;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
        public DataTable getorderlistINDL()
        {
            DataTable dt = new DataTable();
            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT OrdrID,username,ItemName,TotalPrice,DateGenerated,status FROM Order_items;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
        public bool addtotalbillInDB(GenrateOrderBill_DTO gob_dto)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "INSERT INTO Order_items (username,ItemName,TotalPrice,status) SELECT @username, @TypeName , @bill, @status;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@TypeName", gob_dto.ItemName);
                com.Parameters.AddWithValue("@status", gob_dto.Status);
                com.Parameters.AddWithValue("@bill", gob_dto.Totalbill);
                com.Parameters.AddWithValue("@username", gob_dto.Username);


                int RowEffected = com.ExecuteNonQuery();
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
        public void delectitemINDL(Item_DTO del_dto)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "Delete FROM MenuItem WHERE Name=@name;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@name", del_dto.Name.ToString());
                int noOfRowsAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
        public void updateitemINDL(Item_DTO updt_dto)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "UPDATE MenuItem SET Name=@name, TypeName=@typename,Price=@price WHERE Name = @name;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@name", updt_dto.Name);
                com.Parameters.AddWithValue("@typename", updt_dto.Type);
                com.Parameters.AddWithValue("@price", updt_dto.Price);
                int noOfRowsAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }

        internal Item_DTO checkItem(string text)
        {
            Item_DTO retDTO = new Item_DTO();
            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT * FROM MenuItem WHERE Name = @Name;";

                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@Name", text);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.Name = reader["Name"].ToString();
                    retDTO.Type = reader["TypeName"].ToString();
                    retDTO.Price = reader["Price"].ToString();
                    return retDTO;
                }
                return null;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }

        public DataTable gethistoryin_DL(string userid)
        {
            DataTable dt = new DataTable();

            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT * FROM Order_items WHERE username = @userid;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@userid", userid);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
    }
}
