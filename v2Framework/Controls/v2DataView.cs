using System.Windows.Forms;
using System.Text.Json;
using System.Drawing;
using System;
using v2Target.Component;
using static System.Text.Json.JsonElement;

namespace v2Framework.Controls
{
    public class v2DataView: v2Panel
    {
        
        private v2DataContent content = new v2DataContent();
        private v2DataHeader header = new v2DataHeader();
        private v2Panel panelContent = new v2Panel();
        private v2Panel panelHeader = new v2Panel();
        private String jsondata;
        public v2DataView()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Dock = DockStyle.Fill;

            this.Controls.Add(panelContent);
            this.Controls.Add(panelHeader);
            panelHeader.Controls.Add(header);
            panelContent.Controls.Add(content);

            panelHeader.TabIndex = 1;
            panelHeader.AutoSize = true;
            panelHeader.Dock = DockStyle.Top;

            panelContent.TabIndex = 2;
            panelContent.Dock = DockStyle.Fill;

            panelContent.HorizontalScroll.Maximum = 0;
            panelContent.VerticalScroll.Maximum = 0;

            panelContent.AutoScroll = true; 
        }

        public void SetData()
        {
            try
            {
                var jsonHeader = JsonDocument.Parse(jsondata);
                JsonElement root = jsonHeader.RootElement;
                var jheader = root[0].EnumerateObject();

                ClearData();

                header.GenerateComponents(jheader);
                content.GenerateComponents(jsondata);
            }
            catch (Exception)
            {

            }
        }
        private void ClearData()
        {
            try
            {
                header.Controls.Clear();
                content.Controls.Clear();
            }
            catch (Exception)
            {

            }
        }

        public int[] ColumnWidth
        {
            get => this.content.columnWidth;
            set
            {
                this.content.columnWidth = value;
                this.header.columnWidth = value;
            }
        }

        public String Data
        {
            set {
                this.jsondata = value;
                if (!String.IsNullOrEmpty(value))
                {
                    SetData();
                }
                else
                {
                    ClearData();
                }
            } 
        }

        public int RowHighContent
        {
            get => this.content.rowhigh;
            set
            {
                this.content.rowhigh = value;
            }
        }
        public int RowHighHeader
        {
            get => this.header.rowhigh;
            set
            {
                this.header.rowhigh = value;
            }
        }

        public int Row
        {
            get => this.content.RowCount;
            set
            {
                this.content.RowCount = value;
            }
        }
        public int Colunm
        {
            get => this.content.ColumnCount;
            set
            {
                this.content.ColumnCount = value;
            }
        }
        public Color ColorText
        {
            get => this.content.colortext;
            set
            {
                this.content.colortext = value;
            }
        }
        public Font FontText
        {
            get => this.content.fonttext;
            set
            {
                this.content.fonttext = value;
            }
        }

        public Color ColorHeader
        {
            get => this.header.colorheader;
            set
            {
                this.header.colorheader = value;
            }
        }
        public Font FontHeader
        {
            get => this.header.fontheader;
            set
            {
                this.header.fontheader = value;
            }
        }

        public Color EvenRowColor
        {
            get => this.content.evenRowColor;
            set
            {
                this.content.evenRowColor = value;
            }
        }
        public Color OddRowColor
        {
            get => this.content.oddRowColor;
            set
            {
                this.content.oddRowColor = value;
            }
        }
        public Color BackGroundHeader
        {
            get => this.header.BackGroundHeader;
            set
            {
                this.header.BackGroundHeader = value;
            }
        }

        public class v2DataContent : TableLayoutPanel
        {
            public Color colortext = Color.White;
            public Color colorheader = Color.White;
            public Color evenRowColor = Color.Transparent;
            public Color oddRowColor = Color.Transparent;
            public Font fontheader;
            public Font fonttext;
            public int count = 0;
            public int rowcount = 0;
            public int colcount = 0;
            public int rowhigh = 25;
            public int[] columnWidth;
            public v2DataContent()
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.Margin = new Padding(0, 0, 0, 0);
                this.Padding = new Padding(0, 0, 0, 0);
                this.Dock = DockStyle.Top;
                this.AutoSize = true;
            }

