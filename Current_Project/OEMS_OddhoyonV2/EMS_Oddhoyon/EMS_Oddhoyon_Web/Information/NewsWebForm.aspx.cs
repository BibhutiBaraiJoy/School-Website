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
    public partial class NewsWebForm : System.Web.UI.Page
    {
        List<Tbl_News> lstLatestNews = new List<Tbl_News>();
        NewsBusiness aNewsBusiness = new NewsBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.Page.Master.FindControl("liInformation");

            li.Attributes.Add("class", "active nav-item dropdown");
            bindNews();
        }

        void bindNews()
        {
            lstLatestNews = aNewsBusiness.GetAllNews(10);



            listviewNews.DataSource = lstLatestNews;
            listviewNews.DataBind();
            int i = 0;
            foreach (ListViewDataItem lvdi in listviewNews.Items)
            {
                Image newsImage = (Image)lvdi.FindControl("NewsImage");
                Label lblDesignation = (Label)lvdi.FindControl("lblDesignation");
                if (lblDesignation.Text.Length > 250)
                {
                    lblDesignation.Text = "<p>" + lblDesignation.Text.Substring(0, 250) + "</p>" + "<a class=\"col-sm-2 btn btn-theme read-more\" href=\"" + ResolveUrl("~/Information/SingleNewsWebForm.aspx?newsId=" + lstLatestNews[i].News_ID) + "\">Read more<i class=\"fa fa-chevron-right\"></i></a>";
                }
                else
                {
                    lblDesignation.Text = "<p>" + lblDesignation.Text + "</p>";
                }

               if(lstLatestNews[i].News_Picture!=null)
                {
                    string newsPhotobase64String = Convert.ToBase64String(lstLatestNews[i].News_Picture, 0, lstLatestNews[i].News_Picture.Length);
                    newsImage.ImageUrl = "data:image/png;base64," + newsPhotobase64String;
                }
               else

                {
                    newsImage.ImageUrl = ResolveUrl("~/assets/images/news/news-thumb-1.jpg");

                }
                i++;
            }

        }
        protected void DataPagerNews_PreRender(object sender, EventArgs e)
        {
            bindNews();
        }
    }
}