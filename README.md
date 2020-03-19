# NaverAutoLogin


```c

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaverAutoLogin
{
    public partial class brandNameLabel : Form
    {
        IWebDriver driver;
        string url = "https://www.naver.com/";
        TimeSpan ts;

        public brandNameLabel()
        {
            InitializeComponent();
            ts = serverTime();
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void mCroStart_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {            
                ChromeOptions option = new ChromeOptions();
                //option.AddUserProfilePreference("profile.default_content_setting_values.images", 2); //이미지 끄고 로드 옵션
                driver = new ChromeDriver(option);
                autoMacro();
                if(!isElementPresent())
                {
                    MessageBox.Show("로그인 성공", "성공!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("로그인 실패", "실패!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }

        }
        private void autoMacro()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                driver.Navigate().GoToUrl("https://www.naver.com/");
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='account']/div/a"))); //로그인버튼 로드 확인
                driver.FindElement(By.XPath("//*[@id='account']/div/a")).Click(); //로그인 버튼 클릭
                loginWindowHandle();
            }
            catch (Exception e2)
            {
                MessageBox.Show("오류발생", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(e2.Message);
            }

        }

        private void login_pwdC_Validating(object sender, CancelEventArgs e) //유효성 검사
        {
            if (String.IsNullOrEmpty(login_pwdC.Text))
            {
                e.Cancel = true;
                if (!(String.IsNullOrEmpty(login_idC.Text)))
                {
                    login_pwdC.Focus();
                }
                errorProvider2.SetError(login_pwdC, "비밀번호 입력하세요!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(login_pwdC, null);
            }
        }
        private void login_idC_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(login_idC.Text))
            {
                e.Cancel = true;
                login_idC.Focus();
                errorProvider1.SetError(login_idC, "아이디 입력하세요!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(login_idC, null);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                driver.Close();
                driver.Quit();
                Close();
            }
            catch (Exception e1)
            {
                Close();
            }

        }
        //서버 시간 계산
        private TimeSpan serverTime()
        {
            System.Net.HttpWebRequest wReqFirst = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            DateTime dtBefor = DateTime.Now;
            System.Net.HttpWebResponse wRespFirst = (System.Net.HttpWebResponse)wReqFirst.GetResponse();
            DateTime dtAfter = DateTime.Now;
            DateTime dtNosp = Convert.ToDateTime(wRespFirst.Headers["Date"].ToString());
            dtNosp = dtNosp.AddTicks(dtAfter.Ticks - dtBefor.Ticks);
            var minDate = dtNosp.Subtract(DateTime.Now);
            return minDate;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.Add(ts);
            serverT.Text = answer.ToString();
        }


        private void loginWindowHandle() // 로그인
        {
            var id_context = driver.FindElement(By.XPath("//*[@id='id']"));
            var pw_context = driver.FindElement(By.XPath("//*[@id='pw']"));
            id_context.Click();
            Clipboard.SetText(login_idC.Text);
            id_context.SendKeys(OpenQA.Selenium.Keys.Control + 'v');
            id_context.SendKeys(OpenQA.Selenium.Keys.Tab);
            pw_context.Click();
            Clipboard.SetText(login_pwdC.Text);
            pw_context.SendKeys(OpenQA.Selenium.Keys.Control + 'v');
            pw_context.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        private void modalLoginWindowHandle() //모달창 로그인
        {
            var existingWindowHandle = driver.CurrentWindowHandle;
            string popupHandle = string.Empty;
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;

            foreach (string handle in windowHandles)
            {
                if (handle != existingWindowHandle)
                {
                    popupHandle = handle; break;
                }
            }
            driver.SwitchTo().Window(popupHandle);
            var id_context = driver.FindElement(By.XPath("//*[@id='id']"));
            var pw_context = driver.FindElement(By.XPath("//*[@id='pw']"));
            id_context.Click();
            Clipboard.SetText(login_idC.Text);
            id_context.SendKeys(OpenQA.Selenium.Keys.Control+ 'v');
            id_context.SendKeys(OpenQA.Selenium.Keys.Tab);
            pw_context.Click();
            Clipboard.SetText(login_pwdC.Text);
            pw_context.SendKeys(OpenQA.Selenium.Keys.Control + 'v');
            pw_context.SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.SwitchTo().Window(existingWindowHandle);
        }

        private bool isElementPresent()
        {
            List<IWebElement> elementList = new List<IWebElement>();
            Delay(1500);
            elementList.AddRange(driver.FindElements(By.XPath("//*[@id='frmNIDLogin']/fieldset")));
            Console.WriteLine("카운트 :" + elementList.Count);
            if (elementList.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }

        }

        private DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

    }
}


```



> 'First Upload' -CHB-


