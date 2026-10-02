namespace _04_Task_Performance_1
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ThreadState = new Label();
            RunButton = new Button();
            SuspendLayout();
            // 
            // ThreadState
            // 
            ThreadState.AutoSize = true;
            ThreadState.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThreadState.Location = new Point(107, 66);
            ThreadState.Name = "ThreadState";
            ThreadState.Size = new Size(207, 32);
            ThreadState.TabIndex = 0;
            ThreadState.Text = "-- Thread Starts --";
            // 
            // RunButton
            // 
            RunButton.Location = new Point(151, 128);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(121, 32);
            RunButton.TabIndex = 1;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 245);
            Controls.Add(RunButton);
            Controls.Add(ThreadState);
            Name = "frmTrackThread";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ThreadState;
        private Button RunButton;
    }
}
