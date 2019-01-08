namespace WindowsFormsApp1
{
    partial class Tower
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
            this.disksTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.loopSelector = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.totalTimeCounter = new System.Windows.Forms.Label();
            this.totalTurnCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // disksTextBox
            // 
            this.disksTextBox.Location = new System.Drawing.Point(25, 53);
            this.disksTextBox.Name = "disksTextBox";
            this.disksTextBox.Size = new System.Drawing.Size(87, 20);
            this.disksTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disks";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(713, 7);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(96, 24);
            this.lable.TabIndex = 3;
            this.lable.Text = "LoopType";
            // 
            // loopSelector
            // 
            this.loopSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopSelector.FormattingEnabled = true;
            this.loopSelector.Items.AddRange(new object[] {
            "For Loop",
            "Maxverheffen",
            "Recursie"});
            this.loopSelector.Location = new System.Drawing.Point(717, 34);
            this.loopSelector.Name = "loopSelector";
            this.loopSelector.Size = new System.Drawing.Size(162, 32);
            this.loopSelector.TabIndex = 5;
            this.loopSelector.Text = "For Loop";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(717, 73);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 32);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // totalTimeCounter
            // 
            this.totalTimeCounter.AutoSize = true;
            this.totalTimeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeCounter.ForeColor = System.Drawing.Color.Teal;
            this.totalTimeCounter.Location = new System.Drawing.Point(81, 139);
            this.totalTimeCounter.Name = "totalTimeCounter";
            this.totalTimeCounter.Size = new System.Drawing.Size(518, 24);
            this.totalTimeCounter.TabIndex = 7;
            this.totalTimeCounter.Text = "0 Years : 0 Months : 0 Days : 0 Hours : 0 Minutes : 0 Seconds";
            // 
            // totalTurnCounter
            // 
            this.totalTurnCounter.AutoSize = true;
            this.totalTurnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTurnCounter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalTurnCounter.Location = new System.Drawing.Point(80, 110);
            this.totalTurnCounter.Name = "totalTurnCounter";
            this.totalTurnCounter.Size = new System.Drawing.Size(26, 29);
            this.totalTurnCounter.TabIndex = 8;
            this.totalTurnCounter.Text = "0";
            this.totalTurnCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Moves :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time :";
            // 
            // Tower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(891, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTurnCounter);
            this.Controls.Add(this.totalTimeCounter);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.loopSelector);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disksTextBox);
            this.Name = "Tower";
            this.Text = "Towers of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox disksTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox loopSelector;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label totalTimeCounter;
        private System.Windows.Forms.Label totalTurnCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

