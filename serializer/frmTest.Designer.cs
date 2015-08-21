namespace serializer {
    partial class frmTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmdSerialize = new System.Windows.Forms.Button();
            this.txtSerialised = new System.Windows.Forms.TextBox();
            this.cmdDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSerialize
            // 
            this.cmdSerialize.Location = new System.Drawing.Point(12, 12);
            this.cmdSerialize.Name = "cmdSerialize";
            this.cmdSerialize.Size = new System.Drawing.Size(136, 35);
            this.cmdSerialize.TabIndex = 0;
            this.cmdSerialize.Text = "serialize";
            this.cmdSerialize.UseVisualStyleBackColor = true;
            this.cmdSerialize.Click += new System.EventHandler(this.cmdSerialise_Click);
            // 
            // txtSerialised
            // 
            this.txtSerialised.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialised.Location = new System.Drawing.Point(12, 53);
            this.txtSerialised.Multiline = true;
            this.txtSerialised.Name = "txtSerialised";
            this.txtSerialised.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSerialised.Size = new System.Drawing.Size(423, 235);
            this.txtSerialised.TabIndex = 1;
            // 
            // cmdDeserialize
            // 
            this.cmdDeserialize.Location = new System.Drawing.Point(154, 12);
            this.cmdDeserialize.Name = "cmdDeserialize";
            this.cmdDeserialize.Size = new System.Drawing.Size(136, 35);
            this.cmdDeserialize.TabIndex = 2;
            this.cmdDeserialize.Text = "deserialize";
            this.cmdDeserialize.UseVisualStyleBackColor = true;
            this.cmdDeserialize.Click += new System.EventHandler(this.cmdDeserialize_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 300);
            this.Controls.Add(this.cmdDeserialize);
            this.Controls.Add(this.txtSerialised);
            this.Controls.Add(this.cmdSerialize);
            this.Name = "frmTest";
            this.Text = "TEST SERIALIZER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSerialize;
        private System.Windows.Forms.TextBox txtSerialised;
        private System.Windows.Forms.Button cmdDeserialize;
    }
}

