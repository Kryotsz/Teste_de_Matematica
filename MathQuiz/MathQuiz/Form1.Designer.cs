
namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.NumericUpDown();
            this.diferença = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.minusRightLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minusLeftLable = new System.Windows.Forms.Label();
            this.produto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.timesRightLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timesLeftLable = new System.Windows.Forms.Label();
            this.quociente = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dividedRightLable = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dividedLeftLable = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferença)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quociente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(281, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Restante";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(314, 84);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(100, 35);
            this.soma.TabIndex = 1;
            this.soma.ValueChanged += new System.EventHandler(this.CheckValue);
            this.soma.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diferença
            // 
            this.diferença.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferença.Location = new System.Drawing.Point(314, 134);
            this.diferença.Name = "diferença";
            this.diferença.Size = new System.Drawing.Size(100, 35);
            this.diferença.TabIndex = 2;
            this.diferença.ValueChanged += new System.EventHandler(this.CheckValue);
            this.diferença.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLable
            // 
            this.minusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLable.Location = new System.Drawing.Point(182, 125);
            this.minusRightLable.Name = "minusRightLable";
            this.minusRightLable.Size = new System.Drawing.Size(60, 50);
            this.minusRightLable.TabIndex = 9;
            this.minusRightLable.Text = "?";
            this.minusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLable
            // 
            this.minusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLable.Location = new System.Drawing.Point(50, 125);
            this.minusLeftLable.Name = "minusLeftLable";
            this.minusLeftLable.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLable.TabIndex = 7;
            this.minusLeftLable.Text = "?";
            this.minusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            this.produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.Location = new System.Drawing.Point(314, 184);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(100, 35);
            this.produto.TabIndex = 3;
            this.produto.ValueChanged += new System.EventHandler(this.CheckValue);
            this.produto.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLable
            // 
            this.timesRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLable.Location = new System.Drawing.Point(182, 175);
            this.timesRightLable.Name = "timesRightLable";
            this.timesRightLable.Size = new System.Drawing.Size(60, 50);
            this.timesRightLable.TabIndex = 14;
            this.timesRightLable.Text = "?";
            this.timesRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 13;
            this.label8.Text = "×";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLable
            // 
            this.timesLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLable.Location = new System.Drawing.Point(50, 175);
            this.timesLeftLable.Name = "timesLeftLable";
            this.timesLeftLable.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLable.TabIndex = 12;
            this.timesLeftLable.Text = "?";
            this.timesLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quociente
            // 
            this.quociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quociente.Location = new System.Drawing.Point(314, 234);
            this.quociente.Name = "quociente";
            this.quociente.Size = new System.Drawing.Size(100, 35);
            this.quociente.TabIndex = 4;
            this.quociente.ValueChanged += new System.EventHandler(this.CheckValue);
            this.quociente.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLable
            // 
            this.dividedRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLable.Location = new System.Drawing.Point(182, 225);
            this.dividedRightLable.Name = "dividedRightLable";
            this.dividedRightLable.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLable.TabIndex = 19;
            this.dividedRightLable.Text = "?";
            this.dividedRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 18;
            this.label12.Text = "÷";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLable
            // 
            this.dividedLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLable.Location = new System.Drawing.Point(50, 225);
            this.dividedLeftLable.Name = "dividedLeftLable";
            this.dividedLeftLable.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLable.TabIndex = 17;
            this.dividedLeftLable.Text = "?";
            this.dividedLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(166, 300);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(129, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Iniciar o teste";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBox1
            // 
            this.picBox1.Image = global::MathQuiz.Properties.Resources._299110_check_sign_icon;
            this.picBox1.Location = new System.Drawing.Point(424, 77);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(48, 48);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox1.TabIndex = 21;
            this.picBox1.TabStop = false;
            this.picBox1.Visible = false;
            // 
            // picBox2
            // 
            this.picBox2.Image = global::MathQuiz.Properties.Resources._299110_check_sign_icon;
            this.picBox2.Location = new System.Drawing.Point(424, 127);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(48, 48);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox2.TabIndex = 22;
            this.picBox2.TabStop = false;
            this.picBox2.Visible = false;
            // 
            // picBox4
            // 
            this.picBox4.Image = global::MathQuiz.Properties.Resources._299110_check_sign_icon;
            this.picBox4.Location = new System.Drawing.Point(424, 227);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(48, 48);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox4.TabIndex = 23;
            this.picBox4.TabStop = false;
            this.picBox4.Visible = false;
            // 
            // picBox3
            // 
            this.picBox3.Image = global::MathQuiz.Properties.Resources._299110_check_sign_icon;
            this.picBox3.Location = new System.Drawing.Point(424, 177);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(48, 48);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox3.TabIndex = 24;
            this.picBox3.TabStop = false;
            this.picBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quociente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dividedRightLable);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dividedLeftLable);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timesRightLable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timesLeftLable);
            this.Controls.Add(this.diferença);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusRightLable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusLeftLable);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teste de Matemática";
            ((System.ComponentModel.ISupportInitialize)(this.soma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferença)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quociente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown soma;
        private System.Windows.Forms.NumericUpDown diferença;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusRightLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minusLeftLable;
        private System.Windows.Forms.NumericUpDown produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timesRightLable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timesLeftLable;
        private System.Windows.Forms.NumericUpDown quociente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dividedRightLable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dividedLeftLable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox3;
    }
}

