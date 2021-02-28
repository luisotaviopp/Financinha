using UnityEngine;

public class ApiConfig : MonoBehaviour
{
    // http://localhost/backend-financinha/api/1.0.0/

    public static string API_URL = "http://fluxfacility.com/backend-financinha/api/1.0.0/";

    public static string REGISTER_URL = API_URL+ "create_user.php";                 // Cadastrar jogador novo. *****

    public static string LOGIN_URL = API_URL+"login.php";                           // Logar.

    public static string WALLET_AMOUNT_URL = API_URL+"wallet_amount.php";           // Pegar o valor da carteira.

    public static string SAVINGS_AMOUNT_URL = API_URL+"saving_amount.php";          // Pegar o valor do cofrinho.

    public static string GET_LEVEL_URL = API_URL+"user_level.php";                  // Pegar level do jogador.

    public static string INCREASE_LEVEL_URL = API_URL+"increase_level.php";         // Aumentar level do jogador.

    public static string WALLET_OPERATION_URL = API_URL + "wallet_operation.php";       // Inserindo grana na carteira -> post_value, post_reason

    public static string WALLET_TO_SAVINGS_URL = API_URL + "wallet_to_savings.php"; // Transferência -> carteira para cofrinho

    public static string SAVINGS_TO_WALLET_URL = API_URL + "savings_to_wallet.php"; // Transferência -> cofrinho para carteira 

    public static string CREATE_RULE_URL = API_URL + "create_rule.php";             // Criando regras da casa

    public static string LIST_RULES_URL = API_URL + "list_rules.php";               // Listando regras da casa

    public static string LIST_USERS_URL = API_URL + "search_user.php";              // Procurando um usuário

    // Solicitando relação com outro usuário

    // Listar as notificações

    // Aceitar a solicitação

    // Cancelar a solicitação

    // Listar os familiares de um usuário

    public static string EXTRATO_URL = API_URL+"timeline.php";                      // Pegar o extrato do jogador.

    public static string INSERT_OPEN_ANSWER = API_URL + "insert_open_answer.php";   // Cadastrando uma resposta para uma pergunta

    public static string INSERT_OBJECTIVE = API_URL + "create_objective.php";       // Cadastrar objetivo

    public static string GET_GIFT_URL = API_URL + "get_objective.php";                   // Pegar objetivo

    public static string GET_CAUSE_URL = API_URL + "get_cause.php";                 // Pegar causa

    // Apenas responsáveis -> Vendo as respostas para as perguntas

    // Listar as penalidades de um usuário

    // Simular semanada

    // Enviar respostas do Quiz
}
