using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_Json
{
    internal class NotasAlumno
    {
        string nombreAlumno;
        List<int> notas;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public List<int> Notas { get => notas; set => notas = value; }
    }
}
