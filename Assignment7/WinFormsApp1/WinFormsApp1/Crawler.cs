using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public string Seturl { set; get; }
        public string Starturl { set; get; }

        public List<URLString> wrongurl;
        public List<URLString> righturl;
        public void startcrawl()
        {
            urls.Add(Starturl, false);
            Crawl();
        }
        private void Crawl()
        {
            while (true)
            {
                string html = "";
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                    {
                        continue;
                    }
                    current = url;
                }
                if (current == null || count > 10)
                {
                    break;
                }
                if (current == Seturl)//当指定网站时，current==指定网站时，只爬取指定网站上的页面,直接退出。
                {
                    html = DownLoad(current);
                    break;
                }
                else if (Seturl == "") //若未指定网站，则照常爬取
                {
                    html = DownLoad(current);
                    urls[current] = true;
                    count++;
                }
                else       //若指定网站且不满足current为指定网站，则继续更新current的网址
                {
                    continue;
                }
                if (Regex.IsMatch(current, @"htm|html|aspx|php|jsp"))//当爬取的是htm/html/aspx/php/jsp等网页时，才解析并爬取下一级url
                {
                    Parse(html,current);
                }
            }
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webclient = new WebClient();
                webclient.Encoding = Encoding.UTF8;
                string html = webclient.DownloadString(url);
                URLString us = new URLString(url);
                righturl.Add(us);
                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
                return html;
            }
            catch 
            {
                URLString us = new URLString(url);
                wrongurl.Add(us);
                return " ";
            }
        }
        public void Parse(string html,string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                char[] charsToTrim = { '"', '#', ',', '>' };
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim(charsToTrim);
                if (strRef.Length == 0)
                {
                    continue;
                }
                string fixurl = FixUrl(strRef, current);//将相对地址转成完整地址进行爬取
                if (urls[fixurl] == null)
                {
                    urls[fixurl] = false;
                }
            }
        }
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        private string FixUrl(string url, string pageUrl)//将相对路径转为绝对路径
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
