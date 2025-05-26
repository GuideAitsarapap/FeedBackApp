using Microsoft.Data.SqlClient;
using System.Data;

namespace FeedBackApp
{
    public partial class Feedback : Form
    {
        SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
        public Feedback()
        {
            InitializeComponent();
            DisplayFeedbackData();
        }

        public void DisplayFeedbackData()
        {
            FeedBackData feedbacksData = new FeedBackData();
            List<FeedBackData> listData = feedbacksData.FeedbackListData();

            feedBackGridView.DataSource = listData;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" ||
                nameBox.Text == "" ||
                emailBox.Text == "" ||
                commendBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }

            else if (!int.TryParse(idBox.Text, out _))
            {
                MessageBox.Show("Feedback ID must be a number.");
                return;
            }

            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string checkFeedbackId = "Select * from feedbackstable where feedbackid = @FeedbackID";
                        using (SqlCommand checkFeedback = new SqlCommand(checkFeedbackId, connection))
                        {
                            checkFeedback.Parameters.AddWithValue("@FeedbackID", idBox.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(checkFeedback);

                            if (adapter.Fill(new DataTable()) >= 1)
                            {
                                MessageBox.Show("Feedback ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            else
                            {
                                string insertCommand = "insert into feedbackstable (feedbackid,name,email,comment,datesubmited) values (@FeedbackID,@Name,@Email,@Comment,@DateSubmited)";

                                using (SqlCommand command = new SqlCommand(insertCommand, connection))
                                {
                                    command.Parameters.AddWithValue(@"FeedbackID", idBox.Text.Trim());
                                    command.Parameters.AddWithValue(@"Name", nameBox.Text.Trim());
                                    command.Parameters.AddWithValue(@"Email", emailBox.Text.Trim());
                                    command.Parameters.AddWithValue(@"Comment", commendBox.Text.Trim());
                                    command.Parameters.AddWithValue(@"DateSubmited", DateTime.Now);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Feedback submitted successfully");

                                    clearField();
                                }
                            }
                        }
                        DisplayFeedbackData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void clearField()
        {
            idBox.Clear();
            nameBox.Clear();
            emailBox.Clear();
            commendBox.Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" ||
                nameBox.Text == "" ||
                emailBox.Text == "" ||
                commendBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string editCommand = "update feedbackstable set name = @Name, email = @Email, comment = @Comment where feedbackid = @FeedbackID";
                        using (SqlCommand command = new SqlCommand(editCommand, connection))
                        {
                            if (command.Parameters.AddWithValue("@FeedbackID", idBox.Text) == null)
                            {
                                MessageBox.Show("Feedback ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@Name", nameBox.Text.Trim());
                                command.Parameters.AddWithValue("@Email", emailBox.Text.Trim());
                                command.Parameters.AddWithValue("@Comment", commendBox.Text.Trim());
                                command.ExecuteNonQuery();
                                MessageBox.Show("Feedback updated successfully");
                                clearField();
                            }
                        }
                        DisplayFeedbackData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please select a feedback to delete");
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string deleteCommand = "delete from feedbackstable where feedbackid = @FeedbackID";
                        using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                        {
                            command.Parameters.AddWithValue("@FeedbackID", idBox.Text.Trim());
                            command.ExecuteNonQuery();
                            MessageBox.Show("Feedback deleted successfully");
                            clearField();
                        }
                        DisplayFeedbackData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void feedBackGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //display the selected row data in the text boxes
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = feedBackGridView.Rows[rowIndex];
                idBox.Text = row.Cells["feedbackid"].Value.ToString();
                nameBox.Text = row.Cells["name"].Value.ToString();
                emailBox.Text = row.Cells["email"].Value.ToString();
                commendBox.Text = row.Cells["comment"].Value.ToString();
            }
        }
    }
}
