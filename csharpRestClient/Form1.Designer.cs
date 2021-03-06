﻿namespace csharpRestClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RequestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGO = new System.Windows.Forms.Button();
            this.RequestURILabel = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.ClientSecret = new System.Windows.Forms.TextBox();
            this.ClientSecretLabel = new System.Windows.Forms.Label();
            this.ClientIDLabel = new System.Windows.Forms.Label();
            this.ResponseCodeLabel = new System.Windows.Forms.Label();
            this.ResponseCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerlabel1 = new System.Windows.Forms.Label();
            this.HeaderValuetxt = new System.Windows.Forms.TextBox();
            this.HeaderNametxt = new System.Windows.Forms.TextBox();
            this.indexNumber = new System.Windows.Forms.Label();
            this.ReportIndex = new System.Windows.Forms.TextBox();
            this.TokenRadio = new System.Windows.Forms.RadioButton();
            this.MessageRadio = new System.Windows.Forms.RadioButton();
            this.OrderNumbertxt = new System.Windows.Forms.TextBox();
            this.SerialNumbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Derserializebtn = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.ClearResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestURI
            // 
            this.RequestURI.Location = new System.Drawing.Point(226, 18);
            this.RequestURI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RequestURI.Name = "RequestURI";
            this.RequestURI.Size = new System.Drawing.Size(650, 26);
            this.RequestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(68, 386);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(724, 1037);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGO
            // 
            this.cmdGO.Location = new System.Drawing.Point(892, 15);
            this.cmdGO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(112, 35);
            this.cmdGO.TabIndex = 2;
            this.cmdGO.Text = "GO!";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // RequestURILabel
            // 
            this.RequestURILabel.AutoSize = true;
            this.RequestURILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestURILabel.Location = new System.Drawing.Point(88, 23);
            this.RequestURILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RequestURILabel.Name = "RequestURILabel";
            this.RequestURILabel.Size = new System.Drawing.Size(127, 25);
            this.RequestURILabel.TabIndex = 3;
            this.RequestURILabel.Text = "Request URI:";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.Location = new System.Drawing.Point(72, 357);
            this.ResponseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(115, 25);
            this.ResponseLabel.TabIndex = 4;
            this.ResponseLabel.Text = "Response:";
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(226, 63);
            this.ClientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(235, 26);
            this.ClientID.TabIndex = 5;
            // 
            // ClientSecret
            // 
            this.ClientSecret.Location = new System.Drawing.Point(226, 103);
            this.ClientSecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientSecret.Name = "ClientSecret";
            this.ClientSecret.Size = new System.Drawing.Size(235, 26);
            this.ClientSecret.TabIndex = 6;
            // 
            // ClientSecretLabel
            // 
            this.ClientSecretLabel.AutoSize = true;
            this.ClientSecretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSecretLabel.Location = new System.Drawing.Point(84, 112);
            this.ClientSecretLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientSecretLabel.Name = "ClientSecretLabel";
            this.ClientSecretLabel.Size = new System.Drawing.Size(135, 25);
            this.ClientSecretLabel.TabIndex = 9;
            this.ClientSecretLabel.Text = "Client Secret :";
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIDLabel.Location = new System.Drawing.Point(123, 69);
            this.ClientIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(97, 25);
            this.ClientIDLabel.TabIndex = 10;
            this.ClientIDLabel.Text = "Client ID :";
            // 
            // ResponseCodeLabel
            // 
            this.ResponseCodeLabel.AutoSize = true;
            this.ResponseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseCodeLabel.Location = new System.Drawing.Point(562, 63);
            this.ResponseCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResponseCodeLabel.Name = "ResponseCodeLabel";
            this.ResponseCodeLabel.Size = new System.Drawing.Size(152, 22);
            this.ResponseCodeLabel.TabIndex = 11;
            this.ResponseCodeLabel.Text = "Response Code";
            // 
            // ResponseCode
            // 
            this.ResponseCode.Location = new System.Drawing.Point(584, 92);
            this.ResponseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResponseCode.Name = "ResponseCode";
            this.ResponseCode.Size = new System.Drawing.Size(116, 26);
            this.ResponseCode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Header Value:";
            // 
            // headerlabel1
            // 
            this.headerlabel1.AutoSize = true;
            this.headerlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel1.Location = new System.Drawing.Point(72, 152);
            this.headerlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerlabel1.Name = "headerlabel1";
            this.headerlabel1.Size = new System.Drawing.Size(139, 25);
            this.headerlabel1.TabIndex = 14;
            this.headerlabel1.Text = "Header Name:";
            // 
            // HeaderValuetxt
            // 
            this.HeaderValuetxt.Location = new System.Drawing.Point(226, 186);
            this.HeaderValuetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderValuetxt.Name = "HeaderValuetxt";
            this.HeaderValuetxt.Size = new System.Drawing.Size(235, 26);
            this.HeaderValuetxt.TabIndex = 15;
            // 
            // HeaderNametxt
            // 
            this.HeaderNametxt.Location = new System.Drawing.Point(226, 146);
            this.HeaderNametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderNametxt.Name = "HeaderNametxt";
            this.HeaderNametxt.Size = new System.Drawing.Size(235, 26);
            this.HeaderNametxt.TabIndex = 16;
            this.HeaderNametxt.Text = "Authorization";
            // 
            // indexNumber
            // 
            this.indexNumber.AutoSize = true;
            this.indexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexNumber.Location = new System.Drawing.Point(1113, 26);
            this.indexNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indexNumber.Name = "indexNumber";
            this.indexNumber.Size = new System.Drawing.Size(128, 25);
            this.indexNumber.TabIndex = 17;
            this.indexNumber.Text = "Report Index:";
            // 
            // ReportIndex
            // 
            this.ReportIndex.Location = new System.Drawing.Point(1252, 26);
            this.ReportIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportIndex.Name = "ReportIndex";
            this.ReportIndex.Size = new System.Drawing.Size(64, 26);
            this.ReportIndex.TabIndex = 18;
            this.ReportIndex.Text = "0";
            // 
            // TokenRadio
            // 
            this.TokenRadio.AutoSize = true;
            this.TokenRadio.Checked = true;
            this.TokenRadio.Location = new System.Drawing.Point(892, 69);
            this.TokenRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TokenRadio.Name = "TokenRadio";
            this.TokenRadio.Size = new System.Drawing.Size(78, 24);
            this.TokenRadio.TabIndex = 19;
            this.TokenRadio.TabStop = true;
            this.TokenRadio.Text = "Token";
            this.TokenRadio.UseVisualStyleBackColor = true;
            this.TokenRadio.CheckedChanged += new System.EventHandler(this.TokenRadio_CheckedChanged);
            // 
            // MessageRadio
            // 
            this.MessageRadio.AutoSize = true;
            this.MessageRadio.Location = new System.Drawing.Point(892, 103);
            this.MessageRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageRadio.Name = "MessageRadio";
            this.MessageRadio.Size = new System.Drawing.Size(99, 24);
            this.MessageRadio.TabIndex = 20;
            this.MessageRadio.Text = "Message";
            this.MessageRadio.UseVisualStyleBackColor = true;
            this.MessageRadio.CheckedChanged += new System.EventHandler(this.MessageRadio_CheckedChanged);
            // 
            // OrderNumbertxt
            // 
            this.OrderNumbertxt.Location = new System.Drawing.Point(1064, 286);
            this.OrderNumbertxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderNumbertxt.Name = "OrderNumbertxt";
            this.OrderNumbertxt.Size = new System.Drawing.Size(235, 26);
            this.OrderNumbertxt.TabIndex = 21;
            this.OrderNumbertxt.TextChanged += new System.EventHandler(this.OrderNumbertxt_TextChanged);
            // 
            // SerialNumbertxt
            // 
            this.SerialNumbertxt.Location = new System.Drawing.Point(1064, 331);
            this.SerialNumbertxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerialNumbertxt.Name = "SerialNumbertxt";
            this.SerialNumbertxt.Size = new System.Drawing.Size(235, 26);
            this.SerialNumbertxt.TabIndex = 23;
            this.SerialNumbertxt.TextChanged += new System.EventHandler(this.SerialNumbertxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(912, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(915, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Order Number";
            // 
            // Derserializebtn
            // 
            this.Derserializebtn.Location = new System.Drawing.Point(567, 286);
            this.Derserializebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Derserializebtn.Name = "Derserializebtn";
            this.Derserializebtn.Size = new System.Drawing.Size(112, 35);
            this.Derserializebtn.TabIndex = 27;
            this.Derserializebtn.Text = "Deserialize";
            this.Derserializebtn.UseVisualStyleBackColor = true;
            this.Derserializebtn.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(800, 386);
            this.LogBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(910, 1037);
            this.LogBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Log:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1188, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(1014, 15);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 35);
            this.clear.TabIndex = 31;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ClearResponse
            // 
            this.ClearResponse.Location = new System.Drawing.Point(68, 248);
            this.ClearResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearResponse.Name = "ClearResponse";
            this.ClearResponse.Size = new System.Drawing.Size(112, 35);
            this.ClearResponse.TabIndex = 32;
            this.ClearResponse.Text = "Clear Response";
            this.ClearResponse.UseVisualStyleBackColor = true;
            this.ClearResponse.Click += new System.EventHandler(this.ClearResponse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 1443);
            this.Controls.Add(this.ClearResponse);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.Derserializebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialNumbertxt);
            this.Controls.Add(this.OrderNumbertxt);
            this.Controls.Add(this.MessageRadio);
            this.Controls.Add(this.TokenRadio);
            this.Controls.Add(this.ReportIndex);
            this.Controls.Add(this.indexNumber);
            this.Controls.Add(this.HeaderNametxt);
            this.Controls.Add(this.HeaderValuetxt);
            this.Controls.Add(this.headerlabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResponseCode);
            this.Controls.Add(this.ResponseCodeLabel);
            this.Controls.Add(this.ClientIDLabel);
            this.Controls.Add(this.ClientSecretLabel);
            this.Controls.Add(this.ClientSecret);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.RequestURILabel);
            this.Controls.Add(this.cmdGO);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.RequestURI);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "C# REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RequestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGO;
        private System.Windows.Forms.Label RequestURILabel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.TextBox ClientSecret;
        private System.Windows.Forms.Label ClientSecretLabel;
        private System.Windows.Forms.Label ClientIDLabel;
        private System.Windows.Forms.Label ResponseCodeLabel;
        private System.Windows.Forms.TextBox ResponseCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headerlabel1;
        private System.Windows.Forms.TextBox HeaderValuetxt;
        private System.Windows.Forms.TextBox HeaderNametxt;
        private System.Windows.Forms.Label indexNumber;
        private System.Windows.Forms.TextBox ReportIndex;
        private System.Windows.Forms.RadioButton TokenRadio;
        private System.Windows.Forms.RadioButton MessageRadio;
        private System.Windows.Forms.TextBox OrderNumbertxt;
        private System.Windows.Forms.TextBox SerialNumbertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Derserializebtn;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button ClearResponse;
    }
}

