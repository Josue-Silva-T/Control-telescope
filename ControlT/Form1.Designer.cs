namespace controlT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCam = new System.Windows.Forms.Button();
            this.CAMARA = new System.Windows.Forms.GroupBox();
            this.comboBoxCAM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCerrado = new System.Windows.Forms.Button();
            this.buttonAbierto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSERIAL = new System.Windows.Forms.ComboBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMinizar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.buttonPausar = new System.Windows.Forms.Button();
            this.buttonIzquierda = new System.Windows.Forms.Button();
            this.buttonDerecha = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPausarV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonComenzarV = new System.Windows.Forms.Button();
            this.buttonIzquierdaV = new System.Windows.Forms.Button();
            this.buttonDerechoV = new System.Windows.Forms.Button();
            this.CAMARA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCam
            // 
            resources.ApplyResources(this.buttonCam, "buttonCam");
            this.buttonCam.BackColor = System.Drawing.Color.Black;
            this.buttonCam.Name = "buttonCam";
            this.buttonCam.UseVisualStyleBackColor = false;
            this.buttonCam.Click += new System.EventHandler(this.button1_Click);
            // 
            // CAMARA
            // 
            resources.ApplyResources(this.CAMARA, "CAMARA");
            this.CAMARA.BackColor = System.Drawing.Color.Transparent;
            this.CAMARA.Controls.Add(this.comboBoxCAM);
            this.CAMARA.Controls.Add(this.buttonCam);
            this.CAMARA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CAMARA.Name = "CAMARA";
            this.CAMARA.TabStop = false;
            // 
            // comboBoxCAM
            // 
            resources.ApplyResources(this.comboBoxCAM, "comboBoxCAM");
            this.comboBoxCAM.FormattingEnabled = true;
            this.comboBoxCAM.Items.AddRange(new object[] {
            resources.GetString("comboBoxCAM.Items"),
            resources.GetString("comboBoxCAM.Items1"),
            resources.GetString("comboBoxCAM.Items2")});
            this.comboBoxCAM.Name = "comboBoxCAM";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonCerrado);
            this.groupBox1.Controls.Add(this.buttonAbierto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxSERIAL);
            this.groupBox1.Controls.Add(this.comboBoxCOM);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonCerrado
            // 
            resources.ApplyResources(this.buttonCerrado, "buttonCerrado");
            this.buttonCerrado.BackColor = System.Drawing.Color.Black;
            this.buttonCerrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCerrado.Name = "buttonCerrado";
            this.buttonCerrado.UseVisualStyleBackColor = false;
            this.buttonCerrado.Click += new System.EventHandler(this.buttonCerrado_Click);
            // 
            // buttonAbierto
            // 
            resources.ApplyResources(this.buttonAbierto, "buttonAbierto");
            this.buttonAbierto.BackColor = System.Drawing.Color.Black;
            this.buttonAbierto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAbierto.Name = "buttonAbierto";
            this.buttonAbierto.UseVisualStyleBackColor = false;
            this.buttonAbierto.Click += new System.EventHandler(this.buttonAbierto_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // comboBoxSERIAL
            // 
            resources.ApplyResources(this.comboBoxSERIAL, "comboBoxSERIAL");
            this.comboBoxSERIAL.FormattingEnabled = true;
            this.comboBoxSERIAL.Items.AddRange(new object[] {
            resources.GetString("comboBoxSERIAL.Items"),
            resources.GetString("comboBoxSERIAL.Items1"),
            resources.GetString("comboBoxSERIAL.Items2"),
            resources.GetString("comboBoxSERIAL.Items3"),
            resources.GetString("comboBoxSERIAL.Items4"),
            resources.GetString("comboBoxSERIAL.Items5")});
            this.comboBoxSERIAL.Name = "comboBoxSERIAL";
            // 
            // comboBoxCOM
            // 
            resources.ApplyResources(this.comboBoxCOM, "comboBoxCOM");
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            resources.GetString("comboBoxCOM.Items"),
            resources.GetString("comboBoxCOM.Items1"),
            resources.GetString("comboBoxCOM.Items2"),
            resources.GetString("comboBoxCOM.Items3"),
            resources.GetString("comboBoxCOM.Items4"),
            resources.GetString("comboBoxCOM.Items5"),
            resources.GetString("comboBoxCOM.Items6")});
            this.comboBoxCOM.Name = "comboBoxCOM";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonMinizar);
            this.groupBox2.Controls.Add(this.buttonMaximizar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonMinizar
            // 
            resources.ApplyResources(this.buttonMinizar, "buttonMinizar");
            this.buttonMinizar.BackColor = System.Drawing.Color.Black;
            this.buttonMinizar.Name = "buttonMinizar";
            this.buttonMinizar.UseVisualStyleBackColor = false;
            this.buttonMinizar.Click += new System.EventHandler(this.buttonMinizar_Click);
            // 
            // buttonMaximizar
            // 
            resources.ApplyResources(this.buttonMaximizar, "buttonMaximizar");
            this.buttonMaximizar.BackColor = System.Drawing.Color.Black;
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.UseVisualStyleBackColor = false;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonComenzar);
            this.groupBox3.Controls.Add(this.buttonPausar);
            this.groupBox3.Controls.Add(this.buttonIzquierda);
            this.groupBox3.Controls.Add(this.buttonDerecha);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // buttonComenzar
            // 
            resources.ApplyResources(this.buttonComenzar, "buttonComenzar");
            this.buttonComenzar.BackColor = System.Drawing.Color.Black;
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.UseVisualStyleBackColor = false;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click_1);
            // 
            // buttonPausar
            // 
            resources.ApplyResources(this.buttonPausar, "buttonPausar");
            this.buttonPausar.BackColor = System.Drawing.Color.Black;
            this.buttonPausar.Name = "buttonPausar";
            this.buttonPausar.UseVisualStyleBackColor = false;
            this.buttonPausar.Click += new System.EventHandler(this.buttonPausar_Click);
            // 
            // buttonIzquierda
            // 
            resources.ApplyResources(this.buttonIzquierda, "buttonIzquierda");
            this.buttonIzquierda.BackColor = System.Drawing.Color.Black;
            this.buttonIzquierda.Name = "buttonIzquierda";
            this.buttonIzquierda.UseVisualStyleBackColor = false;
            this.buttonIzquierda.Click += new System.EventHandler(this.buttonIzquierda_Click);
            // 
            // buttonDerecha
            // 
            resources.ApplyResources(this.buttonDerecha, "buttonDerecha");
            this.buttonDerecha.BackColor = System.Drawing.Color.Black;
            this.buttonDerecha.Name = "buttonDerecha";
            this.buttonDerecha.UseVisualStyleBackColor = false;
            this.buttonDerecha.Click += new System.EventHandler(this.buttonDerecha_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // buttonPausarV
            // 
            resources.ApplyResources(this.buttonPausarV, "buttonPausarV");
            this.buttonPausarV.BackColor = System.Drawing.Color.Black;
            this.buttonPausarV.Name = "buttonPausarV";
            this.buttonPausarV.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.buttonComenzarV);
            this.groupBox4.Controls.Add(this.buttonPausarV);
            this.groupBox4.Controls.Add(this.buttonIzquierdaV);
            this.groupBox4.Controls.Add(this.buttonDerechoV);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // buttonComenzarV
            // 
            resources.ApplyResources(this.buttonComenzarV, "buttonComenzarV");
            this.buttonComenzarV.BackColor = System.Drawing.Color.Black;
            this.buttonComenzarV.Name = "buttonComenzarV";
            this.buttonComenzarV.UseVisualStyleBackColor = false;
            // 
            // buttonIzquierdaV
            // 
            resources.ApplyResources(this.buttonIzquierdaV, "buttonIzquierdaV");
            this.buttonIzquierdaV.BackColor = System.Drawing.Color.Black;
            this.buttonIzquierdaV.Name = "buttonIzquierdaV";
            this.buttonIzquierdaV.UseVisualStyleBackColor = false;
            // 
            // buttonDerechoV
            // 
            resources.ApplyResources(this.buttonDerechoV, "buttonDerechoV");
            this.buttonDerechoV.BackColor = System.Drawing.Color.Black;
            this.buttonDerechoV.Name = "buttonDerechoV";
            this.buttonDerechoV.UseVisualStyleBackColor = false;
            this.buttonDerechoV.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CAMARA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CAMARA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCam;
        private System.Windows.Forms.GroupBox CAMARA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSERIAL;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonCerrado;
        private System.Windows.Forms.Button buttonAbierto;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMinizar;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.Button buttonIzquierda;
        private System.Windows.Forms.Button buttonDerecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.Button buttonPausar;
        private System.Windows.Forms.ComboBox comboBoxCAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPausarV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonComenzarV;
        private System.Windows.Forms.Button buttonIzquierdaV;
        private System.Windows.Forms.Button buttonDerechoV;
    }
}

