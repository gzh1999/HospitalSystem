using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.SessionState;

namespace UI
{
    /// <summary>
    /// ValidateCode1 的摘要说明
    /// </summary>
    public class ValidateCode1 : IHttpHandler, IRequiresSessionState
    {
        /// <summary>  
        /// 验证码类型(0-字母数字混合,1-数字,2-字母)  
        /// </summary>  
        private string validateCodeType = "0";
        /// <summary>  
        /// 验证码字符个数  
        /// </summary>  
        private int validateCodeCount = 4;
        /// <summary>  
        /// 验证码的字符集，去掉了一些容易混淆的字符  
        /// </summary>  
        char[] character = { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 
'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };  

        public void ProcessRequest(HttpContext context)
        {
            context.Response.BufferOutput = true;
            context.Response.Cache.SetExpires(DateTime.Now.AddMilliseconds(-1));
            context.Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            context.Response.AppendHeader("Pragma", "No-Cache");
            //获取设置参数  
            if (!string.IsNullOrEmpty(context.Request.QueryString["validateCodeType"]))
            {
                validateCodeType = context.Request.QueryString["validateCodeType"];
            }
            if (!string.IsNullOrEmpty(context.Request.QueryString["validateCodeCount"]))
            {
                int.TryParse(context.Request.QueryString["validateCodeCount"], out validateCodeCount);
            }
            //生成验证码  
            this.CreateCheckCodeImage(GenerateCheckCode(context), context);
        }

        private string GenerateCheckCode(HttpContext context)
        {
            char code;
            string checkCode = String.Empty;
            System.Random random = new Random();

            for (int i = 0; i < validateCodeCount; i++)
            {
                code = character[random.Next(character.Length)];

                // 要求全为数字或字母  
                if (validateCodeType == "1")
                {
                    if ((int)code < 48 || (int)code > 57)
                    {
                        i--;
                        continue;
                    }
                }
                else if (validateCodeType == "2")
                {
                    if ((int)code < 65 || (int)code > 90)
                    {
                        i--;
                        continue;
                    }
                }
                checkCode += code;
            }
            
            context.Response.Cookies.Add(new System.Web.HttpCookie("CheckCode", checkCode));
            context.Session.Add("CheckCode",checkCode);
            return checkCode;
        }

        private void CreateCheckCodeImage(string checkCode, HttpContext context)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;

            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling

        ((checkCode.Length * 15.0 + 40)), 23);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);

            try
            {
                //生成随机生成器  
                Random random = new Random();

                //清空图片背景色  
                g.Clear(System.Drawing.Color.White);

                //画图片的背景噪音线  
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);

                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Silver), x1, y1, x2,

        y2);
                }

                System.Drawing.Font font = new System.Drawing.Font("Arial", 14,

        (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new

        System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0,

        image.Width, image.Height), System.Drawing.Color.Blue, System.Drawing.Color.DarkRed, 1.2f,

        true);

                int cySpace = 16;
                for (int i = 0; i < validateCodeCount; i++)
                {
                    g.DrawString(checkCode.Substring(i, 1), font, brush, (i + 1) * cySpace, 1);
                }

                //画图片的前景噪音点  
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);

                    image.SetPixel(x, y, System.Drawing.Color.FromArgb(random.Next()));
                }

                //画图片的边框线  
                g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Silver), 0, 0,

        image.Width - 1, image.Height - 1);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                context.Response.ClearContent();
                context.Response.ContentType = "image/Gif";
                context.Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }  

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public string Mail1(string Txt)
        {
            int n = 1;
            string yanzheng = string.Empty;
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress("1664520645@qq.com");
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(Txt));
            //邮件标题。
            mailMessage.Subject = "这是你的验证码";
            string verificationcode = createrandom(6);
            yanzheng = verificationcode;
            //邮件内容。
            mailMessage.Body = "你的验证码是" + verificationcode;
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.163.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            client.Credentials = new NetworkCredential("发件人邮箱" , "邮箱授权码");
           
            //发送

            client.Send(mailMessage);
            return yanzheng;

        }
        //生成6位数字和大写字母的验证码
        private string createrandom(int codelengh)
        {
            int rep = 0;
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < codelengh; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }
    }
}