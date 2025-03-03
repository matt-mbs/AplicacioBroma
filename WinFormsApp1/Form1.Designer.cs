namespace WinFormsApp1
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
            label1 = new Label();
            accept_Btn = new Button();
            cancel_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 86);
            label1.Name = "label1";
            label1.Size = new Size(282, 30);
            label1.TabIndex = 0;
            label1.Text = "¿Desea formatear su unidad?";
            // 
            // accept_Btn
            // 
            accept_Btn.Location = new Point(87, 327);
            accept_Btn.Name = "accept_Btn";
            accept_Btn.Size = new Size(106, 29);
            accept_Btn.TabIndex = 1;
            accept_Btn.Text = "Aceptar";
            accept_Btn.UseVisualStyleBackColor = true;
            accept_Btn.Click += accept_Btn_Click;
            // 
            // cancel_Btn
            // 
            cancel_Btn.Location = new Point(493, 327);
            cancel_Btn.Name = "cancel_Btn";
            cancel_Btn.Size = new Size(106, 29);
            cancel_Btn.TabIndex = 2;
            cancel_Btn.Text = "Cancelar";
            cancel_Btn.UseVisualStyleBackColor = true;
            cancel_Btn.MouseHover += cancel_Btn_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 509);
            Controls.Add(cancel_Btn);
            Controls.Add(accept_Btn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button accept_Btn;
        private Button cancel_Btn;
    }
}
