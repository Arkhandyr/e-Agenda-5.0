using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.CompromissoModule
{
    /// <summary>
    /// Controlador de compromissos.
    /// </summary>
    public class ControladorCompromisso : Controlador<Compromisso>
    {
        #region Queries
        /// <summary>
        /// Query para inserir compromisso.
        /// </summary>
        private const string sqlInserirCompromisso =
            @"INSERT INTO [TBCOMPROMISSO]
                (
                    [LOCAL],       
                    [DATA], 
                    [ASSUNTO],
                    [HORAINICIO],                    
                    [HORATERMINO],                                                           
                    [ID_CONTATO],
                    [LINK]            
                )
            VALUES
                (
                    @LOCAL,
                    @DATA,
                    @ASSUNTO,
                    @HORAINICIO,
                    @HORATERMINO,
                    @ID_CONTATO,
                    @LINK
                )";

        /// <summary>
        /// Query para editar compromisso.
        /// </summary>
        private const string sqlEditarCompromisso =
            @" UPDATE [TBCOMPROMISSO]
                SET 
                    [LOCAL] = @LOCAL, 
                    [DATA] = @DATA, 
                    [ASSUNTO] = @ASSUNTO,
                    [HORAINICIO] = @HORAINICIO, 
                    [HORATERMINO] = @HORATERMINO,
                    [ID_CONTATO] =@ID_CONTATO,
                    [LINK] = @LINK

                WHERE [ID] = @ID";

        /// <summary>
        /// Query para excluir compromisso.
        /// </summary>
        private const string sqlExcluirCompromisso =
            @"DELETE FROM [TBCOMPROMISSO] 
                WHERE [ID] = @ID";

        /// <summary>
        /// Query para selecionar todos os compromissos.
        /// </summary>
        private const string sqlSelecionarTodosCompromissos =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO";

        /// <summary>
        /// Query para selecionar um compromisso pelo seu ID.
        /// </summary>
        private const string sqlSelecionarCompromissoPorId =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[ID] = @ID";

        /// <summary>
        /// Query para selecionar todos os compromissos passados.
        /// </summary>
        private const string sqlSelecionarTodosCompromissosPassados =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[DATA] <= @DATA";

        /// <summary>
        /// Query para selecionar todos os compromissos futuros.
        /// </summary>
        private const string sqlSelecionarTodosCompromissosFuturos =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[DATA] BETWEEN @DATAINICIO AND @DATAFIM";

        /// <summary>
        /// Query para procurar um compromisso.
        /// </summary>
        private const string sqlExisteCompromisso =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCOMPROMISSO]
            WHERE 
                [ID] = @ID";

        /// <summary>
        /// Query para verificar se um horário já está ocupado.
        /// </summary>
        private const string sqlVerificarHorarioOcupado =
            @"SELECT
	            COUNT(*)
            FROM 
	            TBCOMPROMISSO
            WHERE 
                [DATA] = @DATA 
            AND 
                @HORA_INICIO_DESEJADO BETWEEN HORAINICIO AND HORATERMINO 
            OR 
                @HORA_TERMINO_DESEJADO BETWEEN HORAINICIO AND HORATERMINO";

        #endregion

        /// <summary>
        /// Insere um novo compromisso.
        /// </summary>
        /// <param name="registro">O registro.</param>
        /// <returns>Uma string.</returns>
        public override string InserirNovo(Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                bool horarioOcupado = VerificarHorarioOcupado(registro.Data, registro.HoraInicio, registro.HoraTermino);

                if (horarioOcupado)
                    resultadoValidacao = "Nesta data e horário já tem um compromisso agendado";
                else
                    registro.Id = Db.Insert(sqlInserirCompromisso, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Edita um compromisso.
        /// </summary>
        /// <param name="id">O ID.</param>
        /// <param name="registro">O registro.</param>
        /// <returns>Uma string.</returns>
        public override string Editar(int id, Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCompromisso, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Exclui um compromisso.
        /// </summary>
        /// <param name="id">O ID.</param>
        /// <returns>Um booleano</returns>
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCompromisso, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se um compromisso existe.
        /// </summary>
        /// <param name="id">O ID.</param>
        /// <returns>Um booleano.</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCompromisso, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona um compromisso pelo seu ID.
        /// </summary>
        /// <param name="id">O ID.</param>
        /// <returns>Um Compromisso.</returns>
        public override Compromisso SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCompromissoPorId, ConverterEmCompromisso, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona todos os compromissos.
        /// </summary>
        /// <returns>Uma lista de Compromissos.</returns>
        public override List<Compromisso> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCompromissos, ConverterEmCompromisso);
        }

        /// <summary>
        /// Seleciona os compromissos futuros.
        /// </summary>
        /// <param name="dataInicio">A data de inicio.</param>
        /// <param name="dataFim">A data final.</param>
        /// <returns>Uma lista de Compromissos.</returns>
        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFim)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("DATAINICIO", dataInicio);
            parametros.Add("DATAFIM", dataFim);

            return Db.GetAll(sqlSelecionarTodosCompromissosFuturos, ConverterEmCompromisso, parametros);
        }

        /// <summary>
        /// Seleciona os compromissos passados.
        /// </summary>
        /// <param name="data">A data.</param>
        /// <returns>Uma lista de Compromissos.</returns>
        public List<Compromisso> SelecionarCompromissosPassados(DateTime data)
        {
            return Db.GetAll(sqlSelecionarTodosCompromissosPassados, ConverterEmCompromisso, AdicionarParametro("DATA", data));
        }

        /// <summary>
        /// Verifica se o horário está ocupado.
        /// https://stackoverflow.com/questions/8503825/what-is-the-correct-sql-type-to-store-a-net-timespan-with-values-240000
        /// </summary>
        /// <param name="data">A data.</param>
        /// <param name="horaInicioDesejado">A hora de inicio desejado.</param>
        /// <param name="horaTerminoDesejado">A hora de termino desejado.</param>
        /// <returns>Um booleano.</returns>
        public bool VerificarHorarioOcupado(DateTime data, TimeSpan horaInicioDesejado, TimeSpan horaTerminoDesejado)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("DATA", data);

            parametros.Add("HORA_INICIO_DESEJADO", horaInicioDesejado.Ticks);
            parametros.Add("HORA_TERMINO_DESEJADO", horaTerminoDesejado.Ticks);

            return Db.Exists(sqlVerificarHorarioOcupado, parametros);
        }

        /// <summary>
        /// Converte o resultado da query em um compromisso.
        /// </summary>
        /// <param name="reader">O DataReader.</param>
        /// <returns>Um Compromisso.</returns>
        private Compromisso ConverterEmCompromisso(IDataReader reader)
        {
            var assunto = Convert.ToString(reader["ASSUNTO"]);
            var local = Convert.ToString(reader["LOCAL"]);
            var link = Convert.ToString(reader["LINK"]);
            var dataDoCompromisso = Convert.ToDateTime(reader["DATA"]);
            var horaInicio = TimeSpan.FromTicks(Convert.ToInt64(reader["HORAINICIO"]));
            var horaTermino = TimeSpan.FromTicks(Convert.ToInt64(reader["HORATERMINO"]));

            var email = Convert.ToString(reader["EMAIL"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var empresa = Convert.ToString(reader["EMPRESA"]);
            var cargo = Convert.ToString(reader["CARGO"]);

            Contato contato = null;
            if (reader["ID_CONTATO"] != DBNull.Value)
            {
                contato = new Contato(nome, email, telefone, empresa, cargo);
                contato.Id = Convert.ToInt32(reader["ID_CONTATO"]);
            }

            Compromisso compromisso = new Compromisso(assunto, local, link, dataDoCompromisso, horaInicio, horaTermino, contato);
            compromisso.Id = Convert.ToInt32(reader["ID"]);

            return compromisso;
        }

        /// <summary>
        /// Obtem os parametros do compromisso.
        /// </summary>
        /// <param name="compromisso">O compromisso.</param>
        /// <returns>Um dicionário.</returns>
        private Dictionary<string, object> ObtemParametrosCompromisso(Compromisso compromisso)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", compromisso.Id);
            parametros.Add("ASSUNTO", compromisso.Assunto);
            parametros.Add("LOCAL", compromisso.Local);
            parametros.Add("LINK", compromisso.Link);
            parametros.Add("DATA", compromisso.Data);
            parametros.Add("HORAINICIO", compromisso.HoraInicio.Ticks);
            parametros.Add("HORATERMINO", compromisso.HoraTermino.Ticks);
            parametros.Add("ID_CONTATO", compromisso.Contato?.Id);

            return parametros;
        }
    }
}
