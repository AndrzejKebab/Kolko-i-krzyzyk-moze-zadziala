
namespace Tictoc
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.turn = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.Mark);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Location = new System.Drawing.Point(578, 22);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(37, 15);
            this.turn.TabIndex = 1;
            this.turn.Text = "Ruch:";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(623, 22);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(0, 15);
            this.player.TabIndex = 2;
            this.player.Click += new System.EventHandler(this.Mark);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 101);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mark);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 101);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Mark);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 101);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Mark);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 101);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mark);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 101);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Mark);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(243, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 101);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Mark);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 101);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Mark);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 101);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Mark);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(243, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 101);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Mark);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

