using eAgenda.Dominio.Shared;
using System.Collections.Generic;

namespace eAgenda.Controladores.Shared
{
    /// <summary>
    /// Controlador abstrato.
    /// </summary>
    public abstract class Controlador<T> where T : EntidadeBase
    {
        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract string InserirNovo(T registro);
        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract string Editar(int id, T registro);
        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract bool Existe(int id);
        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract bool Excluir(int id);
        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract List<T> SelecionarTodos();

        /// <summary>
        /// Método abstrato.
        /// </summary>
        public abstract T SelecionarPorId(int id);

        /// <summary>
        /// Adiciona um parametro nas queries.
        /// </summary>
        /// <param name="campo">O campo.</param>
        /// <param name="valor">O valor.</param>
        /// <returns>Um Dicionário.</returns>
        protected Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }

    }
}