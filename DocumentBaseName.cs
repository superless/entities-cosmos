namespace trifenix.connect.entities.cosmos
{
    /// <summary>
    /// Hereda de documentBase, para agregar un nombre al elemento.
    /// </summary>
    public abstract class DocumentBaseName : DocumentBase {
        
        /// <summary>
        /// Nombre del elemento
        /// </summary>        
        public abstract string Name { get; set; }

    }

}