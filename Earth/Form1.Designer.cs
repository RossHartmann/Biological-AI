namespace Earth
{
    partial class Form1
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
            this.functions_list_box = new System.Windows.Forms.ListBox();
            this.function_names_combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codons_encoding_primarily_for_function_name_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.function_base_name_combo_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.function_identifiers_combo_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // functions_list_box
            // 
            this.functions_list_box.FormattingEnabled = true;
            this.functions_list_box.Location = new System.Drawing.Point(444, 25);
            this.functions_list_box.Name = "functions_list_box";
            this.functions_list_box.Size = new System.Drawing.Size(384, 342);
            this.functions_list_box.TabIndex = 0;
            // 
            // function_names_combo_box
            // 
            this.function_names_combo_box.FormattingEnabled = true;
            this.function_names_combo_box.Location = new System.Drawing.Point(15, 65);
            this.function_names_combo_box.Name = "function_names_combo_box";
            this.function_names_combo_box.Size = new System.Drawing.Size(423, 21);
            this.function_names_combo_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Function Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Functions with Selected Function Name:";
            // 
            // codons_encoding_primarily_for_function_name_text_box
            // 
            this.codons_encoding_primarily_for_function_name_text_box.Location = new System.Drawing.Point(15, 224);
            this.codons_encoding_primarily_for_function_name_text_box.Name = "codons_encoding_primarily_for_function_name_text_box";
            this.codons_encoding_primarily_for_function_name_text_box.ReadOnly = true;
            this.codons_encoding_primarily_for_function_name_text_box.Size = new System.Drawing.Size(154, 20);
            this.codons_encoding_primarily_for_function_name_text_box.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codons Encoding Primarily For Selected Function Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Function Base Name:";
            // 
            // function_base_name_combo_box
            // 
            this.function_base_name_combo_box.FormattingEnabled = true;
            this.function_base_name_combo_box.Location = new System.Drawing.Point(15, 105);
            this.function_base_name_combo_box.Name = "function_base_name_combo_box";
            this.function_base_name_combo_box.Size = new System.Drawing.Size(423, 21);
            this.function_base_name_combo_box.TabIndex = 6;
            this.function_base_name_combo_box.SelectedIndexChanged += new System.EventHandler(this.function_base_name_combo_box_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Function Identifiers:";
            // 
            // function_identifiers_combo_box
            // 
            this.function_identifiers_combo_box.FormattingEnabled = true;
            this.function_identifiers_combo_box.Location = new System.Drawing.Point(15, 25);
            this.function_identifiers_combo_box.Name = "function_identifiers_combo_box";
            this.function_identifiers_combo_box.Size = new System.Drawing.Size(423, 21);
            this.function_identifiers_combo_box.TabIndex = 8;
            this.function_identifiers_combo_box.SelectedIndexChanged += new System.EventHandler(this.function_identifiers_combo_box_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.function_identifiers_combo_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.function_base_name_combo_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codons_encoding_primarily_for_function_name_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.function_names_combo_box);
            this.Controls.Add(this.functions_list_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox functions_list_box;
        private System.Windows.Forms.ComboBox function_names_combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codons_encoding_primarily_for_function_name_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox function_base_name_combo_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox function_identifiers_combo_box;
    }
}

