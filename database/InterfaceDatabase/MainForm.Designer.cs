﻿namespace InterfaceDatabase
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSwitch = new System.Windows.Forms.TabControl();
            this.customers = new System.Windows.Forms.TabPage();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNameFirm = new System.Windows.Forms.Label();
            this.telecasts = new System.Windows.Forms.TabPage();
            this.agents = new System.Windows.Forms.TabPage();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelNameAgent = new System.Windows.Forms.Label();
            this.comboBoxSurnameAgent = new System.Windows.Forms.ComboBox();
            this.textBoxNameAgent = new System.Windows.Forms.TextBox();
            this.labelSurnameAgent = new System.Windows.Forms.Label();
            this.advertisement = new System.Windows.Forms.TabPage();
            this.buttonEditAgent = new System.Windows.Forms.Button();
            this.buttonSaveAgent = new System.Windows.Forms.Button();
            this.buttonCancelEditAgent = new System.Windows.Forms.Button();
            this.buttonNewAgent = new System.Windows.Forms.Button();
            this.buttonDeleteAgent = new System.Windows.Forms.Button();
            this.tabSwitch.SuspendLayout();
            this.customers.SuspendLayout();
            this.agents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSwitch
            // 
            this.tabSwitch.Controls.Add(this.customers);
            this.tabSwitch.Controls.Add(this.telecasts);
            this.tabSwitch.Controls.Add(this.agents);
            this.tabSwitch.Controls.Add(this.advertisement);
            this.tabSwitch.Location = new System.Drawing.Point(12, 12);
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.SelectedIndex = 0;
            this.tabSwitch.Size = new System.Drawing.Size(519, 253);
            this.tabSwitch.TabIndex = 0;
            this.tabSwitch.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabSwitch_Selecting);
            // 
            // customers
            // 
            this.customers.Controls.Add(this.label);
            this.customers.Controls.Add(this.comboBox1);
            this.customers.Controls.Add(this.textBox1);
            this.customers.Controls.Add(this.labelNameFirm);
            this.customers.Location = new System.Drawing.Point(4, 22);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(511, 227);
            this.customers.TabIndex = 0;
            this.customers.Text = "заказчики";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(146, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 13);
            this.label.TabIndex = 3;
            this.label.Text = "название фирмы";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelNameFirm
            // 
            this.labelNameFirm.AutoSize = true;
            this.labelNameFirm.Location = new System.Drawing.Point(19, 22);
            this.labelNameFirm.Name = "labelNameFirm";
            this.labelNameFirm.Size = new System.Drawing.Size(94, 13);
            this.labelNameFirm.TabIndex = 0;
            this.labelNameFirm.Text = "название фирмы";
            // 
            // telecasts
            // 
            this.telecasts.Location = new System.Drawing.Point(4, 22);
            this.telecasts.Name = "telecasts";
            this.telecasts.Padding = new System.Windows.Forms.Padding(3);
            this.telecasts.Size = new System.Drawing.Size(511, 227);
            this.telecasts.TabIndex = 1;
            this.telecasts.Text = "передачи";
            this.telecasts.UseVisualStyleBackColor = true;
            // 
            // agents
            // 
            this.agents.Controls.Add(this.buttonDeleteAgent);
            this.agents.Controls.Add(this.buttonNewAgent);
            this.agents.Controls.Add(this.buttonCancelEditAgent);
            this.agents.Controls.Add(this.buttonSaveAgent);
            this.agents.Controls.Add(this.buttonEditAgent);
            this.agents.Controls.Add(this.labelPatronymic);
            this.agents.Controls.Add(this.textBoxPatronymic);
            this.agents.Controls.Add(this.labelNameAgent);
            this.agents.Controls.Add(this.comboBoxSurnameAgent);
            this.agents.Controls.Add(this.textBoxNameAgent);
            this.agents.Controls.Add(this.labelSurnameAgent);
            this.agents.Location = new System.Drawing.Point(4, 22);
            this.agents.Name = "agents";
            this.agents.Size = new System.Drawing.Size(511, 227);
            this.agents.TabIndex = 2;
            this.agents.Text = "агенты";
            this.agents.UseVisualStyleBackColor = true;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(259, 30);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(52, 13);
            this.labelPatronymic.TabIndex = 9;
            this.labelPatronymic.Text = "отчество";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(262, 47);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(106, 20);
            this.textBoxPatronymic.TabIndex = 8;
            // 
            // labelNameAgent
            // 
            this.labelNameAgent.AutoSize = true;
            this.labelNameAgent.Location = new System.Drawing.Point(147, 30);
            this.labelNameAgent.Name = "labelNameAgent";
            this.labelNameAgent.Size = new System.Drawing.Size(27, 13);
            this.labelNameAgent.TabIndex = 7;
            this.labelNameAgent.Text = "имя";
            // 
            // comboBoxSurnameAgent
            // 
            this.comboBoxSurnameAgent.FormattingEnabled = true;
            this.comboBoxSurnameAgent.Location = new System.Drawing.Point(23, 46);
            this.comboBoxSurnameAgent.Name = "comboBoxSurnameAgent";
            this.comboBoxSurnameAgent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSurnameAgent.TabIndex = 6;
            this.comboBoxSurnameAgent.TextChanged += new System.EventHandler(this.comboBoxSurnameAgent_TextChanged);
            // 
            // textBoxNameAgent
            // 
            this.textBoxNameAgent.Location = new System.Drawing.Point(150, 47);
            this.textBoxNameAgent.Name = "textBoxNameAgent";
            this.textBoxNameAgent.Size = new System.Drawing.Size(106, 20);
            this.textBoxNameAgent.TabIndex = 5;
            // 
            // labelSurnameAgent
            // 
            this.labelSurnameAgent.AutoSize = true;
            this.labelSurnameAgent.Location = new System.Drawing.Point(20, 30);
            this.labelSurnameAgent.Name = "labelSurnameAgent";
            this.labelSurnameAgent.Size = new System.Drawing.Size(53, 13);
            this.labelSurnameAgent.TabIndex = 4;
            this.labelSurnameAgent.Text = "фамилия";
            // 
            // advertisement
            // 
            this.advertisement.Location = new System.Drawing.Point(4, 22);
            this.advertisement.Name = "advertisement";
            this.advertisement.Size = new System.Drawing.Size(511, 227);
            this.advertisement.TabIndex = 3;
            this.advertisement.Text = "реклама";
            this.advertisement.UseVisualStyleBackColor = true;
            // 
            // buttonEditAgent
            // 
            this.buttonEditAgent.Location = new System.Drawing.Point(150, 84);
            this.buttonEditAgent.Name = "buttonEditAgent";
            this.buttonEditAgent.Size = new System.Drawing.Size(106, 21);
            this.buttonEditAgent.TabIndex = 10;
            this.buttonEditAgent.Text = "редактировать";
            this.buttonEditAgent.UseVisualStyleBackColor = true;
            this.buttonEditAgent.Click += new System.EventHandler(this.buttonEditAgent_Click);
            // 
            // buttonSaveAgent
            // 
            this.buttonSaveAgent.Enabled = false;
            this.buttonSaveAgent.Location = new System.Drawing.Point(269, 84);
            this.buttonSaveAgent.Name = "buttonSaveAgent";
            this.buttonSaveAgent.Size = new System.Drawing.Size(99, 21);
            this.buttonSaveAgent.TabIndex = 11;
            this.buttonSaveAgent.Text = "сохранить";
            this.buttonSaveAgent.UseVisualStyleBackColor = true;
            this.buttonSaveAgent.Click += new System.EventHandler(this.buttonSaveAgent_Click);
            // 
            // buttonCancelEditAgent
            // 
            this.buttonCancelEditAgent.Enabled = false;
            this.buttonCancelEditAgent.Location = new System.Drawing.Point(271, 112);
            this.buttonCancelEditAgent.Name = "buttonCancelEditAgent";
            this.buttonCancelEditAgent.Size = new System.Drawing.Size(96, 22);
            this.buttonCancelEditAgent.TabIndex = 12;
            this.buttonCancelEditAgent.Text = "отмена";
            this.buttonCancelEditAgent.UseVisualStyleBackColor = true;
            this.buttonCancelEditAgent.Click += new System.EventHandler(this.buttonCancelEditAgent_Click);
            // 
            // buttonNewAgent
            // 
            this.buttonNewAgent.Location = new System.Drawing.Point(150, 112);
            this.buttonNewAgent.Name = "buttonNewAgent";
            this.buttonNewAgent.Size = new System.Drawing.Size(106, 22);
            this.buttonNewAgent.TabIndex = 13;
            this.buttonNewAgent.Text = "добавить";
            this.buttonNewAgent.UseVisualStyleBackColor = true;
            this.buttonNewAgent.Click += new System.EventHandler(this.buttonNewAgent_Click);
            // 
            // buttonDeleteAgent
            // 
            this.buttonDeleteAgent.Location = new System.Drawing.Point(150, 140);
            this.buttonDeleteAgent.Name = "buttonDeleteAgent";
            this.buttonDeleteAgent.Size = new System.Drawing.Size(106, 22);
            this.buttonDeleteAgent.TabIndex = 14;
            this.buttonDeleteAgent.Text = "удалить";
            this.buttonDeleteAgent.UseVisualStyleBackColor = true;
            this.buttonDeleteAgent.Click += new System.EventHandler(this.buttonDeleteAgent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 277);
            this.Controls.Add(this.tabSwitch);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabSwitch.ResumeLayout(false);
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            this.agents.ResumeLayout(false);
            this.agents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSwitch;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage telecasts;
        private System.Windows.Forms.TabPage agents;
        private System.Windows.Forms.TabPage advertisement;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNameFirm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelNameAgent;
        private System.Windows.Forms.ComboBox comboBoxSurnameAgent;
        private System.Windows.Forms.TextBox textBoxNameAgent;
        private System.Windows.Forms.Label labelSurnameAgent;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Button buttonEditAgent;
        private System.Windows.Forms.Button buttonSaveAgent;
        private System.Windows.Forms.Button buttonCancelEditAgent;
        private System.Windows.Forms.Button buttonNewAgent;
        private System.Windows.Forms.Button buttonDeleteAgent;

    }
}
