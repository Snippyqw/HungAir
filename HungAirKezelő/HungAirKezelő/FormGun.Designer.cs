namespace HungAirKezelő
{
    partial class FormGun
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
            this.dTGVGun = new System.Windows.Forms.DataGridView();
            this.bLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dTGVGun)).BeginInit();
            this.SuspendLayout();
            // 
            // dTGVGun
            // 
            this.dTGVGun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTGVGun.Location = new System.Drawing.Point(12, 12);
            this.dTGVGun.Name = "dTGVGun";
            this.dTGVGun.Size = new System.Drawing.Size(776, 320);
            this.dTGVGun.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 338);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Betöltés";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // FormGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.dTGVGun);
            this.Name = "FormGun";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dTGVGun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dTGVGun;
        private System.Windows.Forms.Button bLoad;
    }
}

