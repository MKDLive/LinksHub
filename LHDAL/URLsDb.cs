using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHBOL;

namespace LHDAL
{
    interface IURLsDb
    {
        IEnumerable<URLs> GetAllURLs();
        URLs GetURLById(int urlId);
        bool CreateURL(URLs url);
        bool UpdateURL(URLs url);
        bool DeleteURL(int urlId);

    }
    public class URLsDb : IURLsDb
    {
        LHDBContext lhDbContext;
        public URLsDb()
        {
            lhDbContext = new LHDBContext();
        }

        public bool CreateURL(URLs url)
        {
            lhDbContext.Add(url);
            lhDbContext.SaveChanges();
            return true;
        }

        public bool DeleteURL(int urlId)
        {
           var url = lhDbContext.LHUrls.Find(urlId);
            lhDbContext.Remove(url);
            lhDbContext.SaveChanges();
            return true;
        }

        public IEnumerable<URLs> GetAllURLs()
        {
            return lhDbContext.LHUrls;
        }

        public URLs GetURLById(int urlId)
        {
            return lhDbContext.LHUrls.Find(urlId);
        }

        public bool UpdateURL(URLs url)
        {
            var updateUrl = lhDbContext.LHUrls.Find(url);
            lhDbContext.Update(updateUrl);
            return true;
        }
    }
}
