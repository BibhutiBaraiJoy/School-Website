using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Logic;

namespace EMS_Oddhoyon_Web.PhotoGallery
{
    public partial class VideoGalleryWebForm : System.Web.UI.Page
    {
        List<Tbl_Gallery> aTbl_Gallery = new List<Tbl_Gallery>();
        VideoGalleryBusiness aVideoGalleryBusiness = new VideoGalleryBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.Page.Master.FindControl("liphotogallery");

            li.Attributes.Add("class", "active nav-item dropdown");

            string gallery_type = "video";
            aTbl_Gallery = aVideoGalleryBusiness.GetAllVideo();
            int count = aTbl_Gallery.Count();
            GalleryListView.DataSource = aTbl_Gallery;
            GalleryListView.DataBind();
            

        }
        protected void GalleryListView_PreRender(object sender, EventArgs e)
        {
            GalleryListView.DataBind();
        }
    }
}