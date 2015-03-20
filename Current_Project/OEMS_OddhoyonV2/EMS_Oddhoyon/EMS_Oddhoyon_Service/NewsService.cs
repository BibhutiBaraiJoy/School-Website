//Coded by Anisuzzaman 
//Date 11/3/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Service
{
  public  class NewsService: IDisposable
    {
      private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

        ~NewsService()
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
    

         public int UpdateNews(Tbl_News objNews)
         {
             try
             {

                 context.Tbl_News.ApplyChanges(objNews);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int InsertNews(Tbl_News objNews)
         {
             try
             {
                 context.Tbl_News.AddObject(objNews);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DeleteNews(Tbl_News objNews)
         {
             try
             {
                 context.Tbl_News.DeleteObject(objNews);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public List<Tbl_News> GetAllNews(int selectN)
         {
             try
             {
                 return context.Tbl_News.Take(selectN).ToList();

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         #endregion
    }
  
}
