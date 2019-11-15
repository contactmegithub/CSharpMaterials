using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebForms
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRegistration"] == null)
                return;
            var user = Session["UserRegistration"] as User;

            SetValues(user);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = TextBox1.Text;
            user.LastName = TextBox2.Text;
            user.Email = TextBox3.Text;
            user.Contact = TextBox4.Text;
            user.Address = TextBox5.Text;
            user.State = TextBox6.Text;
            user.Country = TextBox7.Text;
            Session["UserRegistration"] = user;

            HttpCookie myCookie = new HttpCookie("test");
            myCookie.Values["FirstName"] = "Puran Singh Mehra";
            myCookie.Values["LastName"] = "30+";
            myCookie.Values["Email"] = "Software";
            myCookie.Values["Contact"] = "India";
            myCookie.Values["Address"] = "India";
            myCookie.Values["State"] = "India";
            myCookie.Values["Country"] = "India";

            myCookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(myCookie);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        private void SetValues(User user)
        {
            TextBox1.Text = user.FirstName;
            TextBox2.Text = user.LastName;
            TextBox3.Text = user.Email;
            TextBox4.Text = user.Contact;
            TextBox5.Text = user.Address;
            TextBox6.Text = user.State;
            TextBox7.Text = user.Country;
        }
        private void ResetValues()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}