using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lv1威力彩
{

    public partial class Form1 : Form
    {
        List<Label>listLabels = new List<Label>();
        string[] ArrayPrizeNumber = new string[7];     //開獎號碼Array
        int PrizeTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listLabels.Add(lblNo1);   // listLabels[0]
            listLabels.Add(lblNo2);   // listLabels[1]
            listLabels.Add(lblNo3);   // listLabels[2]
            listLabels.Add(lblNo4);   // listLabels[3]
            listLabels.Add(lblNo5);   // listLabels[4]
            listLabels.Add(lblNo6);   // listLabels[5]
            listLabels.Add(lblNo7);   // listLabels[6]
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0 ; i < listLabels.Count - 1 ; i++)
            {
                
                listLabels[i].Text = random.Next(1, 39).ToString();  //取隨機值

                for (int j = 0 ; j < i ; j++)  //依次比對當前數值是否與之前各項重複
                {
                    while (listLabels[j].Text == listLabels[i].Text) //若有重複
                    { //這裡可以用while是因為一旦數值相同，會在while迴圈中改變"listLabels[i].Text"的值，所以不會有無窮迴圈
                        j = 0;                     //給當前數新值後可再重複檢查
                        listLabels[i].Text = random.Next(1, 39).ToString();
                    }
                }
            }
            listLabels[6].Text = random.Next(1, 9).ToString();    //第2區號碼1~8

            int num;
            string str = "", strall = "";
            for (int i = 0; i < listLabels.Count - 1; i++)
            {
                num = Convert.ToInt32(listLabels[i].Text);
                if (num < 10)
                {
                    str = "0" + $"{num.ToString()}" + ",";
                }
                else
                {
                    str = listLabels[i].Text + ",";        //把隨機值List照順序放進ListBox
                }
                strall += str;
            }

            num = Convert.ToInt32(listLabels[6].Text);
            if (num < 10)
            {
                str = "0" + $"{num.ToString()}";
            }
            else
            {
                str = listLabels[6].Text;        //把隨機值List照順序放進ListBox
            }
            strall += str;
            listBoxRandom.Items.Add(strall);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int num;
            string str = "", strall = "";
            for (int i = 0 ; i < listLabels.Count - 1 ; i++)
            {
                num = Convert.ToInt32(listLabels[i].Text);
                if (num < 10)
                {
                    str = "0" + $"{num.ToString()}" + ",";
                }
                else
                {
                    str = listLabels[i].Text + ",";        
                }
                strall += str;
            }

            num = Convert.ToInt32(listLabels[6].Text);
            if (num < 10)
            {
                str = "0" + $"{num.ToString()}";
            }
            else
            {
                str = listLabels[6].Text;       
            }
            strall += str;
            listBox.Items.Add(strall);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndices.Count > 0)
            {                                                                  //從後至前移除
                for (int i = listBox.SelectedIndices.Count - 1 ; i >= 0 ; i--) //i要設為最小到0，因為索引值最小到0
                {                                                              //設為listBox.SelectedIndices.Count-1是因為會比所選數量多一個
                    listBox.Items.RemoveAt(listBox.SelectedIndices[i]);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string strInfo = "";

            if (listBox.Items.Count > 0)
            {
                strInfo = "***** 觸霉頭彩券行 第987期 *****\n====================\n";
                strInfo += $"簽注時間{DateTime.Now}\n";
                strInfo += "-------------------------\n";

                foreach (string str in listBox.Items)
                {
                    strInfo += $"{str}\n";
                }

                strInfo += "-------------------------\n";
                strInfo += "謝謝光臨, 賠錢愉快";
            }
            else
            {
                strInfo += "請加入簽單號碼";
            }
            MessageBox.Show(strInfo);
        }

        private void btnPrizeNumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < ArrayPrizeNumber.Length - 1; i++)
            {
                ArrayPrizeNumber[i] = random.Next(1, 39).ToString();  //取隨機值

                for (int j = 0; j < i; j++)  //依次比對當前數值是否與之前各項重複
                {
                    while (ArrayPrizeNumber[j] == ArrayPrizeNumber[i]) //若有重複
                    {
                        j = 0;                     //給當前數新值後可再重複檢查
                        ArrayPrizeNumber[i] = random.Next(1, 39).ToString();
                    }
                }
            }
            ArrayPrizeNumber[6] = random.Next(1, 9).ToString();    //第2區號碼1~8
            string PrizeNumber = "";
            for (int i = 0; i < ArrayPrizeNumber.Length - 1 ; i++)
            {
                PrizeNumber += ArrayPrizeNumber[i] + ",";
            }
            PrizeNumber += ArrayPrizeNumber[6];
            lblPrizeNumber.Text = PrizeNumber;
        }

        void 單一對獎()
        {
            if (lblPrizeNumber.Text != "0" && lblNo7.Text != "0")
            {
                int same1 = 0;       //前六個數字相同的有幾個
                bool same2 = false;  //最後一數是否相同
                string prize = "";

                // List<string> 兌獎List = new List<string>(ArrayPrizeNumber);
                // test.Text = 兌獎List[6];
                /* string c = "";
                 foreach (string a in ArrayPrizeNumber)
                 {
                     c += a + ",";
                 }
                 test.Text = c;*/

                List<string> 兌獎List = new List<string>(ArrayPrizeNumber);  //將Array變成List

                if (兌獎List[6] == listLabels[6].Text)  //已確認
                {
                    same2 = true;
                }

                for (int i = 0; i < listLabels.Count - 1; i++)  //比較前6數
                {
                    for (int j = 0; j < 兌獎List.Count - 1; j++)  //比對"兌獎List[]"當前數值是否與之前listLabels的各項重複
                    {
                        if (兌獎List[j] == listLabels[i].Text) //若有重複  //不能用while，因為while迴圈中並沒有改變兩比較之值，所以會無窮迴圈
                        {
                            same1++;                     //相同值的數量
                        }
                    }
                }

                if (same1 == 6 && same2 == true)
                {
                    prize = "頭獎！獎金89000000$";
                    PrizeTotal += 89000000;
                }
                else if (same1 == 6 && same2 == false)
                {
                    prize = "貳獎！獎金11000000$";
                    PrizeTotal += 11000000;
                }
                else if (same1 == 5 && same2 == true)
                {
                    prize = "參獎！獎金15000$";
                    PrizeTotal += 15000;
                }
                else if (same1 == 5 && same2 == false)
                {
                    prize = "肆獎！獎金20000$";
                    PrizeTotal += 20000;
                }
                else if (same1 == 4 && same2 == true)
                {
                    prize = "伍獎！獎金4000$";
                    PrizeTotal += 4000;
                }
                else if (same1 == 4 && same2 == false)
                {
                    prize = "陸獎！獎金800$";
                    PrizeTotal += 800;
                }
                else if (same1 == 3 && same2 == true)
                {
                    prize = "柒獎！獎金400$";
                    PrizeTotal += 400;
                }
                else if (same1 == 2 && same2 == true)
                {
                    prize = "捌獎！獎金200$";
                    PrizeTotal += 200;
                }
                else if (same1 == 3 && same2 == false)
                {
                    prize = "玖獎！獎金100";
                    PrizeTotal += 100;
                }
                else if (same1 == 1 && same2 == true)
                {
                    prize = "普獎！獎金100$";
                    PrizeTotal += 100;
                }
                else
                {
                    prize = "水啦！賠到脫褲嘍";
                }
                MessageBox.Show(prize);
                lblPrizeTotal.Text = $"總累積獎金為{Convert.ToString(PrizeTotal)}";

                int num;
                string str = "", strall = "";
                for (int i = 0; i < listLabels.Count - 1; i++)
                {
                    num = Convert.ToInt32(listLabels[i].Text);
                    if (num < 10)
                    {
                        str = "0" + $"{num.ToString()}" + ",";
                    }
                    else
                    {
                        str = listLabels[i].Text + ",";
                    }
                    strall += str;
                }

                num = Convert.ToInt32(listLabels[6].Text);
                if (num < 10)
                {
                    str = "0" + $"{num.ToString()}";
                }
                else
                {
                    str = listLabels[6].Text;
                }
                strall += str;

                string str2 = $"兌獎號碼:\"{strall}\" , 開獎結果:{prize}\n";
                listBoxHistory.Items.Add(str2);
            }
            else if (lblPrizeNumber.Text == "0" && lblNo7.Text == "0")
            {
                MessageBox.Show("大哥啊~不但沒開獎號碼也沒有兌獎號碼啊！");
            }
            else if (lblPrizeNumber.Text == "0" && lblNo7.Text != "0")
            {
                MessageBox.Show("大哥啊~沒開獎號碼啊！");
            }
            else if (lblPrizeNumber.Text != "0" && lblNo7.Text == "0")
            {
                MessageBox.Show("大哥啊~沒兌獎號碼啊！");
            }

        }

        private void btn對獎_Click(object sender, EventArgs e)
        {
            單一對獎();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string strall = "";
            if (lblPrizeNumber.Text != "0" && listBox.Items.Count > 0)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    string listbox = listBox.Items[i].ToString();
                    string[] listboxArray = listbox.Split(',');
                    int[] intArray = listboxArray.Select(a => int.Parse(a)).ToArray(); //將string[]轉換成int[]

                    int same1 = 0;       //前六個數字相同的有幾個
                    bool same2 = false;  //最後一數是否相同
                    string prize = "";

                    int[] intArrayPrizeNumber = ArrayPrizeNumber.Select(a => int.Parse(a)).ToArray(); //將string[]轉換成int[]


                    if (intArrayPrizeNumber[6] == intArray[6])  //已確認
                    {
                        same2 = true;
                    }

                    for (int k = 0; k < listLabels.Count - 1; k++)  //比較前6數
                    {
                        for (int j = 0; j < intArrayPrizeNumber.Length - 1; j++)
                        {
                            if (intArrayPrizeNumber[j] == intArray[k]) //若有重複  //不能用while，因為while迴圈中並沒有改變兩比較之值，所以會無窮迴圈
                            {
                                same1++;                     //相同值的數量
                            }
                        }
                    }

                    if (same1 == 6 && same2 == true)
                    {
                        prize = "頭獎！獎金89000000$";
                        PrizeTotal += 89000000;
                    }
                    else if (same1 == 6 && same2 == false)
                    {
                        prize = "貳獎！獎金11000000$";
                        PrizeTotal += 11000000;
                    }
                    else if (same1 == 5 && same2 == true)
                    {
                        prize = "參獎！獎金15000$";
                        PrizeTotal += 15000;
                    }
                    else if (same1 == 5 && same2 == false)
                    {
                        prize = "肆獎！獎金20000$";
                        PrizeTotal += 20000;
                    }
                    else if (same1 == 4 && same2 == true)
                    {
                        prize = "伍獎！獎金4000$";
                        PrizeTotal += 4000;
                    }
                    else if (same1 == 4 && same2 == false)
                    {
                        prize = "陸獎！獎金800$";
                        PrizeTotal += 800;
                    }
                    else if (same1 == 3 && same2 == true)
                    {
                        prize = "柒獎！獎金400$";
                        PrizeTotal += 400;
                    }
                    else if (same1 == 2 && same2 == true)
                    {
                        prize = "捌獎！獎金200$";
                        PrizeTotal += 200;
                    }
                    else if (same1 == 3 && same2 == false)
                    {
                        prize = "玖獎！獎金100";
                        PrizeTotal += 100;
                    }
                    else if (same1 == 1 && same2 == true)
                    {
                        prize = "普獎！獎金100$";
                        PrizeTotal += 100;
                    }
                    else
                    {
                        prize = "水啦！賠到脫褲嘍";
                    }
                    string str = $"第{i + 1}筆開獎結果:{prize}\n";
                    strall += str;
                    string str2 = $"兌獎號碼:\"{listbox}\" , 開獎結果:{prize}\n";
                    listBoxHistory.Items.Add(str2);
                    //foreach (int j in intArray)
                    //{
                    //    Console.WriteLine(j);
                    //    Console.WriteLine(j.GetType());
                    //}
                    //foreach (string str in listboxArray)
                    //{
                    //    Console.WriteLine(str);
                    //}
                    //Console.WriteLine(listBox.Items[i]);
                    //Console.WriteLine((listBox.Items[i]).GetType());
                }
                MessageBox.Show(strall);
                lblPrizeTotal.Text = $"總累積獎金為{Convert.ToString(PrizeTotal)}";
            }
            else if (listBox.Items.Count == 0 && lblPrizeNumber.Text == "0")
            {
                MessageBox.Show("大哥啊~不但沒開獎號碼，左欄位也沒兌獎號碼啊！");
            }
            else if (listBox.Items.Count > 0 && lblPrizeNumber.Text == "0")
            {
                MessageBox.Show("大哥啊~沒開獎號碼啊！");
            }
            else if (listBox.Items.Count == 0 && lblPrizeNumber.Text != "0")
            {
                MessageBox.Show("大哥啊~左欄位沒兌獎號碼啊！");
            }
        }
    }
}
