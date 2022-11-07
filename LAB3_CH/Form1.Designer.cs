namespace LAB3_CH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOperation = new System.Windows.Forms.ComboBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdFirstType = new System.Windows.Forms.ComboBox();
            this.cmdSecondType = new System.Windows.Forms.ComboBox();
            this.cmdResultType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFirstCompare = new System.Windows.Forms.TextBox();
            this.txtSecondCompare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOperation
            // 
            this.cmdOperation.FormattingEnabled = true;
            this.cmdOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "Сравнить"});
            this.cmdOperation.Location = new System.Drawing.Point(187, 63);
            this.cmdOperation.Name = "cmdOperation";
            this.cmdOperation.Size = new System.Drawing.Size(99, 28);
            this.cmdOperation.TabIndex = 0;
            this.cmdOperation.Text = "+";
            this.cmdOperation.SelectedIndexChanged += new System.EventHandler(this.cmdOperation_SelectedIndexChanged);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(292, 63);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(125, 27);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(292, 96);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(125, 27);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(292, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(125, 27);
            this.txtResult.TabIndex = 3;
            // 
            // cmdFirstType
            // 
            this.cmdFirstType.FormattingEnabled = true;
            this.cmdFirstType.Location = new System.Drawing.Point(423, 63);
            this.cmdFirstType.Name = "cmdFirstType";
            this.cmdFirstType.Size = new System.Drawing.Size(64, 28);
            this.cmdFirstType.TabIndex = 4;
            this.cmdFirstType.SelectedIndexChanged += new System.EventHandler(this.cmdFirstType_SelectedIndexChanged);
            // 
            // cmdSecondType
            // 
            this.cmdSecondType.FormattingEnabled = true;
            this.cmdSecondType.Location = new System.Drawing.Point(423, 95);
            this.cmdSecondType.Name = "cmdSecondType";
            this.cmdSecondType.Size = new System.Drawing.Size(64, 28);
            this.cmdSecondType.TabIndex = 5;
            this.cmdSecondType.SelectedIndexChanged += new System.EventHandler(this.cmdSecondType_SelectedIndexChanged);
            // 
            // cmdResultType
            // 
            this.cmdResultType.FormattingEnabled = true;
            this.cmdResultType.Location = new System.Drawing.Point(423, 129);
            this.cmdResultType.Name = "cmdResultType";
            this.cmdResultType.Size = new System.Drawing.Size(64, 28);
            this.cmdResultType.TabIndex = 6;
            this.cmdResultType.SelectedIndexChanged += new System.EventHandler(this.cmdResultType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFirstCompare
            // 
            this.txtFirstCompare.Location = new System.Drawing.Point(14, 12);
            this.txtFirstCompare.Name = "txtFirstCompare";
            this.txtFirstCompare.Size = new System.Drawing.Size(167, 27);
            this.txtFirstCompare.TabIndex = 8;
            // 
            // txtSecondCompare
            // 
            this.txtSecondCompare.Location = new System.Drawing.Point(264, 9);
            this.txtSecondCompare.Name = "txtSecondCompare";
            this.txtSecondCompare.Size = new System.Drawing.Size(170, 27);
            this.txtSecondCompare.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondCompare);
            this.Controls.Add(this.txtFirstCompare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdResultType);
            this.Controls.Add(this.cmdSecondType);
            this.Controls.Add(this.cmdFirstType);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.cmdOperation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmdOperation;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private ComboBox cmdFirstType;
        private ComboBox cmdSecondType;
        private ComboBox cmdResultType;
        private Button button1;
        private TextBox txtFirstCompare;
        private TextBox txtSecondCompare;
        private Label label1;
    }
}