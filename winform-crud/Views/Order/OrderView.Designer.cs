
namespace winform_crud.Views.Order
{
    partial class OrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CloseOrderButton = new System.Windows.Forms.Button();
            this.RefreshGridViewButton = new System.Windows.Forms.Button();
            this.LastGridViewUpdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.OrdersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersGridView.Location = new System.Drawing.Point(22, 277);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdersGridView.RowTemplate.Height = 25;
            this.OrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGridView.Size = new System.Drawing.Size(800, 300);
            this.OrdersGridView.TabIndex = 0;
            this.OrdersGridView.DoubleClick += new System.EventHandler(this.OrdersGridView_DoubleClick);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddOrderButton.FlatAppearance.BorderSize = 0;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Location = new System.Drawing.Point(22, 205);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(122, 30);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Adicionar";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(742, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SearchText
            // 
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchText.Location = new System.Drawing.Point(22, 241);
            this.SearchText.MaxLength = 6;
            this.SearchText.Multiline = true;
            this.SearchText.Name = "SearchText";
            this.SearchText.PlaceholderText = "Buscar comanda pelo número ou mesa";
            this.SearchText.Size = new System.Drawing.Size(714, 30);
            this.SearchText.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(700, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CloseOrderButton
            // 
            this.CloseOrderButton.BackColor = System.Drawing.Color.ForestGreen;
            this.CloseOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseOrderButton.FlatAppearance.BorderSize = 0;
            this.CloseOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseOrderButton.Location = new System.Drawing.Point(278, 205);
            this.CloseOrderButton.Name = "CloseOrderButton";
            this.CloseOrderButton.Size = new System.Drawing.Size(122, 30);
            this.CloseOrderButton.TabIndex = 5;
            this.CloseOrderButton.Text = "Fechar";
            this.CloseOrderButton.UseVisualStyleBackColor = false;
            this.CloseOrderButton.Click += new System.EventHandler(this.CloseOrderButton_Click);
            // 
            // RefreshGridViewButton
            // 
            this.RefreshGridViewButton.BackColor = System.Drawing.Color.DarkOrange;
            this.RefreshGridViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshGridViewButton.FlatAppearance.BorderSize = 0;
            this.RefreshGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshGridViewButton.Location = new System.Drawing.Point(150, 205);
            this.RefreshGridViewButton.Name = "RefreshGridViewButton";
            this.RefreshGridViewButton.Size = new System.Drawing.Size(122, 30);
            this.RefreshGridViewButton.TabIndex = 6;
            this.RefreshGridViewButton.Text = "Atualizar";
            this.RefreshGridViewButton.UseVisualStyleBackColor = false;
            this.RefreshGridViewButton.Click += new System.EventHandler(this.RefreshGridViewButton_Click);
            // 
            // LastGridViewUpdateLabel
            // 
            this.LastGridViewUpdateLabel.AutoSize = true;
            this.LastGridViewUpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastGridViewUpdateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LastGridViewUpdateLabel.Location = new System.Drawing.Point(713, 18);
            this.LastGridViewUpdateLabel.Name = "LastGridViewUpdateLabel";
            this.LastGridViewUpdateLabel.Size = new System.Drawing.Size(121, 15);
            this.LastGridViewUpdateLabel.TabIndex = 7;
            this.LastGridViewUpdateLabel.Text = "[LastGridViewUpdate]";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.LastGridViewUpdateLabel);
            this.Controls.Add(this.RefreshGridViewButton);
            this.Controls.Add(this.CloseOrderButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrdersGridView);
            this.Name = "OrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POC";
            this.Load += new System.EventHandler(this.OrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseOrderButton;
        private System.Windows.Forms.Button RefreshGridViewButton;
        private System.Windows.Forms.Label LastGridViewUpdateLabel;
    }
}