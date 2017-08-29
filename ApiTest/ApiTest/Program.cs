using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestReques();
        }

        public static void TestReques()
        {
            //请求路径
            string url = "http://101.200.211.175:8042/Api/TrialController/trialstatus";

            //定义request并设置request的路径
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";

            //初始化request参数
            string postData = "{ place: \"12345678\", nonce: \"12312312\", sign: \"1231234412q1q12w2wq1w2e3r4t5a1s2d3f4g5\",timestamp:\"2017082910\" ,state:\"50\" }";

            //设置参数的编码格式，解决中文乱码
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            //设置request的MIME类型及内容长度
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            //打开request字符流
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            //定义response为前面的request响应
            WebResponse response = request.GetResponse();

            //获取相应的状态代码
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            //定义response字符流
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();//读取所有
            Console.WriteLine(responseFromServer);
        }
    }
}
