﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade1.Formularios
{
    public partial class FormJunior : Form
    {
        public FormJunior()
        {
            InitializeComponent();
            textBoxSalario.Select();

        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            FormInicial form = new FormInicial();
            form.ShowDialog();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

            textBoxSalario.Clear();
            textBoxMetaIndividual.Clear();
            textBoxVendasIndividuais.Clear();
            textBoxSalarioFinal.Clear();
            textBoxValorComissao.Clear();
            textBoxPercentual.Clear();

            textBoxSalario.Select();


        }

        private void textBoxSalario_KeyDown(object sender, KeyEventArgs e)
        { 

        }

        private void textBoxSalario_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >=Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = textBoxSalario.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;
                
            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSalario.Text = textBoxSalario.Text.Remove(textBoxSalario.Text.Length - 1);
            }
        }

        private void textBoxMetaIndividual_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = textBoxMetaIndividual.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMetaIndividual.Text = textBoxMetaIndividual.Text.Remove(textBoxMetaIndividual.Text.Length - 1);
            }
        }

        private void textBoxVendasIndividuais_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = textBoxVendasIndividuais.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxVendasIndividuais.Text = textBoxVendasIndividuais.Text.Remove(textBoxVendasIndividuais.Text.Length - 1);
            }
        }

        private void textBoxSalarioFinal_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;
            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = false;
            }
            if (e.KeyCode == Keys.Tab) verificar = false;
            if (e.KeyCode == Keys.Back) verificar = false;
            if (verificar == false)
            {
                textBoxSalarioFinal.Text = textBoxSalarioFinal.Text.Remove(textBoxSalarioFinal.Text.Length - 1);
                btNovo.Select();
            }
        }

        private void textBoxValorComissao_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;
            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = false;
            }
            if (e.KeyCode == Keys.Tab) verificar = false;
            if (e.KeyCode == Keys.Back) verificar = false;
            if (verificar == false)
            {

                textBoxValorComissao.Text = textBoxValorComissao.Text.Remove(textBoxValorComissao.Text.Length - 1);
                btNovo.Select();
            }
        }

        private void textBoxPercentual_KeyUp(object sender, KeyEventArgs e)
        {

            bool verificar = false;
            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = false;
            }
            if (e.KeyCode == Keys.Tab) verificar = false;
            if (e.KeyCode == Keys.Back) verificar = false;
            if (verificar == false)
            {

                textBoxPercentual.Text = textBoxPercentual.Text.Remove(textBoxPercentual.Text.Length - 1);
                btNovo.Select();
            }

        }

        private void textBoxSalarioFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double salarioInicial;
            double metaIndi;
            double vendasIndi;

            double salarioFinal;
            double valorComissao;
            double percentual;

            double bonificacao = 0;


            double difeMeta = 0;

            salarioInicial = Convert.ToDouble(textBoxSalario.Text);
            metaIndi = Convert.ToDouble(textBoxMetaIndividual.Text);
            vendasIndi = Convert.ToDouble(textBoxVendasIndividuais.Text);

            // salario 

            double minMeta = metaIndi * 0.65;

            if (vendasIndi > minMeta)
            {
                valorComissao = vendasIndi * 0.04;
                textBoxValorComissao.Text = valorComissao.ToString("C2");

                bonificacao = salarioInicial * 0.02;
                salarioFinal = salarioInicial + valorComissao + bonificacao;

                textBoxSalarioFinal.Text = salarioFinal.ToString("C2");
            }
            else
            {

                valorComissao = 0;
                textBoxValorComissao.Text = valorComissao.ToString("C2");

                bonificacao = salarioInicial * 0.02;
                salarioFinal = salarioInicial + bonificacao;

                textBoxSalarioFinal.Text = salarioFinal.ToString("C2");

            }

            // meta

            if (metaIndi < vendasIndi)
            {
                difeMeta = vendasIndi - metaIndi;
                percentual = 0;
                textBoxPercentual.Text = percentual.ToString();

            }
            else
            {
                difeMeta = metaIndi - vendasIndi;
                double difeporce = difeMeta * 100;
                percentual = difeporce / metaIndi;
                textBoxPercentual.Text = percentual.ToString();

            }
        }
    }
}
