using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multicoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Multi En/De Coder Made By PapillonKHW";
        }

        /*  base 64 함수 시작             */
        public static string base64en(string str) 
        {
        byte[] Keyword= System.Text.Encoding.UTF8.GetBytes(str);
        return Convert.ToBase64String(Keyword);
        
        }
        public static string base64de(string str)
        {
            byte[] Keyword = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(Keyword);
        }
        /*  base 64 함수 끝              */
        
        /*               아스키 코드   시작 */   
       
        /*public static string asciien(string str)
        {
            ASCIIEncoding keyto = new ASCIIEncoding();
            string key = keyto.GetString(str);
           return (key);
        }
        public static string asciide(int key)
        {
            char keyfrom = Convert.ToChar(key);
            return keyfrom.ToString();
        }
        */


             /*          아스키 코드   끝   */
        
        /*         10진 to 2진 , 2진 to 10진  시작                     */
       /* public static int decitobin(int num)
        {
            
        
        
        
        }
        
        public static int bintodeci(int num)
        {
            
        
        
        
        }
        */


        /*         10진 to 2진 , 2진 to 10진  끝                      */



        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void base64e_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.ToString();
            string keyto;
            keyto = base64en(key);
            textBox1.Text = keyto;

        }

        private void base64d_Click(object sender, EventArgs e)
        {
            string keyfrom = textBox1.Text.ToString();
            string key;
            key = base64de(keyfrom);
            textBox1.Text = key;
        }

        private void asciie_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void asciid_Click(object sender, EventArgs e)
        {
            

        }

        private void asciistr_TextChanged(object sender, EventArgs e)
        {

        }

        private void asciiint_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
