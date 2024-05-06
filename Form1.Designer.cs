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
            this.textBoxEnterSum1 = new System.Windows.Forms.TextBox();
            this.textBoxEnterSum2 = new System.Windows.Forms.TextBox();
            this.textBoxEnterProd1 = new System.Windows.Forms.TextBox();
            this.textBoxEnterProd2 = new System.Windows.Forms.TextBox();
            this.textBoxCompare1 = new System.Windows.Forms.TextBox();
            this.textBoxCompare2 = new System.Windows.Forms.TextBox();
            this.textBoxPolym1 = new System.Windows.Forms.TextBox();
            this.textBoxPolym2 = new System.Windows.Forms.TextBox();
            this.textBoxEnterMinus1 = new System.Windows.Forms.TextBox();
            this.textBoxEnterMinus2 = new System.Windows.Forms.TextBox();
            this.buttonEnterMinus = new System.Windows.Forms.Button();
            this.labelWriteSumRes = new System.Windows.Forms.Label();
            this.labelSumRes = new System.Windows.Forms.Label();
            this.labelMinusRes = new System.Windows.Forms.Label();
            this.labelProdRes = new System.Windows.Forms.Label();
            this.labelCompareRes = new System.Windows.Forms.Label();
            this.labelPolymRes = new System.Windows.Forms.Label();
            this.labelDivideRes = new System.Windows.Forms.Label();
            this.buttonEnterDivide = new System.Windows.Forms.Button();
            this.textBoxDivide1 = new System.Windows.Forms.TextBox();
            this.textBoxDivide2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPathSource = new System.Windows.Forms.TextBox();
            this.textBoxPathResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadSum
            // 
            this.buttonReadSum.AutoSize = true;
            this.buttonReadSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReadSum.Location = new System.Drawing.Point(10, 360);
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
            this.buttonEnterSum.UseVisualStyleBackColor = true;
            this.buttonEnterSum.Click += new System.EventHandler(this.buttonEnterSum_Click);
            // 
            // buttonEnterProd
            // 
            this.buttonEnterProd.AutoSize = true;
            this.buttonEnterProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterProd.Location = new System.Drawing.Point(10, 160);
            this.buttonEnterProd.Name = "buttonEnterProd";
            this.buttonEnterProd.Size = new System.Drawing.Size(279, 30);
            this.buttonEnterProd.TabIndex = 2;
            this.buttonEnterProd.Text = "Знайти добуток двох чисел";
            this.buttonEnterProd.UseVisualStyleBackColor = true;
            this.buttonEnterProd.Click += new System.EventHandler(this.buttonEnterProd_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.AutoSize = true;
            this.buttonCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCompare.Location = new System.Drawing.Point(10, 260);
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
            this.buttonPolym.Location = new System.Drawing.Point(10, 310);
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
            this.buttonExit.Location = new System.Drawing.Point(10, 410);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxEnterSum1
            // 
            this.textBoxEnterSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterSum1.Location = new System.Drawing.Point(360, 60);
            this.textBoxEnterSum1.Name = "textBoxEnterSum1";
            this.textBoxEnterSum1.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterSum1.TabIndex = 11;
            // 
            // textBoxEnterSum2
            // 
            this.textBoxEnterSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterSum2.Location = new System.Drawing.Point(560, 60);
            this.textBoxEnterSum2.Name = "textBoxEnterSum2";
            this.textBoxEnterSum2.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterSum2.TabIndex = 12;
            // 
            // textBoxEnterProd1
            // 
            this.textBoxEnterProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterProd1.Location = new System.Drawing.Point(360, 160);
            this.textBoxEnterProd1.Name = "textBoxEnterProd1";
            this.textBoxEnterProd1.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterProd1.TabIndex = 13;
            // 
            // textBoxEnterProd2
            // 
            this.textBoxEnterProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterProd2.Location = new System.Drawing.Point(560, 160);
            this.textBoxEnterProd2.Name = "textBoxEnterProd2";
            this.textBoxEnterProd2.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterProd2.TabIndex = 14;
            // 
            // textBoxCompare1
            // 
            this.textBoxCompare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompare1.Location = new System.Drawing.Point(360, 260);
            this.textBoxCompare1.Name = "textBoxCompare1";
            this.textBoxCompare1.Size = new System.Drawing.Size(200, 27);
            this.textBoxCompare1.TabIndex = 15;
            // 
            // textBoxCompare2
            // 
            this.textBoxCompare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompare2.Location = new System.Drawing.Point(560, 260);
            this.textBoxCompare2.Name = "textBoxCompare2";
            this.textBoxCompare2.Size = new System.Drawing.Size(200, 27);
            this.textBoxCompare2.TabIndex = 16;
            // 
            // textBoxPolym1
            // 
            this.textBoxPolym1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolym1.Location = new System.Drawing.Point(360, 310);
            this.textBoxPolym1.Name = "textBoxPolym1";
            this.textBoxPolym1.Size = new System.Drawing.Size(200, 27);
            this.textBoxPolym1.TabIndex = 20;
            // 
            // textBoxPolym2
            // 
            this.textBoxPolym2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolym2.Location = new System.Drawing.Point(560, 310);
            this.textBoxPolym2.Name = "textBoxPolym2";
            this.textBoxPolym2.Size = new System.Drawing.Size(200, 27);
            this.textBoxPolym2.TabIndex = 21;
            // 
            // textBoxEnterMinus1
            // 
            this.textBoxEnterMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterMinus1.Location = new System.Drawing.Point(360, 110);
            this.textBoxEnterMinus1.Name = "textBoxEnterMinus1";
            this.textBoxEnterMinus1.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterMinus1.TabIndex = 22;
            // 
            // textBoxEnterMinus2
            // 
            this.textBoxEnterMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterMinus2.Location = new System.Drawing.Point(560, 110);
            this.textBoxEnterMinus2.Name = "textBoxEnterMinus2";
            this.textBoxEnterMinus2.Size = new System.Drawing.Size(200, 27);
            this.textBoxEnterMinus2.TabIndex = 23;
            // 
            // buttonEnterMinus
            // 
            this.buttonEnterMinus.AutoSize = true;
            this.buttonEnterMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterMinus.Location = new System.Drawing.Point(10, 110);
            this.buttonEnterMinus.Name = "buttonEnterMinus";
            this.buttonEnterMinus.Size = new System.Drawing.Size(276, 30);
            this.buttonEnterMinus.TabIndex = 25;
            this.buttonEnterMinus.Text = "Знайти різницю двох чисел";
            this.buttonEnterMinus.UseVisualStyleBackColor = true;
            this.buttonEnterMinus.Click += new System.EventHandler(this.buttonEnterMinus_Click);
            // 
            // labelWriteSumRes
            // 
            this.labelWriteSumRes.AutoSize = true;
            this.labelWriteSumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWriteSumRes.Location = new System.Drawing.Point(790, 360);
            this.labelWriteSumRes.Name = "labelWriteSumRes";
            this.labelWriteSumRes.Size = new System.Drawing.Size(196, 20);
            this.labelWriteSumRes.TabIndex = 26;
            this.labelWriteSumRes.Text = "Сума чисел з файлу";
            // 
            // labelSumRes
            // 
            this.labelSumRes.AutoSize = true;
            this.labelSumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumRes.Location = new System.Drawing.Point(790, 60);
            this.labelSumRes.Name = "labelSumRes";
            this.labelSumRes.Size = new System.Drawing.Size(165, 20);
            this.labelSumRes.TabIndex = 27;
            this.labelSumRes.Text = "Сума двох чисел";
            // 
            // labelMinusRes
            // 
            this.labelMinusRes.AutoSize = true;
            this.labelMinusRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinusRes.Location = new System.Drawing.Point(790, 110);
            this.labelMinusRes.Name = "labelMinusRes";
            this.labelMinusRes.Size = new System.Drawing.Size(190, 20);
            this.labelMinusRes.TabIndex = 28;
            this.labelMinusRes.Text = "Різниця двох чисел";
            // 
            // labelProdRes
            // 
            this.labelProdRes.AutoSize = true;
            this.labelProdRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdRes.Location = new System.Drawing.Point(790, 160);
            this.labelProdRes.Name = "labelProdRes";
            this.labelProdRes.Size = new System.Drawing.Size(196, 20);
            this.labelProdRes.TabIndex = 29;
            this.labelProdRes.Text = "Добуток двох чисел";
            // 
            // labelCompareRes
            // 
            this.labelCompareRes.AutoSize = true;
            this.labelCompareRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompareRes.Location = new System.Drawing.Point(790, 260);
            this.labelCompareRes.Name = "labelCompareRes";
            this.labelCompareRes.Size = new System.Drawing.Size(216, 20);
            this.labelCompareRes.TabIndex = 30;
            this.labelCompareRes.Text = "Результат порівняння";
            // 
            // labelPolymRes
            // 
            this.labelPolymRes.AutoSize = true;
            this.labelPolymRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolymRes.Location = new System.Drawing.Point(790, 310);
            this.labelPolymRes.Name = "labelPolymRes";
            this.labelPolymRes.Size = new System.Drawing.Size(311, 20);
            this.labelPolymRes.TabIndex = 31;
            this.labelPolymRes.Text = "Результат роботи поліморфізму";
            // 
            // labelDivideRes
            // 
            this.labelDivideRes.AutoSize = true;
            this.labelDivideRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivideRes.Location = new System.Drawing.Point(790, 210);
            this.labelDivideRes.Name = "labelDivideRes";
            this.labelDivideRes.Size = new System.Drawing.Size(186, 20);
            this.labelDivideRes.TabIndex = 32;
            this.labelDivideRes.Text = "Частка двох чисел";
            // 
            // buttonEnterDivide
            // 
            this.buttonEnterDivide.AutoSize = true;
            this.buttonEnterDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterDivide.Location = new System.Drawing.Point(10, 210);
            this.buttonEnterDivide.Name = "buttonEnterDivide";
            this.buttonEnterDivide.Size = new System.Drawing.Size(265, 30);
            this.buttonEnterDivide.TabIndex = 33;
            this.buttonEnterDivide.Text = "Знайти частку двох чисел";
            this.buttonEnterDivide.UseVisualStyleBackColor = true;
            this.buttonEnterDivide.Click += new System.EventHandler(this.buttonEnterDivide_Click);
            // 
            // textBoxDivide1
            // 
            this.textBoxDivide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDivide1.Location = new System.Drawing.Point(360, 210);
            this.textBoxDivide1.Name = "textBoxDivide1";
            this.textBoxDivide1.Size = new System.Drawing.Size(200, 27);
            this.textBoxDivide1.TabIndex = 34;
            // 
            // textBoxDivide2
            // 
            this.textBoxDivide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDivide2.Location = new System.Drawing.Point(560, 210);
            this.textBoxDivide2.Name = "textBoxDivide2";
            this.textBoxDivide2.Size = new System.Drawing.Size(200, 27);
            this.textBoxDivide2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(360, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Файл для читання";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(560, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Файл для запису";
            // 
            // textBoxPathSource
            // 
            this.textBoxPathSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPathSource.Location = new System.Drawing.Point(360, 360);
            this.textBoxPathSource.Name = "textBoxPathSource";
            this.textBoxPathSource.Size = new System.Drawing.Size(200, 27);
            this.textBoxPathSource.TabIndex = 38;
            // 
            // textBoxPathResult
            // 
            this.textBoxPathResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPathResult.Location = new System.Drawing.Point(560, 360);
            this.textBoxPathResult.Name = "textBoxPathResult";
            this.textBoxPathResult.Size = new System.Drawing.Size(200, 27);
            this.textBoxPathResult.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(790, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Приклад шляху: С:\\\\user\\\\file.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPathResult);
            this.Controls.Add(this.textBoxPathSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDivide2);
            this.Controls.Add(this.textBoxDivide1);
            this.Controls.Add(this.buttonEnterDivide);
            this.Controls.Add(this.labelDivideRes);
            this.Controls.Add(this.labelPolymRes);
            this.Controls.Add(this.labelCompareRes);
            this.Controls.Add(this.labelProdRes);
            this.Controls.Add(this.labelMinusRes);
            this.Controls.Add(this.labelSumRes);
            this.Controls.Add(this.labelWriteSumRes);
            this.Controls.Add(this.buttonEnterMinus);
            this.Controls.Add(this.textBoxEnterMinus2);
            this.Controls.Add(this.textBoxEnterMinus1);
            this.Controls.Add(this.textBoxPolym2);
            this.Controls.Add(this.textBoxPolym1);
            this.Controls.Add(this.textBoxCompare2);
            this.Controls.Add(this.textBoxCompare1);
            this.Controls.Add(this.textBoxEnterProd2);
            this.Controls.Add(this.textBoxEnterProd1);
            this.Controls.Add(this.textBoxEnterSum2);
            this.Controls.Add(this.textBoxEnterSum1);
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
        private System.Windows.Forms.TextBox textBoxEnterSum1;
        private System.Windows.Forms.TextBox textBoxEnterSum2;
        private System.Windows.Forms.TextBox textBoxEnterProd1;
        private System.Windows.Forms.TextBox textBoxEnterProd2;
        private System.Windows.Forms.TextBox textBoxCompare1;
        private System.Windows.Forms.TextBox textBoxCompare2;
        private System.Windows.Forms.TextBox textBoxPolym1;
        private System.Windows.Forms.TextBox textBoxPolym2;
        private System.Windows.Forms.TextBox textBoxEnterMinus1;
        private System.Windows.Forms.TextBox textBoxEnterMinus2;
        private System.Windows.Forms.Button buttonEnterMinus;
        private System.Windows.Forms.Label labelWriteSumRes;
        private System.Windows.Forms.Label labelSumRes;
        private System.Windows.Forms.Label labelMinusRes;
        private System.Windows.Forms.Label labelProdRes;
        private System.Windows.Forms.Label labelCompareRes;
        private System.Windows.Forms.Label labelPolymRes;
        private System.Windows.Forms.Label labelDivideRes;
        private System.Windows.Forms.Button buttonEnterDivide;
        private System.Windows.Forms.TextBox textBoxDivide1;
        private System.Windows.Forms.TextBox textBoxDivide2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPathSource;
        private System.Windows.Forms.TextBox textBoxPathResult;
        private System.Windows.Forms.Label label3;
    }
}

