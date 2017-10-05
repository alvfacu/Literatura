using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace UI.Desktop
{
    public partial class formFrases : Form
    {
        bool bnd = true;
        DataTable TablaFrases = new DataTable();
        List<Autores> autores = new AutorLogic().GetAll(Program.IdUsuario);
        List<Libros> libros = new LibroLogic().GetAll(Program.IdUsuario);

        public formFrases()
        {
            InitializeComponent();
            this.cmbAutores.Enabled = this.cmbLibros.Enabled = false;
            this.btnEditar.Enabled = false;

            ValorInicial();

            this.cmbAutores.DataSource = new AutorLogic().GetAll(Program.IdUsuario);
            this.cmbAutores.ValueMember = "idAutor";
            this.cmbAutores.DisplayMember = "apynom";
            this.cmbAutores.SelectedIndex = -1;

            this.cmbLibros.DataSource = new LibroLogic().GetAll(Program.IdUsuario);
            this.cmbLibros.ValueMember = "idLibro";
            this.cmbLibros.DisplayMember = "titulo";
            this.cmbLibros.SelectedIndex = -1;
        }

        public formFrases(int idAutor, int idLibro)
        {
            InitializeComponent();
            btnBuscar.Enabled = false;
            btnEditar.Enabled = true;
            btnNO.Enabled = true;
            chk_autor.Enabled = false;
            chk_libro.Enabled = false;
            cmbAutores.Enabled = false;
            cmbLibros.Enabled = false;

            ValorInicial();

            this.cmbAutores.DataSource = new AutorLogic().GetAll(Program.IdUsuario);
            this.cmbAutores.ValueMember = "idAutor";
            this.cmbAutores.DisplayMember = "apynom";
            this.cmbAutores.SelectedIndex = -1;

            this.cmbLibros.DataSource = new LibroLogic().GetAll(Program.IdUsuario);
            this.cmbLibros.ValueMember = "idLibro";
            this.cmbLibros.DisplayMember = "titulo";
            this.cmbLibros.SelectedIndex = -1;

            Autores AutorActual = new AutorLogic().GetOne(idAutor, Program.IdUsuario);
            Libros LibroActual = new LibroLogic().GetOne(idLibro, Program.IdUsuario);

            cmbAutores.SelectedValue = AutorActual.IdAutor;
            cmbLibros.SelectedValue = LibroActual.IdLibro;

            CargarGrilla(AutorActual.IdAutor, LibroActual.IdLibro);
        }

        public void ValorInicial()
        {
            if (!TablaFrases.Columns.Contains("idFrase"))
                TablaFrases.Columns.Add("idFrase", Type.GetType("System.Int32"));
            if (!TablaFrases.Columns.Contains("frase"))
                TablaFrases.Columns.Add("frase", Type.GetType("System.String"));
            if (!TablaFrases.Columns.Contains("idLibro"))
                TablaFrases.Columns.Add("idLibro", Type.GetType("System.Int32"));
            if (!TablaFrases.Columns.Contains("titulo"))
                TablaFrases.Columns.Add("titulo", Type.GetType("System.String"));
            if (!TablaFrases.Columns.Contains("idAutor"))
                TablaFrases.Columns.Add("idAutor", Type.GetType("System.Int32"));
            if (!TablaFrases.Columns.Contains("autor"))
                TablaFrases.Columns.Add("autor", Type.GetType("System.String"));

            dgv_Frases.DataSource = TablaFrases.DefaultView;

            dgv_Frases.Columns["idFrase"].Visible = false;
            dgv_Frases.Columns["idLibro"].Visible = false;
            dgv_Frases.Columns["idAutor"].Visible = false;

            dgv_Frases.Columns["frase"].HeaderText = "Frase";
            dgv_Frases.Columns["frase"].ReadOnly = true;
            dgv_Frases.Columns["frase"].Width = 200;

            dgv_Frases.Columns["titulo"].HeaderText = "Libro";
            dgv_Frases.Columns["titulo"].ReadOnly = true;
            dgv_Frases.Columns["titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_Frases.Columns["autor"].HeaderText = "Autor";
            dgv_Frases.Columns["autor"].ReadOnly = true;
            dgv_Frases.Columns["autor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
        }
        
        private void CargarGrilla(int idAutor, int idLibro)
        {
            TablaFrases.Rows.Clear();

            if (idAutor > -1 && idLibro > -1)
            {
                List<Frases> frases = new FraseLogic().GetAllXLibro(idLibro, Program.IdUsuario);

                if (frases.Count > 0)
                {
                    foreach (Frases fr in frases)
                    {
                        DataRow FilaNueva = TablaFrases.NewRow();
                        FilaNueva["idFrase"] = fr.IdFrase;
                        FilaNueva["titulo"] = "";
                        FilaNueva["autor"] = "";
                        FilaNueva["frase"] = fr.Frase;

                        foreach (Libros li in libros)
                        {
                            if (li.IdLibro == fr.IdLibro)
                            {
                                FilaNueva["titulo"] = li.Titulo;
                                FilaNueva["idLibro"] = li.IdLibro;
                                foreach (Autores au in autores)
                                {
                                    if (au.IdAutor == li.IdAutor)
                                    {
                                        FilaNueva["autor"] = au.ApyNom;
                                        FilaNueva["idAutor"] = au.IdAutor;
                                        break;
                                    }
                                }
                                break;
                            }
                        }                        

                        TablaFrases.Rows.Add(FilaNueva);
                    }
                    btnEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("¡No existen frases cargadas con los parámetros ingresados!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnEditar.Enabled = false;
                }
                    
            }
            else if (idAutor > -1 && idLibro == -1)
            {
                List<Frases> frases = new FraseLogic().GetAllXAutor(idAutor,Program.IdUsuario);

                if (frases.Count > 0)
                {
                    foreach (Frases fr in frases)
                    {
                        DataRow FilaNueva = TablaFrases.NewRow();
                        FilaNueva["idFrase"] = fr.IdFrase;
                        FilaNueva["titulo"] = "";
                        FilaNueva["autor"] = "";
                        FilaNueva["frase"] = fr.Frase;

                        foreach (Libros li in libros)
                        {
                            if (li.IdLibro == fr.IdLibro)
                            {
                                FilaNueva["titulo"] = li.Titulo;
                                FilaNueva["idLibro"] = li.IdLibro;
                                foreach (Autores au in autores)
                                {
                                    if (au.IdAutor == li.IdAutor)
                                    {
                                        FilaNueva["autor"] = au.ApyNom;
                                        FilaNueva["idAutor"] = au.IdAutor;
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        TablaFrases.Rows.Add(FilaNueva);
                    }
                    btnEditar.Enabled = true;

                    if (TablaFrases.Rows.Count == 0)
                    {
                        MessageBox.Show("¡No existen frases cargadas para el Autor seleccionado!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnEditar.Enabled = false;
                    }
                }
                else
                {
                    btnEditar.Enabled = false;
                    MessageBox.Show("¡No existen frases cargadas con los parámetros ingresados!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   
            }
            else if(idAutor==-1 && idLibro>-1)
            {
                List<Frases> frases = new FraseLogic().GetAllXLibro(idLibro, Program.IdUsuario);

                if (frases.Count > 0)
                {
                    foreach (Frases fr in frases)
                    {
                        DataRow FilaNueva = TablaFrases.NewRow();
                        FilaNueva["idFrase"] = fr.IdFrase;
                        FilaNueva["titulo"] = "";
                        FilaNueva["autor"] = "";
                        FilaNueva["frase"] = fr.Frase;

                        foreach (Libros li in libros)
                        {
                            if (li.IdLibro == fr.IdLibro)
                            {
                                FilaNueva["titulo"] = li.Titulo;
                                FilaNueva["idLibro"] = li.IdLibro;
                                foreach (Autores au in autores)
                                {
                                    if (au.IdAutor == li.IdAutor)
                                    {
                                        FilaNueva["autor"] = au.ApyNom;
                                        break;
                                    }   
                                }
                            }
                        }

                        TablaFrases.Rows.Add(FilaNueva);
                    }
                    btnEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("¡No existen frases cargadas para el título seleccionado!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnEditar.Enabled = false;
                }   
            }

            dgv_Frases.Columns["idFrase"].Visible = false;
            dgv_Frases.Columns["idLibro"].Visible = false;
            dgv_Frases.Columns["idAutor"].Visible = false;

            dgv_Frases.DataSource = TablaFrases;
            dgv_Frases.CurrentCell = null;            
        }
        
        private void chk_autor_CheckedChanged(object sender, EventArgs e)
        {      
            if (chk_autor.Checked == true)
            {
                this.cmbAutores.Enabled = true;
                //this.cmbAutores.DataSource = new AutorLogic().GetAll(Program.IdUsuario);
                //this.cmbAutores.DisplayMember = "apynom";
                //this.cmbAutores.ValueMember = "idAutor";
                //this.cmbAutores.SelectedIndex = -1;
            }
            else
            {
                this.cmbAutores.Enabled = false;
                this.cmbAutores.SelectedIndex = -1;
                if(chk_libro.Checked)
                {
                    this.cmbLibros.DataSource = new LibroLogic().GetAll(Program.IdUsuario);
                    this.cmbLibros.ValueMember = "idLibro";
                    this.cmbLibros.DisplayMember = "titulo";
                    this.cmbLibros.SelectedIndex = -1;
                }
            }
        }

        private void chk_libro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_libro.Checked == true)
            {
                this.cmbLibros.Enabled = true;
                if(chk_autor.Checked)
                {
                    this.cmbLibros.DataSource = new LibroLogic().GetAllXAutor(Convert.ToInt32(cmbAutores.SelectedValue),Program.IdUsuario);
                    this.cmbLibros.ValueMember = "idLibro";
                    this.cmbLibros.DisplayMember = "titulo";
                    this.cmbLibros.SelectedIndex = -1;
                }
                else
                {
                    this.cmbLibros.DataSource = new LibroLogic().GetAll(Program.IdUsuario);
                    this.cmbLibros.ValueMember = "idLibro";
                    this.cmbLibros.DisplayMember = "titulo";
                    this.cmbLibros.SelectedIndex = -1;
                }
                
            }
            else
            {
                this.cmbLibros.Enabled = false;
                this.cmbLibros.SelectedIndex = -1;
            }
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            if(dgv_Frases.CurrentRow != null && Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idFrase"].Value)>-1)
            {
                int ID = Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idFrase"].Value);
                Frase fr = new Frase(ID, Entidades.Entidades.States.Modified);
                fr.ShowDialog();
                fr.Close();
                CargarGrilla(Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idAutor"].Value), Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idLibro"].Value));
            }
        }
        
        private void dgv_Frases_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Frases.CurrentRow != null && !(this.dgv_Frases.SelectedRows == null))
            {
                int ID = Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idFrase"].Value);
                Frase fr = new Frase(ID, Entidades.Entidades.States.Modified);
                fr.ShowDialog();
                fr.Close();
                CargarGrilla(Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idAutor"].Value), Convert.ToInt32(dgv_Frases.CurrentRow.Cells["idLibro"].Value)); ;
            }
        }
        
        private void cmbAutores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bnd)
            {
                this.cmbLibros.DataSource = new LibroLogic().GetAllXAutor(Convert.ToInt32(cmbAutores.SelectedValue), Program.IdUsuario);
                this.cmbLibros.ValueMember = "idLibro";
                this.cmbLibros.DisplayMember = "titulo";
                this.cmbLibros.SelectedIndex = -1;
            }
            else
            {
                bnd = true;
            }
        }

        private void cmbLibros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Libros lib in libros)
            {
                if (lib.IdLibro == Convert.ToInt32(cmbLibros.SelectedValue))
                {
                    bnd = false;
                    this.cmbAutores.SelectedValue = lib.IdAutor;
                }
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                int idAutor = -1;
                int idLibro = -1;

                if (Convert.ToInt32(cmbAutores.SelectedIndex) > -1)
                    idAutor = Convert.ToInt32(cmbAutores.SelectedValue);

                if (Convert.ToInt32(cmbLibros.SelectedIndex) > -1)
                    idLibro = Convert.ToInt32(cmbLibros.SelectedValue);

                CargarGrilla(idAutor, idLibro);
            }
        }

        private bool Validar()
        {
            if (chk_autor.Checked==false && chk_libro.Checked==false)            
            {
                MessageBox.Show("¡Seleccione algún filtro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            if (cmbAutores.SelectedIndex == -1 && cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("¡Seleccione algún filtro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
