using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appProyectoBDD.AccesoDatos;
using System.Data;

namespace appProyectoBDD.Logica
{
    internal class Biblioteca
    {
        //Creo un objeto de la clase datos para manipular en esta clase
        Datos misDatos = new Datos();

        public int ingresarBiblioteca(int nitBib, string nomBib)
        {
            int resultado;
            string consulta;
            consulta = "insert into BIBLIOTECA(bibNit, bibNombre) values(" + nitBib + ",'" + nomBib + "')";

            //Envio el resultado
            resultado = misDatos.ejecutarDML(consulta);
            return resultado;


        }
        public int ingresarLibro(int codLib,  string libTitulo, int numPag, string libCategoria)
        {
            int resultado;
            string consulta;
            consulta = "insert into LIBRO(libCod, libTitulo,LibNumPag,libCategoria) values(" + codLib + ",'" + libTitulo + "'," + numPag + ",'"  + libCategoria +"')";

            //Envio el resultado
            resultado = misDatos.ejecutarDML(consulta);
            return resultado;

        }

        public int ingresarRegistro(int nitBib, int codLib, string fechaIn, string fechaFin )
        {
            int resultado;
            string consulta;
            consulta = "insert into REGISTRA(bibNit,libcod,regfechain,regfechafin ) values(" + nitBib +"," + codLib + ",'" + fechaIn + "','" + fechaFin + "')";

            //Envio el resultado
            resultado = misDatos.ejecutarDML(consulta);
            return resultado;


        }

        public DataSet consultarLibrosAventura()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select COUNT(libcod) from libro where libcategoria like 'Aventura' ";
            //Envio la consulta a la capa de acceso a datos para ejecutarla 
            miDS = misDatos.ejecutarSELECT(consulta);
            return miDS;
           
        }

        public DataSet consultarNitYFecha(int nitBiblioteca , string fechaFinConsulta)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "SELECT bibNombre , libro.libcod , libtitulo , libcategoria , registra.regfechafin " +
                       "from biblioteca inner join registra on biblioteca.bibnit = registra.bibnit inner join libro on registra.libcod = libro.libcod " +
                       "where biblioteca.bibnit ="+ nitBiblioteca + "and registra.regfechain =" + "'" + fechaFinConsulta + "'";

            //Envio el resultado
            miDS = misDatos.ejecutarSELECT(consulta);
            return miDS;


        }


    }
}
