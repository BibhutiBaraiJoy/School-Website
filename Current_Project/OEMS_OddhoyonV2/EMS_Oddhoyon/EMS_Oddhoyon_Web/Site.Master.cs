using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Logic;
using System.Globalization;
namespace EMS_Oddhoyon_Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        List<Tbl_QuickLinks> lstQuickLinks = new List<Tbl_QuickLinks>();
        List<Tbl_Events> lstEvents = new List<Tbl_Events>();
        List<Tbl_News> lstLatestNews = new List<Tbl_News>();
        List<Tbl_Notice> lstNotice = new List<Tbl_Notice>();

        EventsBusiness aEventBusiness = new EventsBusiness();
        NewsBusiness aNewsBusiness = new NewsBusiness();
        NoticeBusiness aNoticeBusiness = new NoticeBusiness();
        QuickLinksBusiness aQuickLinksBusiness = new QuickLinksBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
            bindNotice();
            BindNews();
            //BindEvents();
            //BindQuickLinks();

        }
        void bindNotice()
        {
            lstNotice = aNoticeBusiness.GetAllNotice(5);
            string NoticeScroll = null;
            int i = 1;
            int x = 0;
            foreach (Tbl_Notice nb in lstNotice)
            {
                if ((bool)nb.Notice_IsScroll && ((nb.Notice_Status == "A") ? true : false) && nb.Notice_ExpireDate >= DateTime.UtcNow.AddHours(6) && nb.Notice_PublishDate <= DateTime.UtcNow.AddHours(6))
                {
                    x = x + 1;
                }
            }
            foreach (Tbl_Notice nb in lstNotice)
            {
                if ((bool)nb.Notice_IsScroll && ((nb.Notice_Status == "A") ? true : false) && nb.Notice_ExpireDate >= DateTime.UtcNow.AddHours(6) && nb.Notice_PublishDate <= DateTime.UtcNow.AddHours(6))
                {
                    if (i != x)
                    {
                        NoticeScroll = NoticeScroll + nb.Notice_Title + "&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;";
                    }
                 
                    else
                    {
                        NoticeScroll = NoticeScroll + nb.Notice_Title;
                    }
                    i++;
                }

                topnews.InnerHtml = NoticeScroll;
            }
        }


        void BindNews()
        {
            lstLatestNews = aNewsBusiness.GetAllNews(5);
            string activenewsPrefix = "<div class=\"item active\"><blockquote class=\"quote\"><p style=\"{max-height:230px;}\"><i class=\"fa fa-quote-left\"></i>";
            string newsPrefix = "<div class=\"item\"><blockquote  class=\"quote\"><p><i class=\"fa fa-quote-left\"></i>";
            string newsPostfix = "</p></blockquote></div>";
            string newsitems = null;
            bool IssetActive = false;
            foreach (Tbl_News ln in lstLatestNews)
            {
                if (((ln.News_Status == "A") ? true : false) && ln.News_ExpireDate >= DateTime.UtcNow.AddHours(6))
                {
                    if (ln.News_Description.Length > 200)
                    {
                        ln.News_Description = ln.News_Description.Substring(0, 200);
                        ln.News_Description = ln.News_Description  +" <a href=\"" + ResolveUrl("~/Information/SingleNewsWebForm.aspx?newsId=" + ln.News_ID) + "\">read more</a>";
                    }

                    if (IssetActive)
                    {
                        newsitems = newsitems + newsPrefix + ln.News_Description + newsPostfix;
                    }
                    else
                    {
                        newsitems = newsitems + activenewsPrefix + ln.News_Description + newsPostfix;
                        IssetActive = true;
                    }
                }

            }

          //  LatestNewsDiv.InnerHtml = newsitems;

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

        //void BindEvents()
        //{
        //    lstEvents = aEventBusiness.GetAllEvents(5);
        //    string eventsInnerhtml = null;
        //    foreach (Tbl_Events ae in lstEvents)
        //    {
        //        GeneralObjects.EventDateTime eventdatetime = new GeneralObjects.EventDateTime();
        //        DateTime dt = new DateTime();
        //        dt = (DateTime)ae.Events_StartDate;

        //        DateTime dtE = new DateTime();
        //        dtE = (DateTime)ae.Events_EndDate;

        //        eventdatetime.MonthName = GetMonthName(dt.Month);
        //        eventdatetime.DateNumber = dt.Day.ToString();
        //        eventdatetime.StartTime = dt.ToString("t", CultureInfo.CreateSpecificCulture("en-us"));
        //        eventdatetime.EndTime = dtE.ToString("t", CultureInfo.CreateSpecificCulture("en-us"));
        //        eventsInnerhtml = eventsInnerhtml +
        //            "<div class=\"event-item\"><p class=\"date-label\">" +
        //            "<span class=\"month\">" + eventdatetime.MonthName + "</span> <span class=\"date-number\">" + eventdatetime.DateNumber + "</span></p>" +
        //            "<div class=\"details\"><h2 class=\"title\">" + ae.Events_Title + "</h2><p class=\"time\">" +
        //            "<i class=\"fa fa-clock-o\"></i>" + eventdatetime.StartTime + " - " + eventdatetime.EndTime + "</p><p class=\"location\">" +
        //            "<i class=\"fa fa-map-marker\"></i>" + ae.Events_Location + "</p></div></div>";

        //    }
        //    string readMore = "<a class=\"read-more\" href='" + Page.ResolveUrl("~/Event/events.aspx?page=1") + "'>All events<i class=\"fa fa-chevron-right\"></i></a>";
        //    eventsDiv.InnerHtml = eventsInnerhtml + readMore;

        //}


        //void BindQuickLinks()
        //{
        //    lstQuickLinks = aQuickLinksBusiness.GetAllQuickLink(5);
        //    string QuickLinksInnerHtml = null;
        //    foreach (Tbl_QuickLinks ql in lstQuickLinks)
        //    {
        //        QuickLinksInnerHtml = QuickLinksInnerHtml +
        //     "<p><a href=\"" + ql.QuickLinks_URL + "\"><i class=\"fa fa-caret-right\"></i>" + ql.QuickLinks_Name + "</a></p>";

        //    }

        //    QuickLinksDiv.InnerHtml = QuickLinksInnerHtml;

        //}

        class QuickLinks
        {
            public string linkName { set; get; }
            public string url { set; get; }
            public bool IsActive { set; get; }

        }
        class ArtEvents
        {
            public string MonthName { get; set; }
            public string Date_Number { get; set; }
            public string Title { get; set; }
            public string Event_Time { get; set; }
            public string EventLocation { get; set; }

        }

        class LatestNews
        {
            public bool IsActive { set; get; }

            public string News { get; set; }
            public DateTime ExpireDate { get; set; }
        }

    }
}