namespace Kursova__CS_
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
            this.buttonReadSum = new System.Windows.Forms.Button();
            this.buttonEnterSum = new System.Windows.Forms.Button();
            this.buttonEnterProd = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonPolym = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelReadSum = new System.Windows.Forms.Label();
            this.labelEnterSum = new System.Windows.Forms.Label();
            this.labelEnterProd = new System.Windows.Forms.Label();
            this.labelCompare = new System.Windows.Forms.Label();
            this.labelPolym = new System.Windows.Forms.Label();
            this.textBoxEnterSum1 = new System.Windows.Forms.TextBox();
            this.textBoxEnterSum2 = new System.Windows.Forms.TextBox();
            this.textBoxEnterProd1 = new System.Windows.Forms.TextBox();
            this.textBoxEnterProd2 = new System.Windows.Forms.TextBox();
            this.textBoxCompare1 = new System.Windows.Forms.TextBox();
            this.textBoxCompare2 = new System.Windows.Forms.TextBox();
            this.labelReadSumRes = new System.Windows.Forms.Label();
            this.textBoxPolym1 = new System.Windows.Forms.TextBox();
            this.textBoxPolym2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReadSum
            // 
            this.buttonReadSum.AutoSize = true;
            this.buttonReadSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReadSum.Location = new System.Drawing.Point(10, 10);
            this.buttonReadSum.Name = "buttonReadSum";
            this.buttonReadSum.Size = new System.Drawing.Size(306, 30);
            this.buttonReadSum.TabIndex = 0;
            this.buttonReadSum.Text = "Прочитати файл і знайти суму";
            this.buttonReadSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReadSum.UseVisualStyleBackColor = true;
            this.buttonReadSum.Click += new System.EventHandler(this.buttonReadSum_Click);
            // 
            // buttonEnterSum
            // 
            this.buttonEnterSum.AutoSize = true;
            this.buttonEnterSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterSum.Location = new System.Drawing.Point(10, 60);
            this.buttonEnterSum.Name = "buttonEnterSum";
            this.buttonEnterSum.Size = new System.Drawing.Size(244, 30);
            this.buttonEnterSum.TabIndex = 1;
            this.buttonEnterSum.Text = "Знайти суму двох чисел";
            this.buttonEnterSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnterSum.UseVisualStyleBackColor = true;
            this.buttonEnterSum.Click += new System.EventHandler(this.buttonEnterSum_Click);
            // 
            // buttonEnterProd
            // 
            this.buttonEnterProd.AutoSize = true;
            this.buttonEnterProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterProd.Location = new System.Drawing.Point(10, 110);
            this.buttonEnterProd.Name = "buttonEnterProd";
            this.buttonEnterProd.Size = new System.Drawing.Size(279, 30);
            this.buttonEnterProd.TabIndex = 2;
            this.buttonEnterProd.Text = "Знайти добуток двох чисел";
            this.buttonEnterProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnterProd.UseVisualStyleBackColor = true;
            this.buttonEnterProd.Click += new System.EventHandler(this.buttonEnterProd_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.AutoSize = true;
            this.buttonCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCompare.Location = new System.Drawing.Point(10, 160);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(216, 30);
            this.buttonCompare.TabIndex = 3;
            this.buttonCompare.Text = "Порівняти два числа";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonPolym
            // 
            this.buttonPolym.AutoSize = true;
            this.buttonPolym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolym.Location = new System.Drawing.Point(10, 210);
            this.buttonPolym.Name = "buttonPolym";
            this.buttonPolym.Size = new System.Drawing.Size(323, 30);
            this.buttonPolym.TabIndex = 4;
            this.buttonPolym.Text = "Продемонструвати поліморфізм";
            this.buttonPolym.UseVisualStyleBackColor = true;
            this.buttonPolym.Click += new System.EventHandler(this.buttonPolym_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(10, 260);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelReadSum
            // 
            this.labelReadSum.AutoSize = true;
            this.labelReadSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReadSum.Location = new System.Drawing.Point(850, 10);
            this.labelReadSum.Name = "labelReadSum";
            this.labelReadSum.Size = new System.Drawing.Size(0, 20);
            this.labelReadSum.TabIndex = 6;
            // 
            // labelEnterSum
            // 
            this.labelEnterSum.AutoSize = true;
            this.labelEnterSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterSum.Location = new System.Drawing.Point(850, 60);
            this.labelEnterSum.Name = "labelEnterSum";
            this.labelEnterSum.Size = new System.Drawing.Size(0, 20);
            this.labelEnterSum.TabIndex = 7;
            // 
            // labelEnterProd
            // 
            this.labelEnterProd.AutoSize = true;
            this.labelEnterProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterProd.Location = new System.Drawing.Point(850, 110);
            this.labelEnterProd.Name = "labelEnterProd";
            this.labelEnterProd.Size = new System.Drawing.Size(0, 20);
            this.labelEnterProd.TabIndex = 8;
            // 
            // labelCompare
            // 
            this.labelCompare.AutoSize = true;
            this.labelCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompare.Location = new System.Drawing.Point(850, 160);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(0, 20);
            this.labelCompare.TabIndex = 9;
            // 
            // labelPolym
            // 
            this.labelPolym.AutoSize = true;
            this.labelPolym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolym.Location = new System.Drawing.Point(850, 210);
            this.labelPolym.Name = "labelPolym";
            this.labelPolym.Size = new System.Drawing.Size(0, 20);
            this.labelPolym.TabIndex = 10;
            // 
            // textBoxEnterSum1
            // 
            this.textBoxEnterSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterSum1.Location = new System.Drawing.Point(360, 62);
            this.textBoxEnterSum1.Name = "textBoxEnterSum1";
            this.textBoxEnterSum1.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterSum1.TabIndex = 11;
            // 
            // textBoxEnterSum2
            // 
            this.textBoxEnterSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterSum2.Location = new System.Drawing.Point(566, 62);
            this.textBoxEnterSum2.Name = "textBoxEnterSum2";
            this.textBoxEnterSum2.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterSum2.TabIndex = 12;
            // 
            // textBoxEnterProd1
            // 
            this.textBoxEnterProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterProd1.Location = new System.Drawing.Point(360, 110);
            this.textBoxEnterProd1.Name = "textBoxEnterProd1";
            this.textBoxEnterProd1.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterProd1.TabIndex = 13;
            // 
            // textBoxEnterProd2
            // 
            this.textBoxEnterProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterProd2.Location = new System.Drawing.Point(566, 110);
            this.textBoxEnterProd2.Name = "textBoxEnterProd2";
            this.textBoxEnterProd2.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterProd2.TabIndex = 14;
            // 
            // textBoxCompare1
            // 
            this.textBoxCompare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompare1.Location = new System.Drawing.Point(360, 157);
            this.textBoxCompare1.Name = "textBoxCompare1";
            this.textBoxCompare1.Size = new System.Drawing.Size(200, 27);
            this.textBoxCompare1.TabIndex = 15;
            // 
            // textBoxCompare2
            // 
            this.textBoxCompare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompare2.Location = new System.Drawing.Point(566, 157);
            this.textBoxCompare2.Name = "textBoxCompare2";
            this.textBoxCompare2.Size = new System.Drawing.Size(200, 27);
            this.textBoxCompare2.TabIndex = 16;
            // 
            // labelReadSumRes
            // 
            this.labelReadSumRes.AutoSize = true;
            this.labelReadSumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReadSumRes.Location = new System.Drawing.Point(550, 10);
            this.labelReadSumRes.Name = "labelReadSumRes";
            this.labelReadSumRes.Size = new System.Drawing.Size(0, 20);
            this.labelReadSumRes.TabIndex = 19;
            // 
            // textBoxPolym1
            // 
            this.textBoxPolym1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolym1.Location = new System.Drawing.Point(360, 210);
            this.textBoxPolym1.Name = "textBoxPolym1";
            this.textBoxPolym1.Size = new System.Drawing.Size(200, 27);
            this.textBoxPolym1.TabIndex = 20;
            // 
            // textBoxPolym2
            // 
            this.textBoxPolym2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolym2.Location = new System.Drawing.Point(566, 210);
            this.textBoxPolym2.Name = "textBoxPolym2";
            this.textBoxPolym2.Size = new System.Drawing.Size(200, 27);
            this.textBoxPolym2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 436);
            this.Controls.Add(this.textBoxPolym2);
            this.Controls.Add(this.textBoxPolym1);
            this.Controls.Add(this.labelReadSumRes);
            this.Controls.Add(this.textBoxCompare2);
            this.Controls.Add(this.textBoxCompare1);
            this.Controls.Add(this.textBoxEnterProd2);
            this.Controls.Add(this.textBoxEnterProd1);
            this.Controls.Add(this.textBoxEnterSum2);
            this.Controls.Add(this.textBoxEnterSum1);
            this.Controls.Add(this.labelPolym);
            this.Controls.Add(this.labelCompare);
            this.Controls.Add(this.labelEnterProd);
            this.Controls.Add(this.labelEnterSum);
            this.Controls.Add(this.labelReadSum);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPolym);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonEnterProd);
            this.Controls.Add(this.buttonEnterSum);
            this.Controls.Add(this.buttonReadSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadSum;
        private System.Windows.Forms.Button buttonEnterSum;
        private System.Windows.Forms.Button buttonEnterProd;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonPolym;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelReadSum;
        private System.Windows.Forms.Label labelEnterSum;
        private System.Windows.Forms.Label labelEnterProd;
        private System.Windows.Forms.Label labelCompare;
        private System.Windows.Forms.Label labelPolym;
        private System.Windows.Forms.TextBox textBoxEnterSum1;
        private System.Windows.Forms.TextBox textBoxEnterSum2;
        private System.Windows.Forms.TextBox textBoxEnterProd1;
        private System.Windows.Forms.TextBox textBoxEnterProd2;
        private System.Windows.Forms.TextBox textBoxCompare1;
        private System.Windows.Forms.TextBox textBoxCompare2;
        private System.Windows.Forms.Label labelReadSumRes;
        private System.Windows.Forms.TextBox textBoxPolym1;
        private System.Windows.Forms.TextBox textBoxPolym2;
    }
}

