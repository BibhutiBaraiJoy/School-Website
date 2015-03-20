using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Service
{
   public class VideoGalleryService : IDisposable
    {
       #region Initial
       private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

       ~VideoGalleryService()
        {
            if (context != null){try{context.Dispose();context = null;}catch { }}
        }
         private bool disposedValue = false;

         protected virtual void Dispose(bool disposing)
         {
             if (!this.disposedValue)
             {
                 if (disposing)
                 {
                     if (context != null) { try { context.Dispose(); context = null; } catch { } }
                 }
             }
             this.disposedValue = true;
         }

         public void Dispose()
         {
             Dispose(true);
             GC.SuppressFinalize(this);
         }

       #endregion 

         #region CRUD


         public List<Tbl_Gallery> GetAllVideo()
         {
             try
             {
                 List<Tbl_Gallery> lstVideoGallery = new List<Tbl_Gallery>();
                
                 return context.Tbl_Gallery.ToList();

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         #endregion


    }
}
