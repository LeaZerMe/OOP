namespace OOP_Project
{
    partial class Form1
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
            this.workUnitySignUpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.systemLoginBtn = new System.Windows.Forms.Button();
            this.travelDestinationBtn = new System.Windows.Forms.Button();
            this.studInfoBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workUnitySignUpBtn
            // 
            this.workUnitySignUpBtn.Location = new System.Drawing.Point(427, 274);
            this.workUnitySignUpBtn.Name = "workUnitySignUpBtn";
            this.workUnitySignUpBtn.Size = new System.Drawing.Size(178, 51);
            this.workUnitySignUpBtn.TabIndex = 0;
            this.workUnitySignUpBtn.Text = "Зарегіструватися у проф. спілці";
            this.workUnitySignUpBtn.UseVisualStyleBackColor = true;
            this.workUnitySignUpBtn.Click += new System.EventHandler(this.workUnitySignUpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Головний портал університету";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Щоб отримати путівку, потрібно";
            // 
            // systemLoginBtn
            // 
            this.systemLoginBtn.Location = new System.Drawing.Point(12, 274);
            this.systemLoginBtn.Name = "systemLoginBtn";
            this.systemLoginBtn.Size = new System.Drawing.Size(178, 51);
            this.systemLoginBtn.TabIndex = 3;
            this.systemLoginBtn.Text = "Увійти в систему";
            this.systemLoginBtn.UseVisualStyleBackColor = true;
            this.systemLoginBtn.Click += new System.EventHandler(this.systemLoginBtn_Click);
            // 
            // travelDestinationBtn
            // 
            this.travelDestinationBtn.Location = new System.Drawing.Point(222, 274);
            this.travelDestinationBtn.Name = "travelDestinationBtn";
            this.travelDestinationBtn.Size = new System.Drawing.Size(178, 51);
            this.travelDestinationBtn.TabIndex = 4;
            this.travelDestinationBtn.Text = "Переглянути доступні путівки";
            this.travelDestinationBtn.UseVisualStyleBackColor = true;
            this.travelDestinationBtn.Click += new System.EventHandler(this.travelDestinationBtn_Click);
            // 
            // studInfoBtn
            // 
            this.studInfoBtn.Location = new System.Drawing.Point(12, 274);
            this.studInfoBtn.Name = "studInfoBtn";
            this.studInfoBtn.Size = new System.Drawing.Size(178, 51);
            this.studInfoBtn.TabIndex = 5;
            this.studInfoBtn.Text = "Інформація про студента";
            this.studInfoBtn.UseVisualStyleBackColor = true;
            this.studInfoBtn.Visible = false;
            this.studInfoBtn.Click += new System.EventHandler(this.studInfoBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Location = new System.Drawing.Point(427, 274);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(178, 51);
            this.bookTicketBtn.TabIndex = 6;
            this.bookTicketBtn.Text = "Замовити путівку";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Visible = false;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 337);
            this.Controls.Add(this.bookTicketBtn);
            this.Controls.Add(this.studInfoBtn);
            this.Controls.Add(this.travelDestinationBtn);
            this.Controls.Add(this.systemLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workUnitySignUpBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button workUnitySignUpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button systemLoginBtn;
        private System.Windows.Forms.Button travelDestinationBtn;
        private System.Windows.Forms.Button studInfoBtn;
        private System.Windows.Forms.Button bookTicketBtn;
    }
}

