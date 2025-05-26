using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackApp
{
    internal class FeedBackData
    {
        public string feedbackId { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public string comment { get; set; }

        public DateTime date { get; set; }

        SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);

        public List<FeedBackData> FeedbackListData()
        {
            List<FeedBackData> feedbackList = new List<FeedBackData>();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectCommand = "SELECT * FROM feedbackstable ORDER BY TRY_CAST(feedbackid AS INT)";

                    using (SqlCommand command = new SqlCommand(selectCommand,connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            FeedBackData feedback = new FeedBackData();
                            feedback.feedbackId = reader["feedbackid"].ToString();
                            feedback.name = reader["name"].ToString();
                            feedback.email = reader["email"].ToString();
                            feedback.comment = reader["comment"].ToString();
                            feedback.date = Convert.ToDateTime(reader["datesubmited"]);
                            feedbackList.Add(feedback);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return feedbackList;
        }
    }
}
