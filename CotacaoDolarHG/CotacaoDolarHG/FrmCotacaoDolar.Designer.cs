﻿namespace CotacaoDolarHG
{
    partial class FrmCotacaoDolar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compra:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(293, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Variação:";
            // 
            // lblBuy
            // 
            this.lblBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.Black;
            this.lblBuy.Location = new System.Drawing.Point(149, 106);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(248, 46);
            this.lblBuy.TabIndex = 5;
            this.lblBuy.Text = "0,0";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.Black;
            this.lblSell.Location = new System.Drawing.Point(149, 174);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(248, 46);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "0,0";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVar
            // 
            this.lblVar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar.ForeColor = System.Drawing.Color.Black;
            this.lblVar.Location = new System.Drawing.Point(149, 242);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(248, 46);
            this.lblVar.TabIndex = 7;
            this.lblVar.Text = "0,0";
            this.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 373);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblVar;
    }
}

