using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aww_Sum_10
{
    public partial class AwwSum10 : System.Web.UI.Page
    {
        public static int right_answer = 0;
        public static int wrong_answer = 0;
        public static string[] emoticons = new string[5] { "ʕ•́ᴥ•̀ʔっ", "☜(*▽*)☞", "(ɔ◔‿◔)ɔ ♥", "εїз Ƹ̴Ӂ̴Ʒ Ƹ̵̡Ӝ̵̨̄Ʒ", "ツ" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Random rnd = new Random();
                btn1.Text = rnd.Next(10).ToString();
                btn2.Text = rnd.Next(10).ToString();
                btn3.Text = rnd.Next(10).ToString();
                btn4.Text = rnd.Next(10).ToString();
                btn5.Text = rnd.Next(10).ToString();
                btn6.Text = rnd.Next(10).ToString();
                btn7.Text = rnd.Next(10).ToString();
                btn8.Text = rnd.Next(10).ToString();
                btn9.Text = rnd.Next(10).ToString();
                //digit1.Text = null;
                //digit2.Text = null;
                l1.Text = "";
                l2.Text = "";
                l3.Text = "";
                l4.Text = "";
                l5.Text = "";
                l6.Text = "";
                l7.Text = "";
                l8.Text = "";
                l9.Text = "";
                ////
                lbl_right_answer.Text = "0";
                lbl_wrong_answer.Text = "0";
            }      

        }
        public void clear()
        {
            digit1.Text = "First Number";
            digit2.Text = "Second Number";
            right_answer = 0;
            wrong_answer = 0;
        }
        public int answer_checker()
        {
            if (digit1.Text != "First Number" && digit2.Text != "Second Number")
            {
                if ((Convert.ToInt32(digit1.Text) + Convert.ToInt32(digit2.Text)) == 10)
                {
                    right_answer++;
                    lblresult.Text = "Aww Sum 10";
                    lblresult.ForeColor = System.Drawing.Color.Green;
                    lbl_right_answer.Text = (Convert.ToInt32(lbl_right_answer.Text) + right_answer).ToString();
                    clear();
                    return 1;

                }
                else
                {
                    wrong_answer++;
                    lblresult.Text = "Try again.....";
                    lblresult.ForeColor = System.Drawing.Color.Red;
                    lbl_wrong_answer.Text = (Convert.ToInt32(lbl_wrong_answer.Text)+wrong_answer).ToString();
                    clear();
                    return 0;

                }
            }
            else
                return 0;
        }

        protected void time_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rd = new Random();
            btn1.Text = btn2.Text;
            btn2.Text = btn3.Text;
            btn3.Text = btn4.Text;
            btn4.Text = btn5.Text;
            btn5.Text = btn6.Text;
            btn6.Text = btn7.Text;
            btn7.Text = btn8.Text;
            btn8.Text = btn9.Text;
            l1.Text = l2.Text;
            l2.Text = l3.Text;
            l3.Text = l4.Text;
            l4.Text = l5.Text;
            l5.Text = l6.Text;
            l6.Text = l7.Text;
            l7.Text = l8.Text;
            l8.Text = l9.Text;
            l9.Text = emoticons[rd.Next(emoticons.Length)];
            btn9.Text = rnd.Next(10).ToString();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
           
            if (digit1.Text== "First Number")
            {
                digit1.Text = btn1.Text;
                lbl_last_first_digit.Text = btn1.Text;
            }
            else if(digit1.Text!= "First Number")
            {
                digit2.Text = btn1.Text;
                lbl_last_second_digit.Text = " and " + btn2.Text;
            }

            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn1.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn2.Text;
                lbl_last_first_digit.Text = btn2.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn2.Text;
                lbl_last_second_digit.Text = " and "+btn2.Text;
            }
            
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn2.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn3.Text;
                lbl_last_first_digit.Text = btn3.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn3.Text;
                lbl_last_second_digit.Text = " and "+btn3.Text;
            }
            
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn3.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn4.Text;
                lbl_last_first_digit.Text = btn4.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn4.Text;
                lbl_last_second_digit.Text = " and "+btn4.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn4.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn5.Text;
                lbl_last_first_digit.Text = btn5.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn5.Text;
                lbl_last_second_digit.Text = " and "+btn5.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn5.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn6.Text;
                lbl_last_first_digit.Text = btn6.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn6.Text;
                lbl_last_second_digit.Text = " and " + btn6.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn6.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn7.Text;
                lbl_last_first_digit.Text = btn7.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn7.Text;
                lbl_last_second_digit.Text = " and " + btn7.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn7.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn8.Text;
                lbl_last_first_digit.Text = btn8.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn8.Text;
                lbl_last_second_digit.Text = " and " + btn8.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn8.Text = rnd.Next(10).ToString();
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            if (digit1.Text == "First Number")
            {
                digit1.Text = btn9.Text;
                lbl_last_first_digit.Text = btn9.Text;
            }
            else if (digit1.Text != "First Number")
            {
                digit2.Text = btn9.Text;
                lbl_last_second_digit.Text = " and " + btn9.Text;
            }
            int i;
            i = answer_checker();
            Random rnd = new Random();
            if (i == 1)
            {
                btn9.Text = rnd.Next(10).ToString();
            }
        }
    }
}