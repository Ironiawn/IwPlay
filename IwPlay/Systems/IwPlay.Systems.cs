using System;
using System.Management;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Specialized;
using CefSharp;

/// <summary>
/// Sistemas do IwPlay
/// </summary>
namespace IwPlay.Systems
{
    /// <summary>
    /// Itens relacionados a segurança do cliente IwPlay
    /// </summary>
    public static class IwP_Main_Security
    {
        /// <summary>
        /// Detecta se a máquina a rodar o aplicativo é virtual
        /// </summary>
        public static bool IsVM
        {
            get
            {
                using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
                {
                    using (var items = searcher.Get())
                    {
                        foreach (var item in items)
                        {
                            string manufacturer = item["Manufacturer"].ToString().ToLower();
                            if ((manufacturer == "microsoft corporation" && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                                || manufacturer.Contains("vmware")
                                || item["Model"].ToString() == "VirtualBox")
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }
        public class CustomMenuHandler : CefSharp.IContextMenuHandler
        {
            public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
            {
                model.Clear();
            }

            public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
            {

                return false;
            }

            public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
            {

            }
            public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
            {
                return false;
            }
        }

        /// <summary>
        /// Helper method to determine if invoke required, if so will rerun method on correct thread.
        /// if not do nothing.
        /// </summary>
        /// <param name="c">Control that might require invoking</param>
        /// <param name="a">action to preform on control thread if so.</param>
        /// <returns>true if invoke required</returns>
        public static bool ControlInvokeRequired(Control c, Action a)
        {
            try
            {
                if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
                else return false;
            }
            catch
            {
                return true;
            }

            return true;
        }
    }

    /// <summary>
    /// Diretórios da IwPlay Client
    /// </summary>
    public static class Directories
    {
        /// <summary>
        /// Arquivos temporários HTML sobre o jogo informado
        /// </summary>
        public static string TempGameFiles_HTML(string GameCode)
        {
            // Verifica se a pasta temporária do jogo existe
            if (Directory.Exists(Environment.CurrentDirectory + "\\tmp\\" + GameCode + "\\wb"))
                // Retornar caminho da pasta
                return Environment.CurrentDirectory + "\\tmp\\" + GameCode + "\\wb";
            else
            {
                // Criar pasta temporária
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\tmp\\" + GameCode + "\\wb");
                // Retornar caminho da pasta
                return Environment.CurrentDirectory + "\\tmp\\" + GameCode + "\\wb";
            }
        }

        /// <summary>
        /// Arquivos de log do client
        /// </summary>
        public static string LogFiles
        {
            get
            {
                // Verificar se a pasta de logs existe
                if(Directory.Exists(Environment.CurrentDirectory + "\\log"))
                    // Retornar caminho, já existe!
                    return Environment.CurrentDirectory + "\\log";
                {
                    // Criar pasta de logs e retornar caminho
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\log");
                    return Environment.CurrentDirectory + "\\log";
                }
            }
        }
    }

    /// <summary>
    /// Informações de um jogo
    /// </summary>
    public class GameInformation
    {
        /// <summary>
        /// Nome
        /// </summary>
        [JsonPropertyName("GAMENAME")]
        public string Name;

        /// <summary>
        /// Desenvolvedora
        /// </summary>
        [JsonPropertyName("COMPANY")]
        public string Developer;

        /// <summary>
        /// Descrição resumida
        /// </summary>
        [JsonPropertyName("GAMEDESCRIPTION")]
        public string Description;

        /// <summary>
        /// Boxshot do jogo
        /// </summary>
        [JsonPropertyName("GAMEIMAGE")]
        public string Image;

        /// <summary>
        /// Preço (em BRL)
        /// </summary>
        [JsonPropertyName("GAMEPRICE")]
        public string Price;

        /// <summary>
        /// ID no banco de dados
        /// </summary>
        [JsonPropertyName("GAMEID")]
        public string ID;
        /// <summary>
        /// Link de compra do jogo
        /// </summary>
        [JsonPropertyName("GAMEBUYID")]
        public string GameBuyLink;

        /// <summary>
        /// O jogo foi aprovado para ser exibido na loja?
        /// </summary>
        [JsonPropertyName("APPROVED")]
        public string ApprovedGame = "false";

        /// <summary>
        /// Data de aprovação do jogo (se foi)
        /// </summary>
        [JsonPropertyName("APPROVALDATE")]
        public string ApprovalDate = "";
    }

    /// <summary>
    /// Cliente web para metodos post
    /// </summary>
    public class PostClient
    {
        private string UAC = "Ironiawn WebCLI | IwPlay CLI v1";


        public PostClient()
        {
            // Cria novo cliente browser
            PostHTTPClient = new WebClient();
        }
        /// <summary>
        /// Enviar POST para um endereço web
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="data">Dados</param>
        /// <returns></returns>
        public byte[] POST(string url, NameValueCollection data)
        {
            try
            {
                using (WebClient client = PostHTTPClient)
                {
                    // Define codificação
                    client.Encoding = Encoding.UTF8;

                    // Define userAgent
                    client.Headers.Add("user-agent", UAC);

                    // Retornar valores adquiridos com o método POST
                    return client.UploadValues("https://ipsvr.ironiawn.com.br" + url, "POST", data);
                }
            }
            finally
            {
                // Coletar G
                GC.Collect();
            }
        }

        /// <summary>
        /// Enviar POST para o servidor Ironiawn
        /// </summary>
        /// <param name="URL">URL alvo</param>
        /// <param name="requestBody">Dados para envio</param>
        /// <returns>Retornará string</returns>
        public string RESTPOST(string URL, Dictionary<string, string> requestBody)
        {
            // Criar cliente rest
            var client = new RestClient("https://ipsvr.ironiawn.com.br");
            client.UserAgent = UAC;

            // Criar requisição
            var request = new RestRequest(URL, Method.POST);

            // Adicionar parâmetros ao corpo da requisição
            foreach (var dKey in requestBody)
                request.AddParameter(dKey.Key, dKey.Value);

            try
            {
                // Adquirir retorno do site
                IRestResponse r = client.ExecuteAsync(request).Result;

                // Verificar retorno
                if (r.StatusCode == HttpStatusCode.OK)
                    // Retorno OK
                    return r.Content;
                else
                // Retorno NOK
                {
                    // Log
                    LogClient.Log(r.Content);
                    return "iwp_nok";
                }
            }
            catch (Exception error)
            {
                // Log
                LogClient.Log(error.Message);
                return "iwp_nok";
            }

        }

        /// <summary>
        /// Retornar um cliente web
        /// </summary>
        public WebClient PostHTTPClient = null;
    }

    /// <summary>
    /// Itens relacionados ao banco de dados
    /// </summary>
    public static class IwP_Main_Database
    {
        static PostClient _PostClient = new PostClient();

        /// <summary>
        /// Funções referentes à conexão com o banco de dados
        /// </summary>
        public static class Connection
        {
            public enum RetCodes
            { 
                SUCCESS,
                PASSWORD,
                VALIDATION,
                NSU,
                BANNED,
                ERROR,
                ALREADY_USER,
                ALREADY_MAIL,
                ERROR_SENDMAIL,
                ERROR_CREATEQUERY
            };

            /// <summary>
            /// Código de retorno de login
            /// </summary>
            public static RetCodes ReturnCodes = RetCodes.VALIDATION;

            /// <summary>
            /// Tentar logar o usuário utilizando os parâmetros fornecidos
            /// </summary>
            /// <param name="username">Nome de usuário</param>
            /// <param name="password">Senha de usuário</param>
            /// <returns></returns>
            public static RetCodes LoginUser(string username, string password)
            {
                try
                {
                    // Criar aleatoriedade de palavras
                    Random random = new Random();
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                    // Criar session ID
                    UserInfo.SessionID = new string(Enumerable.Repeat(chars, 15)
                          .Select(s => s[random.Next(s.Length)]).ToArray());
                    /*
                    // Criar dados para serem enviados
                    var dados = new NameValueCollection
                    {
                        ["u"] = username, // Nome do usuário
                        ["p"] = password, // Senha do usuário
                        ["sid"] = UserInfo.SessionID, // Sessão criada para a utilização da IwPlay
                        ["i"] = UserInfo.Userdata // Dados de localização do usuário
                    };

                    // Encaminhar dados e retornar resposta
                    var upl = _PostClient.POST("/users/users.verify", dados);
                    string ret = Encoding.UTF8.GetString(upl);
                    */

                    // Criar dados para envio
                    var data = new Dictionary<string, string>
                    {
                        ["u"] = username, // Nome do usuário
                        ["p"] = password, // Senha do usuário
                        ["sid"] = UserInfo.SessionID, // Sessão criada para a utilização da IwPlay
                        ["i"] = UserInfo.Userdata // Dados de localização do usuário
                    };

                    // Adquirir retorno
                    string ret = _PostClient.RESTPOST("/users/users.verify", data);

                    // Separar códigos de retorno
                    switch (ret)
                    {
                        // Geralmente outro erro!
                        default:
                            // Criar log de retorno
                            LogClient.Log(ret);
                            return RetCodes.ERROR;
                        case "BANNED":
                            // Usuário banido!
                            return RetCodes.BANNED;
                        case "NO SUCH USER":
                            // Usuário não encontrado!
                            return RetCodes.NSU;
                        case "VALIDATION":
                            // Usuário não validou o e-mail de criação!
                            return RetCodes.VALIDATION;
                        case "INCORRECT PASSWORD":
                            // Senha incorreta!
                            return RetCodes.PASSWORD;
                        // Login correto!
                        case "OK":
                            // Inserir nome de usuário
                            UserInfo.Username = username;
                            // Inserir e-mail do usuário
                            UserInfo.Usermail = UserInfo.AdquireInfo("USERMAIL");
                            return RetCodes.SUCCESS;
                    }
                }
                catch(Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar false, login incorreto
                    return RetCodes.ERROR;
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }
            }

            /// <summary>
            /// Tentar criar um novo usuário utilizando os parâmetros fornecidos
            /// </summary>
            /// <param name="username">Nome do usuário</param>
            /// <param name="password">Senha do usuário</param>
            /// <param name="email">E-mail do usuário</param>
            /// <returns></returns>
            public static RetCodes CreateUser(string username, string password, string email)
            {
                try
                {
                    // Criar dados para envio
                    var dados = new NameValueCollection
                    {
                        ["u"] = username,
                        ["p"] = password,
                        ["e"] = email
                    };
                    // Enviar dados
                    var upl = _PostClient.POST("/users/users.create", dados);

                    // Criar string de retorno
                    string ret = Encoding.UTF8.GetString(upl);

                    // Separar códigos de retorno
                    switch (ret)
                    {
                        default:
                            // Criar log
                            LogClient.Log(ret);
                            // Erro de servidor não catalogado
                            return RetCodes.ERROR;
                        case "NO MAIL":
                            // Erro ao enviar e-mail
                            return RetCodes.ERROR_SENDMAIL;
                        case "NOK_USER":
                            // Erro ao criar usuário
                            return RetCodes.ERROR_CREATEQUERY;
                        case "ALREADY MAIL":
                            // Já existe um e-mail, parça!
                            return RetCodes.ALREADY_MAIL;
                        case "ALREADY USER":
                            // Já existe um usuário, parça!
                            return RetCodes.ALREADY_USER;
                        // Login correto!
                        case "OK":
                            return RetCodes.SUCCESS;
                    }
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Erro de servidor não catalogado
                    return RetCodes.ERROR;
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }
            }

            /// <summary>
            /// Retornar todos os jogos criados na IwPlay Store
            /// </summary>
            public static List<GameInformation> Games
            {
                get
                {
                    // Define cliente
                    var cli = new NameValueCollection
                    {
                        ["sid"] = UserInfo.SessionID
                    };

                    // Adquire informações
                    string GameList = Encoding.UTF8.GetString(_PostClient.POST("/games/games.list", cli));

                    // Se o retorno não for NOK, continuar
                    if (GameList != "NOK")
                    {
                        // Criar opção de Json
                        var options = new JsonSerializerOptions()
                        {
                            IncludeFields = true,
                        };

                        // Lista de jogos
                        return JsonSerializer.Deserialize<List<GameInformation>>(GameList, options);
                    }
                    else
                        // Retornar nulo
                        return null;
                }
            }            
        }

        /// <summary>
        /// Itens sobre o usuário da sessão atual
        /// </summary>
        public static class UserInfo
        {
            /// <summary>
            /// Nome do usuário logado
            /// </summary>
            public static string Username = "";

            /// <summary>
            /// E-mail do usuário logado
            /// </summary>
            public static string Usermail = "";

            /// <summary>
            /// ID de sessão única do usuário
            /// </summary>
            public static string SessionID;

            /// <summary>
            /// Adquire os dados de localidade do usuário
            /// </summary>
            public static string Userdata => new WebClient().DownloadString("https://freegeoip.app/json/");

            /// <summary>
            /// Retornar informação do usuário
            /// </summary>
            /// <param name="columnName">Coluna do valor desejado</param>
            /// <returns></returns>
            public static string AdquireInfo(string columnName)
            {
                try
                {
                    // Verifica se a informação requisitada é o valor da carteira do usuário
                    if (columnName == "USERWALLET")
                    {
                        /*
                            // Criar protocolo de dados
                            var dados = new NameValueCollection
                            {
                                ["u"] = Username, // Nome do usuário
                                ["sid"] = SessionID, // Código de sessão IwPlay
                                ["command"] = "GET" // Comando para ADQUIRIR dados
                            };

                            // Encaminhar e receber respostas
                            var resp = _PostClient.POST("/users/users.wallet", dados);
                            string upl_resp = Encoding.UTF8.GetString(resp);

                            // Retornar valor recebido
                            return upl_resp;
                        */
                        // Criar dados para envio

                        // Criar protocolo de dados
                        var dados = new Dictionary<string, string>
                        {
                            ["u"] = Username, // Nome do usuário
                            ["sid"] = SessionID, // Código de sessão IwPlay
                            ["command"] = "GET" // Comando para ADQUIRIR dados
                        };

                        return _PostClient.RESTPOST("/users/users.wallet", dados);
                    }
                    else
                    {
                        /*
                        // Criar protocolo de dados
                        var dados = new NameValueCollection
                        {
                            ["u"] = Username, // Nome do usuário
                            ["c"] = columnName, // Coluna requisitada
                            ["sid"] = SessionID // Código da sessão IwPlay
                        };
                        // Encaminhar e receber respostas
                        var upl = _PostClient.POST("/users/users.check", dados);
                        return Encoding.UTF8.GetString(upl);
                        */

                        // Criar protocolo de dados
                        var dados = new Dictionary<string, string>
                        {
                            ["u"] = Username, // Nome do usuário
                            ["sid"] = SessionID, // Código de sessão IwPlay
                            ["c"] = columnName // Coluna requisitada
                        };

                        return _PostClient.RESTPOST("/users/users.check", dados);
                    }
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar nulo, coluna incorreta e/ou inexistente
                    return "iw_false";
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }

            }


            /// <summary>
            /// Atualiza alguma informação do usuário no banco de dados
            /// </summary>
            /// <param name="columnName">Nome da coluna</param>
            /// <param name="valor">Valor para atualização</param
            /// <param name="novaSenha">Definição da nova senha (em caso de atualização)</param>
            /// <returns></returns>
            public static string AtualizaInfo(string columnName, string valor, string novaSenha = null)
            {
                try
                {
                    // Criar dados para atualização
                    var dados = new NameValueCollection
                    {
                        ["u"] = Username, // Nome do usuário
                        ["sid"] = SessionID, // Código da sessão IwPlay
                        ["c"] = columnName, // Coluna requisitada para atualização
                        ["value"] = valor, // Valor para ser atualizado
                        ["newpw"] = novaSenha // Nova senha caso necessite de atualização
                    };
                    // Enviar dados para o servidor
                    var upd = _PostClient.POST("/users/users.up", dados);

                    // Adquirir resposta
                    string resp = Encoding.UTF8.GetString(upd);

                    // Verifica resposta
                    return resp;
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar falso para atualização
                    return "iw_false";
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }
            }

            /// <summary>
            /// Retornar valores disponíveis na carteira do usuário
            /// </summary>
            public static string Wallet
            {
                get
                {
                    return AdquireInfo("USERWALLET");
                }
            }

            /// <summary>
            /// Tenta comprar um item na loja utilizando a carteira IwPlay
            /// </summary>
            /// <param name="valor">Valor a ser debitado</param>
            /// <returns></returns>
            public static bool CompraItem(float valor)
            {
                try
                {
                    // Criar protocolo de dados
                    var dados = new NameValueCollection
                    {
                        ["u"] = Username, // Nome do usuário
                        ["sid"] = SessionID, // Código de sessão IwPlay
                        ["command"] = "POST", // Comando para INSERIR dados
                        ["draw"] = valor.ToString() // Valor para ser removido
                    };

                    // Encaminhar e receber respostas
                    var resp = _PostClient.POST("/users/users.wallet", dados);
                    string upl_resp = Encoding.UTF8.GetString(resp);

                    // Adquirir valor recebido
                    if (upl_resp == "NOFUND")
                        return false;
                    else
                        return true;
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar falso, houve um erro de processamento
                    return false;
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }
            }

            /// <summary>
            /// Verifica se o usuário possui um jogo
            /// </summary>
            /// <param name="gc">Dados do jogo</param>
            /// <returns></returns>
            public static bool HasGame(string gc)
            {
                try
                {
                    // Definir dados para envio
                    var dados = new NameValueCollection
                    {
                        ["u"] = Username,
                        ["gamecode"] = gc,
                        ["sid"] = SessionID
                    };

                    // Adquire informações
                    var GameList = _PostClient.POST("/games/games.check", dados);
                    string gList = Encoding.UTF8.GetString(GameList);

                    // Adquire retornos
                    if (gList == "IWP_OK")
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar falso
                    return false;
                }
            }

            /// <summary>
            /// Deslogar usuário e encerrar sessões
            /// </summary>
            public static void Deslogar()
            {
                try
                {
                    // Criar dados
                    var dados = new NameValueCollection
                    {
                        ["u"] = Username
                    };

                    // Enviar dados
                    var resp = _PostClient.POST("/users/users.logout", dados);
                }
                finally
                {
                    // Coletar garbage
                    GC.Collect();
                }
            }

            /// <summary>
            /// Retornar todas as companhias que o usuário está registrado
            /// </summary>
            public static List<string> Desenvolvedor
            {
                get
                {
                    // Verifica se o nome do desenvolvedor já foi preenchido
                    if (NomesDesenvolvedor != null)
                        return NomesDesenvolvedor;
                    else
                    {
                        // Criar lista de nomes de desenvolvedor
                        NomesDesenvolvedor = new List<string>();

                        // Adquirir nome do desenvolvedor
                        foreach (DevInfo._DeveloperInfo di in DevInfo.DeveloperInfo)
                            NomesDesenvolvedor.Add(di.DeveloperName);

                        // Retornar lista
                        return NomesDesenvolvedor;
                    }
                }
            }

            /// <summary>
            /// Nomes de desenvolvedor do usuário
            /// </summary>
            static List<string> NomesDesenvolvedor = null;
        }

        /// <summary>
        /// Itens sobre o desenvolvedor da sessão atual
        /// </summary>
        public static class DevInfo
        {
            /// <summary>
            /// Informações do desenvolvedor
            /// </summary>
            public class _DeveloperInfo
            {
                /// <summary>
                /// Selo de verificação do desenvolvedor
                /// </summary>
                [JsonPropertyName("DEVELOPERVERIFIED")]
                public string Verified = "0";

                /// <summary>
                /// Nome da companhia como desenvolvedor
                /// </summary>
                [JsonPropertyName("DEVELOPERNAME")]
                public string DeveloperName;

                /// <summary>
                /// Nome de usuário do desenvolvedor
                /// </summary>
                [JsonPropertyName("USERNAME")]
                public string DevUsername;
            }

            /// <summary>
            /// Adquirir informações do desenvolvedor (com base no usuário logado)
            /// </summary>
            /// <returns>Retornará informações sobre o desenvolvedor</returns>
            public static List<_DeveloperInfo> DeveloperInfo
            {
                get
                {
                    try
                    {
                        // Criar dados para envio
                        var dados = new NameValueCollection
                        {
                            ["u"] = UserInfo.Username,
                            ["sid"] = UserInfo.SessionID
                        };

                        // Postar dados e adquirir retorno      
                        string ret = Encoding.UTF8.GetString(_PostClient.POST("/dev/dev.retrieveusercompany", dados));
                        // Verifica se há valores
                        if (ret != "[]")
                        {
                            // Criar opção de Json
                            var options = new JsonSerializerOptions()
                            {
                                IncludeFields = true,
                            };

                            // Decodificar Json e retornar lista
                            return JsonSerializer.Deserialize<List<_DeveloperInfo>>(ret, options);
                        }
                        else
                            return new List<_DeveloperInfo>();
                    }
                    catch (Exception ex)
                    {
                        // Log file
                        LogClient.Log(ex.Message);

                        // Retornar null, erro
                        return null;
                    }
                }
            }

            /// <summary>
            /// Adquirir informações de um ddesenvolvedor
            /// </summary>
            /// <param name="DevName">Nome do desenvolvedor</param>
            /// <returns>Retornará informações sobre o desenvolvedor</returns>
            public static _DeveloperInfo DeveloperInfoWeb(string DevName)
            {
                try
                {
                    // Criar dados para envio
                    var dados = new NameValueCollection
                    {
                        ["company"] = DevName,
                        ["sid"] = UserInfo.SessionID
                    };

                    // Postar dados e adquirir retorno      
                    string ret = Encoding.UTF8.GetString(_PostClient.POST("/dev/dev.retrievecompany", dados));
                    // Verifica se há valores
                    if (ret != "[]")
                    {
                        // Criar opção de Json
                        var options = new JsonSerializerOptions()
                        {
                            IncludeFields = true,
                        };

                        // Decodificar Json
                        return JsonSerializer.Deserialize<List<_DeveloperInfo>>(ret, options)[0];
                    }
                    else
                        return new _DeveloperInfo();
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar null, erro
                    return null;
                }
            }

            /// <summary>
            /// Atualizar informações de um jogo
            /// </summary>
            /// <param name="column">Coluna de atualização</param>
            /// <param name="value">Valor para atualizar</param>
            /// <param name="gamecode">Código do jogo</param>
            /// <returns></returns>
            public static bool UpdateInfo(string column, string value, string gamecode, string DeveloperName)
            {
                try
                {
                    // Criar dados para upload
                    var dados = new NameValueCollection
                    {
                        ["sid"] = UserInfo.SessionID,
                        ["developer"] = DeveloperName,
                        ["gamecode"] = gamecode,
                        ["column"] = column,
                        ["value"] = value
                    };

                    // Enviar dados
                    var rest = _PostClient.POST("/games/games.up.developer", dados);

                    // Adquirir dados
                    string feedback = Encoding.UTF8.GetString(rest);

                    // Verificar se o retorno é IWP_OK
                    if (feedback == "IWP_OK")
                        return true;
                    else
                        // Valor não atualizado
                        return false;
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Valor não atualizado
                    return false;
                }
            }

            /// <summary>
            /// Adquirir informações de um jogo específico
            /// </summary>
            /// <param name="gameCode">Código do jogo</param>
            /// <returns></returns>
            public static GameInformation GameInfo(string gameCode)
            {
                try
                {
                    // Define cliente
                    var cli = new NameValueCollection
                    {
                        ["sid"] = UserInfo.SessionID,
                        ["gamecode"] = gameCode
                    };

                    // Adquire informações
                    string GameList = Encoding.UTF8.GetString(_PostClient.POST("/games/games.detail", cli));

                    // Se o retorno não for NOK, continuar
                    if (GameList != "NOK")
                    {
                        // Criar opção de Json
                        var options = new JsonSerializerOptions()
                        {
                            IncludeFields = true,
                        };

                        // Lista de jogos
                        return JsonSerializer.Deserialize<List<GameInformation>>(GameList, options)[0];
                    }
                    else
                        // Retornar nulo
                        return null;
                }
                catch (Exception ex)
                {
                    // Log file
                    LogClient.Log(ex.Message);

                    // Retornar nulo
                    return null;
                }
            }
        }

    }

    /// <summary>
    /// Funções para criação de log
    /// </summary>
    public static class LogClient
    {
        /// <summary>
        /// Criar log do client
        /// </summary>
        /// <param name="log">Mensagem</param>
        public static void Log(string log)
        {
            // Adquirir data do sistema
            DateTime date = DateTime.UtcNow;

            // Escrever no arquivo de log
            File.AppendAllText(Directories.LogFiles + "\\log.log", $"[{date}] {log}" + Environment.NewLine);
        }
    }
}
