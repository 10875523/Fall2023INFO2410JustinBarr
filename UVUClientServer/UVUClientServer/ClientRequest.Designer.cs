namespace UVUClientServer
{
    partial class ClientRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRequest));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNSubmit = new System.Windows.Forms.Button();
            this.TXTRequest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTBoxResponse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTNSubmit);
            this.groupBox1.Controls.Add(this.TXTRequest);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REQUEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message The Server (UVUFact or UVUMajor):";
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.Location = new System.Drawing.Point(268, 58);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.Size = new System.Drawing.Size(126, 28);
            this.BTNSubmit.TabIndex = 1;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.UseVisualStyleBackColor = true;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // TXTRequest
            // 
            this.TXTRequest.Location = new System.Drawing.Point(7, 61);
            this.TXTRequest.Name = "TXTRequest";
            this.TXTRequest.Size = new System.Drawing.Size(255, 29);
            this.TXTRequest.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTBoxResponse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESPONSE";
            // 
            // TXTBoxResponse
            // 
            this.TXTBoxResponse.Location = new System.Drawing.Point(11, 39);
            this.TXTBoxResponse.Multiline = true;
            this.TXTBoxResponse.Name = "TXTBoxResponse";
            this.TXTBoxResponse.ReadOnly = true;
            this.TXTBoxResponse.Size = new System.Drawing.Size(383, 229);
            this.TXTBoxResponse.TabIndex = 0;
            // 
            // ClientRequest
            // 
            this.AcceptButton = this.BTNSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientRequest";
            this.Text = "Justin\'s Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNSubmit;
        private System.Windows.Forms.TextBox TXTRequest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTBoxResponse;
    }
}

