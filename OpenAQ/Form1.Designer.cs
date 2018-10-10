namespace OpenAQ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonCity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCountry = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPollution = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonForecast = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelPanels = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Panel();
            this.panelCity = new System.Windows.Forms.Panel();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.panelPollution = new System.Windows.Forms.Panel();
            this.panelForecast = new System.Windows.Forms.Panel();
            this.checkComboBox1 = new OpenAQ.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkComboBoxCity = new OpenAQ.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPollution = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panelPanels.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.line);
            this.bunifuGradientPanel1.Controls.Add(this.panelPanels);
            this.bunifuGradientPanel1.Controls.Add(this.buttonForecast);
            this.bunifuGradientPanel1.Controls.Add(this.buttonPollution);
            this.bunifuGradientPanel1.Controls.Add(this.buttonCountry);
            this.bunifuGradientPanel1.Controls.Add(this.buttonCity);
            this.bunifuGradientPanel1.Controls.Add(this.buttonClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1224, 662);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(1175, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 43);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // buttonCity
            // 
            this.buttonCity.Activecolor = System.Drawing.Color.Purple;
            this.buttonCity.BackColor = System.Drawing.Color.Transparent;
            this.buttonCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCity.BorderRadius = 0;
            this.buttonCity.ButtonText = "Города";
            this.buttonCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCity.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCity.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCity.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCity.Iconimage")));
            this.buttonCity.Iconimage_right = null;
            this.buttonCity.Iconimage_right_Selected = null;
            this.buttonCity.Iconimage_Selected = null;
            this.buttonCity.IconMarginLeft = 30;
            this.buttonCity.IconMarginRight = 0;
            this.buttonCity.IconRightVisible = true;
            this.buttonCity.IconRightZoom = 0D;
            this.buttonCity.IconVisible = true;
            this.buttonCity.IconZoom = 90D;
            this.buttonCity.IsTab = false;
            this.buttonCity.Location = new System.Drawing.Point(0, 140);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCity.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonCity.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCity.selected = false;
            this.buttonCity.Size = new System.Drawing.Size(350, 66);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Города";
            this.buttonCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCity.Textcolor = System.Drawing.Color.White;
            this.buttonCity.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonCountry
            // 
            this.buttonCountry.Activecolor = System.Drawing.Color.Purple;
            this.buttonCountry.BackColor = System.Drawing.Color.Transparent;
            this.buttonCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCountry.BorderRadius = 0;
            this.buttonCountry.ButtonText = "Страны";
            this.buttonCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCountry.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCountry.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCountry.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCountry.Iconimage")));
            this.buttonCountry.Iconimage_right = null;
            this.buttonCountry.Iconimage_right_Selected = null;
            this.buttonCountry.Iconimage_Selected = null;
            this.buttonCountry.IconMarginLeft = 30;
            this.buttonCountry.IconMarginRight = 0;
            this.buttonCountry.IconRightVisible = true;
            this.buttonCountry.IconRightZoom = 0D;
            this.buttonCountry.IconVisible = true;
            this.buttonCountry.IconZoom = 90D;
            this.buttonCountry.IsTab = false;
            this.buttonCountry.Location = new System.Drawing.Point(0, 240);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCountry.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonCountry.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCountry.selected = false;
            this.buttonCountry.Size = new System.Drawing.Size(350, 66);
            this.buttonCountry.TabIndex = 1;
            this.buttonCountry.Text = "Страны";
            this.buttonCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCountry.Textcolor = System.Drawing.Color.White;
            this.buttonCountry.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonPollution
            // 
            this.buttonPollution.Activecolor = System.Drawing.Color.Purple;
            this.buttonPollution.BackColor = System.Drawing.Color.Transparent;
            this.buttonPollution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPollution.BorderRadius = 0;
            this.buttonPollution.ButtonText = "Загрязнители";
            this.buttonPollution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPollution.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPollution.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPollution.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonPollution.Iconimage")));
            this.buttonPollution.Iconimage_right = null;
            this.buttonPollution.Iconimage_right_Selected = null;
            this.buttonPollution.Iconimage_Selected = null;
            this.buttonPollution.IconMarginLeft = 30;
            this.buttonPollution.IconMarginRight = 0;
            this.buttonPollution.IconRightVisible = true;
            this.buttonPollution.IconRightZoom = 0D;
            this.buttonPollution.IconVisible = true;
            this.buttonPollution.IconZoom = 90D;
            this.buttonPollution.IsTab = false;
            this.buttonPollution.Location = new System.Drawing.Point(0, 340);
            this.buttonPollution.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonPollution.Name = "buttonPollution";
            this.buttonPollution.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonPollution.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonPollution.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPollution.selected = false;
            this.buttonPollution.Size = new System.Drawing.Size(350, 66);
            this.buttonPollution.TabIndex = 1;
            this.buttonPollution.Text = "Загрязнители";
            this.buttonPollution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPollution.Textcolor = System.Drawing.Color.White;
            this.buttonPollution.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPollution.Click += new System.EventHandler(this.buttonPollution_Click);
            // 
            // buttonForecast
            // 
            this.buttonForecast.Activecolor = System.Drawing.Color.Purple;
            this.buttonForecast.BackColor = System.Drawing.Color.Transparent;
            this.buttonForecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonForecast.BorderRadius = 0;
            this.buttonForecast.ButtonText = "Прогноз";
            this.buttonForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForecast.DisabledColor = System.Drawing.Color.Gray;
            this.buttonForecast.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonForecast.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonForecast.Iconimage")));
            this.buttonForecast.Iconimage_right = null;
            this.buttonForecast.Iconimage_right_Selected = null;
            this.buttonForecast.Iconimage_Selected = null;
            this.buttonForecast.IconMarginLeft = 30;
            this.buttonForecast.IconMarginRight = 0;
            this.buttonForecast.IconRightVisible = true;
            this.buttonForecast.IconRightZoom = 0D;
            this.buttonForecast.IconVisible = true;
            this.buttonForecast.IconZoom = 90D;
            this.buttonForecast.IsTab = false;
            this.buttonForecast.Location = new System.Drawing.Point(0, 440);
            this.buttonForecast.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonForecast.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonForecast.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonForecast.selected = false;
            this.buttonForecast.Size = new System.Drawing.Size(350, 66);
            this.buttonForecast.TabIndex = 1;
            this.buttonForecast.Text = "Прогноз";
            this.buttonForecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonForecast.Textcolor = System.Drawing.Color.White;
            this.buttonForecast.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForecast.Click += new System.EventHandler(this.buttonForecast_Click);
            // 
            // panelPanels
            // 
            this.panelPanels.BackColor = System.Drawing.Color.Transparent;
            this.panelPanels.Controls.Add(this.panelCity);
            this.panelPanels.Controls.Add(this.panelPollution);
            this.panelPanels.Controls.Add(this.panelForecast);
            this.panelPanels.Controls.Add(this.panelCountry);
            this.panelPanels.Location = new System.Drawing.Point(278, 72);
            this.panelPanels.Name = "panelPanels";
            this.panelPanels.Size = new System.Drawing.Size(934, 578);
            this.panelPanels.TabIndex = 2;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Purple;
            this.line.Location = new System.Drawing.Point(-3, 140);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(10, 66);
            this.line.TabIndex = 3;
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.panel1);
            this.panelCity.Controls.Add(this.checkComboBox1);
            this.panelCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCity.Location = new System.Drawing.Point(0, 0);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(934, 578);
            this.panelCity.TabIndex = 0;
            // 
            // panelCountry
            // 
            this.panelCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCountry.Location = new System.Drawing.Point(0, 0);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(934, 578);
            this.panelCountry.TabIndex = 1;
            // 
            // panelPollution
            // 
            this.panelPollution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPollution.Location = new System.Drawing.Point(0, 0);
            this.panelPollution.Name = "panelPollution";
            this.panelPollution.Size = new System.Drawing.Size(934, 578);
            this.panelPollution.TabIndex = 1;
            // 
            // panelForecast
            // 
            this.panelForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForecast.Location = new System.Drawing.Point(0, 0);
            this.panelForecast.Name = "panelForecast";
            this.panelForecast.Size = new System.Drawing.Size(934, 578);
            this.panelForecast.TabIndex = 1;
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkComboBox1.FormattingEnabled = true;
            this.checkComboBox1.Location = new System.Drawing.Point(92, 19);
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.Size = new System.Drawing.Size(213, 23);
            this.checkComboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Города:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPeriod);
            this.panel1.Controls.Add(this.comboBoxPollution);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkComboBoxCity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 578);
            this.panel1.TabIndex = 4;
            // 
            // checkComboBoxCity
            // 
            this.checkComboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkComboBoxCity.FormattingEnabled = true;
            this.checkComboBoxCity.Location = new System.Drawing.Point(92, 19);
            this.checkComboBoxCity.Name = "checkComboBoxCity";
            this.checkComboBoxCity.Size = new System.Drawing.Size(213, 23);
            this.checkComboBoxCity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Загрязнение:";
            // 
            // comboBoxPollution
            // 
            this.comboBoxPollution.FormattingEnabled = true;
            this.comboBoxPollution.Location = new System.Drawing.Point(414, 19);
            this.comboBoxPollution.Name = "comboBoxPollution";
            this.comboBoxPollution.Size = new System.Drawing.Size(194, 24);
            this.comboBoxPollution.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Период:";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Неделя",
            "Месяц"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(682, 19);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(194, 24);
            this.comboBoxPeriod.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 662);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panelPanels.ResumeLayout(false);
            this.panelCity.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonForecast;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPollution;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCountry;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCity;
        private System.Windows.Forms.Panel panelPanels;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel panelPollution;
        private System.Windows.Forms.Panel panelForecast;
        private System.Windows.Forms.Panel panelCountry;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.ComboBox comboBoxPollution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CheckComboBox checkComboBoxCity;
        private CheckComboBox checkComboBox1;
    }
}

