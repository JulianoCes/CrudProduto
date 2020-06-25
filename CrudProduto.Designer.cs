namespace CrudProduto
{
    partial class CrudProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MetlblNome = new MetroFramework.Controls.MetroLabel();
            this.Metlbltipo = new MetroFramework.Controls.MetroLabel();
            this.MetlblMarca = new MetroFramework.Controls.MetroLabel();
            this.MetlblQuantidade = new MetroFramework.Controls.MetroLabel();
            this.MetlblValor = new MetroFramework.Controls.MetroLabel();
            this.MetxtNome = new MetroFramework.Controls.MetroTextBox();
            this.MetxtTipo = new MetroFramework.Controls.MetroTextBox();
            this.MetxtMarca = new MetroFramework.Controls.MetroTextBox();
            this.MetxtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.MetxtValor = new MetroFramework.Controls.MetroTextBox();
            this.MetbtnLocalizar = new MetroFramework.Controls.MetroButton();
            this.MetbtnSair = new MetroFramework.Controls.MetroButton();
            this.MetbtnCadastra = new MetroFramework.Controls.MetroButton();
            this.MetbtnExcluir = new MetroFramework.Controls.MetroButton();
            this.MetbtnAtualizar = new MetroFramework.Controls.MetroButton();
            this.MetDgvProduto = new MetroFramework.Controls.MetroGrid();
            this.MetxtId = new MetroFramework.Controls.MetroTextBox();
            this.MetlblId = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MetDgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // MetlblNome
            // 
            this.MetlblNome.AutoSize = true;
            this.MetlblNome.FontSize = MetroFramework.MetroLabelSize.Small;
            this.MetlblNome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetlblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MetlblNome.Location = new System.Drawing.Point(81, 109);
            this.MetlblNome.Name = "MetlblNome";
            this.MetlblNome.Size = new System.Drawing.Size(41, 15);
            this.MetlblNome.TabIndex = 0;
            this.MetlblNome.Text = "Nome";
            // 
            // Metlbltipo
            // 
            this.Metlbltipo.AutoSize = true;
            this.Metlbltipo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Metlbltipo.Location = new System.Drawing.Point(79, 140);
            this.Metlbltipo.Name = "Metlbltipo";
            this.Metlbltipo.Size = new System.Drawing.Size(39, 19);
            this.Metlbltipo.TabIndex = 1;
            this.Metlbltipo.Text = "Tipo";
            // 
            // MetlblMarca
            // 
            this.MetlblMarca.AutoSize = true;
            this.MetlblMarca.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetlblMarca.Location = new System.Drawing.Point(79, 175);
            this.MetlblMarca.Name = "MetlblMarca";
            this.MetlblMarca.Size = new System.Drawing.Size(51, 19);
            this.MetlblMarca.TabIndex = 2;
            this.MetlblMarca.Text = "Marca";
            // 
            // MetlblQuantidade
            // 
            this.MetlblQuantidade.AutoSize = true;
            this.MetlblQuantidade.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetlblQuantidade.Location = new System.Drawing.Point(79, 213);
            this.MetlblQuantidade.Name = "MetlblQuantidade";
            this.MetlblQuantidade.Size = new System.Drawing.Size(87, 19);
            this.MetlblQuantidade.TabIndex = 3;
            this.MetlblQuantidade.Text = "Quantidade";
            // 
            // MetlblValor
            // 
            this.MetlblValor.AutoSize = true;
            this.MetlblValor.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetlblValor.Location = new System.Drawing.Point(81, 244);
            this.MetlblValor.Name = "MetlblValor";
            this.MetlblValor.Size = new System.Drawing.Size(44, 19);
            this.MetlblValor.TabIndex = 4;
            this.MetlblValor.Text = "Valor";
            // 
            // MetxtNome
            // 
            // 
            // 
            // 
            this.MetxtNome.CustomButton.Image = null;
            this.MetxtNome.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MetxtNome.CustomButton.Name = "";
            this.MetxtNome.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtNome.CustomButton.TabIndex = 1;
            this.MetxtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtNome.CustomButton.UseSelectable = true;
            this.MetxtNome.CustomButton.Visible = false;
            this.MetxtNome.Lines = new string[0];
            this.MetxtNome.Location = new System.Drawing.Point(153, 101);
            this.MetxtNome.MaxLength = 32767;
            this.MetxtNome.Name = "MetxtNome";
            this.MetxtNome.PasswordChar = '\0';
            this.MetxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtNome.SelectedText = "";
            this.MetxtNome.SelectionLength = 0;
            this.MetxtNome.SelectionStart = 0;
            this.MetxtNome.ShortcutsEnabled = true;
            this.MetxtNome.Size = new System.Drawing.Size(243, 23);
            this.MetxtNome.TabIndex = 5;
            this.MetxtNome.UseSelectable = true;
            this.MetxtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetxtTipo
            // 
            // 
            // 
            // 
            this.MetxtTipo.CustomButton.Image = null;
            this.MetxtTipo.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MetxtTipo.CustomButton.Name = "";
            this.MetxtTipo.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtTipo.CustomButton.TabIndex = 1;
            this.MetxtTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtTipo.CustomButton.UseSelectable = true;
            this.MetxtTipo.CustomButton.Visible = false;
            this.MetxtTipo.Lines = new string[0];
            this.MetxtTipo.Location = new System.Drawing.Point(153, 136);
            this.MetxtTipo.MaxLength = 32767;
            this.MetxtTipo.Name = "MetxtTipo";
            this.MetxtTipo.PasswordChar = '\0';
            this.MetxtTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtTipo.SelectedText = "";
            this.MetxtTipo.SelectionLength = 0;
            this.MetxtTipo.SelectionStart = 0;
            this.MetxtTipo.ShortcutsEnabled = true;
            this.MetxtTipo.Size = new System.Drawing.Size(243, 23);
            this.MetxtTipo.TabIndex = 6;
            this.MetxtTipo.UseSelectable = true;
            this.MetxtTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetxtMarca
            // 
            // 
            // 
            // 
            this.MetxtMarca.CustomButton.Image = null;
            this.MetxtMarca.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MetxtMarca.CustomButton.Name = "";
            this.MetxtMarca.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtMarca.CustomButton.TabIndex = 1;
            this.MetxtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtMarca.CustomButton.UseSelectable = true;
            this.MetxtMarca.CustomButton.Visible = false;
            this.MetxtMarca.Lines = new string[0];
            this.MetxtMarca.Location = new System.Drawing.Point(153, 171);
            this.MetxtMarca.MaxLength = 32767;
            this.MetxtMarca.Name = "MetxtMarca";
            this.MetxtMarca.PasswordChar = '\0';
            this.MetxtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtMarca.SelectedText = "";
            this.MetxtMarca.SelectionLength = 0;
            this.MetxtMarca.SelectionStart = 0;
            this.MetxtMarca.ShortcutsEnabled = true;
            this.MetxtMarca.Size = new System.Drawing.Size(243, 23);
            this.MetxtMarca.TabIndex = 7;
            this.MetxtMarca.UseSelectable = true;
            this.MetxtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetxtQuantidade
            // 
            // 
            // 
            // 
            this.MetxtQuantidade.CustomButton.Image = null;
            this.MetxtQuantidade.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.MetxtQuantidade.CustomButton.Name = "";
            this.MetxtQuantidade.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtQuantidade.CustomButton.TabIndex = 1;
            this.MetxtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtQuantidade.CustomButton.UseSelectable = true;
            this.MetxtQuantidade.CustomButton.Visible = false;
            this.MetxtQuantidade.Lines = new string[0];
            this.MetxtQuantidade.Location = new System.Drawing.Point(189, 213);
            this.MetxtQuantidade.MaxLength = 32767;
            this.MetxtQuantidade.Name = "MetxtQuantidade";
            this.MetxtQuantidade.PasswordChar = '\0';
            this.MetxtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtQuantidade.SelectedText = "";
            this.MetxtQuantidade.SelectionLength = 0;
            this.MetxtQuantidade.SelectionStart = 0;
            this.MetxtQuantidade.ShortcutsEnabled = true;
            this.MetxtQuantidade.Size = new System.Drawing.Size(92, 23);
            this.MetxtQuantidade.TabIndex = 8;
            this.MetxtQuantidade.UseSelectable = true;
            this.MetxtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetxtValor
            // 
            // 
            // 
            // 
            this.MetxtValor.CustomButton.Image = null;
            this.MetxtValor.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.MetxtValor.CustomButton.Name = "";
            this.MetxtValor.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtValor.CustomButton.TabIndex = 1;
            this.MetxtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtValor.CustomButton.UseSelectable = true;
            this.MetxtValor.CustomButton.Visible = false;
            this.MetxtValor.Lines = new string[0];
            this.MetxtValor.Location = new System.Drawing.Point(153, 244);
            this.MetxtValor.MaxLength = 32767;
            this.MetxtValor.Name = "MetxtValor";
            this.MetxtValor.PasswordChar = '\0';
            this.MetxtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtValor.SelectedText = "";
            this.MetxtValor.SelectionLength = 0;
            this.MetxtValor.SelectionStart = 0;
            this.MetxtValor.ShortcutsEnabled = true;
            this.MetxtValor.Size = new System.Drawing.Size(128, 23);
            this.MetxtValor.TabIndex = 9;
            this.MetxtValor.UseSelectable = true;
            this.MetxtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetbtnLocalizar
            // 
            this.MetbtnLocalizar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MetbtnLocalizar.Location = new System.Drawing.Point(300, 62);
            this.MetbtnLocalizar.Name = "MetbtnLocalizar";
            this.MetbtnLocalizar.Size = new System.Drawing.Size(96, 33);
            this.MetbtnLocalizar.TabIndex = 10;
            this.MetbtnLocalizar.Text = "Buscar";
            this.MetbtnLocalizar.UseSelectable = true;
            this.MetbtnLocalizar.Click += new System.EventHandler(this.MetbtnLocalizar_Click);
            // 
            // MetbtnSair
            // 
            this.MetbtnSair.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MetbtnSair.Location = new System.Drawing.Point(444, 224);
            this.MetbtnSair.Name = "MetbtnSair";
            this.MetbtnSair.Size = new System.Drawing.Size(76, 38);
            this.MetbtnSair.TabIndex = 11;
            this.MetbtnSair.Text = "Sair";
            this.MetbtnSair.UseSelectable = true;
            this.MetbtnSair.Click += new System.EventHandler(this.MetbtnSair_Click);
            // 
            // MetbtnCadastra
            // 
            this.MetbtnCadastra.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MetbtnCadastra.Location = new System.Drawing.Point(444, 54);
            this.MetbtnCadastra.Name = "MetbtnCadastra";
            this.MetbtnCadastra.Size = new System.Drawing.Size(76, 38);
            this.MetbtnCadastra.TabIndex = 11;
            this.MetbtnCadastra.Text = "Cadastra";
            this.MetbtnCadastra.UseSelectable = true;
            this.MetbtnCadastra.Click += new System.EventHandler(this.MetbtnCadastra_Click);
            // 
            // MetbtnExcluir
            // 
            this.MetbtnExcluir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MetbtnExcluir.Location = new System.Drawing.Point(444, 166);
            this.MetbtnExcluir.Name = "MetbtnExcluir";
            this.MetbtnExcluir.Size = new System.Drawing.Size(76, 38);
            this.MetbtnExcluir.TabIndex = 11;
            this.MetbtnExcluir.Text = "Excluir";
            this.MetbtnExcluir.UseSelectable = true;
            this.MetbtnExcluir.Click += new System.EventHandler(this.MetbtnExcluir_Click);
            // 
            // MetbtnAtualizar
            // 
            this.MetbtnAtualizar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MetbtnAtualizar.Location = new System.Drawing.Point(444, 109);
            this.MetbtnAtualizar.Name = "MetbtnAtualizar";
            this.MetbtnAtualizar.Size = new System.Drawing.Size(76, 38);
            this.MetbtnAtualizar.TabIndex = 11;
            this.MetbtnAtualizar.Text = "Atualizar";
            this.MetbtnAtualizar.UseSelectable = true;
            this.MetbtnAtualizar.Click += new System.EventHandler(this.MetbtnAtualizar_Click);
            // 
            // MetDgvProduto
            // 
            this.MetDgvProduto.AllowUserToResizeRows = false;
            this.MetDgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetDgvProduto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.MetDgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetDgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetDgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetDgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MetDgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetDgvProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.MetDgvProduto.EnableHeadersVisualStyles = false;
            this.MetDgvProduto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetDgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetDgvProduto.Location = new System.Drawing.Point(46, 283);
            this.MetDgvProduto.Name = "MetDgvProduto";
            this.MetDgvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetDgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MetDgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetDgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetDgvProduto.Size = new System.Drawing.Size(528, 95);
            this.MetDgvProduto.TabIndex = 12;
            this.MetDgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetDgvProduto_CellClick);
            // 
            // MetxtId
            // 
            // 
            // 
            // 
            this.MetxtId.CustomButton.Image = null;
            this.MetxtId.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.MetxtId.CustomButton.Name = "";
            this.MetxtId.CustomButton.Size = new System.Drawing.Size(21, 18);
            this.MetxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetxtId.CustomButton.TabIndex = 1;
            this.MetxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetxtId.CustomButton.UseSelectable = true;
            this.MetxtId.CustomButton.Visible = false;
            this.MetxtId.Lines = new string[0];
            this.MetxtId.Location = new System.Drawing.Point(153, 69);
            this.MetxtId.MaxLength = 32767;
            this.MetxtId.Name = "MetxtId";
            this.MetxtId.PasswordChar = '\0';
            this.MetxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetxtId.SelectedText = "";
            this.MetxtId.SelectionLength = 0;
            this.MetxtId.SelectionStart = 0;
            this.MetxtId.ShortcutsEnabled = true;
            this.MetxtId.Size = new System.Drawing.Size(68, 23);
            this.MetxtId.TabIndex = 14;
            this.MetxtId.UseSelectable = true;
            this.MetxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetlblId
            // 
            this.MetlblId.AutoSize = true;
            this.MetlblId.FontSize = MetroFramework.MetroLabelSize.Small;
            this.MetlblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetlblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MetlblId.Location = new System.Drawing.Point(98, 69);
            this.MetlblId.Name = "MetlblId";
            this.MetlblId.Size = new System.Drawing.Size(20, 15);
            this.MetlblId.TabIndex = 13;
            this.MetlblId.Text = "ID";
            // 
            // CrudProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 401);
            this.Controls.Add(this.MetxtId);
            this.Controls.Add(this.MetlblId);
            this.Controls.Add(this.MetDgvProduto);
            this.Controls.Add(this.MetbtnAtualizar);
            this.Controls.Add(this.MetbtnExcluir);
            this.Controls.Add(this.MetbtnCadastra);
            this.Controls.Add(this.MetbtnSair);
            this.Controls.Add(this.MetbtnLocalizar);
            this.Controls.Add(this.MetxtValor);
            this.Controls.Add(this.MetxtQuantidade);
            this.Controls.Add(this.MetxtMarca);
            this.Controls.Add(this.MetxtTipo);
            this.Controls.Add(this.MetxtNome);
            this.Controls.Add(this.MetlblValor);
            this.Controls.Add(this.MetlblQuantidade);
            this.Controls.Add(this.MetlblMarca);
            this.Controls.Add(this.Metlbltipo);
            this.Controls.Add(this.MetlblNome);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CrudProduto";
            this.Text = "CrudProduto";
            this.Load += new System.EventHandler(this.CrudProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MetDgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel MetlblNome;
        private MetroFramework.Controls.MetroLabel Metlbltipo;
        private MetroFramework.Controls.MetroLabel MetlblMarca;
        private MetroFramework.Controls.MetroLabel MetlblQuantidade;
        private MetroFramework.Controls.MetroLabel MetlblValor;
        private MetroFramework.Controls.MetroTextBox MetxtNome;
        private MetroFramework.Controls.MetroTextBox MetxtTipo;
        private MetroFramework.Controls.MetroTextBox MetxtMarca;
        private MetroFramework.Controls.MetroTextBox MetxtQuantidade;
        private MetroFramework.Controls.MetroTextBox MetxtValor;
        private MetroFramework.Controls.MetroButton MetbtnLocalizar;
        private MetroFramework.Controls.MetroButton MetbtnSair;
        private MetroFramework.Controls.MetroButton MetbtnCadastra;
        private MetroFramework.Controls.MetroButton MetbtnExcluir;
        private MetroFramework.Controls.MetroButton MetbtnAtualizar;
        private MetroFramework.Controls.MetroGrid MetDgvProduto;
        private MetroFramework.Controls.MetroTextBox MetxtId;
        private MetroFramework.Controls.MetroLabel MetlblId;
    }
}