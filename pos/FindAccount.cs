using pos.classes;
using pos.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class FindAccount : Form
    {
        string email;
        string otp;
        bool otpMode = false;

        string[] TITLE = { "FIND YOUR ACCOUNT", "SENT AN OTP" };
        string[] CAPTION = { "Please enter your email.", "Please check your email for a message with your OTP. Your code is 4 numbers long." };
        string[] HEADER = { "Email:", "OTP:" };
        public FindAccount()
        {
            InitializeComponent();
            lblTitle.Text = TITLE[0];
            lblCaption.Text = CAPTION[0];
            lblTitle.Text = HEADER[0];
        }

        // Generates a 6-digit OTP
        public static string GenerateOTP()
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999); // Generates a random number between 100000 and 999999
            return otp.ToString();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string toEmail = txtInput.Text;
            if (otpMode == false)
            {
                // Validate the email address
                if (IsValidEmail(toEmail))
                {
                    if (!new Account().CheckEmailIfExist(toEmail))
                    {
                        MessageBox.Show("Email Not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    otp = GenerateOTP();
                    string subject = "OTP Password";
                    string body = string.Format("<h1>{0}</h1><p>This is an OTP password!</p>", otp);
                    string fromEmail = "emailtransactionsofficial@gmail.com";
                    string fromPassword = "cmou rksu xwwo curd"; // Use a secure way to store and access the password

                    if (EmailSender.SendGmail(toEmail, subject, body, fromEmail, fromPassword))
                    {
                        lblTitle.Text = TITLE[1];
                        lblCaption.Text = CAPTION[1];
                        lblTitle.Text = HEADER[1];
                        txtInput.Clear();
                        txtInput.Focus();
                        otpMode = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email address!");
                    txtInput.Focus();
                    txtInput.SelectAll();
                }
            }
            else
            {
                if (txtInput.Text != otp.ToString())
                {
                    MessageBox.Show("Incorrect OTP!");
                }
                else
                {
                    COMMON.route = new ForgotPassword(toEmail);
                }
            }
        }

        private void FindAccount_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            COMMON.route = new CashierLogin();
        }
    }
}
