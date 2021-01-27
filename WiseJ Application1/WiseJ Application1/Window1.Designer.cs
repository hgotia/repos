
namespace WiseJ_Application1
{
    partial class Window1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromName("@appWorkspace");
            this.button1.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.button1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(184, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me!";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(184, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Watermark = "Pick a location";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Window1";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.ComboBox comboBox1;
    }
}

