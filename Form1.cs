using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace İnstaTakiptenÇıkart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver = null;
        private void button1_Click(object sender, EventArgs e)
        {

                for (int i = 0; i < islem; i++)
                {
                        ((IJavaScriptExecutor)this.driver).ExecuteScript("var inputs = document.getElementsByClassName('_0mzm- sqdOP  L3NKy   _8A5w5    '); inputs[" + i + "].click();", Array.Empty<object>());
                    driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[1]")).Click();
                  
                    try
                    {
                        Thread.Sleep(0x3e8);
                        IJavaScriptExecutor driver = (IJavaScriptExecutor)this.driver;
                        driver.ExecuteScript("window.scrollBy(0,100)", Array.Empty<object>());
                        driver.ExecuteScript("window.scrollBy(0,-75)", Array.Empty<object>());
                    }
                    catch (Exception)
                    {
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.ilkmesj==0)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                Properties.Settings.Default.ilkmesj++;
                Properties.Settings.Default.Save();
            }
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--window-size=250,700");
            option.EnableMobileEmulation("Galaxy S5");
            driver = new ChromeDriver(service, option);
            driver.Url = "https://www.instagram.com/accounts/login/";

            //driver.FindElement(By.Name("username")).SendKeys("mustafadgr38@gmail.com");
            //driver.FindElement(By.Name("password")).SendKeys("mustafadgr38**"+ OpenQA.Selenium.Keys.Enter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                   try
                    {
                for (int i = 0; i < islem; i++)
                {
                        ((IJavaScriptExecutor)this.driver).ExecuteScript("var inputs = document.getElementsByClassName('_0mzm- sqdOP  L3NKy       '); inputs[" + i + "].click();", Array.Empty<object>());
                    Thread.Sleep(1000);
                    //driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[1]")).Click();
                    //((IJavaScriptExecutor)this.driver).ExecuteScript("var inputs2 = document.getElementsByClassName('aOOlW -Cab_   ').click(); for(var i=0; i<inputs.length;i++) { inputs[i].click();}", Array.Empty<object>());
                    try
                    {
                        Thread.Sleep(0x3e8);
                        IJavaScriptExecutor driver = (IJavaScriptExecutor)this.driver;
                        driver.ExecuteScript("window.scrollBy(0,100)", Array.Empty<object>());
                        driver.ExecuteScript("window.scrollBy(0,-50)", Array.Empty<object>());
                    }
                    catch (Exception)
                    {
                    }
                }
            }
                    catch (Exception)
                    {
                    }
                
        }
        int islem = 50;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            islem = int.Parse(textBox1.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {

                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {


            }
        }
    }
    }
