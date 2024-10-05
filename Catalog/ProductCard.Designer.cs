namespace Catalog
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            costLabel = new Label();
            quantityLabel = new Label();
            manufacturerLabel = new Label();
            nameLabel = new Label();
            groupBox2 = new GroupBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(costLabel);
            groupBox1.Controls.Add(quantityLabel);
            groupBox1.Controls.Add(manufacturerLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Location = new Point(153, -6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 153);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(4, 134);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(73, 15);
            costLabel.TabIndex = 3;
            costLabel.Text = "Стоимость: ";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(4, 114);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(78, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Количество: ";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new Point(3, 31);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(98, 15);
            manufacturerLabel.TabIndex = 1;
            manufacturerLabel.Text = "Производитель: ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(descriptionTextBox);
            groupBox2.Controls.Add(descriptionLabel);
            groupBox2.Location = new Point(409, -6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(6, 31);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(238, 116);
            descriptionTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(6, 11);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(68, 15);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Описание: ";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "ProductCard";
            Size = new Size(660, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label costLabel;
        private Label quantityLabel;
        private Label manufacturerLabel;
        private Label nameLabel;
        private GroupBox groupBox2;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
    }
}
