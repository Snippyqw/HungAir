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
            this.components = new System.ComponentModel.Container();
            this.dTGVGun = new System.Windows.Forms.DataGridView();
            this.bLoad = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bMod = new System.Windows.Forms.Button();
            this.ePNew = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dTGVGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNew)).BeginInit();
            this.SuspendLayout();
            // 
            // dTGVGun
            // 
            this.dTGVGun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTGVGun.Location = new System.Drawing.Point(12, 12);
            this.dTGVGun.Name = "dTGVGun";
            this.dTGVGun.Size = new System.Drawing.Size(943, 320);
            this.dTGVGun.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 338);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(85, 34);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Betöltés";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(12, 378);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(85, 34);
            this.bNew.TabIndex = 2;
            this.bNew.Text = "Új";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(132, 338);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(85, 34);
            this.bDel.TabIndex = 3;
            this.bDel.Text = "Törlés";
            this.bDel.UseVisualStyleBackColor = true;
            // 
            // bMod
            // 
            this.bMod.Location = new System.Drawing.Point(132, 378);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(85, 34);
            this.bMod.TabIndex = 4;
            this.bMod.Text = "Módosítás";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.bMod_Click);
            // 
            // ePNew
            // 
            this.ePNew.ContainerControl = this;
            // 
            // FormGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.dTGVGun);
            this.Name = "FormGun";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dTGVGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dTGVGun;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bMod;
        private System.Windows.Forms.ErrorProvider ePNew;
    }
}

