namespace Abstract_Fabric
{
    partial class FabricsForm
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
            groupBoxChooseFabric = new GroupBox();
            radioButtonGreen = new RadioButton();
            radioButtonRed = new RadioButton();
            radioButtonBlue = new RadioButton();
            groupBoxChooseShape = new GroupBox();
            radioButtonSquare = new RadioButton();
            radioButtonTriangle = new RadioButton();
            radioButtonCircle = new RadioButton();
            buttonDrawing = new Button();
            groupBoxChooseFabric.SuspendLayout();
            groupBoxChooseShape.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxChooseFabric
            // 
            groupBoxChooseFabric.Controls.Add(radioButtonGreen);
            groupBoxChooseFabric.Controls.Add(radioButtonRed);
            groupBoxChooseFabric.Controls.Add(radioButtonBlue);
            groupBoxChooseFabric.Location = new Point(12, 12);
            groupBoxChooseFabric.Name = "groupBoxChooseFabric";
            groupBoxChooseFabric.Size = new Size(122, 101);
            groupBoxChooseFabric.TabIndex = 0;
            groupBoxChooseFabric.TabStop = false;
            groupBoxChooseFabric.Text = "Выберите цвет:";
            // 
            // radioButtonGreen
            // 
            radioButtonGreen.AutoSize = true;
            radioButtonGreen.Location = new Point(6, 72);
            radioButtonGreen.Name = "radioButtonGreen";
            radioButtonGreen.Size = new Size(74, 19);
            radioButtonGreen.TabIndex = 2;
            radioButtonGreen.Text = "Зеленый";
            radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            radioButtonRed.AutoSize = true;
            radioButtonRed.Location = new Point(6, 47);
            radioButtonRed.Name = "radioButtonRed";
            radioButtonRed.Size = new Size(74, 19);
            radioButtonRed.TabIndex = 1;
            radioButtonRed.Text = "Красный";
            radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            radioButtonBlue.AutoSize = true;
            radioButtonBlue.Checked = true;
            radioButtonBlue.Location = new Point(6, 22);
            radioButtonBlue.Name = "radioButtonBlue";
            radioButtonBlue.Size = new Size(61, 19);
            radioButtonBlue.TabIndex = 0;
            radioButtonBlue.TabStop = true;
            radioButtonBlue.Text = "Синий";
            radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // groupBoxChooseShape
            // 
            groupBoxChooseShape.Controls.Add(radioButtonSquare);
            groupBoxChooseShape.Controls.Add(radioButtonTriangle);
            groupBoxChooseShape.Controls.Add(radioButtonCircle);
            groupBoxChooseShape.Location = new Point(12, 119);
            groupBoxChooseShape.Name = "groupBoxChooseShape";
            groupBoxChooseShape.Size = new Size(122, 101);
            groupBoxChooseShape.TabIndex = 1;
            groupBoxChooseShape.TabStop = false;
            groupBoxChooseShape.Text = "Выберите форму:";
            // 
            // radioButtonSquare
            // 
            radioButtonSquare.AutoSize = true;
            radioButtonSquare.Location = new Point(6, 72);
            radioButtonSquare.Name = "radioButtonSquare";
            radioButtonSquare.Size = new Size(68, 19);
            radioButtonSquare.TabIndex = 2;
            radioButtonSquare.Text = "Квадрат";
            radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            radioButtonTriangle.AutoSize = true;
            radioButtonTriangle.Location = new Point(6, 47);
            radioButtonTriangle.Name = "radioButtonTriangle";
            radioButtonTriangle.Size = new Size(95, 19);
            radioButtonTriangle.TabIndex = 1;
            radioButtonTriangle.Text = "Треугольник";
            radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            radioButtonCircle.AutoSize = true;
            radioButtonCircle.Checked = true;
            radioButtonCircle.Location = new Point(6, 22);
            radioButtonCircle.Name = "radioButtonCircle";
            radioButtonCircle.Size = new Size(50, 19);
            radioButtonCircle.TabIndex = 0;
            radioButtonCircle.TabStop = true;
            radioButtonCircle.Text = "Круг";
            radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonDrawing
            // 
            buttonDrawing.Location = new Point(12, 226);
            buttonDrawing.Name = "buttonDrawing";
            buttonDrawing.Size = new Size(122, 33);
            buttonDrawing.TabIndex = 2;
            buttonDrawing.Text = "Нарисовать";
            buttonDrawing.UseVisualStyleBackColor = true;
            buttonDrawing.Click += buttonDrawing_Click;
            // 
            // FabricsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(buttonDrawing);
            Controls.Add(groupBoxChooseShape);
            Controls.Add(groupBoxChooseFabric);
            Name = "FabricsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxChooseFabric.ResumeLayout(false);
            groupBoxChooseFabric.PerformLayout();
            groupBoxChooseShape.ResumeLayout(false);
            groupBoxChooseShape.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxChooseFabric;
        private RadioButton radioButtonGreen;
        private RadioButton radioButtonRed;
        private RadioButton radioButtonBlue;
        private GroupBox groupBoxChooseShape;
        private RadioButton radioButtonSquare;
        private RadioButton radioButtonTriangle;
        private RadioButton radioButtonCircle;
        private Button buttonDrawing;
    }
}
