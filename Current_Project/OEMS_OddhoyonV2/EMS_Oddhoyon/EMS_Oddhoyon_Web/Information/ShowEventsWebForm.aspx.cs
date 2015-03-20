using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Logic;
using System.Globalization;

namespace EMS_Oddhoyon_Web.Information
{
    public partial class ShowEventsWebForm : System.Web.UI.Page
    {
        List<Tbl_Events> lstEvents = new List<Tbl_Events>();
        EventsBusiness aEventBusiness = new EventsBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.Page.Master.FindControl("liHome");

            li.Attributes.Add("class", "active nav-item dropdown");
            BindEvents();


        }



        void BindEvents()
        {

            lstEvents = aEventBusiness.GetAllEvents(5);
            listviewEvents.DataSource = lstEvents;
            listviewEvents.DataBind();
            int i = 0;
            foreach (ListViewDataItem lstViewDataItem in listviewEvents.Items)
            {

                string monthname = "";
                string dayName = "";
                string startTime = "";
                string endTime = "";
                string Events_StartDat = lstEvents[i].Events_StartDate.ToString();
                string Events_EndDat = lstEvents[i].Events_EndDate.ToString();

                DateTime dt = Convert.ToDateTime(Events_StartDat);
                DateTime dtE = Convert.ToDateTime(Events_EndDat);
                 monthname = GetMonthName(dt.Month);
                 dayName= dt.Day.ToString();

                 startTime = dt.ToString("hh:mm tt");
                 endTime = dtE.ToString("hh:mm tt");

                Label lblEventMonthName = (Label)lstViewDataItem.FindControl("lblEventMonthName");
                lblEventMonthName.Text = monthname.ToString();
                Label lblEveentDateName = (Label)lstViewDataItem.FindControl("lblEveentDateName");
                lblEveentDateName.Text = dayName.ToString();


                Label lblEventtitle = (Label)lstViewDataItem.FindControl("Events_Title");
                Label LabeStartTime = (Label)lstViewDataItem.FindControl("LabeStartTime");
                LabeStartTime.Text = startTime.ToString();
                Label lblendTime = (Label)lstViewDataItem.FindControl("lblendTime");
                lblendTime.Text = endTime.ToString();
                Label lblCampusName = (Label)lstViewDataItem.FindControl("Events_Location");
                Label lblEventDesc = (Label)lstViewDataItem.FindControl("Events_Description");

                i++; 
            }

        }
        protected void DataPagerEvents_PreRender(object sender, EventArgs e)
        {
            BindEvents();
        }
        string GetMonthName(int Imonth)
        {
            Dictionary<int, string> dicMonths = new Dictionary<int, string>();

            dicMonths.Add(1, "JAN");
            dicMonths.Add(2, "FEB");
            dicMonths.Add(3, "MAR");
            dicMonths.Add(4, "APR");
            dicMonths.Add(5, "MAY");
            dicMonths.Add(6, "JUN");
            dicMonths.Add(7, "JUL");
            dicMonths.Add(8, "AUG");
            dicMonths.Add(9, "SEP");
            dicMonths.Add(10, "OCT");
            dicMonths.Add(11, "NOV");
            dicMonths.Add(12, "DEC");

            return dicMonths.Where(x => x.Key == Imonth).FirstOrDefault().Value;


        }

    }

}