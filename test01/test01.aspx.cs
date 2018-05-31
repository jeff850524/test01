using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test01
{
    public partial class test01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            var UserId = "Uac8806571d495b1f45a8d06aa5c36c6f";
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("6OSXqt9Xih7+TySg8Etv2kMADdgH/ZnPygjc1LwsgYi1QlHRQMMZwQDSAwJKkJyD0myJe49Ld3LSonbyEUv6NbsS9iSDLVC9HrGxfPr3hbGV2Nr2XOgLEuV9NGKS4TO2kpf124dbRuVymqif7Euc4QdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage(UserId, "text00000");
            bot.PushMessage(UserId, 4, 299);
            bot.PushMessage(UserId, new Uri("https://lh3.googleusercontent.com/958OXI6Dxhgp_dv_0tN7gthEm0DyxJ9i0eVXzNW7nKCtODhYxSaigMtTNRKKMPKTzdyFHDepNcC8Mo-jgLMmoAAQuTBBFpSasA=w1600-rj"));
        }
    }
}