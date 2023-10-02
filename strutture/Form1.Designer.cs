namespace strutture
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salva = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.canc = new System.Windows.Forms.Button();
            this.modifi = new System.Windows.Forms.Button();
            this.nome1 = new System.Windows.Forms.TextBox();
            this.prezzo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome2 = new System.Windows.Forms.TextBox();
            this.prez2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(15, 27);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 0;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(136, 25);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(15, 53);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(75, 23);
            this.salva.TabIndex = 4;
            this.salva.Text = "salva";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(516, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 362);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // canc
            // 
            this.canc.Location = new System.Drawing.Point(136, 151);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(75, 23);
            this.canc.TabIndex = 6;
            this.canc.Text = "cancella";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // modifi
            // 
            this.modifi.Location = new System.Drawing.Point(15, 151);
            this.modifi.Name = "modifi";
            this.modifi.Size = new System.Drawing.Size(75, 23);
            this.modifi.TabIndex = 7;
            this.modifi.Text = "modifica";
            this.modifi.UseVisualStyleBackColor = true;
            this.modifi.Click += new System.EventHandler(this.modifi_Click);
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(12, 96);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(100, 20);
            this.nome1.TabIndex = 8;
            // 
            // prezzo2
            // 
            this.prezzo2.Location = new System.Drawing.Point(136, 96);
            this.prezzo2.Name = "prezzo2";
            this.prezzo2.Size = new System.Drawing.Size(100, 20);
            this.prezzo2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(12, 122);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(100, 20);
            this.nome2.TabIndex = 12;
            // 
            // prez2
            // 
            this.prez2.Location = new System.Drawing.Point(136, 122);
            this.prez2.Name = "prez2";
            this.prez2.Size = new System.Drawing.Size(100, 20);
            this.prez2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prez2);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezzo2);
            this.Controls.Add(this.nome1);
            this.Controls.Add(this.modifi);
            this.Controls.Add(this.canc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Button modifi;
        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.TextBox prezzo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome2;
        private System.Windows.Forms.TextBox prez2;
    }
}

