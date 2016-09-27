using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigrams1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Controls["labelBigrams"].Text = "bigrams from '" + ActiveForm.Controls["word"].Text +"'";
            ActiveForm.Controls["bigrams"].Text = textToBigrams(ActiveForm.Controls["word"].Text);
        }

        private string textToBigrams(string word)
        {
            string bigrams = "";
            int wordLength = word.Length;
            for (int i = 0; i < wordLength-1; i++)
            {
                bigrams = bigrams + word.Substring(i, 1) + "+" + word.Substring(i + 1, 1)+"; ";
                CheckBox cb = ActiveForm.Controls["pureBigrams"] as CheckBox;
                CheckBox mt = ActiveForm.Controls["noMiddle"] as CheckBox;
                if (cb.Checked == false)
                {
                    for (int j = i + 2; j < wordLength; j++)
                    {
                        string middleTxt = "+_)+";
                        string preTxt = "(";
                        if (mt.Checked == true)
                        {
                            middleTxt = "+";
                            preTxt = "";
                        }
                        bigrams = bigrams + preTxt + word.Substring(i, 1) + middleTxt + word.Substring(j, 1) + "; ";
                    }
                }
            }
            return bigrams;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pureBigrams_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox pB = ActiveForm.Controls["pureBigrams"] as CheckBox; 
            if (pB.Checked == false)
            {
                ActiveForm.Controls["noMiddle"].Visible = true;
                if (noMiddle.Checked)
                {
                    labelExample.Text = "eg: cat -> c+a; c+t; a+t";
                }
                else
                {
                    labelExample.Text = "eg: cat -> c+a; (c+_)+t; a+t";
                }
            } else
            {
                ActiveForm.Controls["noMiddle"].Visible = false;
                labelExample.Text = "eg. cat -> c+a; a+t";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (compareOrCreate.Checked == false)
            {
                label2.Visible = false;
                compareButton.Visible = false;
                word2.Visible = false;
            } else
            {
                label2.Visible = true;
                compareButton.Visible = true;
                word2.Visible = true;
            }
        }

        private List<string> bigramlist(string word)
        {
            List<string> bigramList = new List<string>();
            int wordLength = word.Length;
            for (int i = 0; i < wordLength-1; i++) {
                bigramList.Add(word.Substring(i,1)+"+"+word.Substring(i+1,1));
                for (int j = i + 2; j < wordLength; j++)
                {
                    if (pureBigrams.Checked == false)
                    {
                        if (noMiddle.Checked)
                        {
                            bigramList.Add(word.Substring(i, 1) + "+" + word.Substring(j, 1));                            
                        }else
                        {
                            bigramList.Add("(" + word.Substring(i, 1) + "+_)+" + word.Substring(j, 1));
                        }
                    }
                }
            }
            return bigramList;
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            labelBigrams.Text = "Compare '" + word.Text + "' with '" + word2.Text + "'";
            List<string> list1 = bigramlist(word.Text);
            List<string> list2 = bigramlist(word2.Text);
            List<string> newlist1 = new List<string>(list1);
            List<string> newlist2 = new List<string>(list2);
            string ts = "unique bigrams in first word:\r\n";
            foreach(string s in list1)
            {
                if (newlist2.Contains(s))
                {
                    newlist2.Remove(s);
                    newlist1.Remove(s);
                }
            }
            foreach(string s in newlist1)
            {
                ts = ts + s + "; ";
            }
            ts = ts + "\r\n\r\n unique bigrams in second word:\r\n";
            foreach(string s in newlist2)
            {
                ts = ts + s + "; ";
            }
            bigrams.Text = ts;
        }

        private void noMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (noMiddle.Checked)
            {
                labelExample.Text = "eg: cat -> c+a; c+t; a+t";
            }else
            {
                labelExample.Text = "eg: cat -> c+a; (c+_)+t; a+t";
            }
        }
    }
}
