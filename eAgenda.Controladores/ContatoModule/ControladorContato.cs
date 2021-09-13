using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.ContatoModule
{
    /// <summary>
    /// Controlador de contatos.
    /// </summary>
    public class ControladorContato : Controlador<Contato>
    {
        /// <summary>
        /// Query para inserir contato.
        /// </summary>
        private const string sqlInserirContato =
            @"INSERT INTO TBCONTATO 
	                (
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                ) 
	                VALUES
	                (
                        @NOME, 
                        @EMAIL,
                        @TELEFONE,
		                @CARGO, 
		                @EMPRESA
	                )";

        /// <summary>
        /// Query para editar contato.
        /// </summary>
        private const string sqlEditarContato =
            @"UPDATE TBCONTATO
                    SET
                        [NOME] = @NOME,
		                [EMAIL] = @EMAIL, 
		                [TELEFONE] = @TELEFONE,
                        [CARGO] = @CARGO,
                        [EMPRESA] = @EMPRESA
                    WHERE 
                        ID = @ID";

        /// <summary>
        /// Query para excluir contato.
        /// </summary>
        private const string sqlExcluirContato =
            @"DELETE 
	                FROM
                        TBCONTATO
                    WHERE 
                        ID = @ID";

        /// <summary>
        /// Query para excluir contato.
        /// </summary>
        private const string sqlSelecionarContatoPorId =
            @"SELECT
                        [ID],
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                FROM
                        TBCONTATO
                    WHERE 
                        ID = @ID";

        /// <summary>
        /// Query para selecionar todos os contatos.
        /// </summary>
        private const string sqlSelecionarTodosContatos =
            @"SELECT
                        [ID],
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                FROM
                        TBCONTATO ORDER BY CARGO;";

        /// <summary>
        /// Query para verificar se existe um contato.
        /// </summary>
        private const string sqlExisteContato =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONTATO]
            WHERE 
                [ID] = @ID";

        /// <summary>
        /// Insere um novo contato.
        /// </summary>
        /// <param name="registro">The registro.</param>
        /// <returns>Uma string.</returns>
        public override string InserirNovo(Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirContato, ObtemParametrosContato(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Edita um contato.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <param name="registro">O registro.</param>
        /// <returns>Uma string.</returns>
        public override string Editar(int id, Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarContato, ObtemParametrosContato(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Exclui um contato
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Um booleano.</returns>
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirContato, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se existe um contato
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Um booleano.</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteContato, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona um contato pelo seu ID
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Um Contato.</returns>
        public override Contato SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarContatoPorId, ConverterEmContato, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona todos os contatos.
        /// </summary>
        /// <returns>Uma lista de Contatos.</returns>
        public override List<Contato> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosContatos, ConverterEmContato);
        }

        /// <summary>
        /// Seleciona os contatos agrupados.
        /// </summary>
        /// <param name="campo">O campo.</param>
        /// <returns>Uma lista de GrupoContatos.</returns>
        public List<GrupoContato> SelecionarContatosAgrupados(Func<Contato, string> campo)
        {
            var contatos = Db.GetAll(sqlSelecionarTodosContatos, ConverterEmContato);

            return new AgrupadorContato().Agrupar(contatos, campo);
        }

        /// <summary>
        /// Obtem os parametros de um contato.
        /// </summary>
        /// <param name="contato">The contato.</param>
        /// <returns>A Dictionary.</returns>
        private Dictionary<string, object> ObtemParametrosContato(Contato contato)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", contato.Id);
            parametros.Add("NOME", contato.Nome);
            parametros.Add("EMAIL", contato.Email);
            parametros.Add("TELEFONE", contato.Telefone);
            parametros.Add("CARGO", contato.Cargo);
            parametros.Add("EMPRESA", contato.Empresa);

            return parametros;
        }

        /// <summary>
        /// Converte o resultado da query em um contato.
        /// </summary>
        /// <param name="reader">O DataReader.</param>
        /// <returns>Um Contato.</returns>
        private Contato ConverterEmContato(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string cargo = Convert.ToString(reader["CARGO"]);
            string empresa = Convert.ToString(reader["EMPRESA"]);

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            contato.Id = id;

            return contato;
        }
    }
}
