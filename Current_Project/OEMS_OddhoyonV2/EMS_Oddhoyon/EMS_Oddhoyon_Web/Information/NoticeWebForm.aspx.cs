using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Logic;

namespace EMS_Oddhoyon_Web.Information
{
    public partial class NoticeWebForm : System.Web.UI.Page
    {
        List<Tbl_Notice> lstNotice = new List<Tbl_Notice>();
        NoticeBusiness aNoticeBusiness = new NoticeBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.Page.Master.FindControl("liInformation");

            li.Attributes.Add("class", "active nav-item dropdown");
            BindNotice();
        }
        void BindNotice()
        {

            lstNotice = aNoticeBusiness.GetAllNotice(5);
            listviewNotice.DataSource = lstNotice;
            listviewNotice.DataBind();
            int i = 0;
            foreach (ListViewDataItem lstViewDataItem in listviewNotice.Items)
            {

                string monthname = "";
                string dayName = "";
                string startTime = "";
                string Notice_StartDat = lstNotice[i].Notice_PublishDate.ToString();


                DateTime dt = Convert.ToDateTime(Notice_StartDat);
                
                monthname = GetMonthName(dt.Month);
                dayName = dt.Day.ToString();
                startTime = dt.ToString("hh:mm tt");
                Label lblNoticeMonthName = (Label)lstViewDataItem.FindControl("lblNoticeMonthName");
                lblNoticeMonthName.Text = monthname.ToString();
                Label lblNoticeDateName = (Label)lstViewDataItem.FindControl("lblNoticeDateName");
                lblNoticeDateName.Text = dayName.ToString();

                Label LabeStartTime = (Label)lstViewDataItem.FindControl("LabeStartTime");
                LabeStartTime.Text = startTime.ToString();
                Label lblNoticetitle = (Label)lstViewDataItem.FindControl("[Notice_Title]");
                Label lblNoticetDesc = (Label)lstViewDataItem.FindControl("[Notice_Description]");

                i++;
            }

        }
        protected void DataPagerNotice_PreRender(object sender, EventArgs e)
        {
            BindNotice();
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