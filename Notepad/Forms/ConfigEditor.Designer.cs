
namespace Notepad.Forms
{
    partial class ConfigEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditor));
            this.label1 = new System.Windows.Forms.Label();
            this._txtFont = new System.Windows.Forms.TextBox();
            this._btnChangeFont = new System.Windows.Forms.Button();
            this._btnOk = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtFile = new System.Windows.Forms.TextBox();
            this._btnFile = new System.Windows.Forms.Button();
            this._lblAutoSave = new System.Windows.Forms.Label();
            this._nrthreshold = new System.Windows.Forms.TrackBar();
            this._cbWordWrap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._nrthreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // _txtFont
            // 
            this._txtFont.Location = new System.Drawing.Point(12, 25);
            this._txtFont.Name = "_txtFont";
            this._txtFont.ReadOnly = true;
            this._txtFont.Size = new System.Drawing.Size(361, 20);
            this._txtFont.TabIndex = 1;
            // 
            // _btnChangeFont
            // 
            this._btnChangeFont.Location = new System.Drawing.Point(379, 23);
            this._btnChangeFont.Name = "_btnChangeFont";
            this._btnChangeFont.Size = new System.Drawing.Size(75, 23);
            this._btnChangeFont.TabIndex = 2;
            this._btnChangeFont.Text = "Change";
            this._btnChangeFont.UseVisualStyleBackColor = true;
            this._btnChangeFont.Click += new System.EventHandler(this._btnChangeFont_Click);
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(298, 415);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 23);
            this._btnOk.TabIndex = 3;
            this._btnOk.Text = "OK";
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(379, 415);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File";
            // 
            // _txtFile
            // 
            this._txtFile.Location = new System.Drawing.Point(12, 64);
            this._txtFile.Name = "_txtFile";
            this._txtFile.Size = new System.Drawing.Size(361, 20);
            this._txtFile.TabIndex = 6;
            // 
            // _btnFile
            // 
            this._btnFile.Location = new System.Drawing.Point(379, 62);
            this._btnFile.Name = "_btnFile";
            this._btnFile.Size = new System.Drawing.Size(75, 23);
            this._btnFile.TabIndex = 7;
            this._btnFile.Text = "Browse";
            this._btnFile.UseVisualStyleBackColor = true;
            this._btnFile.Click += new System.EventHandler(this._btnFile_Click);
            // 
            // _lblAutoSave
            // 
            this._lblAutoSave.AutoSize = true;
            this._lblAutoSave.Location = new System.Drawing.Point(12, 87);
            this._lblAutoSave.Name = "_lblAutoSave";
            this._lblAutoSave.Size = new System.Drawing.Size(130, 13);
            this._lblAutoSave.TabIndex = 8;
            this._lblAutoSave.Text = "Auto save after x seconds";
            // 
            // _nrthreshold
            // 
            this._nrthreshold.Location = new System.Drawing.Point(12, 103);
            this._nrthreshold.Maximum = 120;
            this._nrthreshold.Minimum = 1;
            this._nrthreshold.Name = "_nrthreshold";
            this._nrthreshold.Size = new System.Drawing.Size(442, 45);
            this._nrthreshold.TabIndex = 9;
            this._nrthreshold.Value = 1;
            this._nrthreshold.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // _cbWordWrap
            // 
            this._cbWordWrap.AutoSize = true;
            this._cbWordWrap.Location = new System.Drawing.Point(12, 154);
            this._cbWordWrap.Name = "_cbWordWrap";
            this._cbWordWrap.Size = new System.Drawing.Size(81, 17);
            this._cbWordWrap.TabIndex = 10;
            this._cbWordWrap.Text = "Word Wrap";
            this._cbWordWrap.UseVisualStyleBackColor = true;
            this._cbWordWrap.CheckedChanged += new System.EventHandler(this._cbWordWrap_CheckedChanged);
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this._cbWordWrap);
            this.Controls.Add(this._nrthreshold);
            this.Controls.Add(this._lblAutoSave);
            this.Controls.Add(this._btnFile);
            this.Controls.Add(this._txtFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._btnChangeFont);
            this.Controls.Add(this._txtFont);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Editor";
            ((System.ComponentModel.ISupportInitialize)(this._nrthreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtFont;
        private System.Windows.Forms.Button _btnChangeFont;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtFile;
        private System.Windows.Forms.Button _btnFile;
        private System.Windows.Forms.Label _lblAutoSave;
        private System.Windows.Forms.TrackBar _nrthreshold;
        private System.Windows.Forms.CheckBox _cbWordWrap;
    }
}