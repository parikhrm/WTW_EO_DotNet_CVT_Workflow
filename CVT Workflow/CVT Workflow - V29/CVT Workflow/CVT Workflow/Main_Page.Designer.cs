namespace CVT_Workflow
{
    partial class Main_Page
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
            this.passfort_cvt = new System.Windows.Forms.Button();
            this.cvt_workflow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passfort_cvt
            // 
            this.passfort_cvt.BackColor = System.Drawing.Color.Purple;
            this.passfort_cvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passfort_cvt.ForeColor = System.Drawing.Color.White;
            this.passfort_cvt.Location = new System.Drawing.Point(854, 176);
            this.passfort_cvt.Name = "passfort_cvt";
            this.passfort_cvt.Size = new System.Drawing.Size(364, 153);
            this.passfort_cvt.TabIndex = 4;
            this.passfort_cvt.Text = "PassFort - CVT";
            this.passfort_cvt.UseVisualStyleBackColor = false;
            this.passfort_cvt.Click += new System.EventHandler(this.passfort_cvt_Click);
            // 
            // cvt_workflow
            // 
            this.cvt_workflow.BackColor = System.Drawing.Color.Purple;
            this.cvt_workflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvt_workflow.ForeColor = System.Drawing.Color.White;
            this.cvt_workflow.Location = new System.Drawing.Point(462, 176);
            this.cvt_workflow.Name = "cvt_workflow";
            this.cvt_workflow.Size = new System.Drawing.Size(364, 153);
            this.cvt_workflow.TabIndex = 3;
            this.cvt_workflow.Text = "CVT Workflow";
            this.cvt_workflow.UseVisualStyleBackColor = false;
            this.cvt_workflow.Click += new System.EventHandler(this.cvt_workflow_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1731, 636);
            this.Controls.Add(this.passfort_cvt);
            this.Controls.Add(this.cvt_workflow);
            this.Name = "Main_Page";
            this.Text = "Main_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passfort_cvt;
        private System.Windows.Forms.Button cvt_workflow;
    }
}