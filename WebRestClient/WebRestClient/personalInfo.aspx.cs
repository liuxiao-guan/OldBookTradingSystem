using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;

namespace WebRestClient
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //此处很繁琐 可能会有更好的方法
            id.InnerText = Login.LoginUser.Id.ToString();
            uid.InnerText = Login.LoginUser.Uid.ToString();
            name.InnerText = Login.LoginUser.Name.ToString();
            password.InnerText = Login.LoginUser.Password.ToString();
            tel.InnerText = Login.LoginUser.Tel.ToString();
            address.InnerText = Login.LoginUser.Address.ToString();
        }
      
        protected void DeleteUser(object sender, EventArgs e)
        {
            string Userid = id.InnerText;
            string baseurl = "http://10.135.1.142:89/api/user/";
            string url = baseurl + Userid;
          
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "DELETE";
            //request.
            // Get response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream 得到删除改用户的所有信息
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Console application output
                //Console.WriteLine(reader.ReadToEnd());
                address.InnerText = reader.ReadToEnd();
                JsHelper.AlertAndRedirect("账户删除成功", "Login.aspx");
            }
        }
    }
}