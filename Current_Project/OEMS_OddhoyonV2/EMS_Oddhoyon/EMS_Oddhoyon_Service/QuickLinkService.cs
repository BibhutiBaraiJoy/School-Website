//Coded by Anisuzzaman 
//Date 11/3/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Service
{
  public  class QuickLinkService: IDisposable
    {
      private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

        //~QuickLinkService()
        //{
        //    if (context != null){try{context.Dispose();context = null;}catch { }}
        //}
        // private bool disposedValue = false;

        // protected virtual void Dispose(bool disposing)
        // {
        //     if (!this.disposedValue)
        //     {
        //         if (disposing)
        //         {
        //             if (context != null) { try { context.Dispose(); context = null; } catch { } }
        //         }
        //     }
        //     this.disposedValue = true;
        // }

        // public void Dispose()
        // {
        //     Dispose(true);
        //     GC.SuppressFinalize(this);
        // }

        // #region CRUD


        // public int UpdateQuickLink(Tbl_QuickLinks objQuickLink)
        // {
        //     try
        //     {

        //         context.Tbl_QuickLinks.ApplyChanges(objQuickLink);
        //         return context.SaveChanges();
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }

        // public int InsertQuickLink(Tbl_QuickLinks objQuickLink)
        // {
        //     try
        //     {
        //         context.Tbl_QuickLinks.AddObject(objQuickLink);
        //         return context.SaveChanges();
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }

        // public int DeleteQuickLink(Tbl_QuickLinks objQuickLink)
        // {
        //     try
        //     {
        //         context.Tbl_QuickLinks.DeleteObject(objQuickLink);
        //         return context.SaveChanges();
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }

        // public List<Tbl_QuickLinks> GetAllQuickLink(int selectN)
        // {
        //     try
        //     {
        //         return context.Tbl_QuickLinks.Take(selectN).ToList();

        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }

        // #endregion
    }
   
}
