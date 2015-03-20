using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Service;

namespace EMS_Oddhoyon_Logic
{
   public class NewsBusiness
    {
        NewsService aNewsService = new NewsService();

        ~NewsBusiness()
        {
            aNewsService.Dispose();
            aNewsService = null;
            aNewsService = null;
            aNewsService = null;
        }
        public bool InsertNews(Tbl_News objNews)
        {
            try
            {
                if (aNewsService.InsertNews(objNews) > 0)
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

        public bool UpdateNews(Tbl_News objNews)
        {
            try
            {


                if (aNewsService.UpdateNews(objNews) > 0)
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
        public bool DeleteNews(Tbl_News objnews)
        {
            try
            {


                if (aNewsService.DeleteNews(objnews) > 0)
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

        public List<Tbl_News> GetAllNews(int selectN)
        {
            return aNewsService.GetAllNews(selectN);

        }

    }
}