            public void GenerateComponents(string data)
            {
                var jsondata = JsonDocument.Parse(data);
                JsonElement root = jsondata.RootElement;

                this.RowCount = root.GetArrayLength();

                for (int i = 0; i <= this.RowCount; i++)
                {
                    if (i < this.RowStyles.Count)
                    {
                        this.RowStyles[i].SizeType = SizeType.Absolute;
                        this.RowStyles[i].Height = rowhigh;
                    }
                    else
                    {
                        this.RowStyles.Add(new RowStyle(SizeType.Absolute, rowhigh));
                    }
                }

                var jheader = root[0].EnumerateObject();

                count = 0;

                while (jheader.MoveNext())
                {
                    count = count + 1;
                }


                this.ColumnCount = count;

                var rows = root.EnumerateArray();

                rowcount = 0;

                while (rows.MoveNext())
                {
                    var jsonobject = rows.Current;

                    var jobject = jsonobject.EnumerateObject();

                    colcount = 0;
                    v2Label vLabel = new v2Label();
                    while (jobject.MoveNext())
                    {
                        var job = jobject.Current;
                        vLabel = CreateValue(job.Value.ToString());
                        this.Controls.Add(vLabel, colcount, rowcount);
                        colcount = colcount + 1;
                    }
                    rowcount = rowcount + 1;

                }

                for (int i = 0; i <= this.ColumnCount; i++)
                {
                    if (i < this.ColumnStyles.Count)
                    {
                        this.ColumnStyles[i].SizeType = SizeType.Percent;
                        this.ColumnStyles[i].Width = this.columnWidth[i];
                    }
                    else
                    {
                        this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, this.columnWidth[i]));
                    }
                }

            }

            private v2Label CreateValue(String text)
            {
                v2Label vlabel = new v2Label();
                vlabel.AutoSize = false;
                vlabel.Dock = DockStyle.Fill;
                vlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                vlabel.Text = text;
                vlabel.Font = fonttext;
                vlabel.ForeColor = Color.Transparent;
                vlabel.BorderStyle = BorderStyle.None;
                vlabel.Margin = new Padding(0, 0, 0, 0);
                vlabel.Padding = new Padding(5, 0, 0, 0);
                return vlabel;
            }

            protected override void OnCellPaint(TableLayoutCellPaintEventArgs e)
            {
                base.OnCellPaint(e);
                if ((e.Row) % 2 == 0)
                    e.Graphics.FillRectangle(new SolidBrush(evenRowColor), e.CellBounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(oddRowColor), e.CellBounds);
            }
        }
        public class v2DataHeader : TableLayoutPanel
        {
            public Color colorheader = Color.White;
            public Color BackGroundHeader = Color.Transparent;
            public Font fontheader;
            public int colcount = 0;
            public int rowhigh = 25;
            public int[] columnWidth;
            public v2DataHeader()
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.Margin = new Padding(0, 0, 0, 0);
                this.Padding = new Padding(0, 0, 0, 0);
                this.Dock = DockStyle.Top;
                this.AutoSize = true;
                this.RowCount = 1;
            }

            public void GenerateComponents(ObjectEnumerator data)
            {
                for (int i = this.RowStyles.Count; i < this.RowCount; i++)
                {
                    this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                v2Label vLabelHeader = new v2Label();

                colcount = 0;

                while (data.MoveNext())
                {
                    var job = data.Current;
                    vLabelHeader = CreateHeader(job.Name.ToString());

                    this.Controls.Add(vLabelHeader, colcount, 0);
                    colcount = colcount + 1;
                }
                this.ColumnCount = colcount;

                this.RowStyles[0].SizeType = SizeType.Absolute;
                this.RowStyles[0].Height = rowhigh;

                for (int i = 0; i < this.ColumnCount; i++)
                {
                    if (i < this.ColumnStyles.Count)
                    {
                        this.ColumnStyles[i].SizeType = SizeType.Percent;
                        this.ColumnStyles[i].Width = this.columnWidth[i];
                    }
                    else
                    {
                        this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, this.columnWidth[i]));
                    }
                }
            }


            private v2Label CreateHeader(String text)
            {
                v2Label vlabel = new v2Label();
                vlabel.AutoSize = false;
                vlabel.Dock = DockStyle.Fill;
                vlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                vlabel.Text = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
                vlabel.Font = fontheader;
                vlabel.ForeColor = colorheader;
                vlabel.Margin = new Padding(0, 0, 0, 0);
                vlabel.Padding = new Padding(5, 0, 0, 0);
                return vlabel;
            }

            protected override void OnCellPaint(TableLayoutCellPaintEventArgs e)
            {
                base.OnCellPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(BackGroundHeader), e.CellBounds);
            }
        }
    }
}
