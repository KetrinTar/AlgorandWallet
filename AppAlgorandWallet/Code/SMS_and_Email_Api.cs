using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class SMS_and_Email_Api
    {
        public async Task<bool> SMSSend(string number, int key)
        {
            HttpClient http = new HttpClient();
            http.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer M_qclSuNrw_L7HM");
            var url = "https://im.smsclub.mobi/sms/send";
            var request = new RequestSms
            {
                phone = new string[] { number },
                message = $" Your verification code {key} ",
                src_addr = "Shop Zakaz"
            };
            
            var content = JsonConvert.SerializeObject(request);
            var jsoncontent = new StringContent(content, Encoding.UTF8, "application/json");
            var blockJson = await http.PostAsync(url, jsoncontent);
            var response = await blockJson.Content.ReadAsStringAsync();
            var blockDTO = JsonConvert.DeserializeObject<ResponseSend>(response);           
            return true;
        }   
        public async Task<bool> GetStatusSmsCode(string id)
        {
            HttpClient http = new HttpClient();
            http.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer M_qclSuNrw_L7HM");
            var url = "https://im.smsclub.mobi/sms/status";
            
            var req = new Rootobject1
            {
                id_sms = new string[] { id }
            };
            var content = JsonConvert.SerializeObject(req);
            var jsoncontent = new StringContent(content, Encoding.UTF8, "application/json");
            var blockJson = await http.PostAsync(url, jsoncontent);
            var response = await blockJson.Content.ReadAsStringAsync();
            var blockDTO = JsonConvert.DeserializeObject<ResponseSend>(response);
            return true;
        }
        public void SendEmailAsync(string address, int code)
        {
            var subject = "Test";
            var message = $"Hello. Your code is {code}";
            string email = "ketrin.official.00@gmail.com";
            string password = "17032000ketrin";

            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);

            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(address));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(msg);
        }
        public class RequestSms
        {
            public string[] phone { get; set; }
            public string message { get; set; }
            public string src_addr { get; set; }
        }

        public class ResponseSend
        {
            public Success_Request success_request { get; set; }
        }

        public class Success_Request
        {
            public Info info { get; set; }
        }

        public class Info
        {
            public string Id { get; set; }
        }

        public class Rootobject1
        {
            public string[] id_sms { get; set; }
        }

    }
}
