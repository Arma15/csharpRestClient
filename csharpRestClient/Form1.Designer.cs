namespace csharpRestClient
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
            this.JobNumbertxt = new System.Windows.Forms.TextBox();
            this.SerialNumbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Derserializebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestURI
            // 
            this.RequestURI.Location = new System.Drawing.Point(151, 12);
            this.RequestURI.Name = "RequestURI";
            this.RequestURI.Size = new System.Drawing.Size(435, 20);
            this.RequestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(45, 251);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(822, 319);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGO
            // 
            this.cmdGO.Location = new System.Drawing.Point(595, 10);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(75, 23);
            this.cmdGO.TabIndex = 2;
            this.cmdGO.Text = "GO!";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // RequestURILabel
            // 
            this.RequestURILabel.AutoSize = true;
            this.RequestURILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestURILabel.Location = new System.Drawing.Point(59, 15);
            this.RequestURILabel.Name = "RequestURILabel";
            this.RequestURILabel.Size = new System.Drawing.Size(88, 16);
            this.RequestURILabel.TabIndex = 3;
            this.RequestURILabel.Text = "Request URI:";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.Location = new System.Drawing.Point(48, 222);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(83, 16);
            this.ResponseLabel.TabIndex = 4;
            this.ResponseLabel.Text = "Response:";
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(151, 41);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(158, 20);
            this.ClientID.TabIndex = 5;
            // 
            // ClientSecret
            // 
            this.ClientSecret.Location = new System.Drawing.Point(151, 67);
            this.ClientSecret.Name = "ClientSecret";
            this.ClientSecret.Size = new System.Drawing.Size(158, 20);
            this.ClientSecret.TabIndex = 6;
            // 
            // ClientSecretLabel
            // 
            this.ClientSecretLabel.AutoSize = true;
            this.ClientSecretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSecretLabel.Location = new System.Drawing.Point(56, 73);
            this.ClientSecretLabel.Name = "ClientSecretLabel";
            this.ClientSecretLabel.Size = new System.Drawing.Size(89, 16);
            this.ClientSecretLabel.TabIndex = 9;
            this.ClientSecretLabel.Text = "Client Secret :";
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIDLabel.Location = new System.Drawing.Point(82, 45);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(63, 16);
            this.ClientIDLabel.TabIndex = 10;
            this.ClientIDLabel.Text = "Client ID :";
            // 
            // ResponseCodeLabel
            // 
            this.ResponseCodeLabel.AutoSize = true;
            this.ResponseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseCodeLabel.Location = new System.Drawing.Point(375, 41);
            this.ResponseCodeLabel.Name = "ResponseCodeLabel";
            this.ResponseCodeLabel.Size = new System.Drawing.Size(108, 15);
            this.ResponseCodeLabel.TabIndex = 11;
            this.ResponseCodeLabel.Text = "Response Code";
            // 
            // ResponseCode
            // 
            this.ResponseCode.Location = new System.Drawing.Point(389, 60);
            this.ResponseCode.Name = "ResponseCode";
            this.ResponseCode.Size = new System.Drawing.Size(79, 20);
            this.ResponseCode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Header Value:";
            // 
            // headerlabel1
            // 
            this.headerlabel1.AutoSize = true;
            this.headerlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel1.Location = new System.Drawing.Point(48, 99);
            this.headerlabel1.Name = "headerlabel1";
            this.headerlabel1.Size = new System.Drawing.Size(97, 16);
            this.headerlabel1.TabIndex = 14;
            this.headerlabel1.Text = "Header Name:";
            // 
            // HeaderValuetxt
            // 
            this.HeaderValuetxt.Location = new System.Drawing.Point(151, 121);
            this.HeaderValuetxt.Name = "HeaderValuetxt";
            this.HeaderValuetxt.Size = new System.Drawing.Size(158, 20);
            this.HeaderValuetxt.TabIndex = 15;
            // 
            // HeaderNametxt
            // 
            this.HeaderNametxt.Location = new System.Drawing.Point(151, 95);
            this.HeaderNametxt.Name = "HeaderNametxt";
            this.HeaderNametxt.Size = new System.Drawing.Size(158, 20);
            this.HeaderNametxt.TabIndex = 16;
            this.HeaderNametxt.Text = "Authorization";
            // 
            // indexNumber
            // 
            this.indexNumber.AutoSize = true;
            this.indexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexNumber.Location = new System.Drawing.Point(742, 17);
            this.indexNumber.Name = "indexNumber";
            this.indexNumber.Size = new System.Drawing.Size(87, 16);
            this.indexNumber.TabIndex = 17;
            this.indexNumber.Text = "Report Index:";
            // 
            // ReportIndex
            // 
            this.ReportIndex.Location = new System.Drawing.Point(835, 17);
            this.ReportIndex.Name = "ReportIndex";
            this.ReportIndex.Size = new System.Drawing.Size(44, 20);
            this.ReportIndex.TabIndex = 18;
            this.ReportIndex.Text = "0";
            // 
            // TokenRadio
            // 
            this.TokenRadio.AutoSize = true;
            this.TokenRadio.Checked = true;
            this.TokenRadio.Location = new System.Drawing.Point(595, 45);
            this.TokenRadio.Name = "TokenRadio";
            this.TokenRadio.Size = new System.Drawing.Size(56, 17);
            this.TokenRadio.TabIndex = 19;
            this.TokenRadio.TabStop = true;
            this.TokenRadio.Text = "Token";
            this.TokenRadio.UseVisualStyleBackColor = true;
            this.TokenRadio.CheckedChanged += new System.EventHandler(this.TokenRadio_CheckedChanged);
            // 
            // MessageRadio
            // 
            this.MessageRadio.AutoSize = true;
            this.MessageRadio.Location = new System.Drawing.Point(595, 67);
            this.MessageRadio.Name = "MessageRadio";
            this.MessageRadio.Size = new System.Drawing.Size(68, 17);
            this.MessageRadio.TabIndex = 20;
            this.MessageRadio.Text = "Message";
            this.MessageRadio.UseVisualStyleBackColor = true;
            this.MessageRadio.CheckedChanged += new System.EventHandler(this.MessageRadio_CheckedChanged);
            // 
            // OrderNumbertxt
            // 
            this.OrderNumbertxt.Location = new System.Drawing.Point(709, 163);
            this.OrderNumbertxt.Name = "OrderNumbertxt";
            this.OrderNumbertxt.Size = new System.Drawing.Size(158, 20);
            this.OrderNumbertxt.TabIndex = 21;
            // 
            // JobNumbertxt
            // 
            this.JobNumbertxt.Location = new System.Drawing.Point(709, 189);
            this.JobNumbertxt.Name = "JobNumbertxt";
            this.JobNumbertxt.Size = new System.Drawing.Size(158, 20);
            this.JobNumbertxt.TabIndex = 22;
            // 
            // SerialNumbertxt
            // 
            this.SerialNumbertxt.Location = new System.Drawing.Point(709, 215);
            this.SerialNumbertxt.Name = "SerialNumbertxt";
            this.SerialNumbertxt.Size = new System.Drawing.Size(158, 20);
            this.SerialNumbertxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Job Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Order Number";
            // 
            // Derserializebtn
            // 
            this.Derserializebtn.Location = new System.Drawing.Point(378, 186);
            this.Derserializebtn.Name = "Derserializebtn";
            this.Derserializebtn.Size = new System.Drawing.Size(75, 23);
            this.Derserializebtn.TabIndex = 27;
            this.Derserializebtn.Text = "Deserialize";
            this.Derserializebtn.UseVisualStyleBackColor = true;
            this.Derserializebtn.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 582);
            this.Controls.Add(this.Derserializebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialNumbertxt);
            this.Controls.Add(this.JobNumbertxt);
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
        private System.Windows.Forms.TextBox JobNumbertxt;
        private System.Windows.Forms.TextBox SerialNumbertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Derserializebtn;
    }
}

