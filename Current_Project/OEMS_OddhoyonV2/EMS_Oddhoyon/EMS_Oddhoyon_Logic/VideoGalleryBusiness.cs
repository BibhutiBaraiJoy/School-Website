using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Service;
using EMS_Oddhoyon_Business;
namespace EMS_Oddhoyon_Logic
{
    public class VideoGalleryBusiness
    {
        VideoGalleryService aVideoGalleryService = new VideoGalleryService();

        public List<Tbl_Gallery> GetAllVideo()
        {
            try
            {
                return aVideoGalleryService.GetAllVideo();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
         

    }
}
