
namespace WinFormsSpherometr
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
            this.label1 = new System.Windows.Forms.Label();
            this.SpherometrTypeGroup = new System.Windows.Forms.GroupBox();
            this.CalcTypeGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SpherometrBig = new System.Windows.Forms.RadioButton();
            this.SpherometrSmall = new System.Windows.Forms.RadioButton();
            this.CalcTypeButHeight = new System.Windows.Forms.RadioButton();
            this.CalcTypeButRadus = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PreNote = new System.Windows.Forms.Label();
            this.SpherometrTypeGroup.SuspendLayout();
            this.CalcTypeGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(674, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 1;
            // 
            // SpherometrTypeGroup
            // 
            this.SpherometrTypeGroup.Controls.Add(this.SpherometrSmall);
            this.SpherometrTypeGroup.Controls.Add(this.SpherometrBig);
            this.SpherometrTypeGroup.Location = new System.Drawing.Point(29, 31);
            this.SpherometrTypeGroup.Name = "SpherometrTypeGroup";
            this.SpherometrTypeGroup.Size = new System.Drawing.Size(212, 54);
            this.SpherometrTypeGroup.TabIndex = 3;
            this.SpherometrTypeGroup.TabStop = false;
            this.SpherometrTypeGroup.Text = "Тип сферометра";
            // 
            // CalcTypeGroup
            // 
            this.CalcTypeGroup.Controls.Add(this.CalcTypeButRadus);
            this.CalcTypeGroup.Controls.Add(this.CalcTypeButHeight);
            this.CalcTypeGroup.Location = new System.Drawing.Point(29, 116);
            this.CalcTypeGroup.Name = "CalcTypeGroup";
            this.CalcTypeGroup.Size = new System.Drawing.Size(212, 62);
            this.CalcTypeGroup.TabIndex = 4;
            this.CalcTypeGroup.TabStop = false;
            this.CalcTypeGroup.Text = "Тип вычислений";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PreNote);
            this.groupBox3.Location = new System.Drawing.Point(29, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номер кольца";
            // 
            // SpherometrBig
            // 
            this.SpherometrBig.AutoSize = true;
            this.SpherometrBig.Location = new System.Drawing.Point(23, 26);
            this.SpherometrBig.Name = "SpherometrBig";
            this.SpherometrBig.Size = new System.Drawing.Size(77, 19);
            this.SpherometrBig.TabIndex = 0;
            this.SpherometrBig.TabStop = true;
            this.SpherometrBig.Text = "Большой";
            this.SpherometrBig.UseVisualStyleBackColor = true;
            // 
            // SpherometrSmall
            // 
            this.SpherometrSmall.AutoSize = true;
            this.SpherometrSmall.Location = new System.Drawing.Point(116, 26);
            this.SpherometrSmall.Name = "SpherometrSmall";
            this.SpherometrSmall.Size = new System.Drawing.Size(65, 19);
            this.SpherometrSmall.TabIndex = 1;
            this.SpherometrSmall.TabStop = true;
            this.SpherometrSmall.Text = "Малый";
            this.SpherometrSmall.UseVisualStyleBackColor = true;
            // 
            // CalcTypeButHeight
            // 
            this.CalcTypeButHeight.AutoSize = true;
            this.CalcTypeButHeight.Location = new System.Drawing.Point(23, 32);
            this.CalcTypeButHeight.Name = "CalcTypeButHeight";
            this.CalcTypeButHeight.Size = new System.Drawing.Size(70, 19);
            this.CalcTypeButHeight.TabIndex = 0;
            this.CalcTypeButHeight.TabStop = true;
            this.CalcTypeButHeight.Text = "Стрелка";
            this.CalcTypeButHeight.UseVisualStyleBackColor = true;
            // 
            // CalcTypeButRadus
            // 
            this.CalcTypeButRadus.AutoSize = true;
            this.CalcTypeButRadus.Location = new System.Drawing.Point(116, 32);
            this.CalcTypeButRadus.Name = "CalcTypeButRadus";
            this.CalcTypeButRadus.Size = new System.Drawing.Size(63, 19);
            this.CalcTypeButRadus.TabIndex = 1;
            this.CalcTypeButRadus.TabStop = true;
            this.CalcTypeButRadus.Text = "Радиус";
            this.CalcTypeButRadus.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(552, 361);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(8, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // PreNote
            // 
            this.PreNote.AutoSize = true;
            this.PreNote.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PreNote.Location = new System.Drawing.Point(23, 31);
            this.PreNote.Name = "PreNote";
            this.PreNote.Size = new System.Drawing.Size(200, 18);
            this.PreNote.TabIndex = 0;
            this.PreNote.Text = "Задайте тип сферометра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CalcTypeGroup);
            this.Controls.Add(this.SpherometrTypeGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.Name = "Form1";
            this.Text = "Spherometr";
            this.SpherometrTypeGroup.ResumeLayout(false);
            this.SpherometrTypeGroup.PerformLayout();
            this.CalcTypeGroup.ResumeLayout(false);
            this.CalcTypeGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SpherometrTypeGroup;
        private System.Windows.Forms.RadioButton SpherometrSmall;
        private System.Windows.Forms.RadioButton SpherometrBig;
        private System.Windows.Forms.GroupBox CalcTypeGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton CalcTypeButRadus;
        private System.Windows.Forms.RadioButton CalcTypeButHeight;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label PreNote;
    }
}

