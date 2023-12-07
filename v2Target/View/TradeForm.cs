using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2Framework.Controls;
using v2Framework.Uitls.Binance;

namespace v2Target.View
{
    public partial class TradeForm : UserControl
    {
        public TradeForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        public void LoadTradeList(string data)
        {
            this.v2TradeList.Data = data;
        }
    }
}
