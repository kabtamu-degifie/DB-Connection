namespace WinFormsApp7
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
            this.Save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(47, 134);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 29);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(47, 68);
            this.name.Name = "name";
            this.name.PlaceholderText = "Name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 1;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(47, 101);
            this.age.Name = "age";
            this.age.PlaceholderText = "Age";
            this.age.Size = new System.Drawing.Size(125, 27);
            this.age.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(435, 245);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(47, 35);
            this.id.Name = "id";
            this.id.PlaceholderText = "Id";
            this.id.Size = new System.Drawing.Size(125, 27);
            this.id.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private TextBox name;
        private TextBox age;
        private DataGridView dataGridView1;
        private TextBox id;
    }
}