using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace whyNot
{
    public partial class Form1 : Form
    {
        List<Alumno> lstAlumnos = new List<Alumno>();
        List<Beca> lstBecas = new List<Beca>();

        public Form1()
        {
            InitializeComponent();
        }

        public void dataGridPopulate(DataGridView dtgv, object _lst)
        {
            dtgv.DataSource = null;
            dtgv.DataSource = _lst;
        }

        public decimal CuotaAPagar (int _CantCuota, Alumno auxAlum)
        {
            auxAlum._cuota -= auxAlum.beneficio();

            auxAlum._saldo = auxAlum._cuota;

            return ((auxAlum._cuota) /_CantCuota);

        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno _alumno = null;

                if (rbIngresante.Checked)
                {
                    _alumno = new Alumno();
                }
                if (rbGrado.Checked)
                {
                    _alumno = new Grado();
                }
                if (rbPosgrado.Checked)
                {
                    _alumno = new Posgrado();
                }

                string DNI = Interaction.InputBox("Ingresar DNI :", "DNI");
                if (!Information.IsNumeric(DNI))
                    throw new Exception($"{DNI} is not in the right format...\nMust be numeric");

                string Legajo = Interaction.InputBox("Ingresar Legajo :", "Legajo");
                if (!Information.IsNumeric(Legajo))
                    throw new Exception($"{Legajo} is not in the right format...\nMust be numeric");

                foreach (Alumno x in lstAlumnos)
                {
                    if (x.Legajo.ToString() == Legajo)
                        throw new Exception($"{x.Legajo} ya está asignado a un alumno...");
                }

                string Nombre = Interaction.InputBox("Ingresar Nombre :", "Nombre");
                string Apellido = Interaction.InputBox("Ingresar Apellido :", "Apellido");

                _alumno.Nombre = Nombre;
                _alumno.Apellido = Apellido;
                _alumno.DNI = Int32.Parse(DNI);
                _alumno.Legajo = Int32.Parse(Legajo);

                lstAlumnos.Add(_alumno);

                dataGridPopulate(dtgvAlumno, lstAlumnos);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK); }
        }

        private void btnModificarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAlumnos.Count == 0)
                    throw new Exception("No Hay Alumnos para modificar...\nPrimero agregué Alumno(s)");

                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;

                lstAlumnos.Remove(auxAlumno);

                string DNI = Interaction.InputBox("Ingresar DNI :", "DNI", auxAlumno.DNI.ToString());
                if (!Information.IsNumeric(DNI))
                    throw new Exception($"{DNI} is not in the right format...\nMust be numeric");

                string Legajo = Interaction.InputBox("Ingresar Legajo :", "Legajo", auxAlumno.Legajo.ToString());
                if (!Information.IsNumeric(Legajo))
                    throw new Exception($"{Legajo} is not in the right format...\nMust be numeric");

                foreach (Alumno x in lstAlumnos)
                {
                    if (x.Legajo.ToString() == Legajo)
                        throw new Exception($"{x.Legajo} ya está asignado a un alumno...");
                }

                string Nombre = Interaction.InputBox("Ingresar Nombre :", "Nombre", auxAlumno.Nombre);
                string Apellido = Interaction.InputBox("Ingresar Apellido :", "Apellido", auxAlumno.Apellido);

                auxAlumno.Nombre = Nombre;
                auxAlumno.Apellido = Apellido;
                auxAlumno.DNI = Int32.Parse(DNI);
                auxAlumno.Legajo = Int32.Parse(Legajo);

                lstAlumnos.Add(auxAlumno);

                dataGridPopulate(dtgvAlumno, lstAlumnos);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK); }
        }

        private void btnEliminarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAlumnos.Count == 0)
                    throw new Exception("No Hay Alumnos para Eliminar...\nPrimero agregué Alumno(s)");

                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;

                lstAlumnos.Remove(auxAlumno);

                dataGridPopulate(dtgvAlumno, lstAlumnos);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK); }
        }

        private void btnAgregarBecas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAlumnos.Count == 0)
                    throw new Exception("No Hay Alumnos para Asignar Beca(s)...\nPrimero agregué Alumno(s)");

                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;

                Regex rgx = new Regex(@"^[0-9]{4}[A-Z]{2}");

                string codigoBeca = Interaction.InputBox("Ingresar código con Formato NNNNLL :\nN => numero \nL => Letra", "Código");

                if (!rgx.IsMatch(codigoBeca))
                    throw new Exception($"{codigoBeca} no está en el formato correcto...");

                foreach (Beca auxBecx in lstBecas)
                {
                    if (auxBecx.Código == codigoBeca)
                        throw new Exception($"{codigoBeca} ya está asignado a un alumno...");
                }

                string importe = Interaction.InputBox("Ingresar Importe en pesos argentinos.", "Importe");

                if (!Information.IsNumeric(importe))
                    throw new Exception($"{importe} tiene qué ser númerico...");

                if (decimal.Parse(importe) > auxAlumno._cuota)
                    throw new Exception($"El importe {importe} tiene qué ser menor qué la cuota {auxAlumno._cuota}");

                Beca _beca = new Beca(codigoBeca, DateTime.Today, decimal.Parse(importe));

                auxAlumno.agregarBeca(_beca);

                lstBecas.Add(_beca);

                dataGridPopulate(dtgvBecas, lstBecas);

                dataGridPopulate(dtgvBecasAlumno, auxAlumno.retornarBecas());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK); }
        }

        private void btnEliminarBecas_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstAlumnos.Count == 0)
                    throw new Exception("No Hay Alumnos para Eliminar Beca(s)...\nPrimero agregué Alumno(s)");

                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;

                if (auxAlumno.retornarBecas().Count == 0)
                    throw new Exception($"{auxAlumno.Apellido} {auxAlumno.Nombre} no tiene Becas asignadas");

                Beca auxBeca = (Beca)dtgvBecasAlumno.CurrentRow.DataBoundItem;

                auxAlumno.removerBeca(auxBeca);
                lstBecas.Remove(auxBeca);

                dataGridPopulate(dtgvBecas, lstBecas);

                dataGridPopulate(dtgvBecasAlumno, auxAlumno.retornarBecas());


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK); }
        }



        private void dtgvAlumno_SelectionChanged(object sender, EventArgs e)
        {
            if (lstAlumnos.Count == 0)
            {
                this.labelBecasAlumno.Text = "Becas - Alumno :";
                this.groupBox4.Text = "Operaciones - Pagar";
                this.rb3XCuota.Text = "3 X Cuota";
                this.rb2XCuota.Text = "2 X Cuota";
                this.rb1xCuota.Text = "1 X Cuota";
            }
            else
            {
                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;
                labelBecasAlumno.Text = $"Becas - {auxAlumno.Apellido}, {auxAlumno.Nombre} :";

                if (auxAlumno.retornarBecas().Count == 0)
                {
                    dataGridPopulate(dtgvBecasAlumno, null);
                }
                else 
                {
                    dataGridPopulate(dtgvBecasAlumno, auxAlumno.retornarBecas());
                }

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantCuota = 0;
                Decimal _cuotaAPagar;
                if (lstAlumnos.Count == 0)
                    throw new Exception("No hay alumnos!!!\nPrimero agregué alumnos!!!");

                if (rb1xCuota.Checked == true)
                    cantCuota = 1;
                if (rb2XCuota.Checked == true)
                    cantCuota = 2;
                if (rb3XCuota.Checked == true)
                    cantCuota = 3;

                Alumno auxAlumno = (Alumno)dtgvAlumno.CurrentRow.DataBoundItem;

                _cuotaAPagar = CuotaAPagar(cantCuota, auxAlumno);

                if (auxAlumno._saldo == 0)
                    throw new Exception($"{auxAlumno.Apellido} {auxAlumno.Nombre}, {auxAlumno.DNI}\n\nCuotas al día...");

                

                DialogResult dr = MessageBox.Show($"{auxAlumno.Apellido} {auxAlumno.Nombre}, {auxAlumno.DNI}\n\nCuota a pagar :{_cuotaAPagar}\nQuiere seguir con la operción?", "Cuotas", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                    throw new Exception("Operación cancelada...");

                if (auxAlumno._saldo < _cuotaAPagar)
                {
                    Decimal auxSaldo = (auxAlumno._saldo - _cuotaAPagar) * (-1);
                    auxAlumno._saldo = 0;
                }
                
                    auxAlumno._saldo -= _cuotaAPagar;

                    MessageBox.Show($"Pagado : {_cuotaAPagar}\nSaldo : {auxAlumno._saldo}\nOperción completada!!!", "Operción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }
    }
}
