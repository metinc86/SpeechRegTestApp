
namespace SpeechRegTestApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbxStart = new System.Windows.Forms.PictureBox();
            this.PbxClicked = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClicked)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxStart
            // 
            this.PbxStart.Image = ((System.Drawing.Image)(resources.GetObject("PbxStart.Image")));
            this.PbxStart.Location = new System.Drawing.Point(299, 39);
            this.PbxStart.Name = "PbxStart";
            this.PbxStart.Size = new System.Drawing.Size(80, 80);
            this.PbxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxStart.TabIndex = 0;
            this.PbxStart.TabStop = false;
            this.PbxStart.Click += new System.EventHandler(this.PbxStart_Click);
            // 
            // PbxClicked
            // 
            this.PbxClicked.Image = ((System.Drawing.Image)(resources.GetObject("PbxClicked.Image")));
            this.PbxClicked.Location = new System.Drawing.Point(299, 39);
            this.PbxClicked.Name = "PbxClicked";
            this.PbxClicked.Size = new System.Drawing.Size(80, 80);
            this.PbxClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxClicked.TabIndex = 1;
            this.PbxClicked.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Source Sans Pro Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(243, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxLevel.Location = new System.Drawing.Point(12, 39);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(121, 21);
            this.cbxLevel.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Basamak sayısı seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rakamları tek tek okuyunuz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PbxStart);
            this.Controls.Add(this.PbxClicked);
            this.Name = "Form1";
            this.Text = "SpeechReg";
            ((System.ComponentModel.ISupportInitialize)(this.PbxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxStart;
        private System.Windows.Forms.PictureBox PbxClicked;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

