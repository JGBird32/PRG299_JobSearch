/*Jansen Ford
 * JobSearch DAL
 * CompanyDB
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PRG299_JobSearchBLL;
using System.Data;

namespace PRG299_JobSearchDAL
{
    public static class CompanyDB
    {
        public static List<Company> GetCompanies()
        {
            List<Company> companyList = new List<Company>();
            SqlConnection connection = JobSearchDB.GetConnection();
            string selectStatement = "SELECT * FROM Companies ORDER BY CompanyID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int compIDOrd = reader.GetOrdinal("CompanyID"),
                    nameOrd = reader.GetOrdinal("Name"),
                    addressOrd = reader.GetOrdinal("Address"),
                    cityOrd = reader.GetOrdinal("City"),
                    stateOrd = reader.GetOrdinal("State"),
                    zipOrd = reader.GetOrdinal("ZipCode"),
                    phoneOrd = reader.GetOrdinal("Phone"),
                    faxOrd = reader.GetOrdinal("Fax"),
                    webOrd = reader.GetOrdinal("Website"),
                    notesOrd = reader.GetOrdinal("Notes");
                while(reader.Read())
                {
                    Company com = new Company(reader.GetInt32(compIDOrd), reader.GetString(nameOrd), reader.GetString(addressOrd), reader.GetString(cityOrd), reader.GetString(stateOrd), reader.GetString(zipOrd), reader.GetString(phoneOrd), reader.GetString(faxOrd), reader.GetString(webOrd), reader.GetString(notesOrd));
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return companyList;
        }

        public static Company GetCompany(int comID)
        {
            Company company;
            SqlConnection connection = JobSearchDB.GetConnection();
            string selectStatement = "SELECT * FROM Companies WHERE CompanyID = @CompanyID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CompanyID", comID);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    company = new Company((int)reader["CompanyID"], reader["Name"].ToString(), reader["Address"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["Zip"].ToString(), reader["Phone"].ToString(), reader["Fax"].ToString(), reader["Website"].ToString(), reader["Notes"].ToString());
                }
                else company = null;

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return company;
        }

        public static int AddCompany(Company comp)
        {
            SqlConnection connection = JobSearchDB.GetConnection();
            string insertStatement = "INSERT INTO Companies (Name, Address, City, State, Zip, Phone, Fax, Website, Notes) VALUES (@Name, @Address, @City, @State, @Zip, @Phone, @Fax, @Website, @Notes)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddRange(new SqlParameter[] {
                comp.Name == "" ? new SqlParameter("@Name", DBNull.Value) : new SqlParameter("@Name", comp.Name),
                comp.Address == "" ? new SqlParameter("@Address", DBNull.Value) : new SqlParameter("@Address", comp.Address),
                comp.City == "" ? new SqlParameter("@City", DBNull.Value) : new SqlParameter("@City", comp.City),
                comp.State == "" ? new SqlParameter("@State", DBNull.Value) : new SqlParameter("@State", comp.State),
                comp.Zip == "" ? new SqlParameter("@Zip", DBNull.Value) : new SqlParameter("@Zip", comp.Zip),
                comp.Phone == "" ? new SqlParameter("@Phone", DBNull.Value) : new SqlParameter("@Phone", comp.Phone),
                comp.Fax == "" ? new SqlParameter("@Fax", DBNull.Value) : new SqlParameter("@Fax", comp.Fax),
                comp.Website == "" ? new SqlParameter("@Website", DBNull.Value) : new SqlParameter("@Website", comp.Website),
                comp.Notes == "" ? new SqlParameter("@Notes", DBNull.Value) : new SqlParameter("@Notes", comp.Notes) });
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('Customers') FROM Customers";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return customerID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateCompany(Company oldComp, Company newComp)
        {
            SqlConnection connection = JobSearchDB.GetConnection();
            string updateStatement = "UPDATE Companies SET Name = @newName, Address = @newAddress, City = @newCity, State = @newState, Zip = @newZip, Phone = @newPhone, Fax = @newFax, Website = @newWebsite, Notes = @newNotes WHERE CustomerID = @oldCompanyID";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddRange(new SqlParameter[]
            {
                newComp.Name == "" ? new SqlParameter("@newName", DBNull.Value) : new SqlParameter("@newName", newComp.Name),
                newComp.Address == "" ? new SqlParameter("@newAddress", DBNull.Value) : new SqlParameter("@newAddress", newComp.Address),
                newComp.City == "" ? new SqlParameter("@newCity", DBNull.Value) : new SqlParameter("@newCity", newComp.City),
                newComp.State == "" ? new SqlParameter("@newState", DBNull.Value) : new SqlParameter("@newState", newComp.State),
                newComp.Zip == "" ? new SqlParameter("@newZip", DBNull.Value) : new SqlParameter("@newZip", newComp.Zip),
                newComp.Phone == "" ? new SqlParameter("@newPhone", DBNull.Value) : new SqlParameter("@newPhone", newComp.Phone),
                newComp.Fax == "" ? new SqlParameter("@newFax", DBNull.Value) : new SqlParameter("@newFax", newComp.Fax),
                newComp.Website == "" ? new SqlParameter("@newWebsite", DBNull.Value) : new SqlParameter("@newWebsite", newComp.Website),
                newComp.Notes == "" ? new SqlParameter("@newNotes", DBNull.Value) : new SqlParameter("@newNotes", newComp.Notes),
                new SqlParameter("@oldCompanyID", oldComp.CompanyID)
            });

            try
            {
                connection.Open();
                return updateCommand.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}