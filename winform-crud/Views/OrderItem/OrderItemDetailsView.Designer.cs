
namespace winform_crud.Views.OrderItem
{
    partial class OrderItemDetailsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddOrderItemButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.OrderItemGridView = new System.Windows.Forms.DataGridView();
            this.AllProductsComboBox = new System.Windows.Forms.ComboBox();
            this.OrderTotalPrice = new System.Windows.Forms.Label();
            this.StatusOrderLabel = new System.Windows.Forms.Label();
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.OpenDateLabel = new System.Windows.Forms.Label();
            this.ClosingDateLabel = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrderItemButton
            // 
            this.AddOrderItemButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AddOrderItemButton.FlatAppearance.BorderSize = 0;
            this.AddOrderItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderItemButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOrderItemButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderItemButton.Location = new System.Drawing.Point(548, 142);
            this.AddOrderItemButton.Name = "AddOrderItemButton";
            this.AddOrderItemButton.Size = new System.Drawing.Size(80, 25);
            this.AddOrderItemButton.TabIndex = 4;
            this.AddOrderItemButton.Text = "Adicionar";
            this.AddOrderItemButton.UseVisualStyleBackColor = false;
            this.AddOrderItemButton.Click += new System.EventHandler(this.AddOrderItemButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Location = new System.Drawing.Point(12, 433);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(463, 38);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.Text = "Voltar";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // OrderItemGridView
            // 
            this.OrderItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderItemGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrderItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderItemGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrderItemGridView.Location = new System.Drawing.Point(12, 173);
            this.OrderItemGridView.Name = "OrderItemGridView";
            this.OrderItemGridView.ReadOnly = true;
            this.OrderItemGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderItemGridView.RowTemplate.Height = 25;
            this.OrderItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderItemGridView.Size = new System.Drawing.Size(616, 254);
            this.OrderItemGridView.TabIndex = 5;
            // 
            // AllProductsComboBox
            // 
            this.AllProductsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllProductsComboBox.FormattingEnabled = true;
            this.AllProductsComboBox.Location = new System.Drawing.Point(12, 144);
            this.AllProductsComboBox.Name = "AllProductsComboBox";
            this.AllProductsComboBox.Size = new System.Drawing.Size(530, 23);
            this.AllProductsComboBox.TabIndex = 6;
            // 
            // OrderTotalPrice
            // 
            this.OrderTotalPrice.BackColor = System.Drawing.Color.ForestGreen;
            this.OrderTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderTotalPrice.ForeColor = System.Drawing.Color.White;
            this.OrderTotalPrice.Location = new System.Drawing.Point(481, 433);
            this.OrderTotalPrice.Name = "OrderTotalPrice";
            this.OrderTotalPrice.Size = new System.Drawing.Size(147, 38);
            this.OrderTotalPrice.TabIndex = 11;
            this.OrderTotalPrice.Text = "Value";
            this.OrderTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusOrderLabel
            // 
            this.StatusOrderLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.StatusOrderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusOrderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StatusOrderLabel.Location = new System.Drawing.Point(481, 11);
            this.StatusOrderLabel.Name = "StatusOrderLabel";
            this.StatusOrderLabel.Size = new System.Drawing.Size(147, 60);
            this.StatusOrderLabel.TabIndex = 10;
            this.StatusOrderLabel.Text = "Status";
            this.StatusOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TableNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TableNumberLabel.Location = new System.Drawing.Point(12, 11);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(96, 60);
            this.TableNumberLabel.TabIndex = 9;
            this.TableNumberLabel.Text = "Table";
            this.TableNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenDateLabel
            // 
            this.OpenDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.OpenDateLabel.Location = new System.Drawing.Point(512, 80);
            this.OpenDateLabel.Name = "OpenDateLabel";
            this.OpenDateLabel.Size = new System.Drawing.Size(116, 15);
            this.OpenDateLabel.TabIndex = 11;
            this.OpenDateLabel.Text = "11/11/1111 11:11:11";
            this.OpenDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClosingDateLabel
            // 
            this.ClosingDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClosingDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClosingDateLabel.Location = new System.Drawing.Point(512, 107);
            this.ClosingDateLabel.Name = "ClosingDateLabel";
            this.ClosingDateLabel.Size = new System.Drawing.Size(116, 15);
            this.ClosingDateLabel.TabIndex = 12;
            this.ClosingDateLabel.Text = "11/11/1111 11:11:11";
            this.ClosingDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OrderNumberLabel.Location = new System.Drawing.Point(114, 11);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(151, 60);
            this.OrderNumberLabel.TabIndex = 15;
            this.OrderNumberLabel.Text = "CMD";
            this.OrderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderItemDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.OrderTotalPrice);
            this.Controls.Add(this.StatusOrderLabel);
            this.Controls.Add(this.TableNumberLabel);
            this.Controls.Add(this.ClosingDateLabel);
            this.Controls.Add(this.OpenDateLabel);
            this.Controls.Add(this.AllProductsComboBox);
            this.Controls.Add(this.OrderItemGridView);
            this.Controls.Add(this.AddOrderItemButton);
            this.Controls.Add(this.GoBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderItemDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderItemView";
            this.Load += new System.EventHandler(this.OrderItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddOrderItemButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.DataGridView OrderItemGridView;
        private System.Windows.Forms.ComboBox AllProductsComboBox;
        private System.Windows.Forms.Label TableNumberLabel;
        private System.Windows.Forms.Label StatusOrderLabel;
        private System.Windows.Forms.Label OpenDateLabel;
        private System.Windows.Forms.Label ClosingDateLabel;
        private System.Windows.Forms.Label OrderTotalPrice;
        private System.Windows.Forms.Label OrderNumberLabel;
    }
}