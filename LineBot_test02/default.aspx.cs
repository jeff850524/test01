using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot_test02
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "zKLBi+Ep+GUkHQm2C1QrkwdRz9T/6s/fA49t/lLG9eJ04rCGmpeq5WoG8F4ABQVWyeutDywqtfgB0DkhNP7AsC0/chhz2gEqg0SGa1R2sJ3GVHQUUsvT4NbNag5MQPToWXzh52w5sm7i7/GmHOoTqAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Uac8806571d495b1f45a8d06aa5c36c6f";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}