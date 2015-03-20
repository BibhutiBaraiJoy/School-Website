//Coded by Anisuzzaman 
//Date 11/3/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Service
{
    public class NoticeService: IDisposable
    {
        private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

        ~NoticeService()
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

         #region CRUD


         public int UpdateNotice(Tbl_Notice objNotice)
         {
             try
             {

                 context.Tbl_Notice.ApplyChanges(objNotice);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int InsertNotice(Tbl_Notice objNotice)
         {
             try
             {
                 context.Tbl_Notice.AddObject(objNotice);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DeleteNotice(Tbl_Notice objNotice)
         {
             try
             {
                 context.Tbl_Notice.DeleteObject(objNotice);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public List<Tbl_Notice> GetAllNotice(int selectN)
         {
             try
             {
                 return context.Tbl_Notice.Take(selectN).ToList();

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         #endregion
    }
}
