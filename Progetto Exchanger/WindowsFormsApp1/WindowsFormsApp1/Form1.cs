using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace BasicChangeCurrencies
{
    public partial class Form1 : Form
    {
        
        public DateTime dataInput = DateTime.Now;
        
        public Form1()
        {
            Text = "urrencies Exchange";
            InitializeComponent();
            comboFromCur.Items.AddRange(CryptoCoins);
            comboToCur.Items.AddRange(FiatCoins);
        }

        private void ButtonCalc(object sender, EventArgs e)
        {
            try
            {
                if (selectFiat.Checked)
                {
                    rate.Text = WebServer.GetConversionRate(comboFromCur.Text, comboToCur.Text, dataInput);
                    result.Text = WebServer.GetConversionAmount(comboFromCur.Text, comboToCur.Text, dataInput, amount.Text.Replace(",", "."));
                }
                else
                {
                    if (selectIco.Checked)
                    {
                        rate.Text = WebServer.GetConversionRate(comboFromCur.Text, comboToCur.Text);
                        result.Text = WebServer.CalculateIcoChange(Convert.ToDouble(amount.Text.Replace(".", ",")), rate.Text);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error invalid input", "Convert currencies", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ButtonReload(object sender, EventArgs e)
        {
            try
            {
                if (comboFromCur.Text != null && comboToCur.Text != null)
                {
                    if (selectFiat.Checked == true)
                    {
                        rate.Text = WebServer.GetConversionRate(comboFromCur.Text, comboToCur.Text, dataInput);   // OBTAIN FIAT CHANGE 
                    }
                    else
                    {
                        rate.Text = WebServer.GetConversionRate(comboFromCur.Text, comboToCur.Text);       // OBTAIN ICO CHANGE  (USD to ICO)
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error currencies not valid", "Convert currencies", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Net.WebException)
            {
                rate.Text = "Error!! Currencies not valid or there is no connection";
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value > DateTime.Now) 
                {
                    throw new ArgumentException();
                }
                else
                {
                    dataInput = dateTimePicker1.Value;
                }
            }
            catch (ArgumentException)
            {
                dataInput = DateTime.Now;
                MessageBox.Show("You cant go in the future!!");
            }
        }

        private void ButtonSetToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }

        private void selectIco_CheckedChanged(object sender, EventArgs e)
        {
            comboToCur.Text = "EUR";
            comboFromCur.Text = "bitcoin";
            groupBox2.Enabled = false;
            comboFromCur.Items.Clear();
            comboFromCur.Items.AddRange(CryptoCoins);
        }

        private void selectFiat_CheckedChanged(object sender, EventArgs e)
        {
            comboToCur.Enabled = true;
            groupBox2.Enabled = true;
            comboFromCur.Text = "USD";
            comboToCur.Items.Clear();
            comboToCur.Items.AddRange(FiatCoins);
            comboFromCur.Items.Clear();
            comboFromCur.Items.AddRange(FiatCoins);
        }
        
    }

    public class WebServer
    {
        public static WebClient WebExchange = new WebClient();
        public static string format = "MM/dd/yyyy";

        /// FROM CURRENCY CONVERTER.KOWABUNG.NET
        public static string GetConversionRate(string fCur, string toCur, DateTime data)
        {
            string urlPattern = "http://currencyconverter.kowabunga.net/converter.asmx/GetConversionRate?CurrencyFrom={0}&CurrencyTo={1}&RateDate={2}";
            string date = data.ToString(format);
            string response = Regex.Replace(WebExchange.DownloadString(string.Format(urlPattern, fCur, toCur, date)), "<.*?>", String.Empty).Remove(0, 2);
            return response;
        }
        public static string GetConversionAmount(string fCur, string toCur, DateTime data, string amount)
        {
            string urlPattern = "http://currencyconverter.kowabunga.net/converter.asmx/GetConversionAmount?CurrencyFrom={0}&CurrencyTo={1}&RateDate={2}&Amount={3}";
            string date = data.ToString(format);
            string response = Regex.Replace(WebExchange.DownloadString(string.Format(urlPattern, fCur, toCur, date, amount)), "<.*?>", String.Empty).Remove(0, 2).Replace('.', ',');
            return response;
        }

        //FROM COINMARKET.COM
        public static string GetConversionRate(string FromCur, string ToCur)
        {
            string response;
            char[] arCharSep = new char[] { ' ', ',' };
            string urlPattern = "https://api.coinmarketcap.com/v1/ticker/{0}/?convert=EUR";
            string text = WebExchange.DownloadString(string.Format(urlPattern, FromCur, ToCur));
            string[] segment = text.Split(arCharSep, StringSplitOptions.RemoveEmptyEntries);
            if(ToCur== "EUR")
            response = segment[48].Replace("\"", "").Replace(".", ",");
            else
                response = segment[15].Replace("\"", "").Replace(".", ",");
            return response;
        }
        //public static double GetConversioRate(string toCur, int amount)
        public static string CalculateIcoChange(double amount, string rate)
        {
            string s = Convert.ToString(amount * Convert.ToDouble(rate.Replace(".", ",")));
            return string.Concat(s, "€");
        }

    }
}
