using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;
using WebRestClient.Model;


namespace WebRestClient
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            id.Value = Login.LoginUser.Id.ToString();
            uid.Value = Login.LoginUser.Uid.ToString();
            name.Value = Login.LoginUser.Name.ToString();
            password.Value = Login.LoginUser.Password.ToString();
            tel.Value = Login.LoginUser.Tel.ToString();
            address.Value = Login.LoginUser.Address.ToString();
        }
        protected void SubmitInfo(object sender, EventArgs e)
        {
            #region 注册新账户
            //User user = new User();
            //user.Uid =long.Parse(uid.Value.ToString());
            //user.Name = name.Value.ToString();
            //user.Password = password.Value.ToString();
            //user.Tel = tel.Value.ToString();
            //user.Address = address.Value.ToString();

            //string url = "http://10.135.16.55:89/api/user/";
            //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //request.Method = "POST";
            //request.ContentType = "application/json";
            ////string data = "{\n\"header\": {\n\"token\": \"30xxx6aaxxx93ac8cxx8668xx39xxxx\",\n\"username\": \"jdads\",\n\"password\": \"liuqiangdong2010\",\n\"action\": \"\"\n},\n\"body\": {}\n}";
            //string data = JsonConvert.SerializeObject(user);//JSon序列化我们用到第三方Newtonsoft.Json.dll
            //byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());
            //request.ContentLength = byteData.Length;

            //using (Stream postStream = request.GetRequestStream())
            //{
            //    postStream.Write(byteData, 0, byteData.Length);
            //}

            //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            //{
            //    StreamReader reader = new StreamReader(response.GetResponseStream());
            //    //Console.WriteLine(reader.ReadToEnd());
            //    PostResult.Value = reader.ReadToEnd();
            //}
            #endregion
            #region Get新账户
            //HttpWebRequest request = WebRequest.Create("http://10.135.16.55:89/api/user/") as HttpWebRequest;

            //// Get response
            //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            //{
            //    // Get the response stream
            //    StreamReader reader = new StreamReader(response.GetResponseStream());

            //    // Console application output
            //    //Console.WriteLine(reader.ReadToEnd());
            //    PostResult.Value = reader.ReadToEnd();
            //    JArray jArray = GetToJsonList(PostResult.Value);
            //    name.Value = jArray[0]["Tel"].ToString();


            //}
            #endregion

            #region
            //User user = new User();
            
            Login.LoginUser.Id = long.Parse(id.Value.ToString());
            Login.LoginUser.Uid = long.Parse(uid.Value.ToString());
            Login.LoginUser.Name = name.Value.ToString();
            Login.LoginUser.Password = password.Value.ToString();
            Login.LoginUser.Tel = tel.Value.ToString();
            Login.LoginUser.Address = address.Value.ToString();

            string url = "http://10.135.1.142:89/api/user";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "PUT";
            request.ContentType = "application/json";
            //string data = "{\n\"header\": {\n\"token\": \"30xxx6aaxxx93ac8cxx8668xx39xxxx\",\n\"username\": \"jdads\",\n\"password\": \"liuqiangdong2010\",\n\"action\": \"\"\n},\n\"body\": {}\n}";
            string data = JsonConvert.SerializeObject(Login.LoginUser);//JSon序列化我们用到第三方Newtonsoft.Json.dll
            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());
            request.ContentLength = byteData.Length;

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
               
                   JsHelper.AlertAndRedirect("提交成功", "personalInfo.aspx");
            }
            #endregion
        }

        /// <summary>
        /// 解析json数组 每一个数组对象就是一个类实例
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Newtonsoft.Json.Linq.JArray GetToJsonList(string json)
        {
            Newtonsoft.Json.Linq.JArray jsonArr = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(json);
            return jsonArr;
        }
    }
}