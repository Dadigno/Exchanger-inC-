namespace BasicChangeCurrencies
{
    partial class Form1
    {
        public object[] FiatCoins = new object[2] { "USD", "EUR"};
        public object[] CryptoCoins = new object[3] { "Bitcoin", "Ethereum", "Litecoin" };
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.compute = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.reloadCur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSetToday = new System.Windows.Forms.Button();
            this.comboFromCur = new System.Windows.Forms.ComboBox();
            this.comboToCur = new System.Windows.Forms.ComboBox();
            this.selectIco = new System.Windows.Forms.RadioButton();
            this.selectFiat = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // compute
            // 
            resources.ApplyResources(this.compute, "compute");
            this.compute.BackColor = System.Drawing.SystemColors.Desktop;
            this.compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compute.ForeColor = System.Drawing.Color.Lime;
            this.compute.Name = "compute";
            this.compute.UseVisualStyleBackColor = false;
            this.compute.Click += new System.EventHandler(this.ButtonCalc);
            // 
            // txtFrom
            // 
            resources.ApplyResources(this.txtFrom, "txtFrom");
            this.txtFrom.Name = "txtFrom";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // percentage
            // 
            resources.ApplyResources(this.percentage, "percentage");
            this.percentage.ForeColor = System.Drawing.Color.Lime;
            this.percentage.Name = "percentage";
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.txtAmount.Name = "txtAmount";
            // 
            // amount
            // 
            resources.ApplyResources(this.amount, "amount");
            this.amount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.amount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amount.Name = "amount";
            // 
            // result
            // 
            resources.ApplyResources(this.result, "result");
            this.result.ForeColor = System.Drawing.Color.Yellow;
            this.result.Name = "result";
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            // 
            // rate
            // 
            resources.ApplyResources(this.rate, "rate");
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.Name = "rate";
            // 
            // reloadCur
            // 
            resources.ApplyResources(this.reloadCur, "reloadCur");
            this.reloadCur.BackColor = System.Drawing.Color.SteelBlue;
            this.reloadCur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadCur.Name = "reloadCur";
            this.reloadCur.UseVisualStyleBackColor = false;
            this.reloadCur.Click += new System.EventHandler(this.ButtonReload);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reloadCur);
            this.groupBox1.Controls.Add(this.rate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.buttonSetToday);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // buttonSetToday
            // 
            resources.ApplyResources(this.buttonSetToday, "buttonSetToday");
            this.buttonSetToday.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetToday.Name = "buttonSetToday";
            this.buttonSetToday.UseVisualStyleBackColor = false;
            this.buttonSetToday.Click += new System.EventHandler(this.ButtonSetToday_Click);
            // 
            // comboFromCur
            // 
            resources.ApplyResources(this.comboFromCur, "comboFromCur");
            this.comboFromCur.FormattingEnabled = true;
            this.comboFromCur.Name = "comboFromCur";
            
            // 
            // comboToCur
            // 
            resources.ApplyResources(this.comboToCur, "comboToCur");
            this.comboToCur.FormattingEnabled = true;
            this.comboToCur.Name = "comboToCur";
            // 
            // selectIco
            // 
            resources.ApplyResources(this.selectIco, "selectIco");
            this.selectIco.Checked = true;
            this.selectIco.Name = "selectIco";
            this.selectIco.TabStop = true;
            this.selectIco.UseVisualStyleBackColor = true;
            this.selectIco.CheckedChanged += new System.EventHandler(this.selectIco_CheckedChanged);
            // 
            // selectFiat
            // 
            resources.ApplyResources(this.selectFiat, "selectFiat");
            this.selectFiat.Name = "selectFiat";
            this.selectFiat.TabStop = true;
            this.selectFiat.UseVisualStyleBackColor = true;
            this.selectFiat.CheckedChanged += new System.EventHandler(this.selectFiat_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.selectFiat);
            this.Controls.Add(this.selectIco);
            this.Controls.Add(this.comboToCur);
            this.Controls.Add(this.comboFromCur);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button reloadCur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetToday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboToCur;
        private System.Windows.Forms.RadioButton selectIco;
        private System.Windows.Forms.RadioButton selectFiat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboFromCur;
    }
}

