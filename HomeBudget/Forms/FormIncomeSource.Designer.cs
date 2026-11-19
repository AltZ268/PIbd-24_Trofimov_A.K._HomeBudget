namespace HomeBudget.Forms
{
    partial class FormIncomeSource
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
            labelType = new Label();
            textBoxType = new TextBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(28, 41);
            labelType.Name = "labelType";
            labelType.Size = new Size(71, 15);
            labelType.TabIndex = 0;
            labelType.Text = "Тип дохода:";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(117, 38);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(131, 23);
            textBoxType.TabIndex = 1;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(28, 122);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 2;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(173, 122);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 3;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormIncomeSource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(textBoxType);
            Controls.Add(labelType);
            Name = "FormIncomeSource";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Источник дохода";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private TextBox textBoxType;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}