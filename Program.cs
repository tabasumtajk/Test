using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Open the web browser  /chrome 

IWebDriver driver =  new ChromeDriver ();
//Lauch the Turnup portal url
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
driver.Manage().Window.Maximize();
//identify the User name and ener in to  the textbox

IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
UsernameTextbox.SendKeys("Hari");
//Identify the password and enter in to text box
IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");
//Identify the login button and click
IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
Loginbutton.Click();
//After Login to check user successfull login is done.
IWebElement SuccessfulLogin = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if(SuccessfulLogin.Text == "Hello hari!")
{
    Console.WriteLine("Login successfull");
}
else
{
    Console.WriteLine("Login Failure");
}