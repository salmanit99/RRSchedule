using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using RRSBOL;
namespace RRSDAL
{
    public class UsersDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RRScheduleManagement"].ConnectionString;

        #region List of users
        public List<Users> UsersList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUsersList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Users> usersList = new List<Users>();
                    Users user; 
                    while (dr.Read())
                    {
                        user = new Users(); 
                        user.Id = Convert.ToInt32(dr["Id"].ToString());
                        user.Email = dr["Email"].ToString();
                        user.ConfirmPassword = dr["Password"].ToString();
                        user.Firstname = dr["Firstname"].ToString();
                        user.Lastname = dr["Lastname"].ToString();
                        user.Gender = dr["Gender"].ToString();
                        user.IsActive = Convert.ToInt32(dr["IsActive"]);
                        user.UserImage = Convert.ToString(dr["UserImage"]);

                        usersList.Add(user);
                    }
                   
                    return usersList;
                }
            }         
        }
        #endregion

        #region Add new users
        public bool UserRegistration(Users user)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserRegistration", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.ConfirmPassword);
                    cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    cmd.Parameters.AddWithValue("@UserImage", user.UserImage);
                    cmd.Parameters.AddWithValue("@ActivationCode", user.ActivationCode);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        #endregion   
       
      

    }
}
