﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdviceAppFunctionality.AdviceManagement;

namespace WinFormAdviceGiverApp
{
    public partial class FormAdviceGiver : System.Windows.Forms.Form
    {
        private Dictionary<int, string> piecesOfAdvice = new Dictionary<int, string>();

        public FormAdviceGiver()
        {
            InitializeComponent();
        }

        private void buttonGenerateAdvice_Click(object sender, EventArgs e)
        {
            piecesOfAdvice = new Dictionary<int, string>();
            textBoxPiecesOfAdvice.Clear();

            int neededAdviceQuantity = (int)numericUpDownAdviceQuantity.Value;
            int currentAdviceQuantity = piecesOfAdvice.Count;

            var adviceReceiver = new AdviceReceiver();
            while (currentAdviceQuantity != neededAdviceQuantity)
            {
                var receivedAdvice = adviceReceiver.GetNewAdvice();
                if(!receivedAdvice.Equals(default(KeyValuePair<int,string>)))
                    if (!piecesOfAdvice.ContainsKey(receivedAdvice.Key))
                    {
                        piecesOfAdvice.Add(receivedAdvice.Key, receivedAdvice.Value);
                        currentAdviceQuantity++;
                    }
            }

            var adviceTranslator = new AdviceTranslator();
            foreach (var advice in piecesOfAdvice)
            {
                textBoxPiecesOfAdvice.Text += advice.Value;
                textBoxPiecesOfAdvice.Text += Environment.NewLine;
                var translatedAdvice = adviceTranslator.TranslateAdvice(advice.Value);
                textBoxPiecesOfAdvice.Text += translatedAdvice;
                if(!advice.Equals(piecesOfAdvice.Last()))
                    textBoxPiecesOfAdvice.Text += Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
