namespace Catalog
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            selectPictureButton = new Button();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            manufacturerTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            AddingButton = new Button();
            SuspendLayout();
            // 
            // selectPictureButton
            // 
            selectPictureButton.Location = new Point(342, 41);
            selectPictureButton.Name = "selectPictureButton";
            selectPictureButton.Size = new Size(159, 23);
            selectPictureButton.TabIndex = 0;
            selectPictureButton.Text = "Выберите изображение";
            selectPictureButton.UseVisualStyleBackColor = true;
            selectPictureButton.Click += selectPictureButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.Text = "Введите название";
            nameTextBox.MouseClick += textBoxes_MouseClick;
            nameTextBox.MouseDoubleClick += textBoxes_MouseClick;
            nameTextBox.MouseDown += textBoxes_MouseDown;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(177, 12);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(159, 81);
            descriptionTextBox.TabIndex = 2;
            descriptionTextBox.Text = "Введите описание";
            descriptionTextBox.MouseClick += textBoxes_MouseClick;
            descriptionTextBox.MouseDoubleClick += textBoxes_MouseClick;
            descriptionTextBox.MouseDown += textBoxes_MouseDown;
            // 
            // manufacturerTextBox
            // 
            manufacturerTextBox.Location = new Point(12, 41);
            manufacturerTextBox.Name = "manufacturerTextBox";
            manufacturerTextBox.Size = new Size(159, 23);
            manufacturerTextBox.TabIndex = 3;
            manufacturerTextBox.Text = "Введите производителя";
            manufacturerTextBox.MouseClick += textBoxes_MouseClick;
            manufacturerTextBox.MouseDoubleClick += textBoxes_MouseClick;
            manufacturerTextBox.MouseDown += textBoxes_MouseDown;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 70);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(159, 23);
            priceTextBox.TabIndex = 4;
            priceTextBox.Text = "Введите цену";
            priceTextBox.MouseClick += textBoxes_MouseClick;
            priceTextBox.MouseDoubleClick += textBoxes_MouseClick;
            priceTextBox.MouseDown += textBoxes_MouseDown;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(342, 12);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(159, 23);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.Text = "Введите количество";
            quantityTextBox.MouseClick += textBoxes_MouseClick;
            quantityTextBox.MouseDoubleClick += textBoxes_MouseClick;
            quantityTextBox.MouseDown += textBoxes_MouseDown;
            // 
            // AddingButton
            // 
            AddingButton.Location = new Point(342, 70);
            AddingButton.Name = "AddingButton";
            AddingButton.Size = new Size(159, 23);
            AddingButton.TabIndex = 6;
            AddingButton.Text = "Добавить";
            AddingButton.UseVisualStyleBackColor = true;
            AddingButton.Click += AddingButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 211);
            Controls.Add(AddingButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(manufacturerTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(selectPictureButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectPictureButton;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private TextBox manufacturerTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button AddingButton;
    }
}