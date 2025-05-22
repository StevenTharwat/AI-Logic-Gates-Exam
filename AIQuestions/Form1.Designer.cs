namespace AIQuestions
{
    partial class Form1
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
            this.txtSigns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSigns
            // 
            this.txtSigns.Location = new System.Drawing.Point(76, 70);
            this.txtSigns.Name = "txtSigns";
            this.txtSigns.Size = new System.Drawing.Size(229, 23);
            this.txtSigns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Signs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(76, 115);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(229, 23);
            this.txtQuestion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(76, 162);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(229, 23);
            this.txtAnswer.TabIndex = 6;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(76, 209);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(76, 246);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(134, 23);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change Question";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labStatus.Location = new System.Drawing.Point(232, 222);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(73, 30);
            this.labStatus.TabIndex = 10;
            this.labStatus.Text = "Status";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labScore.ForeColor = System.Drawing.Color.Green;
            this.labScore.Location = new System.Drawing.Point(76, 9);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(106, 30);
            this.labScore.TabIndex = 11;
            this.labScore.Text = "Score = 0";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labAnswer.Location = new System.Drawing.Point(54, 283);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(86, 30);
            this.labAnswer.TabIndex = 12;
            this.labAnswer.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 322);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSigns);
            this.Name = "Form1";
            this.Text = "AI Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSigns;
        private Label label1;
        private Label label2;
        private TextBox txtQuestion;
        private Label label3;
        private TextBox txtAnswer;
        private Button btnCheck;
        private Button btnChange;
        private Label labStatus;
        private Label labScore;
        private Label labAnswer;
    }
}