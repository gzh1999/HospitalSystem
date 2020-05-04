﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DAL;
using System.Net.Mail;

namespace UI.Controllers
{
    public class UserInfoController : ApiController
    {
        UserInfoDAL dal = new UserInfoDAL();
        [HttpGet]
        public int LoginIf(string zh, string pwd)
        {
            return dal.LoginIf(zh, pwd);
        }
        [HttpGet]
        public UsearInfoModel Fantian(string idd)
        {
            return dal.Fantian(idd);
        }
        [HttpPost]
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddLogin(UsearInfoModel model)
        {
            return dal.AddLogin(model);
        }
        [HttpPost]
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateLog(UsearInfoModel model)
        {
            return dal.UpdateLog(model);
        }
        [HttpGet]
        // 工作台
        public List<Workbench> ShowWork(string Birthdate, string PatientName=null)
        {
            return dal.ShowWork(Birthdate, PatientName);

        }
        ///////////////-----------------------  验证嘛
        public string Mail1(string Txt)
        {
            try
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
                client.Host = "smtp.qq.com";
                //使用安全加密连接。
                client.EnableSsl = true;
                //不和请求一块发送。
                client.UseDefaultCredentials = false;
                //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
                client.Credentials = new NetworkCredential("1664520645@qq.com", "twhzwqpjjpaieebe");

                //发送

                client.Send(mailMessage);

                return yanzheng;
            }
            catch (Exception)
            {

                return "格式不对";

            }


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
        /////////////////////---------------
    }
}
