using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Logic;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Web.Employee
{
    public partial class EmployeeInfoWebForm : System.Web.UI.Page
    {
        EmployeeBusiness aEmployeeBusiness = new EmployeeBusiness();

        List<Qry_EmployeeBasicInfo> lstQryEmployees = new List<Qry_EmployeeBasicInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {
          //  lstQryEmployees = aEmployeeBusiness.GetAllEmployees(10);



            //empListView.DataSource = lstQryEmployees;
            //empListView.DataBind();
            //int i = 0;
            //foreach (ListViewDataItem lvdi in empListView.Items)
            //{
            //    Image empImage = (Image)lvdi.FindControl("empImage");

            //    string empPhotobase64String = Convert.ToBase64String(lstQryEmployees[i].EmployeeBasicInfo_Image, 0, lstQryEmployees[i].EmployeeBasicInfo_Image.Length);
            //    empImage.ImageUrl = "data:image/png;base64," + empPhotobase64String;
            //    i++;
            //}

        }

        void HtmlDataBind()
        {
            //string startRowstart="<div class=\"row page-row\" style=\" margin-bottom:20px;\">";
            //string startRowEnd="</div>";
            //string beforeImageStart="<figure class=\"thumb col-md-3 col-sm-4 col-xs-6\">";
            //string beforeImageEnd = "</figure>";
            //string divAfterImageStart = "<div class=\"details col-md-9 col-sm-8 col-xs-6\">";
            //string divAfterImageEnd = "</div>";
            //string beforeNameStart="<h3 class=\"title\">";
            //string beforeNameEnd = "</h3>";
            //lstQryEmployees = aEmployeeBusiness.GetAllEmployees(10);
            //string OutputInnerHtML = null;
            //foreach (Qry_EmployeeBasicInfo anEmployee in lstQryEmployees)
            //{
            //    string EmpID = anEmployee.EmployeeBasicInfo_EmployeeID.ToString();
            //    string EmpName = anEmployee.EmployeeBasicInfo_Name.ToString();
            //    string EmpDesignation = anEmployee.Designation_Name.ToString();
            //    string EmpImage=Convert.ToBase64String(anEmployee.EmployeeBasicInfo_Image);
            //    OutputInnerHtML=OutputInnerHtML+startRowstart+beforeImageStart+
            //}
        }
      
    }
}