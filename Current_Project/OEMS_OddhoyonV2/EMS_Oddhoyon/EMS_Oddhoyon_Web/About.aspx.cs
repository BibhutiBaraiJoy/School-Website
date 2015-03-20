using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace EMS_Oddhoyon_Web
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string relPath = "~/assets/images/gallery/";
            string path= Server.MapPath(relPath);

            string imagelistItems = null;
            foreach (string img in GetAllImages(path))
            {
                imagelistItems = imagelistItems +
                    "<li><img width=\"250px\" height=\"200px\" src=\"" +ResolveUrl(relPath+img) + "\" alt=\"fixedimg\" /> </li>";
            }
            imglistUL.InnerHtml = imagelistItems;
        }


        List<string> GetAllImages(string dirPath)
        {

            List<string> lstImages = new List<string>();

             

            lstImages = Directory.GetFiles(dirPath, "*.jpg") .Select(f => Path.GetFileName(f)).ToList();
            lstImages.AddRange(Directory.GetFiles(dirPath, "*.png").Select(f => Path.GetFileName(f)).ToList());
            lstImages.AddRange(Directory.GetFiles(dirPath, "*.gif").Select(f => Path.GetFileName(f)).ToList());


            return lstImages;
        }
    }
}
