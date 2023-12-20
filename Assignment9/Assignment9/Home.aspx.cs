using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible=false;
            Page.UnobtrusiveValidationMode =UnobtrusiveValidationMode.None;
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text="Registration Done"+TxtName.Text;
            LblMsg.Text="your mobile number is"+TxtMobile.Text;
            LblMsg.Text="your Email id is"+TxtEmail.Text;
            LblMsg.Text="your password is "+TxtPassword.Text;
        }
        protected void CustomValidator1_ServerValidate(object sender, ServerValidateEventArgs args)
        {
            string len = (args.Value);
            args.IsValid = len.Length > 6;
        }
    }
}