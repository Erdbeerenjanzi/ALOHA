namespace aloha
{
    partial class ALOHA
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALOHA));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.out_console = new System.Windows.Forms.RichTextBox();
            this.textBox_prob = new System.Windows.Forms.TextBox();
            this.label_prob = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_nodeamount = new System.Windows.Forms.TextBox();
            this.label_nodeamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // out_console
            // 
            this.out_console.Location = new System.Drawing.Point(12, 12);
            this.out_console.Name = "out_console";
            this.out_console.ReadOnly = true;
            this.out_console.Size = new System.Drawing.Size(625, 410);
            this.out_console.TabIndex = 0;
            this.out_console.Text = "";
            // 
            // textBox_prob
            // 
            this.textBox_prob.Location = new System.Drawing.Point(843, 26);
            this.textBox_prob.Name = "textBox_prob";
            this.textBox_prob.Size = new System.Drawing.Size(100, 20);
            this.textBox_prob.TabIndex = 1;
            this.textBox_prob.Text = "0,01";
            this.textBox_prob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_prob
            // 
            this.label_prob.AutoSize = true;
            this.label_prob.Location = new System.Drawing.Point(782, 29);
            this.label_prob.Name = "label_prob";
            this.label_prob.Size = new System.Drawing.Size(55, 13);
            this.label_prob.TabIndex = 2;
            this.label_prob.Text = "Probability";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(666, 355);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(277, 66);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_nodeamount
            // 
            this.textBox_nodeamount.Location = new System.Drawing.Point(843, 65);
            this.textBox_nodeamount.Name = "textBox_nodeamount";
            this.textBox_nodeamount.Size = new System.Drawing.Size(100, 20);
            this.textBox_nodeamount.TabIndex = 4;
            this.textBox_nodeamount.Text = "20";
            // 
            // label_nodeamount
            // 
            this.label_nodeamount.AutoSize = true;
            this.label_nodeamount.Location = new System.Drawing.Point(765, 68);
            this.label_nodeamount.Name = "label_nodeamount";
            this.label_nodeamount.Size = new System.Drawing.Size(72, 13);
            this.label_nodeamount.TabIndex = 5;
            this.label_nodeamount.Text = "Node Amount";
            // 
            // ALOHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 434);
            this.Controls.Add(this.label_nodeamount);
            this.Controls.Add(this.textBox_nodeamount);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_prob);
            this.Controls.Add(this.textBox_prob);
            this.Controls.Add(this.out_console);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ALOHA";
            this.Text = "ALOHA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox out_console;
        private System.Windows.Forms.TextBox textBox_prob;
        private System.Windows.Forms.Label label_prob;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_nodeamount;
        private System.Windows.Forms.Label label_nodeamount;
    }
}

