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

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon { label = "標題-文字回覆", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriActon() { label = "標題-開啟URL", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackActon() { label = "標題-發生postack", data = "abc=aaa&def=111" });

            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://n6.cmsfile.pg0.cn/group1/M00/06/2F/Cgqg2FWcb-eANjr-AARBy8VOjp8861.jpg"),
                actions = actions
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageActon { label = "No", text = "No" });


            var ConfirmTemplateMsg = new isRock.LineBot.ConfirmTemplate()
            {
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                actions = actions
            };
            bot.PushMessage(AdminUserId, ConfirmTemplateMsg);
        }
    }
}