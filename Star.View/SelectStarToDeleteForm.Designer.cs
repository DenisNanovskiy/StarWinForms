
namespace Star.View
{
    partial class SelectStarToDeleteForm
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
            this.StarsListBox = new System.Windows.Forms.ListBox();
            this.SelectStarButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StarsListBox
            // 
            this.StarsListBox.BackColor = System.Drawing.Color.MistyRose;
            this.StarsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StarsListBox.FormattingEnabled = true;
            this.StarsListBox.ItemHeight = 16;
            this.StarsListBox.Location = new System.Drawing.Point(0, 0);
            this.StarsListBox.Name = "StarsListBox";
            this.StarsListBox.Size = new System.Drawing.Size(654, 212);
            this.StarsListBox.TabIndex = 0;
            // 
            // SelectStarButton
            // 
            this.SelectStarButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SelectStarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectStarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectStarButton.Location = new System.Drawing.Point(388, 219);
            this.SelectStarButton.Name = "SelectStarButton";
            this.SelectStarButton.Size = new System.Drawing.Size(148, 50);
            this.SelectStarButton.TabIndex = 15;
            this.SelectStarButton.Text = "Выбрать";
            this.SelectStarButton.UseVisualStyleBackColor = false;
            this.SelectStarButton.Click += new System.EventHandler(this.SelectStarButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Coral;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(542, 219);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 50);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectStarToDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(654, 281);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectStarButton);
            this.Controls.Add(this.StarsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectStarToDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите звезду на удаление";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StarsListBox;
        private System.Windows.Forms.Button SelectStarButton;
        private System.Windows.Forms.Button CancelButton;
    }
}