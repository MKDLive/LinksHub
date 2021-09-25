using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHBOL;
using LHDAL;

namespace LHBLL
{
    interface IURLsBL
    {
        IEnumerable<URLs> GetAllURLs();
        URLs GetURLById(int urlId);
        bool CreateURL(URLs url);
        bool UpdateURL(URLs url);
        bool DeleteURL(int urlId);

    }
    public class URLsBL : IURLsBL
    {
        URLsDb urlDb;
        public URLsBL()
        {
            urlDb = new URLsDb();
        }
        public bool CreateURL(URLs url)
        {
            return urlDb.CreateURL(url);
        }

        public bool DeleteURL(int urlId)
        {
            return urlDb.DeleteURL(urlId);
        }

        public IEnumerable<URLs> GetAllURLs()
        {
            return urlDb.GetAllURLs();
        }

        public URLs GetURLById(int urlId)
        {
            return urlDb.GetURLById(urlId);
        }

        public bool UpdateURL(URLs url)
        {
            return urlDb.UpdateURL(url);
        }
    }
}
