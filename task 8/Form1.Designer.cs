
namespace task_8
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fPath = new System.Windows.Forms.TextBox();
            this.sPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newText = new System.Windows.Forms.TextBox();
            this.FIleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Файл изменен";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Файл удален";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Файл создан";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fPath
            // 
            this.fPath.Location = new System.Drawing.Point(232, 59);
            this.fPath.Name = "fPath";
            this.fPath.Size = new System.Drawing.Size(642, 27);
            this.fPath.TabIndex = 3;
            // 
            // sPath
            // 
            this.sPath.Location = new System.Drawing.Point(232, 125);
            this.sPath.Name = "sPath";
            this.sPath.Size = new System.Drawing.Size(641, 27);
            this.sPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь к первому устройству";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь ко второму устройству";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст";
            // 
            // newText
            // 
            this.newText.Location = new System.Drawing.Point(232, 249);
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(641, 27);
            this.newText.TabIndex = 8;
            // 
            // FIleName
            // 
            this.FIleName.Location = new System.Drawing.Point(233, 183);
            this.FIleName.Name = "FIleName";
            this.FIleName.Size = new System.Drawing.Size(641, 27);
            this.FIleName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FIleName);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sPath);
            this.Controls.Add(this.fPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox fPath;
        private System.Windows.Forms.TextBox sPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newText;
        private System.Windows.Forms.TextBox FIleName;
        private System.Windows.Forms.Label label4;
    }
}

