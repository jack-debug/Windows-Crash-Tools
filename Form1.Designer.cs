namespace ComputerCrashingTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.crash = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Crash Tools";
            // 
            // crash
            // 
            this.crash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crash.Location = new System.Drawing.Point(22, 92);
            this.crash.Name = "crash";
            this.crash.Size = new System.Drawing.Size(153, 65);
            this.crash.TabIndex = 1;
            this.crash.Text = "Press For Crash";
            this.crash.UseVisualStyleBackColor = true;
            this.crash.Click += new System.EventHandler(this.crash_Click);
            // 
            // shutdown
            // 
            this.shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdown.Location = new System.Drawing.Point(359, 92);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(153, 65);
            this.shutdown.TabIndex = 2;
            this.shutdown.Text = "Press For Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 177);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.crash);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Widnows Crash Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crash;
        private System.Windows.Forms.Button shutdown;
    }
}

