using System;
using System.Collections;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

public class Crawler
{
    private Hashtable urls = new Hashtable();
    private int count = 0;
    private string seturl = "";
    static void Main(string[] args)
    {
        Crawler mycrawler = new Crawler();
        string startUrl = "https://blog.csdn.net/";
        if (args.Length >= 1)
        {
            startUrl = args[0];
        }
        mycrawler.urls.Add(startUrl, false);
        new Thread(mycrawler.Crawl).Start();

    }
    private void Crawl()
    {
        Console.WriteLine("开始爬行了.....");
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
            if (current == seturl)//当指定网站时，current==指定网站时，只爬取指定网站上的页面,直接退出。

            {
                Console.WriteLine("爬行" + current + "界面！");
                html = DownLoad(current);
                break;
            }
            else if (seturl == "") //若未指定网站，则照常爬取
            {
                Console.WriteLine("爬行" + current + "界面！");
                html = DownLoad(current);
                urls[current] = true;
                count++;
            }
            else       //若指定网站且不满足current==指定网站时，继续更新current的网址
            {
                continue;
            }
            if (Regex.IsMatch(current, @"htm|html|aspx|php|jsp"))//当爬取的是htm/html/aspx/php/jsp等网页时，才解析并爬取下一级url
            {
                Parse(html);
            }
        }
        Console.WriteLine("爬行结束");
    }
    public string DownLoad(string url)
    {
        try
        {
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            string html = webclient.DownloadString(url);
            string filename = count.ToString();
            File.WriteAllText(filename, html, Encoding.UTF8);
            return html;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return " ";
        }
    }
    public void Parse(string html)
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
            if (urls[strRef] == null)
            {
                urls[strRef] = false;
            }
        }
    }
}

