using eAgenda.Controladores.Shared;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.TarefaModule
{
    /// <summary>
    /// Controlador de tarefas.
    /// </summary>
    public class ControladorTarefa : Controlador<Tarefa>
    {
        #region Queries
        /// <summary>
        /// Query para inserir tarefa.
        /// </summary>
        private const string sqlInserirTarefa =
            @"INSERT INTO [TBTAREFA]
                (
                    [TITULO],       
                    [PRIORIDADE],             
                    [DATACRIACAO],                    
                    [DATACONCLUSAO], 
                    [PERCENTUAL]            
                )
            VALUES
                (
                    @TITULO,
                    @PRIORIDADE,
                    @DATACRIACAO,
                    @DATACONCLUSAO,
                    @PERCENTUAL
                )";

        /// <summary>
        /// Query para editar tarefa.
        /// </summary>
        private const string sqlEditarTarefa =
            @" UPDATE [TBTAREFA]
                SET 
                    [PRIORIDADE] = @PRIORIDADE, 
                    [TITULO] = @TITULO, 
                    [DATACRIACAO] = @DATACRIACAO, 
                    [DATACONCLUSAO] = @DATACONCLUSAO,
                    [PERCENTUAL] = @PERCENTUAL

                WHERE [ID] = @ID";

        /// <summary>
        /// Query para excluir tarefa.
        /// </summary>
        private const string sqlExcluirTarefa =
            @"DELETE FROM [TBTAREFA] 
                WHERE [ID] = @ID";

        /// <summary>
        /// Query para selecionar todas as tarefas.
        /// </summary>
        private const string sqlSelecionarTodasTarefas =
            @"SELECT 
                [ID],       
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            ORDER BY 
                T.PRIORIDADE DESC";

        /// <summary>
        /// Query para selecionar tarefa pelo seu ID.
        /// </summary>
        private const string sqlSelecionarTarefaPorId =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],        
                [DATACRIACAO],       
                [DATACONCLUSAO],
                [PERCENTUAL]
             FROM
                [TBTAREFA]
             WHERE 
                [ID] = @ID";

        /// <summary>
        /// Query para selecionar todas as tarefas concluidas.
        /// </summary>
        private const string sqlSelecionarTodasTarefasConcluidas =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            WHERE 
                T.[PERCENTUAL] = 100
            ORDER BY 
                T.[PRIORIDADE] DESC";

        /// <summary>
        /// Query para selecionar todas as tarefas pendentes.
        /// </summary>
        private const string sqlSelecionarTodasTarefasPendentes =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            WHERE 
                T.[PERCENTUAL] <> 100
            ORDER BY 
                T.[PRIORIDADE] DESC";

        /// <summary>
        /// Query para verificar se existe uma tarefa.
        /// </summary>
        private const string sqlExisteTarefa =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBTAREFA]
            WHERE 
                [ID] = @ID";

        #endregion


        /// <summary>
        /// Insere uma nova tarefa
        /// </summary>
        /// <param name="registro">O registro.</param>
        /// <returns>Uma tarefa.</returns>
        public override string InserirNovo(Tarefa registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirTarefa, ObtemParametrosTarefa(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Edita uma tarefa.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <param name="registro">O registro.</param>
        /// <returns>Uma string.</returns>
        public override string Editar(int id, Tarefa registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarTarefa, ObtemParametrosTarefa(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Exclui uma tarefa.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Um booleano.</returns>
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirTarefa, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Busca uma tarefa.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Um booleano.</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteTarefa, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona todas as tarefas.
        /// </summary>
        /// <returns>Uma lista de Tarefas.</returns>
        public override List<Tarefa> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasTarefas, ConverterEmTarefa);
        }

        /// <summary>
        /// Seleciona uma tarefa pelo seu ID.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns>Uma Tarefa.</returns>
        public override Tarefa SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTarefaPorId, ConverterEmTarefa, AdicionarParametro("ID", id));
        }


        /// <summary>
        /// Atualiza o percentual de conclusão de uma tarefa.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <param name="novoPercentual">O novo percentual.</param>
        public void AtualizarPercentual(int id, int novoPercentual)
        {
            Tarefa tarefa = SelecionarPorId(id);

            AtualizarPercentual(tarefa, novoPercentual);
        }

        /// <summary>
        /// Atualiza o percentual de conclusão de uma tarefa.
        /// </summary>
        /// <param name="tarefa">A tarefa.</param>
        /// <param name="novoPercentual">O novo percentual.</param>
        public void AtualizarPercentual(Tarefa tarefa, int novoPercentual)
        {
            tarefa.AtualizarPercentual(novoPercentual, DateTime.Today);

            Editar(tarefa.Id, tarefa);
        }

        /// <summary>
        /// Seleciona todas as tarefas concluidas.
        /// </summary>
        /// <returns>Uma lista de Tarefas.</returns>
        public List<Tarefa> SelecionarTodasTarefasConcluidas()
        {
            return Db.GetAll(sqlSelecionarTodasTarefasConcluidas, ConverterEmTarefa);
        }

        /// <summary>
        /// Seleciona todas as tarefas pendentes.
        /// </summary>
        /// <returns>Uma lista de Tarefas.</returns>
        public List<Tarefa> SelecionarTodasTarefasPendentes()
        {
            return Db.GetAll(sqlSelecionarTodasTarefasPendentes, ConverterEmTarefa);
        }

        /// <summary>
        /// Converte o resultado da query em uma tarefa.
        /// </summary>
        /// <param name="reader">O DataReader.</param>
        /// <returns>Uma Tarefa.</returns>
        private Tarefa ConverterEmTarefa(IDataReader reader)
        {
            var titulo = Convert.ToString(reader["TITULO"]);
            var prioridade = Convert.ToInt32(reader["PRIORIDADE"]);
            var dataCriacao = Convert.ToDateTime(reader["DATACRIACAO"]);
            int percentual = Convert.ToInt32(reader["PERCENTUAL"]);

            Tarefa tarefa = new Tarefa(titulo, dataCriacao, (PrioridadeEnum)prioridade);

            DateTime dataConclusao = DateTime.MinValue;

            if (reader["DATACONCLUSAO"] != DBNull.Value)            
                dataConclusao = Convert.ToDateTime(reader["DATACONCLUSAO"]);            

            tarefa.Id = Convert.ToInt32(reader["ID"]);                            
            tarefa.AtualizarPercentual(percentual, dataConclusao);

            return tarefa;
        }

        /// <summary>
        /// Obtem os parametros de uma tarefa.
        /// </summary>
        /// <param name="tarefa">A tarefa.</param>
        /// <returns>Um Dicionário.</returns>
        private Dictionary<string, object> ObtemParametrosTarefa(Tarefa tarefa)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", tarefa.Id);
            parametros.Add("TITULO", tarefa.Titulo);
            parametros.Add("PRIORIDADE", tarefa.Prioridade.Chave);
            parametros.Add("DATACRIACAO", tarefa.DataCriacao);
            parametros.Add("DATACONCLUSAO", tarefa.DataConclusao);
            parametros.Add("PERCENTUAL", tarefa.Percentual);

            return parametros;
        }
    }
}