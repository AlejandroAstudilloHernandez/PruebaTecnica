﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaTecnica.BussinessLayer;
using PruebaTecnica.Models;

namespace PruebaTecnica.PresentationLayer
{
    public partial class ABCC : Form
    {
        private readonly Bussiness _business;
        public ABCC(Bussiness bussiness)
        {
            InitializeComponent();
            _business = bussiness;
            btnAlta.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            cbDepartamento.Enabled = false;
            cbDescontinuado.Enabled = false;
            tbArticulo.Enabled= false;
            tbMarca.Enabled= false;
            tbModelo.Enabled=false;
            tbStock.Enabled=false;
            tbCantidad.Enabled=false;
            cbClase.Enabled = false;
            cbFamilia.Enabled = false;
            dtpFechaAlta.Enabled = false;
            dtpFechaBaja.Enabled = false;
            dtpFechaAlta.Text = string.Empty;
            dtpFechaBaja.Text = string.Empty;
            CargarDepartamentos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbSku.Text != null)
            {
                var sku = Convert.ToInt32(tbSku.Text);
                Articulo articulo = new Articulo();
                articulo = _business.ConsultaArticulo(sku);
                if (articulo != null)
                {
                    tbArticulo.Text = articulo.Articulo1;
                    tbMarca.Text = articulo.Marca;
                    tbModelo.Text = articulo.Modelo;
                    cbDepartamento.Text = articulo.Departamento.ToString();
                    cbClase.Text = articulo.Clase.ToString();
                    cbFamilia.Text = articulo.Familia.ToString();
                    tbStock.Text = articulo.Stock.ToString();
                    tbCantidad.Text = articulo.Cantidad.ToString();
                    dtpFechaAlta.Text = articulo.FechaAlta.ToString();
                    dtpFechaBaja.Text = articulo.FechaBaja.ToString();
                    cbDescontinuado.Checked = articulo.Descontinuado;

                    //Habilitar Botones relevantes en caso de que exista Sku
                    cbDepartamento.Enabled = true;
                    cbClase.Enabled = false;
                    cbFamilia.Enabled = false;
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;
                    cbDescontinuado.Enabled = true;
                    tbArticulo.Enabled = true;
                    tbMarca.Enabled = true;
                    tbModelo.Enabled = true;
                    tbStock.Enabled = true;
                    tbCantidad.Enabled = true;
                    //inhabilitar la alta
                    btnAlta.Enabled = false;
                }
                else
                {
                    tbArticulo.Text = string.Empty;
                    tbArticulo.Text = string.Empty;
                    tbMarca.Text = string.Empty;
                    tbModelo.Text = string.Empty;
                    cbDepartamento.Text = string.Empty;
                    cbClase.Text = string.Empty;
                    cbFamilia.Text = string.Empty;
                    tbStock.Text = string.Empty;
                    tbCantidad.Text = string.Empty;
                    dtpFechaAlta.Text = string.Empty;
                    dtpFechaBaja.Text = string.Empty;
                    cbDescontinuado.Checked = false;

                    //Habilitar Alta
                    btnAlta.Enabled = true;
                    //inhabilitar botones no relevantes en caso de que no exista Sku
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cbDepartamento.Enabled = true;
                    cbClase.Enabled = false;
                    cbFamilia.Enabled = false;
                    cbDescontinuado.Enabled = false;
                }
            }
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int sku = Convert.ToInt32(tbSku.Text);
            string articulo1 = tbArticulo.Text;
            string marca = tbMarca.Text;
            string modelo = tbModelo.Text;
            int departamento = Convert.ToInt32(cbDepartamento.Text);
            int clase = Convert.ToInt32(cbClase.Text);
            int familia = Convert.ToInt32(cbFamilia.Text);
            int stock = Convert.ToInt32(tbStock.Text);
            int cantidad = Convert.ToInt32(tbCantidad.Text);

            _business.AltaProducto(sku, articulo1, marca, modelo, departamento, clase, familia, stock, cantidad);

            //Habilitar Botones relevantes en caso de que exista Sku
            cbDepartamento.Enabled = true;
            cbClase.Enabled = false;
            cbFamilia.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            cbDescontinuado.Enabled = true;
            btnAlta.Enabled = false;
            //inhabilitar la alta
            btnAlta.Enabled = false;
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroDepartamento = Convert.ToInt32(cbDepartamento.SelectedItem);

            // Cargar las clases basadas en el departamento seleccionado
            CargarClases(numeroDepartamento);
            cbClase.Enabled = true;
        }

