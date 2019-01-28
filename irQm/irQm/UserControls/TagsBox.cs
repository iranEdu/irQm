using irQm.BaseCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace irQm
{
    public class TagsBox : TextBox
    {
        List<string> tags;

        ListBox options=new ListBox();

        public TagsBox()
        {
            tags = new List<string>();
        }
        public string[] Tags { get { string[] tgs = this.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray(); for (int i = 0; i < tgs.Length; i++) tgs[i] = tgs[i].Trim(); return tgs; } }
        bool isInitialized;
        public void UpdateTags()
        {
            tags.Clear();
            using (irQmDbContext db = new irQmDbContext())
            {
                var t = db.Tags.ToArray();
                foreach (var tag in t)
                {
                    tags.Add(tag.Value);
                }
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            if (!isInitialized)
            {
                options.Items.Clear();
                options.SelectedIndexChanged += options_SelectedIndexChanged;
                options.Visible = false;
                options.MaximumSize = new System.Drawing.Size(this.Width, this.Height * 5);
                options.Width = this.Width;
                options.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + this.Height);

                this.Parent.Controls.Add(options);
                this.Parent.Controls.SetChildIndex(options, 0);

                using (irQmDbContext db = new irQmDbContext())
                {
                    var t = db.Tags.ToArray();
                    foreach (var tag in t)
                    {
                        tags.Add(tag.Value);
                    }
                }
                isInitialized = true;
            }
            base.OnGotFocus(e);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            options.Width = this.Width;
        }
        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            options.Visible = false;
            string[] s = this.Text.Split('-');
            short current = 0;

            int sum = 0;
            for (; current < s.Length; current++)
            {
                sum += s[current].Length;
                if (sum >= this.SelectionStart - (current))
                    break;
            }

            s[current] = (string)options.SelectedItem;

            this.Text = String.Join("-", s);

            this.Focus(); this.SelectionStart = this.TextLength; this.SelectionLength = 0;


        }
        protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            string[] s = this.Text.Split('-');
            options.Items.Clear();
            short current = 0;
            if ((char)e.KeyCode == '-')
            {
                options.Hide();
            }
            else if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                int sum = 0;
                for (; current < s.Length; current++)
                {
                    sum += s[current].Length;
                    if (sum >= this.SelectionStart - (current))
                        break;
                }

                foreach (var t in tags.Where(a => s[current] != "" && a.StartsWith(s[current].Trim())))
                {
                    options.Items.Add(t);
                }

            }
            if (options.Items.Count > 0)
            {
                options.RightToLeft = this.RightToLeft;
                options.Show();
            }
            else
            {
                options.Hide();
            }
            base.OnKeyUp(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (!options.Focused)
                options.Hide();
            base.OnLostFocus(e);
        }
        public void Next()
        {
            string[] s = this.Text.Split('-');
            foreach (var t in s)
            {
                if (!tags.Contains(t))
                {
                    tags.Add(t);
                }
            }
            this.Text = "";
        }
    }
}
