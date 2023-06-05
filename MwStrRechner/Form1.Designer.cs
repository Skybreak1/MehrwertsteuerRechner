namespace MwStrRechner
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbxMwSt = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelEingabe = new Label();
            tbxEingabe = new TextBox();
            tbxSteuern = new TextBox();
            tbxNetto = new TextBox();
            tbxBrutto = new TextBox();
            tbxBruttoGes = new TextBox();
            tbxNettoGes = new TextBox();
            tbxSteuernGes = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            resetbtn = new Button();
            rbtnNetto = new RadioButton();
            rbtnBrutto = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Steuern";
            // 
            // tbxMwSt
            // 
            tbxMwSt.Location = new Point(65, 6);
            tbxMwSt.Name = "tbxMwSt";
            tbxMwSt.Size = new Size(26, 23);
            tbxMwSt.TabIndex = 2;
            tbxMwSt.Text = "19";
            tbxMwSt.Leave += tbxMwSt_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 10);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "%";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 141);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Steuern";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 197);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Netto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 254);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "Brutto";
            // 
            // labelEingabe
            // 
            labelEingabe.AutoSize = true;
            labelEingabe.Location = new Point(44, 69);
            labelEingabe.Name = "labelEingabe";
            labelEingabe.Size = new Size(49, 15);
            labelEingabe.TabIndex = 8;
            labelEingabe.Text = "Eingabe";
            // 
            // tbxEingabe
            // 
            tbxEingabe.Location = new Point(97, 66);
            tbxEingabe.Name = "tbxEingabe";
            tbxEingabe.Size = new Size(82, 23);
            tbxEingabe.TabIndex = 9;
            tbxEingabe.KeyDown += tbxEingabe_KeyDown;
            tbxEingabe.KeyUp += tbxEingabe_KeyUp;
            // 
            // tbxSteuern
            // 
            tbxSteuern.Location = new Point(86, 138);
            tbxSteuern.Name = "tbxSteuern";
            tbxSteuern.Size = new Size(93, 23);
            tbxSteuern.TabIndex = 10;
            // 
            // tbxNetto
            // 
            tbxNetto.Location = new Point(86, 194);
            tbxNetto.Name = "tbxNetto";
            tbxNetto.Size = new Size(93, 23);
            tbxNetto.TabIndex = 11;
            // 
            // tbxBrutto
            // 
            tbxBrutto.Location = new Point(86, 251);
            tbxBrutto.Name = "tbxBrutto";
            tbxBrutto.Size = new Size(93, 23);
            tbxBrutto.TabIndex = 12;
            // 
            // tbxBruttoGes
            // 
            tbxBruttoGes.Location = new Point(139, 431);
            tbxBruttoGes.Name = "tbxBruttoGes";
            tbxBruttoGes.Size = new Size(93, 23);
            tbxBruttoGes.TabIndex = 18;
            // 
            // tbxNettoGes
            // 
            tbxNettoGes.Location = new Point(139, 374);
            tbxNettoGes.Name = "tbxNettoGes";
            tbxNettoGes.Size = new Size(93, 23);
            tbxNettoGes.TabIndex = 17;
            // 
            // tbxSteuernGes
            // 
            tbxSteuernGes.Location = new Point(139, 318);
            tbxSteuernGes.Name = "tbxSteuernGes";
            tbxSteuernGes.Size = new Size(93, 23);
            tbxSteuernGes.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 434);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 15;
            label6.Text = "Brutto Gesamt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 377);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 14;
            label7.Text = "Netto Gesamt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 321);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 13;
            label8.Text = "Steuern Gesamt";
            // 
            // resetbtn
            // 
            resetbtn.Location = new Point(113, 510);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(75, 23);
            resetbtn.TabIndex = 19;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // rbtnNetto
            // 
            rbtnNetto.AutoSize = true;
            rbtnNetto.Checked = true;
            rbtnNetto.Location = new Point(198, 50);
            rbtnNetto.Name = "rbtnNetto";
            rbtnNetto.Size = new Size(55, 19);
            rbtnNetto.TabIndex = 20;
            rbtnNetto.TabStop = true;
            rbtnNetto.Text = "Netto";
            rbtnNetto.UseVisualStyleBackColor = true;
            rbtnNetto.CheckedChanged += rbtnNetto_CheckedChanged;
            // 
            // rbtnBrutto
            // 
            rbtnBrutto.AutoSize = true;
            rbtnBrutto.Location = new Point(198, 75);
            rbtnBrutto.Name = "rbtnBrutto";
            rbtnBrutto.Size = new Size(58, 19);
            rbtnBrutto.TabIndex = 21;
            rbtnBrutto.TabStop = true;
            rbtnBrutto.Text = "Brutto";
            rbtnBrutto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 587);
            Controls.Add(rbtnBrutto);
            Controls.Add(rbtnNetto);
            Controls.Add(resetbtn);
            Controls.Add(tbxBruttoGes);
            Controls.Add(tbxNettoGes);
            Controls.Add(tbxSteuernGes);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(tbxBrutto);
            Controls.Add(tbxNetto);
            Controls.Add(tbxSteuern);
            Controls.Add(tbxEingabe);
            Controls.Add(labelEingabe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxMwSt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Mwst. Rechner";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbxMwSt;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelEingabe;
        private TextBox tbxEingabe;
        private TextBox tbxSteuern;
        private TextBox tbxNetto;
        private TextBox tbxBrutto;
        private TextBox tbxBruttoGes;
        private TextBox tbxNettoGes;
        private TextBox tbxSteuernGes;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button resetbtn;
        private RadioButton rbtnNetto;
        private RadioButton rbtnBrutto;
    }
}