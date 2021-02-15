using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnitityFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeDataEntities3 ede = new EmployeeDataEntities3();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var data = new EmpData
            {
                Id = Convert.ToInt32(TextBox1.Text),
                Name = TextBox2.Text,
                Salary = Convert.ToInt32(TextBox3.Text),
                Gender = TextBox4.Text

            };
            ede.EmpDatas.Add(data);
            ede.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            EmpData x = ede.EmpDatas.Find(id);

            if (x != null)
            {
                x.Name = TextBox2.Text;
                x.Salary = Convert.ToInt32(TextBox3.Text);
                x.Gender = TextBox4.Text;
              }
                ede.SaveChanges();
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);


            EmpData x = ede.EmpDatas.Find(id);

            if (x != null)
            {
                ede.EmpDatas.Remove(x);
            }

            ede.SaveChanges();
        }

        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    //int id = Convert.ToInt32(TextBox1.Text);
        //    //EmpData x = ede.EmpDatas.Find(id);

        //    //if (x != null)
        //    //{
        //    //    TextBox2.Text = x.Name.ToString();
        //    //    TextBox3.Text = x.Salary.ToString();
        //    //    TextBox4.Text = x.Gender.ToString();
        //    //}
        //    //ede.SaveChanges();


        //    SqlConnection con1 = new SqlConnection("Data Source=USER-PC;Initial Catalog=webservice_database;Integrated Security=True");
        //    DataTable dt = new DataTable();
        //    con1.Open();
        //    SqlDataReader myReader = null;
        //    SqlCommand myCommand = new SqlCommand("select * from customer_registration where username='" + Session["username"] + "'", con1);

        //    myReader = myCommand.ExecuteReader();

        //    while (myReader.Read())
        //    {
        //        TextBoxPassword.Text = (myReader["password"].ToString());
        //        TextBoxRPassword.Text = (myReader["retypepassword"].ToString());
        //        DropDownListGender.SelectedItem.Text = (myReader["gender"].ToString());
        //        DropDownListMonth.Text = (myReader["birth"].ToString());
        //        DropDownListYear.Text = (myReader["birth"].ToString());
        //        TextBoxAddress.Text = (myReader["address"].ToString());
        //        TextBoxCity.Text = (myReader["city"].ToString());
        //        DropDownListCountry.SelectedItem.Text = (myReader["country"].ToString());
        //        TextBoxPostcode.Text = (myReader["postcode"].ToString());
        //        TextBoxEmail.Text = (myReader["email"].ToString());
        //        TextBoxCarno.Text = (myReader["carno"].ToString());
        //    }
        //    con1.Close()


        //}
    }
}