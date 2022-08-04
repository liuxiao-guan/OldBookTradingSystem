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
using Utility;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;

namespace WebRestClient
{
    public partial class Login : System.Web.UI.Page
    {
        public static User LoginUser = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 注册新账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SignUp(object sender, EventArgs e)
        {
            #region 注册新账户
            User user = new User();
            user.Uid = long.Parse(newuid.Value.ToString());
            user.Name = newuser.Value.ToString();
            user.Password = newpass.Value.ToString();
            user.Tel = newtel.Value.ToString();
            user.Address = newaddress.Value.ToString();
            string url = "http://10.135.1.142:89/api/user";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            //string data = "{\n\"header\": {\n\"token\": \"30xxx6aaxxx93ac8cxx8668xx39xxxx\",\n\"username\": \"jdads\",\n\"password\": \"liuqiangdong2010\",\n\"action\": \"\"\n},\n\"body\": {}\n}";
            string data = JsonConvert.SerializeObject(user);//JSon序列化我们用到第三方Newtonsoft.Json.dll
            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());
            request.ContentLength = byteData.Length;

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());

                JObject UserInfo = JObject.Parse(reader.ReadToEnd());

                string UserId = UserInfo["Id"].ToString();
                string message = string.Format("注册新账号{0}成功", UserId);
                JsHelper.AlertAndRedirect(message, "Login.aspx");
                //Console.WriteLine(reader.ReadToEnd());
                //newpost.Value = reader.ReadToEnd();


            }
            #endregion
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SignIn(object sender, EventArgs e)
        {
            #region Get新账户
            string UserId = id.Value;
            string baseurl = "http://10.135.1.142:89/api/user/";
            string url = baseurl + UserId;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

            // Get response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Console application output
                //Console.WriteLine(reader.ReadToEnd());
                try
                {
                    JObject UserInfo = JObject.Parse(reader.ReadToEnd());
                    if (UserInfo["Password"].ToString() == password.Value)
                    {

                        LoginUser.Id = long.Parse(UserInfo["Id"].ToString());
                        LoginUser.Name = UserInfo["Name"].ToString();
                        LoginUser.Address = UserInfo["Address"].ToString();
                        LoginUser.Tel = UserInfo["Tel"].ToString();
                        LoginUser.Password = UserInfo["Password"].ToString();
                        LoginUser.Uid = long.Parse(UserInfo["Uid"].ToString());

                        JsHelper.Redirect("index.aspx");
                    }
                    else
                    {
                        JsHelper.AlertAndRedirect("账号密码错误，请重新输入", "Login.aspx");
                    }
                }catch
                {
                    JsHelper.AlertAndRedirect("用户可能不存在", "Login.aspx");
                }
                

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
        /// <summary>
        /// 将json转为对象实例
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object JsonToObject(string jsonString, object obj)

        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());

            MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

            return serializer.ReadObject(mStream);

        }
    }
}