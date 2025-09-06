using System.Diagnostics;
namespace YandexBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(78, 54);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 2;
            label2.Text = "Яндекс блокиратор";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.DisabledLinkColor = Color.Black;
            linkLabel2.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(401, 448);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(85, 13);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "By Dimon1757\r\n";
            linkLabel2.VisitedLinkColor = Color.Black;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI Black", 9.25F, FontStyle.Bold);
            button1.Location = new Point(89, 334);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 4;
            button1.Text = "Заблокировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Font = new Font("Segoe UI Black", 9.25F, FontStyle.Bold);
            button2.Location = new Point(254, 334);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 5;
            button2.Text = "Разблокировать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 461);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Yandex Block";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel linkLabel2;
        private Button button1;
        private Button button2;
    }
}
