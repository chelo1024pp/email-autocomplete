namespace CustomControls
{
    partial class TextBoxEmailAutocomplete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbSuggestions = new CustomControls.TextBoxEmailAutocomplete.CustomListBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(0, 0);
            this.tbInput.MinimumSize = new System.Drawing.Size(100, 45);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(400, 45);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "line1\r\nline2\r\nline3";
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
            // 
            // lbSuggestions
            // 
            this.lbSuggestions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSuggestions.FormattingEnabled = true;
            this.lbSuggestions.Items.AddRange(new object[] {
            "line1",
            "line2",
            "line3",
            "line4",
            "line5",
            "line6",
            "line7",
            "line8",
            "line9",
            "line10",
            "line11",
            "line12",
            "line13",
            "line14",
            "line15"});
            this.lbSuggestions.Location = new System.Drawing.Point(0, 44);
            this.lbSuggestions.Name = "lbSuggestions";
            this.lbSuggestions.Size = new System.Drawing.Size(200, 199);
            this.lbSuggestions.TabIndex = 1;
            this.lbSuggestions.VisibleChanged += new System.EventHandler(this.lbSuggestions_VisibleChanged);
            this.lbSuggestions.SizeChanged += new System.EventHandler(this.lbSuggestions_SizeChanged);
            this.lbSuggestions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbSuggestions_MouseMove);
            this.lbSuggestions.Click += new System.EventHandler(this.lbSuggestions_Click);
            // 
            // TextBoxEmailAutocomplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSuggestions);
            this.Controls.Add(this.tbInput);
            this.MaximumSize = new System.Drawing.Size(99999, 246);
            this.MinimumSize = new System.Drawing.Size(103, 246);
            this.Name = "TextBoxEmailAutocomplete";
            this.Size = new System.Drawing.Size(403, 246);
            this.Leave += new System.EventHandler(this.TextBoxEmailAutocomplete_Leave);
            this.Resize += new System.EventHandler(this.TextBoxEmailAutocomplete_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private CustomControls.TextBoxEmailAutocomplete.CustomListBox lbSuggestions;
    }
}
