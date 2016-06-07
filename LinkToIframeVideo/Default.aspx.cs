using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace LinkToIframeVideo
{
    public partial class Default : System.Web.UI.Page
    {
        protected String getUrlVideo(String url)
        {
            String urlresult = "";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(url);
                    int position = 0;
                    position = htmlCode.IndexOf("twitter:player");
                    if (position > 0)
                    {
                        int start = position;
                        int stop = position;
                        while (htmlCode[start] != '<' && start != 0)
                        {
                            start--;
                        }
                        while (htmlCode[stop] != '>' && htmlCode.Count() != stop)
                        {
                            stop++;
                        }
                        stop++;
                        int elementi = stop - start;

                        string xmlContent = htmlCode.Substring(start, elementi);
                        if (!xmlContent.Contains("/>")) { xmlContent = xmlContent.Replace(">", "/>"); }
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xmlContent);
                        XmlNode newNode = doc.DocumentElement;

                        urlresult = newNode.Attributes["content"].Value;
                    }

                }


            }
            catch (Exception ex)
            {
                // handle error
                return "";
            }

            return urlresult;
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAvvia_Click(object sender, EventArgs e)
        {
            Video.Attributes.Add("src", getUrlVideo(Link.Text));
        }
    }
}