namespace ExceptionsAndDelegates
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbxShowDialog = new System.Windows.Forms.CheckBox();
            this.chbxSaveToFile = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnOneArgument = new System.Windows.Forms.RadioButton();
            this.btnTwoArguments = new System.Windows.Forms.RadioButton();
            this.textBoxDef1 = new System.Windows.Forms.TextBox();
            this.textBoxDef2 = new System.Windows.Forms.TextBox();
            this.comboBoxDef = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chbxShowDialog
            // 
            this.chbxShowDialog.AutoSize = true;
            this.chbxShowDialog.Location = new System.Drawing.Point(13, 13);
            this.chbxShowDialog.Name = "chbxShowDialog";
            this.chbxShowDialog.Size = new System.Drawing.Size(84, 17);
            this.chbxShowDialog.TabIndex = 0;
            this.chbxShowDialog.Text = "Show dialog";
            this.chbxShowDialog.UseVisualStyleBackColor = true;
            this.chbxShowDialog.CheckedChanged += new System.EventHandler(this.chbxShowDialog_CheckedChanged);
            // 
            // chbxSaveToFile
            // 
            this.chbxSaveToFile.AutoSize = true;
            this.chbxSaveToFile.Location = new System.Drawing.Point(13, 36);
            this.chbxSaveToFile.Name = "chbxSaveToFile";
            this.chbxSaveToFile.Size = new System.Drawing.Size(79, 17);
            this.chbxSaveToFile.TabIndex = 1;
            this.chbxSaveToFile.Text = "Save to file";
            this.chbxSaveToFile.UseVisualStyleBackColor = true;
            this.chbxSaveToFile.CheckedChanged += new System.EventHandler(this.chbxSaveToFile_CheckedChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(183, 26);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnOneArgument
            // 
            this.btnOneArgument.AutoSize = true;
            this.btnOneArgument.Location = new System.Drawing.Point(13, 118);
            this.btnOneArgument.Name = "btnOneArgument";
            this.btnOneArgument.Size = new System.Drawing.Size(92, 17);
            this.btnOneArgument.TabIndex = 3;
            this.btnOneArgument.TabStop = true;
            this.btnOneArgument.Text = "One argument";
            this.btnOneArgument.UseVisualStyleBackColor = true;
            this.btnOneArgument.CheckedChanged += new System.EventHandler(this.btnOneArgument_CheckedChanged);
            // 
            // btnTwoArguments
            // 
            this.btnTwoArguments.AutoSize = true;
            this.btnTwoArguments.Location = new System.Drawing.Point(13, 142);
            this.btnTwoArguments.Name = "btnTwoArguments";
            this.btnTwoArguments.Size = new System.Drawing.Size(98, 17);
            this.btnTwoArguments.TabIndex = 4;
            this.btnTwoArguments.TabStop = true;
            this.btnTwoArguments.Text = "Two arguments";
            this.btnTwoArguments.UseVisualStyleBackColor = true;
            this.btnTwoArguments.CheckedChanged += new System.EventHandler(this.btnTwoArguments_CheckedChanged);
            // 
            // textBoxDef1
            // 
            this.textBoxDef1.Location = new System.Drawing.Point(134, 118);
            this.textBoxDef1.Name = "textBoxDef1";
            this.textBoxDef1.Size = new System.Drawing.Size(121, 20);
            this.textBoxDef1.TabIndex = 5;
            // 
            // textBoxDef2
            // 
            this.textBoxDef2.Location = new System.Drawing.Point(134, 145);
            this.textBoxDef2.Name = "textBoxDef2";
            this.textBoxDef2.Size = new System.Drawing.Size(121, 20);
            this.textBoxDef2.TabIndex = 6;
            // 
            // comboBoxDef
            // 
            this.comboBoxDef.FormattingEnabled = true;
            this.comboBoxDef.Location = new System.Drawing.Point(134, 172);
            this.comboBoxDef.Name = "comboBoxDef";
            this.comboBoxDef.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDef.TabIndex = 7;
            this.comboBoxDef.SelectedIndexChanged += new System.EventHandler(this.comboBoxDef_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxDef);
            this.Controls.Add(this.textBoxDef2);
            this.Controls.Add(this.textBoxDef1);
            this.Controls.Add(this.btnTwoArguments);
            this.Controls.Add(this.btnOneArgument);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.chbxSaveToFile);
            this.Controls.Add(this.chbxShowDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxShowDialog;
        private System.Windows.Forms.CheckBox chbxSaveToFile;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton btnOneArgument;
        private System.Windows.Forms.RadioButton btnTwoArguments;
        private System.Windows.Forms.TextBox textBoxDef1;
        private System.Windows.Forms.TextBox textBoxDef2;
        private System.Windows.Forms.ComboBox comboBoxDef;
    }
}

