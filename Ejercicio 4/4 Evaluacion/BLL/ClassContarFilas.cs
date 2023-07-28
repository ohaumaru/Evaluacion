using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetEvaluacionTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassContarFilas
    {
        #region Atributo
        private PROYECTOTableAdapter proyecto;              //Atributo para el llamado del DataTable
        #endregion

        #region Propiedad
        private PROYECTOTableAdapter PROYECTO
        {
            get
            {
                if(proyecto == null)                        //Consulta si el Atributo esta vacio
                    proyecto = new PROYECTOTableAdapter();  //Crea un nuevo TableAdapter si esta vacio
                return proyecto;                            //Devuelve el nuevo TableAdapter
            }
        }
        #endregion

        #region Metodo
        ///<summary>
        ///Lista PROYECTOS de la BD
        ///</summary>
        ///<returns>Devuelve un DataTable</returns>

        public DataTable Proyecto()                         //Se crea el metodo para llamar al DataTable
        {
            DataTable resultado = new DataTable();          //Se crea una variable "resultado" para controlar el DataTable
            resultado = PROYECTO.GetDataListarProyecto();   //Variable igual al SELECT del DataTable
            return resultado;                               //Devuelve el DataTable
        }

        public string InsertarProyecto(string nombreProyecto) //Se crea el meotodo INSERT para la tabla PROYECTO
        {
            string respuesta = ""; //Cadena vacia que almacena la respuesta del procedimiento almacenado insertar
            try
            {
                PROYECTO.SP_InsertarProyecto(nombreProyecto, ref respuesta); //Variable invoca el SP insertar proyecto
            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message; //Variable respuesta almacena el mensaje de error si no se inserta nada en la tabla PROYECTO
            }
            return respuesta; //Variable respuesta devuelve el mensaje de INSERT exitoso a la BD
        }

        public string ModificarProyecto(string nombreProyecto, string nombreNuevo) // Se crea el metodo UPDATE para la tabla PROYECTO
        {
            string respuesta = ""; //Cadena vacia que almacena la respuesta del procedimiento almacenado actualizar
            try
            {
                PROYECTO.SP_ActualizarProyecto(nombreProyecto, nombreNuevo, ref respuesta); //Variable invoca el SP actualizar proyecto
            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message; //Variable respuesta almacena el mensaje de error si no se actualiza nada en la tabla PROYECTO
            }
            return respuesta; //Variable respuesta devuelve el mensaje de UPDATE exitoso en la BD
        }

        public string EliminarProyecto(string nombreProyecto) //Se crea el metodo DELETE para la tabla PROYECTO
        {
            string respuesta = ""; //Variable vacia que almacena la respuesta del procedimiento almacenado eliminar
            try
            {
                PROYECTO.SP_EliminarProyecto(nombreProyecto, ref respuesta); //Variable invoca el SP eliminar proyecto
            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message; //Variable respuesta almacena el mensaje de error si no se elimina nada de la tabla PROYECTO
            }
            return respuesta; //Variable respuesta almacena el mensaje de DELETE existo en la BD
        }
        #endregion
    }
}
