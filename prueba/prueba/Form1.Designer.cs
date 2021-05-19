namespace prueba
{
    partial class Snake
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.serpienteM = new System.Windows.Forms.PictureBox();
            this.timerSerpienteIzquierda = new System.Windows.Forms.Timer(this.components);
            this.timerSerpienteDerecha = new System.Windows.Forms.Timer(this.components);
            this.timerSerpienteAbajo = new System.Windows.Forms.Timer(this.components);
            this.timerSerpienteArriba = new System.Windows.Forms.Timer(this.components);
            this.ComidaSerpiente = new System.Windows.Forms.PictureBox();
            this.numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serpienteM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComidaSerpiente)).BeginInit();
            this.SuspendLayout();
            // 
            // serpienteM
            // 
            this.serpienteM.Image = global::prueba.Properties.Resources.Serpiente2_reducida;
            this.serpienteM.Location = new System.Drawing.Point(3, 271);
            this.serpienteM.Name = "serpienteM";
            this.serpienteM.Size = new System.Drawing.Size(100, 38);
            this.serpienteM.TabIndex = 0;
            this.serpienteM.TabStop = false;
            // 
            // timerSerpienteIzquierda
            // 
            this.timerSerpienteIzquierda.Interval = 200;
            this.timerSerpienteIzquierda.Tick += new System.EventHandler(this.timerSerpienteIzquierda_Tick);
            // 
            // timerSerpienteDerecha
            // 
            this.timerSerpienteDerecha.Interval = 200;
            this.timerSerpienteDerecha.Tick += new System.EventHandler(this.timerSerpienteDerecha_Tick);
            // 
            // timerSerpienteAbajo
            // 
            this.timerSerpienteAbajo.Interval = 200;
            this.timerSerpienteAbajo.Tick += new System.EventHandler(this.timerSerpienteAbajo_Tick);
            // 
            // timerSerpienteArriba
            // 
            this.timerSerpienteArriba.Interval = 200;
            this.timerSerpienteArriba.Tick += new System.EventHandler(this.timerSerpienteArriba_Tick);
            // 
            // ComidaSerpiente
            // 
            this.ComidaSerpiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComidaSerpiente.BackgroundImage")));
            this.ComidaSerpiente.Location = new System.Drawing.Point(441, 133);
            this.ComidaSerpiente.Name = "ComidaSerpiente";
            this.ComidaSerpiente.Size = new System.Drawing.Size(25, 26);
            this.ComidaSerpiente.TabIndex = 5;
            this.ComidaSerpiente.TabStop = false;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.numero.Location = new System.Drawing.Point(412, 408);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(25, 25);
            this.numero.TabIndex = 6;
            this.numero.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(242, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Su puntaje es:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.ComidaSerpiente);
            this.Controls.Add(this.serpienteM);
            this.KeyPreview = true;
            this.Name = "Snake";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 2, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "j";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Snake_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.serpienteM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComidaSerpiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox serpienteM;
        private System.Windows.Forms.Timer timerSerpienteIzquierda;
        private System.Windows.Forms.Timer timerSerpienteDerecha;
        private System.Windows.Forms.Timer timerSerpienteAbajo;
        private System.Windows.Forms.Timer timerSerpienteArriba;
        private System.Windows.Forms.PictureBox ComidaSerpiente;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

