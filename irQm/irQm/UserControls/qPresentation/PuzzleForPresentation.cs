using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class PuzzleForPresentation : UserControl
    {
        Label selectedAnsLbl;
        List<StringPair> pairs;
        List<StringPair> answer;
        public PuzzleForPresentation(Puzzle question,bool answerTime,bool showAnswer)
        {
            pairs = question.Pairs;
            answer = question.AnswerPairs;
            InitializeComponent();
        //    if (answerTime)
            {
                var c1 = pairs.Where(p => !string.IsNullOrWhiteSpace(p.Key)).Select(p => p.Key).ToArray();
                tableLayoutPanel1.RowCount = c1.Length;
                for (int i = 0; i < c1.Length; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                var j = 0;
                foreach (var s in c1)
                {
                    //if (!string.IsNullOrWhiteSpace(s))
                    //{
                    Label lbl = new Label();
                    lbl.Text = s;
                    lbl.AutoSize = true;
                    
                    if (!showAnswer && answerTime)
                    {
                        lbl.Click += LblKey_Click;
                        lbl.Cursor = Cursors.Hand;
                    }
                    lbl.Tag = j;
                    lbl.RightToLeft = RightToLeft.Yes;
                    lbl.Padding = new Padding(10);
                    
                    tableLayoutPanel1.Controls.Add(lbl, 0, j);

                    if(showAnswer)
                    {
                        var aLbl = new Label();
                        aLbl.Text = pairs[j].Value;
                        aLbl.RightToLeft = RightToLeft.Yes;
                        aLbl.Padding = new Padding(10);
                        aLbl.AutoSize = true;
                        aLbl.BackColor = BaseCodes.Utilities.Globals.Colors.TrueOption;
                        if(!string.IsNullOrWhiteSpace(pairs[j].Value))
                        tableLayoutPanel1.Controls.Add(aLbl, 1, j);
                    }
                    j++;
                    //}
                }


                var c2 = pairs.Select(p => p.Value).ToArray();

                foreach (var s in c2)
                {
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        Label lbl = new Label();
                        lbl.Text = s;
                        lbl.AutoSize = true;

                        if (!showAnswer && answerTime)
                        {
                            lbl.Click += LblAns_Click;
                            lbl.Cursor = Cursors.Hand;
                        }
                        lbl.BackColor = Color.White;
                        lbl.Padding = new Padding(10);

                        lbl.RightToLeft = RightToLeft.Yes;
                        var pairInAnswer = answer?.Where(p => p.Value == s).ToArray();
                        if (pairInAnswer!=null&&pairInAnswer.Length > 0)
                        {
                            tableLayoutPanel1.Controls.Add(lbl, 1, pairs.IndexOf(pairInAnswer[0]));
                        }
                        else
                            flowLayoutPanel1.Controls.Add(lbl);
                    }
                }

            }
        }

        private void LblKey_Click(object sender, EventArgs e)
        {
            var clickedIndex =(int) ((Label)sender).Tag;
            if(selectedAnsLbl!=null)
            {
                flowLayoutPanel1.Controls.Remove(selectedAnsLbl);
                tableLayoutPanel1.Controls.Add(selectedAnsLbl, 1, clickedIndex);
                selectedAnsLbl.BackColor = Color.White;
                selectedAnsLbl = null;

            }
        }

        private void LblAns_Click(object sender, EventArgs e)
        {
            var clicked = (Label)sender;
            if(flowLayoutPanel1.Controls.IndexOf(clicked)<0)
            {
                tableLayoutPanel1.Controls.Remove(clicked);
                flowLayoutPanel1.Controls.Add(clicked);
                clicked.BackColor = Color.White;
                selectedAnsLbl = null;
            }
            else
            {
                if (selectedAnsLbl != null)
                    selectedAnsLbl.BackColor = Color.White;
                selectedAnsLbl = clicked;
                selectedAnsLbl.BackColor = Color.LightBlue;
            }
        }
    }
}
