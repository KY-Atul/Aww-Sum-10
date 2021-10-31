using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aww_Sum_10
{
    public partial class Welcome : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDB"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
            }
        }

        protected void btnplay_Click(object sender, EventArgs e)
        {
            if (txt_player_name.Text != "")
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("sp_players", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@player_name", txt_player_name.Text);
                cmd.Parameters.AddWithValue("@ops", "insert_new_player_name");
                cmd.ExecuteNonQuery();
                cnn.Close();
                Response.Redirect("AwwSum10.aspx");
            }
        }
    }
}