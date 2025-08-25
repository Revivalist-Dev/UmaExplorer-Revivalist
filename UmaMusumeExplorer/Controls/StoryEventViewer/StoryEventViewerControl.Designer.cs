namespace UmaMusumeExplorer.Controls.StoryEventViewer
{
    partial class StoryEventViewerControl
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
            this.storyEventTreeView = new System.Windows.Forms.TreeView();
            this.dialogueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // storyEventTreeView
            // 
            this.storyEventTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.storyEventTreeView.Location = new System.Drawing.Point(0, 0);
            this.storyEventTreeView.Name = "storyEventTreeView";
            this.storyEventTreeView.Size = new System.Drawing.Size(200, 450);
            this.storyEventTreeView.TabIndex = 0;
            // 
            // dialogueRichTextBox
            // 
            this.dialogueRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogueRichTextBox.Location = new System.Drawing.Point(200, 0);
            this.dialogueRichTextBox.Name = "dialogueRichTextBox";
            this.dialogueRichTextBox.Size = new System.Drawing.Size(400, 450);
            this.dialogueRichTextBox.TabIndex = 1;
            this.dialogueRichTextBox.Text = "";
            // 
            // StoryEventViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dialogueRichTextBox);
            this.Controls.Add(this.storyEventTreeView);
            this.Name = "StoryEventViewerControl";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.StoryEventViewerControl_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView storyEventTreeView;
        private System.Windows.Forms.RichTextBox dialogueRichTextBox;
    }
}