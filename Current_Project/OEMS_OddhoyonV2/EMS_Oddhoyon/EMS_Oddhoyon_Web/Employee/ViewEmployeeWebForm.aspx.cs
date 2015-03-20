using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Logic;
namespace EMS_Oddhoyon_Web.Employee
{
    public partial class ViewEmployeeWebForm : System.Web.UI.Page
    {
        EmployeeBusiness aEmployeeBusiness = new EmployeeBusiness();

        List<Qry_EmployeeBasicInfo> lstQryEmployees = new List<Qry_EmployeeBasicInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {

            lstQryEmployees = aEmployeeBusiness.GetAllEmployees(10);



            empListView.DataSource = lstQryEmployees;
            empListView.DataBind();
            int i=0;
            foreach (ListViewDataItem lvdi in empListView.Items)
            {
                Image empImage = (Image)lvdi.FindControl("empImage");

            string empPhotobase64String = Convert.ToBase64String(lstQryEmployees[i].EmployeeBasicInfo_Image, 0, lstQryEmployees[i].EmployeeBasicInfo_Image.Length);
            empImage.ImageUrl = "data:image/png;base64," + empPhotobase64String;
            i++;
            }

           

        }


    }
}