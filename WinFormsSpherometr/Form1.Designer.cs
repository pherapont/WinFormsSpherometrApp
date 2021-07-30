
namespace WinFormsSpherometr
{
    public partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.SpherometrTypeGroup = new System.Windows.Forms.GroupBox();
            this.SpherometrSmall = new System.Windows.Forms.RadioButton();
            this.SpherometrBig = new System.Windows.Forms.RadioButton();
            this.CalcTypeGroup = new System.Windows.Forms.GroupBox();
            this.CalcTypeButRadus = new System.Windows.Forms.RadioButton();
            this.CalcTypeButHeight = new System.Windows.Forms.RadioButton();
            this.BigRingsGroup = new System.Windows.Forms.GroupBox();
            this.bRing4 = new System.Windows.Forms.RadioButton();
            this.bRing3 = new System.Windows.Forms.RadioButton();
            this.bRing2 = new System.Windows.Forms.RadioButton();
            this.bRing1 = new System.Windows.Forms.RadioButton();
            this.RingsPreNote = new System.Windows.Forms.Label();
            this.SmallRingsGroup = new System.Windows.Forms.GroupBox();
            this.sRing7 = new System.Windows.Forms.RadioButton();
            this.sRing5 = new System.Windows.Forms.RadioButton();
            this.sRing4 = new System.Windows.Forms.RadioButton();
            this.sRing3 = new System.Windows.Forms.RadioButton();
            this.sRing2 = new System.Windows.Forms.RadioButton();
            this.sRing1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.measure = new System.Windows.Forms.TextBox();
            this.measureGroup = new System.Windows.Forms.GroupBox();
            this.SurfTypeGroup = new System.Windows.Forms.GroupBox();
            this.surfTypeConvex = new System.Windows.Forms.RadioButton();
            this.surfTypeConcave = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.SpherometrTypeGroup.SuspendLayout();
            this.CalcTypeGroup.SuspendLayout();
            this.BigRingsGroup.SuspendLayout();
            this.SmallRingsGroup.SuspendLayout();
            this.measureGroup.SuspendLayout();
            this.SurfTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(674, 471);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(264, 63);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SpherometrTypeGroup
            // 
            this.SpherometrTypeGroup.Controls.Add(this.SpherometrSmall);
            this.SpherometrTypeGroup.Controls.Add(this.SpherometrBig);
            this.SpherometrTypeGroup.Location = new System.Drawing.Point(29, 31);
            this.SpherometrTypeGroup.Name = "SpherometrTypeGroup";
            this.SpherometrTypeGroup.Size = new System.Drawing.Size(180, 71);
            this.SpherometrTypeGroup.TabIndex = 3;
            this.SpherometrTypeGroup.TabStop = false;
            this.SpherometrTypeGroup.Text = "Тип сферометра";
            // 
            // SpherometrSmall
            // 
            this.SpherometrSmall.AutoSize = true;
            this.SpherometrSmall.Location = new System.Drawing.Point(105, 26);
            this.SpherometrSmall.Name = "SpherometrSmall";
            this.SpherometrSmall.Size = new System.Drawing.Size(65, 19);
            this.SpherometrSmall.TabIndex = 1;
            this.SpherometrSmall.TabStop = true;
            this.SpherometrSmall.Text = "Малый";
            this.SpherometrSmall.UseVisualStyleBackColor = true;
            this.SpherometrSmall.Enter += new System.EventHandler(this.SpherometrSmall_Enter);
            // 
            // SpherometrBig
            // 
            this.SpherometrBig.AutoSize = true;
            this.SpherometrBig.Location = new System.Drawing.Point(19, 26);
            this.SpherometrBig.Name = "SpherometrBig";
            this.SpherometrBig.Size = new System.Drawing.Size(77, 19);
            this.SpherometrBig.TabIndex = 0;
            this.SpherometrBig.TabStop = true;
            this.SpherometrBig.Text = "Большой";
            this.SpherometrBig.UseVisualStyleBackColor = true;
            this.SpherometrBig.Enter += new System.EventHandler(this.SpherometrBig_Enter);
            // 
            // CalcTypeGroup
            // 
            this.CalcTypeGroup.Controls.Add(this.CalcTypeButRadus);
            this.CalcTypeGroup.Controls.Add(this.CalcTypeButHeight);
            this.CalcTypeGroup.Location = new System.Drawing.Point(29, 124);
            this.CalcTypeGroup.Name = "CalcTypeGroup";
            this.CalcTypeGroup.Size = new System.Drawing.Size(180, 71);
            this.CalcTypeGroup.TabIndex = 4;
            this.CalcTypeGroup.TabStop = false;
            this.CalcTypeGroup.Text = "Тип вычислений";
            // 
            // CalcTypeButRadus
            // 
            this.CalcTypeButRadus.AutoSize = true;
            this.CalcTypeButRadus.Location = new System.Drawing.Point(105, 32);
            this.CalcTypeButRadus.Name = "CalcTypeButRadus";
            this.CalcTypeButRadus.Size = new System.Drawing.Size(63, 19);
            this.CalcTypeButRadus.TabIndex = 1;
            this.CalcTypeButRadus.TabStop = true;
            this.CalcTypeButRadus.Text = "Радиус";
            this.CalcTypeButRadus.UseVisualStyleBackColor = true;
            this.CalcTypeButRadus.Enter += new System.EventHandler(this.CalcTypeButRadus_Enter);
            // 
            // CalcTypeButHeight
            // 
            this.CalcTypeButHeight.AutoSize = true;
            this.CalcTypeButHeight.Location = new System.Drawing.Point(19, 32);
            this.CalcTypeButHeight.Name = "CalcTypeButHeight";
            this.CalcTypeButHeight.Size = new System.Drawing.Size(70, 19);
            this.CalcTypeButHeight.TabIndex = 0;
            this.CalcTypeButHeight.TabStop = true;
            this.CalcTypeButHeight.Text = "Стрелка";
            this.CalcTypeButHeight.UseVisualStyleBackColor = true;
            this.CalcTypeButHeight.Enter += new System.EventHandler(this.CalcTypeButHeight_Enter);
            // 
            // BigRingsGroup
            // 
            this.BigRingsGroup.Controls.Add(this.bRing4);
            this.BigRingsGroup.Controls.Add(this.bRing3);
            this.BigRingsGroup.Controls.Add(this.bRing2);
            this.BigRingsGroup.Controls.Add(this.bRing1);
            this.BigRingsGroup.Location = new System.Drawing.Point(29, 217);
            this.BigRingsGroup.Name = "BigRingsGroup";
            this.BigRingsGroup.Size = new System.Drawing.Size(387, 71);
            this.BigRingsGroup.TabIndex = 5;
            this.BigRingsGroup.TabStop = false;
            this.BigRingsGroup.Text = "Номер кольца большого сферометра";
            // 
            // bRing4
            // 
            this.bRing4.AutoSize = true;
            this.bRing4.Enabled = false;
            this.bRing4.Location = new System.Drawing.Point(274, 32);
            this.bRing4.Name = "bRing4";
            this.bRing4.Size = new System.Drawing.Size(75, 19);
            this.bRing4.TabIndex = 4;
            this.bRing4.TabStop = true;
            this.bRing4.Text = "Кольцо 4";
            this.bRing4.UseVisualStyleBackColor = true;
            this.bRing4.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // bRing3
            // 
            this.bRing3.AutoSize = true;
            this.bRing3.Enabled = false;
            this.bRing3.Location = new System.Drawing.Point(189, 32);
            this.bRing3.Name = "bRing3";
            this.bRing3.Size = new System.Drawing.Size(75, 19);
            this.bRing3.TabIndex = 3;
            this.bRing3.TabStop = true;
            this.bRing3.Text = "Кольцо 3";
            this.bRing3.UseVisualStyleBackColor = true;
            this.bRing3.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // bRing2
            // 
            this.bRing2.AutoSize = true;
            this.bRing2.Enabled = false;
            this.bRing2.Location = new System.Drawing.Point(104, 32);
            this.bRing2.Name = "bRing2";
            this.bRing2.Size = new System.Drawing.Size(75, 19);
            this.bRing2.TabIndex = 2;
            this.bRing2.TabStop = true;
            this.bRing2.Text = "Кольцо 2";
            this.bRing2.UseVisualStyleBackColor = true;
            this.bRing2.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // bRing1
            // 
            this.bRing1.AutoSize = true;
            this.bRing1.Enabled = false;
            this.bRing1.Location = new System.Drawing.Point(19, 32);
            this.bRing1.Name = "bRing1";
            this.bRing1.Size = new System.Drawing.Size(75, 19);
            this.bRing1.TabIndex = 1;
            this.bRing1.TabStop = true;
            this.bRing1.Text = "Кольцо 1";
            this.bRing1.UseVisualStyleBackColor = true;
            this.bRing1.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // RingsPreNote
            // 
            this.RingsPreNote.AutoSize = true;
            this.RingsPreNote.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RingsPreNote.Location = new System.Drawing.Point(109, 32);
            this.RingsPreNote.Name = "RingsPreNote";
            this.RingsPreNote.Size = new System.Drawing.Size(0, 18);
            this.RingsPreNote.TabIndex = 0;
            // 
            // SmallRingsGroup
            // 
            this.SmallRingsGroup.Controls.Add(this.sRing7);
            this.SmallRingsGroup.Controls.Add(this.sRing5);
            this.SmallRingsGroup.Controls.Add(this.sRing4);
            this.SmallRingsGroup.Controls.Add(this.sRing3);
            this.SmallRingsGroup.Controls.Add(this.sRing2);
            this.SmallRingsGroup.Controls.Add(this.sRing1);
            this.SmallRingsGroup.Location = new System.Drawing.Point(29, 310);
            this.SmallRingsGroup.Name = "SmallRingsGroup";
            this.SmallRingsGroup.Size = new System.Drawing.Size(536, 71);
            this.SmallRingsGroup.TabIndex = 6;
            this.SmallRingsGroup.TabStop = false;
            this.SmallRingsGroup.Text = "Номер кольца малого сферометра";
            // 
            // sRing7
            // 
            this.sRing7.AutoSize = true;
            this.sRing7.Enabled = false;
            this.sRing7.Location = new System.Drawing.Point(449, 31);
            this.sRing7.Name = "sRing7";
            this.sRing7.Size = new System.Drawing.Size(75, 19);
            this.sRing7.TabIndex = 10;
            this.sRing7.TabStop = true;
            this.sRing7.Text = "Кольцо 7";
            this.sRing7.UseVisualStyleBackColor = true;
            this.sRing7.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);

            // 
            // sRing5
            // 
            this.sRing5.AutoSize = true;
            this.sRing5.Enabled = false;
            this.sRing5.Location = new System.Drawing.Point(363, 31);
            this.sRing5.Name = "sRing5";
            this.sRing5.Size = new System.Drawing.Size(75, 19);
            this.sRing5.TabIndex = 10;
            this.sRing5.TabStop = true;
            this.sRing5.Text = "Кольцо 5";
            this.sRing5.UseVisualStyleBackColor = true;
            this.sRing5.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // sRing4
            // 
            this.sRing4.AutoSize = true;
            this.sRing4.Enabled = false;
            this.sRing4.Location = new System.Drawing.Point(277, 31);
            this.sRing4.Name = "sRing4";
            this.sRing4.Size = new System.Drawing.Size(75, 19);
            this.sRing4.TabIndex = 9;
            this.sRing4.TabStop = true;
            this.sRing4.Text = "Кольцо 4";
            this.sRing4.UseVisualStyleBackColor = true;
            this.sRing4.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // sRing3
            // 
            this.sRing3.AutoSize = true;
            this.sRing3.Enabled = false;
            this.sRing3.Location = new System.Drawing.Point(191, 31);
            this.sRing3.Name = "sRing3";
            this.sRing3.Size = new System.Drawing.Size(75, 19);
            this.sRing3.TabIndex = 8;
            this.sRing3.TabStop = true;
            this.sRing3.Text = "Кольцо 3";
            this.sRing3.UseVisualStyleBackColor = true;
            this.sRing3.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // sRing2
            // 
            this.sRing2.AutoSize = true;
            this.sRing2.Enabled = false;
            this.sRing2.Location = new System.Drawing.Point(105, 31);
            this.sRing2.Name = "sRing2";
            this.sRing2.Size = new System.Drawing.Size(75, 19);
            this.sRing2.TabIndex = 7;
            this.sRing2.TabStop = true;
            this.sRing2.Text = "Кольцо 2";
            this.sRing2.UseVisualStyleBackColor = true;
            this.sRing2.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // sRing1
            // 
            this.sRing1.AutoSize = true;
            this.sRing1.Enabled = false;
            this.sRing1.Location = new System.Drawing.Point(19, 31);
            this.sRing1.Name = "sRing1";
            this.sRing1.Size = new System.Drawing.Size(75, 19);
            this.sRing1.TabIndex = 6;
            this.sRing1.TabStop = true;
            this.sRing1.Text = "Кольцо 1";
            this.sRing1.UseVisualStyleBackColor = true;
            this.sRing1.CheckedChanged += new System.EventHandler(this.Ring_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 5;
            // 
            // measure
            // 
            this.measure.Location = new System.Drawing.Point(6, 31);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(100, 23);
            this.measure.TabIndex = 7;
            this.measure.TextChanged += new System.EventHandler(this.measure_TextChanged);
            // 
            // measureGroup
            // 
            this.measureGroup.Controls.Add(this.measure);
            this.measureGroup.Location = new System.Drawing.Point(29, 405);
            this.measureGroup.Name = "measureGroup";
            this.measureGroup.Size = new System.Drawing.Size(200, 70);
            this.measureGroup.TabIndex = 8;
            this.measureGroup.TabStop = false;
            this.measureGroup.Text = "Данные";
            // 
            // SurfTypeGroup
            // 
            this.SurfTypeGroup.Controls.Add(this.surfTypeConvex);
            this.SurfTypeGroup.Controls.Add(this.surfTypeConcave);
            this.SurfTypeGroup.Location = new System.Drawing.Point(249, 124);
            this.SurfTypeGroup.Name = "SurfTypeGroup";
            this.SurfTypeGroup.Size = new System.Drawing.Size(200, 71);
            this.SurfTypeGroup.TabIndex = 5;
            this.SurfTypeGroup.TabStop = false;
            this.SurfTypeGroup.Text = "Тип поверхности";
            // 
            // surfTypeConvex
            // 
            this.surfTypeConvex.AutoSize = true;
            this.surfTypeConvex.Location = new System.Drawing.Point(105, 32);
            this.surfTypeConvex.Name = "surfTypeConvex";
            this.surfTypeConvex.Size = new System.Drawing.Size(74, 19);
            this.surfTypeConvex.TabIndex = 1;
            this.surfTypeConvex.TabStop = true;
            this.surfTypeConvex.Text = "Выпуклая";
            this.surfTypeConvex.UseVisualStyleBackColor = true;
            // 
            // surfTypeConcave
            // 
            this.surfTypeConcave.AutoSize = true;
            this.surfTypeConcave.Location = new System.Drawing.Point(19, 32);
            this.surfTypeConcave.Name = "surfTypeConcave";
            this.surfTypeConcave.Size = new System.Drawing.Size(79, 19);
            this.surfTypeConcave.TabIndex = 0;
            this.surfTypeConcave.TabStop = true;
            this.surfTypeConcave.Text = "Вогнутая";
            this.surfTypeConcave.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(674, 358);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(103, 23);
            this.result.TabIndex = 9;
            this.result.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.result);
            this.Controls.Add(this.SurfTypeGroup);
            this.Controls.Add(this.measureGroup);
            this.Controls.Add(this.BigRingsGroup);
            this.Controls.Add(this.SmallRingsGroup);
            this.Controls.Add(this.CalcTypeGroup);
            this.Controls.Add(this.SpherometrTypeGroup);
            this.Controls.Add(this.calculateButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Spherometr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SpherometrTypeGroup.ResumeLayout(false);
            this.SpherometrTypeGroup.PerformLayout();
            this.CalcTypeGroup.ResumeLayout(false);
            this.CalcTypeGroup.PerformLayout();
            this.BigRingsGroup.ResumeLayout(false);
            this.BigRingsGroup.PerformLayout();
            this.SmallRingsGroup.ResumeLayout(false);
            this.SmallRingsGroup.PerformLayout();
            this.measureGroup.ResumeLayout(false);
            this.measureGroup.PerformLayout();
            this.SurfTypeGroup.ResumeLayout(false);
            this.SurfTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox SpherometrTypeGroup;
        private System.Windows.Forms.RadioButton SpherometrSmall;
        private System.Windows.Forms.RadioButton SpherometrBig;
        private System.Windows.Forms.GroupBox CalcTypeGroup;
        private System.Windows.Forms.GroupBox BigRingsGroup;
        private System.Windows.Forms.RadioButton CalcTypeButRadus;
        private System.Windows.Forms.RadioButton CalcTypeButHeight;
        private System.Windows.Forms.Label RingsPreNote;
        private System.Windows.Forms.GroupBox SmallRingsGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sRing7;
        private System.Windows.Forms.RadioButton sRing5;
        private System.Windows.Forms.RadioButton sRing4;
        private System.Windows.Forms.RadioButton sRing3;
        private System.Windows.Forms.RadioButton sRing2;
        private System.Windows.Forms.RadioButton sRing1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton bRing3;
        public System.Windows.Forms.RadioButton bRing2;
        public System.Windows.Forms.RadioButton bRing1;
        public System.Windows.Forms.RadioButton bRing4;
        private System.Windows.Forms.TextBox measure;
        private System.Windows.Forms.GroupBox measureGroup;
        private System.Windows.Forms.GroupBox SurfTypeGroup;
        private System.Windows.Forms.RadioButton surfTypeConvex;
        private System.Windows.Forms.RadioButton surfTypeConcave;
        private System.Windows.Forms.Label result;
    }
}

