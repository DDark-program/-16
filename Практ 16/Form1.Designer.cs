
namespace Практ_16
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.water = new System.Windows.Forms.PictureBox();
            this.boiler = new System.Windows.Forms.PictureBox();
            this.fon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Собрано капель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 2;
            // 
            // water
            // 
            this.water.Image = global::Практ_16.Properties.Resources.water;
            this.water.Location = new System.Drawing.Point(362, 133);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(71, 74);
            this.water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.water.TabIndex = 0;
            this.water.TabStop = false;
            // 
            // boiler
            // 
            this.boiler.BackColor = System.Drawing.SystemColors.Window;
            this.boiler.Image = global::Практ_16.Properties.Resources.boiler1;
            this.boiler.Location = new System.Drawing.Point(395, 367);
            this.boiler.Name = "boiler";
            this.boiler.Size = new System.Drawing.Size(207, 201);
            this.boiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boiler.TabIndex = 0;
            this.boiler.TabStop = false;
            // 
            // fon
            // 
            this.fon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fon.Image = global::Практ_16.Properties.Resources.nicolas_appenzeller_cmc_clubhouse_by_tardifice_d97h0uq;
            this.fon.Location = new System.Drawing.Point(0, 0);
            this.fon.Name = "fon";
            this.fon.Size = new System.Drawing.Size(1000, 568);
            this.fon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fon.TabIndex = 0;
            this.fon.TabStop = false;
            this.fon.Click += new System.EventHandler(this.fon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.water);
            this.Controls.Add(this.boiler);
            this.Controls.Add(this.fon);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Собери капли\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox boiler;
        private System.Windows.Forms.PictureBox water;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox fon;
    }
}

