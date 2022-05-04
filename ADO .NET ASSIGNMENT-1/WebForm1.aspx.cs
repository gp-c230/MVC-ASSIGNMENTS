using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO_Assignment1_FBL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connectStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            WinTeamDetails(connectStr);

            JapanMatchDetails(connectStr);
        }

        public void WinTeamDetails(String connectStr)
        {
            using (SqlConnection conn = new SqlConnection(connectStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from FootBallLeague where Status = 'Win'", conn);
                SqlDataReader datareader = cmd.ExecuteReader();

                GridView1.DataSource = datareader;
                GridView1.DataBind();
            }
        }

        public void JapanMatchDetails(String connectStr)
        {
            using (SqlConnection conn = new SqlConnection(connectStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from FootBallLeague where TeamName1 = 'Japan' or TeamName2 = 'Japan'", conn);
                SqlDataReader datareader = cmd.ExecuteReader();

                GridView2.DataSource = datareader;
                GridView2.DataBind();
            }
        }
    }
}