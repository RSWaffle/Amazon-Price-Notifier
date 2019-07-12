using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;

namespace AmazonPriceNotifier
{
    class PriceNotifier
    {
        public string amazonURL = @"""This string is quoted""";

        public string price = "";
        public PriceNotifier()
        {
            string url = "https://www.amazon.com/RODE-Swivel-Mount-Studio-Microphone/dp/B001D7UYBO/ref=pd_rhf_gw_s_pd_crcd_0_10?_encoding=UTF8&ie=UTF8&pd_rd_i=B001D7UYBO&pd_rd_r=S4TQRX8RGWSP1ZTF1E9P&pd_rd_w=iB3to&pd_rd_wg=uuP3C&pf_rd_p=d17c2de0-cc1d-4b09-aad8-987099a21717&pf_rd_r=S4TQRX8RGWSP1ZTF1E9P&pf_rd_r=S4TQRX8RGWSP1ZTF1E9P&pf_rd_s=recent-history-footer&pf_rd_t=gateway&psc=1&refRID=S4TQRX8RGWSP1ZTF1E9P";
            getPrice(url);
        }

        public void getPrice(string url)
        {

            var web = new HtmlAgilityPack.HtmlWeb()
            {
                PreRequest = request =>
            {
                // Make any changes to the request object that will be used.
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                return true;
            }
            };
            HtmlDocument doc = web.Load(url);

            string price = doc.DocumentNode.SelectNodes("//*[@id=\"priceblock_ourprice\"]")[0].InnerText;

            this.price = price;
        }
    }


}
