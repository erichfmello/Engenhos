
namespace Teste002
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
            this.components = new System.ComponentModel.Container();
            this.btnTurn = new System.Windows.Forms.Button();
            this.lblLaterna = new System.Windows.Forms.Label();
            this.lblBatery = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerChangeChargeBatery = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(13, 13);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(100, 25);
            this.btnTurn.TabIndex = 0;
            this.btnTurn.Text = "Ligar";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // lblLaterna
            // 
            this.lblLaterna.AutoSize = true;
            this.lblLaterna.Location = new System.Drawing.Point(122, 60);
            this.lblLaterna.Name = "lblLaterna";
            this.lblLaterna.Size = new System.Drawing.Size(106, 15);
            this.lblLaterna.TabIndex = 2;
            this.lblLaterna.Text = "Lanterna desligada";
            // 
            // lblBatery
            // 
            this.lblBatery.AutoSize = true;
            this.lblBatery.Location = new System.Drawing.Point(12, 60);
            this.lblBatery.Name = "lblBatery";
            this.lblBatery.Size = new System.Drawing.Size(90, 15);
            this.lblBatery.TabIndex = 3;
            this.lblBatery.Text = "100% de bateria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trocar bateria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerChangeChargeBatery
            // 
            this.TimerChangeChargeBatery.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 96);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBatery);
            this.Controls.Add(this.lblLaterna);
            this.Controls.Add(this.btnTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lanterna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Label lblLaterna;
        private System.Windows.Forms.Label lblBatery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TimerChangeChargeBatery;
    }
}