        private void cbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroDepartamento = Convert.ToInt32(cbDepartamento.SelectedItem);
            int numeroClase = Convert.ToInt32(cbClase.SelectedItem);

            CargarFamilias(ObtenerNombreClase(numeroClase, numeroDepartamento));
        }

        private string ObtenerNombreClase(int numeroClase, int numeroDepartamento)
        {
            List<Clase> clases = new List<Clase>();
            clases = _business.ObtenerClases(numeroDepartamento);
            string nombreClase = "";
            foreach (Clase clase in clases)
            {
                if (clase.NumeroClase == numeroClase)
                {
                    nombreClase = clase.NombreClase;
                }
            }
            cbFamilia.Enabled = true;
            return nombreClase;
        }

        private void CargarDepartamentos()
        {
            cbDepartamento.Items.Clear();

            var departamentos = _business.ObtenerDepartamentos();

            foreach (var departamento in departamentos)
            {
                cbDepartamento.Items.Add(departamento.NumeroDepartamento);
            }
        }

        private void CargarClases(int numeroDepartamento)
        {
            cbClase.Items.Clear();

            var clases = _business.ObtenerClases(numeroDepartamento);

            foreach (var clase in clases)
            {
                cbClase.Items.Add(clase.NumeroClase);
            }
        }

        private void CargarFamilias(string nombreClase)
        {
            cbFamilia.Items.Clear();

            var familias = _business.ObtenerFamilias(nombreClase);

            foreach (var familia in familias)
            {
                cbFamilia.Items.Add(familia.NumeroFamilia);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int sku = Convert.ToInt32(tbSku.Text);
            string articulo1 = tbArticulo.Text;
            string marca = tbMarca.Text;
            string modelo = tbModelo.Text;
            int departamento = Convert.ToInt32(cbDepartamento.Text);
            int clase = Convert.ToInt32(cbClase.Text);
            int familia = Convert.ToInt32(cbFamilia.Text);
            int stock = Convert.ToInt32(tbStock.Text);
            int cantidad = Convert.ToInt32(tbCantidad.Text);
            bool descontinuado = cbDescontinuado.Checked;

            // Muestra un cuadro de diálogo de confirmación
            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas actualizar este artículo?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Articulo articulo = new Articulo();
                articulo = _business.CambioProducto(sku, articulo1, marca, modelo, departamento, clase, familia, stock, cantidad, descontinuado);
                tbArticulo.Text = articulo.Articulo1;
                tbMarca.Text = articulo.Marca;
                tbModelo.Text = articulo.Modelo;
                cbDepartamento.Text = articulo.Departamento.ToString();
                cbClase.Text = articulo.Clase.ToString();
                cbFamilia.Text = articulo.Familia.ToString();
                tbStock.Text = articulo.Stock.ToString();
                tbCantidad.Text = articulo.Cantidad.ToString();
                dtpFechaAlta.Text = articulo.FechaAlta.ToString();
                dtpFechaBaja.Text = articulo.FechaBaja.ToString();
                cbDescontinuado.Checked = articulo.Descontinuado;

                //Habilitar Botones relevantes en caso de que exista Sku
                cbDepartamento.Enabled = true;
                cbClase.Enabled = false;
                cbFamilia.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                cbDescontinuado.Enabled = true;
                //inhabilitar la alta
                btnAlta.Enabled = false;

                // Puedes mostrar un mensaje indicando que la actualización fue exitosa
                MessageBox.Show("La actualización se realizó con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error durante la actualización del articulo", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var sku = Convert.ToInt32(tbSku.Text);
            // Muestra un cuadro de diálogo de confirmación
            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                _business.BajaArticulo(sku);
                tbArticulo.Text = string.Empty;
                tbArticulo.Text = string.Empty;
                tbMarca.Text = string.Empty;
                tbModelo.Text = string.Empty;
                cbDepartamento.Text = string.Empty;
                cbClase.Text = string.Empty;
                cbFamilia.Text = string.Empty;
                tbStock.Text = string.Empty;
                tbCantidad.Text = string.Empty;
                dtpFechaAlta.Text = string.Empty;
                dtpFechaBaja.Text = string.Empty;
                cbDescontinuado.Checked = false;                

                // Puedes mostrar un mensaje indicando que la actualización fue exitosa
                MessageBox.Show("La eliminación se realizó con éxito.", "Articulo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error durante la eliminación del articulo", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}