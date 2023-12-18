using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class ExperienceData
    {

        public int ID { set; get; } // 0
        public string UserID { set; get; } // 1
        public string Name { set; get; } // 2
        public string CompanyName { set; get; } // 3
        public string DateBegin { set; get; } // 4
        public string Position { set; get; } // 5
        public string DateEnd { set; get; } // 6
    
        public string Status { set; get; } // 8


        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-60E5KM3A;Initial Catalog=Recruitement;Integrated Security=True;Pooling=False");
    

        public List<ExperienceData> userListData()
        {
            List<ExperienceData> listdata = new List<ExperienceData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM user WHERE id IS NOT NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ExperienceData ed = new ExperienceData();
                            ed.ID = (int)reader["id"];
                            ed.UserID = reader["user_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.CompanyName = reader["Company_name"].ToString();
                            ed.DateBegin = reader["date_begin"].ToString();
                            ed.DateEnd = reader["date_end"].ToString();
                       
                        
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }
                        
                }catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    //    public List<ExperienceData> EducationUserListData()
    //    {
    //        List<ExperienceData> listdata = new List<ExperienceData>();

    //        if (connect.State != ConnectionState.Open)
    //        {
    //            try
    //            {
    //                connect.Open();

    //                string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

    //                using (SqlCommand cmd = new SqlCommand(selectData, connect))
    //                {
    //                    SqlDataReader reader = cmd.ExecuteReader();

    //                    while (reader.Read())
    //                    {
    //                        ExperienceData ed = new ExperienceData();
    //                        ed.UserID = reader["user_id"].ToString();
    //                        ed.Name = reader["full_name"].ToString();
    //                        ed.Position = reader["position"].ToString();
                          

    //                        listdata.Add(ed);
    //                    }
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine("Error: " + ex);
    //            }
    //            finally
    //            {
    //                connect.Close();
    //            }
    //        }
    //        return listdata;
    //    }
    }
}
