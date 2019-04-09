namespace NumbersProjekt
{
    partial class NumbersForm
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
            this.components = new System.ComponentModel.Container();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxNumber = new System.Windows.Forms.ListBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.panelCompute = new System.Windows.Forms.Panel();
            this.errorProviderAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModify = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelNumber.SuspendLayout();
            this.panelCompute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(28, 33);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(113, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Adjon meg egy számot";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(165, 25);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(154, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(349, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(151, 70);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;            
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(151, 115);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // listBoxNumber
            // 
            this.listBoxNumber.FormattingEnabled = true;
            this.listBoxNumber.Location = new System.Drawing.Point(14, 13);
            this.listBoxNumber.Name = "listBoxNumber";
            this.listBoxNumber.Size = new System.Drawing.Size(113, 303);
            this.listBoxNumber.TabIndex = 5;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(3, 16);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(75, 23);
            this.buttonCompute.TabIndex = 6;
            this.buttonCompute.Text = "Kiszámol";
            this.buttonCompute.UseVisualStyleBackColor = true;            
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(17, 52);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(31, 13);
            this.labelAverage.TabIndex = 7;
            this.labelAverage.Text = "Átlag";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(20, 68);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 8;
            this.textBoxAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(457, 399);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelNumber
            // 
            this.panelNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNumber.Controls.Add(this.buttonModify);
            this.panelNumber.Controls.Add(this.buttonDelete);
            this.panelNumber.Controls.Add(this.listBoxNumber);
            this.panelNumber.Location = new System.Drawing.Point(12, 81);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(307, 341);
            this.panelNumber.TabIndex = 10;
            // 
            // panelCompute
            // 
            this.panelCompute.Controls.Add(this.buttonCompute);
            this.panelCompute.Controls.Add(this.textBoxAverage);
            this.panelCompute.Controls.Add(this.labelAverage);
            this.panelCompute.Location = new System.Drawing.Point(349, 81);
            this.panelCompute.Name = "panelCompute";
            this.panelCompute.Size = new System.Drawing.Size(183, 290);
            this.panelCompute.TabIndex = 11;
            // 
            // errorProviderAdd
            // 
            this.errorProviderAdd.ContainerControl = this;
            // 
            // errorProviderDelete
            // 
            this.errorProviderDelete.ContainerControl = this;
            // 
            // errorProviderModify
            // 
            this.errorProviderModify.ContainerControl = this;
            // 
            // errorProviderNumber
            // 
            this.errorProviderNumber.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelCompute);
            this.Controls.Add(this.panelNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelNumber.ResumeLayout(false);
            this.panelCompute.ResumeLayout(false);
            this.panelCompute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxNumber;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelNumber;
        private System.Windows.Forms.Panel panelCompute;
        private System.Windows.Forms.ErrorProvider errorProviderAdd;
        private System.Windows.Forms.ErrorProvider errorProviderDelete;
        private System.Windows.Forms.ErrorProvider errorProviderModify;
        private System.Windows.Forms.ErrorProvider errorProviderNumber;
    }
}

