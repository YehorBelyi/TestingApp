using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.RegistrationForms
{
    public class SmtpSender
    {
        MailMessage m;
        public static SmtpClient smcl;

        string _host, _port;
        string _sender;
        string _reciever;
        string _subject;
        string _body;
        string _password;
        bool _isSsl;

        Register _form;

        public SmtpSender(MailData maildata)
        {
            _form = maildata.form;
            _host = maildata.host;
            _port = maildata.port;
            _sender = maildata.sender;
            _reciever = maildata.reciever;
            _subject = maildata.subject;
            _body = maildata.body;
            _password = maildata.password;
            _isSsl = maildata.isSsl;
        }
        public void SendMessage()
        {
            _form.button1.Enabled = false;
            try
            {
                m = new MailMessage(_sender, _reciever);
                m.Subject = _subject;
                m.Body = _body;
                smcl = new SmtpClient(_host);
                smcl.Credentials = new NetworkCredential(_sender, _password);
                smcl.EnableSsl = _isSsl;
                smcl.Port = int.Parse(_port);

                // Set the method that is called back when the send operation ends.
                smcl.SendCompleted += SendCompletedCallback;

                try
                {
                    string userState = "Sending message";
                    smcl.SendAsync(m, userState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelSendMessage()
        {
            smcl.SendAsyncCancel();
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                MessageBox.Show("Sending is canceled" + token, "Attention");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(token + " " + e.Error.ToString(), "Attention");
            }

            _form.button1.Enabled = true;
            _form.smtp = null;
        }
    }
}