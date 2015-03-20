using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using System.Globalization;
using EMS_Oddhoyon_Logic;

namespace EMS_Oddhoyon_Web.Event
{
    public partial class AllEventsWebForm : System.Web.UI.Page
    {
        List<Tbl_Events> lstEvents = new List<Tbl_Events>();
        EventsBusiness aEventsBusiness = new EventsBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            int pi = Convert.ToInt32(Request.QueryString["page"]);
            bindEvents(pi);
        }
        void bindEvents(int PageIndex)
        {
            string Art_start = "<article class=\"events-item page-row has-divider clearfix\"><div class=\"date-label-wrapper col-md-1 col-sm-2\"><p class=\"date-label\">";
            string eventsDetails = null;

            lstEvents = aEventsBusiness.GetAllEvents(5);

            // dynamic Paging//
            string page = "<ul class=\"pagination\">";

            string nPage = null;
            int countPage = (lstEvents.Count()) / 5;
            if (countPage > 5)
            {
                for (int i = 1; i <= countPage + 1; i++)
                {
                    if (i == PageIndex)
                    {
                        nPage += "<li class=\"active\"><a href=\"events.aspx?page=" + i + "\">" + i + "<span class=\"sr-only\">(current)</span></a></li>";
                    }
                    else
                    {
                        nPage += "<li><a href=\"events.aspx?page=" + i + "\">" + i + "</a></li>";
                    }

                }
            }

            page = page + nPage + "</ul>";
            //End//
            int x = 1;
            int start = ((PageIndex - 1) * 5) + 1;
            foreach (Tbl_Events ae in lstEvents)
            {
                GeneralObjects.EventDateTime eventdatetime = new GeneralObjects.EventDateTime();
                DateTime dt = new DateTime();
                dt = (DateTime)ae.Events_StartDate;

                DateTime dtE = new DateTime();
                dtE = (DateTime)ae.Events_EndDate;

                eventdatetime.MonthName = GetMonthName(dt.Month);
                eventdatetime.DateNumber = dt.Day.ToString();
                eventdatetime.StartTime = dt.ToString("dd-MM-yyyy") + " " + (dt.ToString("t", CultureInfo.CreateSpecificCulture("en-us")));
                eventdatetime.EndTime = dtE.ToString("dd-MM-yyyy") + " " + dtE.ToString("t", CultureInfo.CreateSpecificCulture("en-us"));
                if (x >= start)
                {
                    string newArticle = Art_start;
                    string datelabel = "<span class=\"month\">" + eventdatetime.MonthName + "</span><span class=\"date-number\">" + eventdatetime.DateNumber + "</span></p></div>";
                    string detailStart = "<div class=\"details col-md-11 col-sm-10\"><h3 class=\"title\">" + ae.Events_Title + "</h3>";
                    string detailLine1 = " <p class=\"meta\"><span class=\"time\"><i class=\"fa fa-clock-o\"></i>" + eventdatetime.StartTime + " - " + eventdatetime.EndTime + "</span><span class=\"location\"><i class=\"fa fa-map-marker\"></i><a href=\"#\">" + ae.Events_Location + "</a></span></p>";
                    string desc = "<p class=\"desc\">" + ae.Events_Description + "</p></div></article>";

                    newArticle = newArticle + datelabel + detailStart + detailLine1 + desc;

                    eventsDetails = eventsDetails + newArticle;
                }

                x++;
            }
            eventsDetails = eventsDetails + page;

            eventsDetailsDiv.InnerHtml = eventsDetails;


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