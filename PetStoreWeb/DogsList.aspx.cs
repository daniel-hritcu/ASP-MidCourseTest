using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;


namespace PetStoreWeb
{
    public partial class DogsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connection string hardcoded. Not a good practice, but good enough for what we need.
            string cs = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=PetStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           
            DataSet frndDataSet = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("Select * From Dogs", new SqlConnection(cs));

            da.Fill(frndDataSet, "DogDataTable");

            BulletedDogList.DataTextField = "Breed";
            BulletedDogList.DataSource = frndDataSet.Tables["DogDataTable"].DefaultView;
            BulletedDogList.DataBind();
        }
    }
}