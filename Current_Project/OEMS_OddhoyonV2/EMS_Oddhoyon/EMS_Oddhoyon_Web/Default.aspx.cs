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
    public partial class _Default : System.Web.UI.Page
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
           // bindNotice();
            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.Page.Master.FindControl("liHome");

            li.Attributes.Add("class", "active nav-item dropdown");

            BindLatestNews();
            BindEvents();
            BindQuickLinks();

        }


        void BindLatestNews()
        {
            lstLatestNews = aNewsBusiness.GetAllNews(12);
            string newsItemPrefixActive = " <div class=\"item active\">";
            string newsItemPrefix = " <div class=\"item \">";
            string newsItemPostfix = " </div>";
            string newsSubItemPrefix = "<div class=\"col-md-6 news-item\"><h2 class=\"title\"><a href=\"news-single.html\">";
            string newsSubItemPrefixEnd =   "</a></h2><img class=\"thumb\" src=\"assets/images/news/news-thumb-1.jpg\" alt=\"\" /><p>";
            string newsSubItemPostFix = "</p>";
            string newsSubItemEnd = "</div>";

            bool IssetActive = true;
            bool IsNew = true;
            int countNewsSubItem = 1;
            string OutputInnerHtML = null;
            int TotalNews = 0;
            foreach (Tbl_News ln in lstLatestNews)
            {
                if (((ln.News_Status == "A") ? true : false) && ln.News_ExpireDate >= DateTime.UtcNow.AddHours(6) && ln.News_PublishDate <= DateTime.UtcNow.AddHours(6))
                {
                   
                    if (IsNew)
                    {
                        if (IssetActive)
                        {
                            OutputInnerHtML = OutputInnerHtML + newsItemPrefixActive;
                            IssetActive = false;
                        }
                        else
                        {
                            OutputInnerHtML = OutputInnerHtML + newsItemPrefix;
                        }
                        
                    }

                    else { 
                    
                    
                    }

                   

                        if (ln.News_Description.Length > 200)
                        {
                            ln.News_Description = ln.News_Description.Substring(0, 200);
                            ln.News_Description = ln.News_Description +" <a href=\"" + ResolveUrl("~/Information/SingleNewsWebForm.aspx?newsId=" + ln.News_ID) + "\">read more</a>";
                        }
                        OutputInnerHtML = OutputInnerHtML + newsSubItemPrefix +ln.News_Title+newsSubItemPrefixEnd+ ln.News_Description + newsSubItemPostFix+newsSubItemEnd;

                        

                        TotalNews = TotalNews + 1;

                        if (countNewsSubItem == 2)
                        {
                            OutputInnerHtML = OutputInnerHtML + newsItemPostfix;
                            countNewsSubItem = 1;
                            IsNew = true;
                        }
                        else
                        {
                            IsNew = false;
                            countNewsSubItem++;
                        }

                        

                      
                  
                }



            }

            if (TotalNews % 2 != 0)
            {
                OutputInnerHtML = OutputInnerHtML + newsItemPostfix;
            }


            newsContentDiv.InnerHtml = OutputInnerHtML;
        
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
                        ln.News_Description = ln.News_Description + " <a href=\"" + ResolveUrl("~/Information/SingleNewsWebForm.aspx?newsId=" +ln.News_ID)+"\">read more</a>";
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

        void BindEvents()
        {
            lstEvents = aEventBusiness.GetAllEvents(2);
            string eventsInnerhtml = null;
            foreach (Tbl_Events ae in lstEvents)
            {
                GeneralObjects.EventDateTime eventdatetime = new GeneralObjects.EventDateTime();
                DateTime dt = new DateTime();
                dt = (DateTime)ae.Events_StartDate;

                DateTime dtE = new DateTime();
                dtE = (DateTime)ae.Events_EndDate;

                eventdatetime.MonthName = GetMonthName(dt.Month);
                eventdatetime.DateNumber = dt.Day.ToString();
                eventdatetime.StartTime = dt.ToString("t", CultureInfo.CreateSpecificCulture("en-us"));
                eventdatetime.EndTime = dtE.ToString("t", CultureInfo.CreateSpecificCulture("en-us"));
                eventsInnerhtml = eventsInnerhtml +
                    "<div class=\"event-item\"><p class=\"date-label\">" +
                    "<span class=\"month\">" + eventdatetime.MonthName + "</span> <span class=\"date-number\">" + eventdatetime.DateNumber + "</span></p>" +
                    "<div class=\"details\"><h2 class=\"title\">" + ae.Events_Title + "</h2><p class=\"time\">" +
                    "<i class=\"fa fa-clock-o\"></i>" + eventdatetime.StartTime + " - " + eventdatetime.EndTime + "</p><p class=\"location\">" +
                    "<i class=\"fa fa-map-marker\"></i>" + ae.Events_Location + "</p></div></div>";

            }
            string readMore = "<a class=\"read-more\" href='" + Page.ResolveUrl("~/Information/ShowEventsWebForm.aspx?page=1") + "'>All events<i class=\"fa fa-chevron-right\"></i></a>";
            eventsDiv.InnerHtml = eventsInnerhtml + readMore;

        }


        void BindQuickLinks()
        {
            lstQuickLinks = aQuickLinksBusiness.GetAllQuickLink(5);
            string QuickLinksInnerHtml = null;
            foreach (Tbl_QuickLinks ql in lstQuickLinks)
            {
                if (ql.QuickLinks_Status == "A")
                {
                    QuickLinksInnerHtml = QuickLinksInnerHtml +
                 "<p style=\"padding-left:5px;\"><a target=\"_blank\" href=\"" + ql.QuickLinks_URL + "\"><i class=\"fa fa-caret-right\" style=\"padding-left:5px;\" > " + ql.QuickLinks_Name + "</i></a></p>";
                }
            }

            QuickLinksDiv.InnerHtml = QuickLinksInnerHtml;

        }
    }
}
