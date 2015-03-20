using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Service;

namespace EMS_Oddhoyon_Logic
{
  public class NoticeBusiness
    {
      NoticeService aNoticeService = new NoticeService();

      ~NoticeBusiness()
        {
            aNoticeService.Dispose();
            aNoticeService = null;
            aNoticeService = null;
            aNoticeService = null;
        }
      public bool InsertNotice(Tbl_Notice objNotice)
        {
            try
            {
                if (aNoticeService.InsertNotice(objNotice) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      public bool UpdateNotice(Tbl_Notice objNotice)
        {
            try
            {


                if (aNoticeService.UpdateNotice(objNotice) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      public bool DeleteNotice(Tbl_Notice objNotice)
        {
            try
            {


                if (aNoticeService.DeleteNotice(objNotice) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tbl_Notice> GetAllNotice(int selectN)
        {
            return aNoticeService.GetAllNotice(selectN);

        }

        public object objNotice { get; set; }
    }
}
