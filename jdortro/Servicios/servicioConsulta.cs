using DAL.Modelos;

namespace jdortro.Servicios
{
    /// <summary>
    /// Interfaz de metodo que realizan consultas sobre la base de datos.
    /// </summary>
    public interface servicioConsulta
    {
        /// <summary>
        /// Interfaz del metodo muestra el menu y nos permite elegir una opcion, se repite hasta pulsar la opcion 0
        /// </summary>
        /// <returns></returns>
        public int Menu();

        /// <summary>
        /// Interfaz del metodo que inserta en la base de datos un nuevo elemento
        /// </summary>
        /// <param name="nuevoElemento"></param>
        public void añadirElemento(Elemento nuevoElemento);
        /// <summary>
        /// Interfaz del metodo para cargar el codigo elemento concatenando Elem-nombreElemento
        /// </summary>
        /// <param name="elen"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public string cargarCodigoElemento(string elen, string nombre);
        /// <summary>
        /// Interfaz del metodo que devuelve un listado de todos los datos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Elemento> listarElementos();

        /// <summary>
        /// Interfaz del metodo que añade una reserva a la base de datos y se añade automaticamente en la tabla intermetida
        /// </summary>
        /// <param name="nuevaReserva"></param>
        public void añadirReserva(Reserva nuevaReserva, int idElemento);
    }
}
