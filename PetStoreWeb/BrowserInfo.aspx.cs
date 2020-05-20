using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStoreWeb
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get userAgent
            string userAgent = Request.UserAgent;

            //write user agent to label
           CsUserAgentLabel.Text = $"CodeBehind: {userAgent}";


        }
    }
}