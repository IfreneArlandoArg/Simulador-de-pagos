using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whyNot
{
    public class Alumno
    {
        public List<Beca> becas = new List<Beca>();

        public decimal _cuota = 150000.89M;

        public decimal _saldo = 150000.89M;
        public int Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int DNI { get; set; }


        public void agregarBeca(Beca _beca)
        {
            if (becas.Count == 2)
                throw new Exception($"{this.Apellido} ya tiene 2 becas asignadas\nEl maximo es de 2.");

            becas.Add(_beca);
        }

        public void removerBeca(Beca _beca)
        {
            
            becas.Remove(_beca);
        }

        public List<Beca> retornarBecas()
        {
            return becas;
        }

        public virtual decimal beneficio () 
        {
            decimal totalImporteBeca = 0;
            decimal ImporteTotal = 0;

            if(becas.Count != 0)
            foreach (Beca bec in becas)
            {
                totalImporteBeca += bec.Importe;
            }

            ImporteTotal = _cuota + totalImporteBeca;

            return (ImporteTotal * (0.1M));
            
        }


    }

    public class Grado : Alumno
    {
        
        public override decimal beneficio()
        {
            decimal totalImporteBeca = 0;
            decimal ImporteTotal = 0;

            if (becas.Count != 0)
            foreach (Beca bec in becas)
            {
                totalImporteBeca += bec.Importe;
            }

            ImporteTotal = _cuota + totalImporteBeca;

            return (ImporteTotal * (0.05M));

        }
    }

    public class Posgrado : Alumno
    {
        public override decimal beneficio()
        {
            decimal totalImporteBeca = 0;
            decimal ImporteTotal = 0;

            if (becas.Count != 0)
            foreach (Beca bec in becas)
            {
                totalImporteBeca += bec.Importe;
            }

            ImporteTotal = _cuota + totalImporteBeca;

            return (ImporteTotal * (0.01M));

        }
    }

}
