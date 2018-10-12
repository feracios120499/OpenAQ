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
            this.line = new System.Windows.Forms.Panel();
            this.panelPanels = new System.Windows.Forms.Panel();
            this.panelCity = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxPollution = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPollution = new System.Windows.Forms.Panel();
            this.panelForecast = new System.Windows.Forms.Panel();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.buttonForecast = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPollution = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCountry = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panelPanels.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
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
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(918, 538);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Purple;
            this.line.Location = new System.Drawing.Point(-2, 114);
            this.line.Margin = new System.Windows.Forms.Padding(2);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(8, 54);
            this.line.TabIndex = 3;
            // 
            // panelPanels
            // 
            this.panelPanels.BackColor = System.Drawing.Color.Transparent;
            this.panelPanels.Controls.Add(this.panelCity);
            this.panelPanels.Controls.Add(this.panelPollution);
            this.panelPanels.Controls.Add(this.panelForecast);
            this.panelPanels.Controls.Add(this.panelCountry);
            this.panelPanels.Location = new System.Drawing.Point(208, 58);
            this.panelPanels.Margin = new System.Windows.Forms.Padding(2);
            this.panelPanels.Name = "panelPanels";
            this.panelPanels.Size = new System.Drawing.Size(700, 470);
            this.panelPanels.TabIndex = 2;
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.panel1);
            this.panelCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCity.Location = new System.Drawing.Point(0, 0);
            this.panelCity.Margin = new System.Windows.Forms.Padding(2);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(700, 470);
            this.panelCity.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Controls.Add(this.comboBoxPeriod);
            this.panel1.Controls.Add(this.comboBoxCity);
            this.panel1.Controls.Add(this.comboBoxPollution);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 470);
            this.panel1.TabIndex = 4;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(23, 56);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(657, 339);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Неделя",
            "Месяц"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(512, 15);
            this.comboBoxPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPeriod.TabIndex = 5;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(70, 15);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCity.TabIndex = 5;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxPollution
            // 
            this.comboBoxPollution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPollution.FormattingEnabled = true;
            this.comboBoxPollution.Location = new System.Drawing.Point(310, 15);
            this.comboBoxPollution.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPollution.Name = "comboBoxPollution";
            this.comboBoxPollution.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPollution.TabIndex = 5;
            this.comboBoxPollution.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Период:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Загрязнение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Города:";
            // 
            // panelPollution
            // 
            this.panelPollution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPollution.Location = new System.Drawing.Point(0, 0);
            this.panelPollution.Margin = new System.Windows.Forms.Padding(2);
            this.panelPollution.Name = "panelPollution";
            this.panelPollution.Size = new System.Drawing.Size(700, 470);
            this.panelPollution.TabIndex = 1;
            // 
            // panelForecast
            // 
            this.panelForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForecast.Location = new System.Drawing.Point(0, 0);
            this.panelForecast.Margin = new System.Windows.Forms.Padding(2);
            this.panelForecast.Name = "panelForecast";
            this.panelForecast.Size = new System.Drawing.Size(700, 470);
            this.panelForecast.TabIndex = 1;
            // 
            // panelCountry
            // 
            this.panelCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCountry.Location = new System.Drawing.Point(0, 0);
            this.panelCountry.Margin = new System.Windows.Forms.Padding(2);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(700, 470);
            this.panelCountry.TabIndex = 1;
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
            this.buttonForecast.Location = new System.Drawing.Point(0, 358);
            this.buttonForecast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonForecast.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonForecast.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonForecast.selected = false;
            this.buttonForecast.Size = new System.Drawing.Size(262, 54);
            this.buttonForecast.TabIndex = 1;
            this.buttonForecast.Text = "Прогноз";
            this.buttonForecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonForecast.Textcolor = System.Drawing.Color.White;
            this.buttonForecast.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForecast.Click += new System.EventHandler(this.buttonForecast_Click);
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
            this.buttonPollution.Location = new System.Drawing.Point(0, 276);
            this.buttonPollution.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPollution.Name = "buttonPollution";
            this.buttonPollution.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonPollution.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonPollution.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPollution.selected = false;
            this.buttonPollution.Size = new System.Drawing.Size(262, 54);
            this.buttonPollution.TabIndex = 1;
            this.buttonPollution.Text = "Загрязнители";
            this.buttonPollution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPollution.Textcolor = System.Drawing.Color.White;
            this.buttonPollution.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPollution.Click += new System.EventHandler(this.buttonPollution_Click);
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
            this.buttonCountry.Location = new System.Drawing.Point(0, 195);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCountry.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonCountry.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCountry.selected = false;
            this.buttonCountry.Size = new System.Drawing.Size(262, 54);
            this.buttonCountry.TabIndex = 1;
            this.buttonCountry.Text = "Страны";
            this.buttonCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCountry.Textcolor = System.Drawing.Color.White;
            this.buttonCountry.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
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
            this.buttonCity.Location = new System.Drawing.Point(0, 114);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCity.OnHovercolor = System.Drawing.Color.Purple;
            this.buttonCity.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCity.selected = false;
            this.buttonCity.Size = new System.Drawing.Size(262, 54);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Города";
            this.buttonCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCity.Textcolor = System.Drawing.Color.White;
            this.buttonCity.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(881, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 35);
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 54);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 538);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panelPanels.ResumeLayout(false);
            this.panelCity.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
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
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel2;
    }
}

