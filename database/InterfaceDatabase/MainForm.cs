﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InterfaceDatabase
{
    public partial class MainForm : Form
    {
        string connectionString;
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader reader;
        int codeAlterable;
        bool edit = false;
        bool add = false;

        public MainForm()
        {
            InitializeComponent();

            connectionString = "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=C:\\DB\\DB.mdb";
            connection = new OleDbConnection(connectionString);
            command = connection.CreateCommand();

            this.tabSwitch_Selecting();
        }

        private void tabSwitch_Selecting(object sender = null, TabControlCancelEventArgs e = null)
        {
            string nameNewPage;
            if (e != null)
                nameNewPage = e.TabPage.Name;
            else
                nameNewPage = this.customers.Name;

            if (nameNewPage == this.customers.Name)
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.writeComboBoxNameFirm();
            }
            else if (nameNewPage == this.telecasts.Name)
            {

            }
            else if (nameNewPage == this.agents.Name)
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.writeInComboBoxSurnameAgent();
            }
            else if (nameNewPage == this.advertisement.Name)
            {

            }

        }

        private void writeInComboBoxSurnameAgent()
        {
            this.comboBoxSurnameAgent.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT фамилия " + "FROM агенты ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.comboBoxSurnameAgent.Items.Add(this.reader["фамилия"]);
            }
            reader.Close();
            this.connection.Close();
            this.comboBoxSurnameAgent.Text = Convert.ToString(this.comboBoxSurnameAgent.Items[0]);
        }

        private void comboBoxSurnameAgent_TextChanged(object sender, EventArgs e)
        {
            string selected = "'" + this.comboBoxSurnameAgent.Text + "'";
            this.connection.Open();
            this.command.CommandText = "SELECT код_агента, имя, отчество " + "FROM агенты " + "WHERE фамилия = " + selected;
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBoxNameAgent.Text = Convert.ToString(this.reader["имя"]);
                this.textBoxPatronymic.Text = Convert.ToString(this.reader["отчество"]);
                this.codeAlterable = (int)this.reader["код_агента"];
            }
            reader.Close();
            this.connection.Close();
        }

        private void buttonEditAgent_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxNameAgent.ReadOnly = false;
                this.textBoxPatronymic.ReadOnly = false;
                this.edit = true;
                this.buttonSaveAgent.Enabled = true;
                this.buttonCancelEditAgent.Enabled = true;
            }
            else
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.edit = false;
                this.buttonSaveAgent.Enabled = false;
                this.buttonCancelEditAgent.Enabled = false;
            }
        }


        private void buttonNewAgent_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxSurnameAgent.Text = "";
                this.textBoxNameAgent.ReadOnly = false;
                this.textBoxNameAgent.Text = "";
                this.textBoxPatronymic.ReadOnly = false;
                this.textBoxPatronymic.Text = "";
                this.add = true;
                this.buttonSaveAgent.Enabled = true;
                this.buttonCancelEditAgent.Enabled = true;
            }
            else
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.add = false;
                this.buttonSaveAgent.Enabled = false;
                this.buttonCancelEditAgent.Enabled = false;
            }
        }

        private void buttonSaveAgent_Click(object sender, EventArgs e)
        {
            string newSurname = "'" + this.comboBoxSurnameAgent.Text + "'";
            string newName = "'" + this.textBoxNameAgent.Text + "'";
            string newPatronymic = "'" + this.textBoxPatronymic.Text + "'";
            if (newSurname != "''" && newName != "''")
            {
                this.connection.Open();
                if (this.edit)
                {
                    this.command.CommandText = "UPDATE агенты SET фамилия = " + newSurname +
                                               ", имя = " + newName +
                                               ", отчество = " + newPatronymic +
                                               " WHERE код_агента = " + this.codeAlterable;
                    this.buttonEditAgent_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                }
                else if(this.add)
                {
                    this.command.CommandText = "INSERT INTO агенты (фамилия, имя, отчество) VALUES (" + newSurname +
                                               ", " + newName +
                                               ", " + newPatronymic +")";
                    this.buttonNewAgent_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый агент добавлен");
                }

                this.connection.Close();
                this.writeInComboBoxSurnameAgent();
            }
            else
            {
                MessageBox.Show("фамилия и имя должны быть обязательно");
            }
        }

        private void buttonCancelEditAgent_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditAgent_Click();
            if(this.add)
                this.buttonNewAgent_Click();
            this.writeInComboBoxSurnameAgent();
        }

        private void buttonDeleteAgent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM агенты WHERE (код_агента = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Агент удалён");
                this.connection.Close();
                this.writeInComboBoxSurnameAgent();
            }

        }

        private void writeComboBoxNameFirm()
        {
            this.comboBoxNameFirm.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT название " + "FROM заказчики ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.comboBoxNameFirm.Items.Add(this.reader["название"]);
            }
            reader.Close();
            this.connection.Close();
            this.comboBoxNameFirm.Text = Convert.ToString(this.comboBoxNameFirm.Items[0]);
        }

        private void comboBoxNameFirm_TextChanged(object sender, EventArgs e)
        {
            string selected = "'" + this.comboBoxNameFirm.Text + "'";
            this.connection.Open();
            this.command.CommandText = "SELECT код_заказчика, название, банковские_реквизиты, телефон, контактное_лицо " + 
                                       "FROM заказчики " + 
                                       "WHERE название = " + selected;
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBoxRequisites.Text = Convert.ToString(this.reader["банковские_реквизиты"]);
                this.textBoxTelephone.Text = Convert.ToString(this.reader["телефон"]);
                this.textBoxContact.Text = Convert.ToString(this.reader["контактное_лицо"]);
                this.codeAlterable = (int)this.reader["код_заказчика"];
            }
            reader.Close();
            this.connection.Close();
        }

        private void buttonEditCustomer_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxRequisites.ReadOnly = false;
                this.textBoxTelephone.ReadOnly = false;
                this.textBoxContact.ReadOnly = false;
                this.edit = true;
                this.buttonSaveCustomer.Enabled = true;
                this.buttonCancelEditCustomer.Enabled = true;
            }
            else
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.edit = false;
                this.buttonSaveCustomer.Enabled = false;
                this.buttonCancelEditCustomer.Enabled = false;
            }
        }

        private void buttonNewCustomer_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxNameFirm.Text = "";
                this.textBoxRequisites.ReadOnly = false;
                this.textBoxRequisites.Text = "";
                this.textBoxTelephone.ReadOnly = false;
                this.textBoxTelephone.Text = "";
                this.textBoxContact.ReadOnly = false;
                this.textBoxContact.Text = "";
                this.add = true;
                this.buttonSaveCustomer.Enabled = true;
                this.buttonCancelEditCustomer.Enabled = true;
            }
            else
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.add = false;
                this.buttonSaveCustomer.Enabled = false;
                this.buttonCancelEditCustomer.Enabled = false;
            }
        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            string newName = "'" + this.comboBoxNameFirm.Text + "'";
            string newRequisites = "'" + this.textBoxRequisites.Text + "'";
            string newTelephone = "'" + this.textBoxTelephone.Text + "'";
            string newContact = "'" + this.textBoxContact.Text + "'";
            if (newName != "''" && newRequisites != "''" && newTelephone != "''" && newContact != "''")
            {
                this.connection.Open();
                if (this.edit)
                {
                    this.command.CommandText = "UPDATE заказчики SET название = " + newName +
                                               ", банковские_реквизиты = " + newRequisites +
                                               ", телефон = " + newTelephone +
                                               ", контактное_лицо = " + newContact +
                                               " WHERE код_заказчика = " + this.codeAlterable;
                    this.buttonEditCustomer_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                }
                else if (this.add)
                {
                    this.command.CommandText = "INSERT INTO заказчики (название, банковские_реквизиты, телефон, контактное_лицо) VALUES (" + 
                                               newName +
                                               ", " + newRequisites +
                                               ", " + newTelephone +
                                               ", " + newContact + ")";
                    this.buttonNewCustomer_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый заказчик добавлен");
                }

                this.connection.Close();
                this.writeComboBoxNameFirm();
            }
            else
            {
                MessageBox.Show("все поля должны быть обязательно");
            }
        }

        private void buttonCancelEditCustomer_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditCustomer_Click();
            if (this.add)
                this.buttonNewCustomer_Click();
            this.writeComboBoxNameFirm();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM заказчики WHERE (код_заказчика = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Заказчик удалён");
                this.connection.Close();
                this.writeComboBoxNameFirm();
            }
        }
    }

}
