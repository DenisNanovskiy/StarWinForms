
namespace Star.View
{
    partial class StarCreatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLargeRadius = new System.Windows.Forms.TextBox();
            this.TextBoxSmallRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxRaysCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDegree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCenterX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCenterY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.ButtonCreateStar = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус (внешний)";
            // 
            // TextBoxLargeRadius
            // 
            this.TextBoxLargeRadius.Location = new System.Drawing.Point(166, 18);
            this.TextBoxLargeRadius.Name = "TextBoxLargeRadius";
            this.TextBoxLargeRadius.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLargeRadius.TabIndex = 1;
            // 
            // TextBoxSmallRadius
            // 
            this.TextBoxSmallRadius.Location = new System.Drawing.Point(166, 44);
            this.TextBoxSmallRadius.Name = "TextBoxSmallRadius";
            this.TextBoxSmallRadius.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSmallRadius.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Радиус (внутренний)";
            // 
            // TextBoxRaysCount
            // 
            this.TextBoxRaysCount.Location = new System.Drawing.Point(166, 70);
            this.TextBoxRaysCount.Name = "TextBoxRaysCount";
            this.TextBoxRaysCount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRaysCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество лучей";
            // 
            // TextBoxDegree
            // 
            this.TextBoxDegree.Location = new System.Drawing.Point(166, 96);
            this.TextBoxDegree.Name = "TextBoxDegree";
            this.TextBoxDegree.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDegree.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Начальный сдвиг (радиан)";
            // 
            // TextBoxCenterX
            // 
            this.TextBoxCenterX.Location = new System.Drawing.Point(166, 122);
            this.TextBoxCenterX.Name = "TextBoxCenterX";
            this.TextBoxCenterX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCenterX.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Координата центра (ось X)";
            // 
            // TextBoxCenterY
            // 
            this.TextBoxCenterY.Location = new System.Drawing.Point(166, 148);
            this.TextBoxCenterY.Name = "TextBoxCenterY";
            this.TextBoxCenterY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCenterY.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Координата центра (ось Y)";
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.MistyRose;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColorButton.Location = new System.Drawing.Point(166, 174);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(100, 39);
            this.ColorButton.TabIndex = 12;
            this.ColorButton.Text = "Выбор цвета...";
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(15, 174);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(145, 39);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Цвет звезды";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCreateStar
            // 
            this.ButtonCreateStar.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonCreateStar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateStar.Location = new System.Drawing.Point(12, 219);
            this.ButtonCreateStar.Name = "ButtonCreateStar";
            this.ButtonCreateStar.Size = new System.Drawing.Size(148, 50);
            this.ButtonCreateStar.TabIndex = 14;
            this.ButtonCreateStar.Text = "Создать";
            this.ButtonCreateStar.UseVisualStyleBackColor = false;
            this.ButtonCreateStar.Click += new System.EventHandler(this.ButtonCreateStar_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Coral;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(166, 219);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 50);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StarCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ButtonCreateStar);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.TextBoxCenterY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxCenterX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxDegree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxRaysCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxSmallRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxLargeRadius);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StarCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание новой звезды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLargeRadius;
        private System.Windows.Forms.TextBox TextBoxSmallRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxRaysCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCenterX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCenterY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button ButtonCreateStar;
        private System.Windows.Forms.Button CancelButton;
    }
}