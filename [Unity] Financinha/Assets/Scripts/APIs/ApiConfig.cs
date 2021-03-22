using UnityEngine;

public class ApiConfig : MonoBehaviour
{
	// http://localhost/backend-financinha/api/1.0.0/
	public static string API_URL = "http://fluxfacility.com/backend-financinha/api/1.0.0";

	// USUARIOS
	public static string REGISTER_URL 				= API_URL + "/user/create_user.php";            // Cadastrar jogador novo. *****
	public static string LOGIN_URL 					= API_URL + "/user/login.php";                  // Logar.

	// LEVEL
	public static string GET_LEVEL_URL 				= API_URL + "/level/user_level.php";            // Pegar level do jogador.
	public static string INCREASE_LEVEL_URL 		= API_URL + "/level/increase_level.php";        // Aumentar level do jogador.

	// BANCO
	public static string SAVINGS_TO_WALLET_URL 		= API_URL + "/bank/savings_to_wallet.php";      // Transferência -> cofrinho para carteira 
	public static string BANK_EVENTS_URL 			= API_URL + "/bank/bank_timeline.php";               // Pegar o extrato do jogador.
	public static string SAVINGS_AMOUNT_URL 		= API_URL + "/bank/saving_amount.php";                // Pegar o valor do cofrinho.

	// CARTEIRA
	public static string WALLET_EVENTS_URL 			= API_URL + "/wallet/wallet_timeline.php";        // Pegar o extrato do jogador.
	public static string WALLET_AMOUNT_URL 			= API_URL + "/wallet/wallet_amount.php";                // Pegar o valor da carteira.
	public static string WALLET_OPERATION_URL 		= API_URL + "/wallet/wallet_operation.php";             // Inserindo grana na carteira -> post_value, post_reason
	public static string WALLET_TO_SAVINGS_URL 		= API_URL + "/wallet/wallet_to_savings.php";            // Transferência -> carteira para cofrinho

	// REGRAS
	public static string CREATE_RULE_URL 			= API_URL + "/rule/create_rule.php";            // Criando regras da casa
	public static string LIST_RULES_URL 			= API_URL + "/rule/list_rules.php";             // Listando regras da casa

	// USUARIOS
	public static string LIST_USERS_URL 			= API_URL + "/user/search_user.php";            // Procurando um usuário

	// MENU
	public static string MENU_UPDATE_VALUES 		= API_URL + "/menu/menu_values.php";            // Pega os valores para o menu
	public static string MENU_LIST_NOTIFICATIONS 	= API_URL + "/menu/list_notifications.php";     // Listar as notificações

	// APPRENDICE
	public static string LIST_USER_APPRENDICES 		= API_URL + "/apprentice/list_aprendiz.php";    // Listar os aprendizes de um usuário
	public static string CREATE_APPRENDICE 			= API_URL + "/apprentice/create_aprendiz.php";  // Criar aprendiz

	// OBJECTIVE
	public static string INSERT_OBJECTIVE 			= API_URL + "/objective/create_objective.php";   // Cadastrar objetivo
	public static string GET_GIFT_URL 				= API_URL + "/objective/get_objective.php";      // Pegar objetivo
	public static string GET_CAUSE_URL 				= API_URL + "/objective/get_cause.php";          // Pegar causa

	// QUIZZ
	public static string GET_QUESTIONS_BY_LEVEL 	= API_URL + "/quiz/get_questions_level.php";    // Pega as questões por level
	public static string INSERT_QUESTION_RESPONSES 	= API_URL + "/quiz/insert_selection.php";     	// Envia as respostas pro servidor	
	public static string INSERT_OPEN_ANSWER 		= API_URL + "/quiz/insert_open_answer.php";		// Cadastrando uma resposta para uma pergunta

	// Apenas responsáveis -> Vendo as respostas para as perguntas

	// Simular semanada
}
