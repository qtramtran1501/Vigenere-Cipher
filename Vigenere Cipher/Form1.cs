using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //encryption function

        public class Vigernere
        {
            #region property
            public string key { get; set; }
            public string plainText { get; set; }
            public string cipherText {get; set; }
            #endregion


            string chuoi = @" !”#$%&’()*+,-/0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]Ỳ_ỶabcdefghijklmnopqrstuvwxyzÝỸĐÁÀẢÃẠÉÈẺẼẸÍÌỈĨỊÓÒỎÕỌÚÙỦŨỤĂẮẰẲẴẶÂẤẦẨẪẬÊẾỀỂỄỆÔỐỒỔỖỘƠỚỜỞỠỢỨỪỬỮỰđáàảãạéèẻẽẹíìỉĩịóòỏõọúùủũụăắằẳẵặâấầẩẫậêếềểễệôốồổỗộơớờởỡợưứừửữựýỳỷỹỵ";

            public int[] chuoi_mangchiso(StringBuilder s)
            {
                int[] mang = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                    mang[i] = chuoi.IndexOf(s[i]);
                return mang;
            }

            public string chiso_chuoi(int[] a)
            {
                string s = "";
                for (int i = 0; i < a.Length; i++)
                    s += chuoi[a[i]];
                return s;
            }
            public string MaHoa (ref StringBuilder plainText, StringBuilder key)
            {
                int []p = chuoi_mangchiso(plainText);
                int []k = chuoi_mangchiso(key);

                int []kq = new int[plainText.Length];
                for (int i = 0, j = 0; i < plainText.Length; i++)
                {
                    kq[i] = (p[i] + k[j]) % chuoi.Length;
                    j = ++j % k.Length;
                }
                cipherText = chiso_chuoi(kq);
                return cipherText;
             
            }

            public string GiaiMa (ref StringBuilder cipherText, StringBuilder key)
            {
                int[] c = chuoi_mangchiso(cipherText);
                int[] k = chuoi_mangchiso(key);

                int[] kq = new int[cipherText.Length];
                for (int i = 0, j = 0; i < cipherText.Length; i++)
                {
                    kq[i] = (c[i] - k[j]) % chuoi.Length;
                    if (kq[i] < 0)
                        kq[i] = (c[i] + (chuoi.Length - k[j])) % chuoi.Length;
                    j = ++j % k.Length;
                }
                plainText = chiso_chuoi(kq);
                return plainText;
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            var ob1 = new Vigernere();
            StringBuilder s = new StringBuilder(textBox6.Text);
            StringBuilder key = new StringBuilder(textBox5.Text);
            ob1.GiaiMa(ref s, key);
            textBox4.Text = Convert.ToString(ob1.plainText);
        
        }


        private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {
                
            }

            private void textBox6_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ob1 = new Vigernere();
            StringBuilder s = new StringBuilder(textBox1.Text);
            StringBuilder key = new StringBuilder(textBox2.Text);
            ob1.MaHoa(ref s, key);
            textBox3.Text = Convert.ToString(ob1.cipherText);
        }

      
    } 
}
