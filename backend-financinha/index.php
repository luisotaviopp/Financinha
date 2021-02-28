<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>Document</title>

		<style>
			.finalizado {
				color: green;
			}

			.fazer {
				color: red;
			}

			.alterar {
				color: orangered;
			}
		</style>
	</head>
	<body>
		<h1>ENDPOINTS E TESTES DA API DO FINANCINHA</h1>
		
		<a href="api/1.0.0/list_users.php"> VER TODOS OS USUARIOS</a>

		<br><h3 class="finalizado">Registrando novo usuário</h3>
		<form action="api/1.0.0/create_user.php" method="post" autocomplete="off">
			<input type="text" name="post_user" placeholder="Usuário">
			<input type="text" name="post_name"placeholder="Nome">
			<input type="password" name="post_password"placeholder="Senha">
			<input type="submit" value="DALE">
		</form>
		<p>Passar o post_user, post_name e post_password.</p>


		<br><h3 class="finalizado">Login</h3>
		<form action="api/1.0.0/login.php" method="post" autocomplete="off">
			<input type="text" name="post_username" placeholder="Usuário">
			<input type="password" name="post_password" placeholder="Senha">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Verificando o login de um usuário (se o token é válido)</h3>
		<form action="api/1.0.0/check_login.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Verificando o valor total da carteira</h3>
		<form action="api/1.0.0/wallet_amount.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Verificando o valor total do cofrinho</h3>
		<form action="api/1.0.0/saving_amount.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Verificando o level de um usuário</h3>
		<form action="api/1.0.0/user_level.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Aumentando o level de um usuário</h3>
		<form action="api/1.0.0/increase_level.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Inserindo grana na carteira.</h3>
		<form action="api/1.0.0/wallet_deposit.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="text" placeholder="Motivo" name="post_reason">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Retirando grana da carteira.</h3>
		<form action="api/1.0.0/wallet_takeout.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="text" placeholder="Motivo" name="post_reason">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Transferindo da carteira para o cofrinho. </h3>
		<form action="api/1.0.0/wallet_to_savings.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="text" placeholder="Motivo" name="post_reason">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Transferindo do cofrinho para a carteira. </h3>
		<form action="api/1.0.0/savings_to_wallet.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="text" placeholder="Motivo" name="post_reason">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Criando regras da casa de um usuário.</h3>
		<form action="api/1.0.0/create_rule.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="text" placeholder="Nome da regra" name="post_name">
			<input type="text" placeholder="Descrição" name="post_description">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="submit" value="DALE">
		</form>








		<br><h3 class="alterar">Listando regras da casa de um usuário.</h3>
		<p class="alterar">Provavelmente vai precisar de uma tabela de ligação, já que a cardinalidade relacional é N para N.</p>

		<form action="api/1.0.0/list_rules.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="submit" value="DALE">
		</form>


		<br><h3 class="finalizado">Procurando um usuário.</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="text" placeholder="Nome" name="post_username">
			<input type="submit" value="DALE">
		</form>









		
		<br><h3 class="finalizado">Solicitar relação com outro usuário.</h3>
		<form action="api/1.0.0/request_relation.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="number" placeholder="Id do usuário" name="post_to">
			<input type="number" placeholder="Id da relação" name="post_relation_type">
			<input type="submit" value="DALE">
		</form>

		<ol>
			<li>Filho</li>
			<li>Filha</li>
			<li>Pai</li>
			<li>Mãe</li>
			<li>Avó</li>
			<li>Avô</li>
			<li>Tio</li>
			<li>Tia</li>
			<li>Neto</li>
			<li>Neta</li>
			<li>Sobrinho</li>
			<li>Sobrinha</li>
		</ol>



		<br><h3 class="finalizado">Listar as notificações (e solicitações). *</h3>
		<form action="api/1.0.0/list_notifications.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="submit" value="DALE">
		</form>



		<br><h3 class="finalizado">Aceitar a solicitação.</h3>
		<form action="api/1.0.0/accept_relation.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="text" placeholder="Id da notificação" name="post_notification_id">
			<input type="submit" value="DALE">
		</form>


		<br><h3 class="finalizado">Cancelar/recusar a solicitação.</h3>
		<form action="api/1.0.0/refuse_request.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="text" placeholder="Id da notificação" name="post_notification_id">
			<input type="submit" value="DALE">
		</form>










		<br><h3 class="finalizado">Listando os familiáres de um usuário (precisa dar uma pequena atenção nesse).</h3>
		<form action="api/1.0.0/list_family.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="submit" value="DALE">
		</form>


		<br><h3 class="finalizado">Extrato.</h3>
		<form action="api/1.0.0/timeline.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="submit" value="DALE">
		</form>




		<br><h3 class="finalizado">(Apenas filhos) - Cadastrando uma resposta para uma pergunta.</h3>
		<form action="api/1.0.0/insert_open_answer.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token"><br><br>
			<textarea name="post_answer" id="" cols="30" rows="10"></textarea>
			<br><input type="submit" value="DALE">
		</form>










		<br><h3 class="">Cadastrar presente. *</h3>
		<form action="api/1.0.0/create_gift.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="text" placeholder="Nome" name="post_name">
			<input type="text" placeholder="Descricao" name="post_description">
			<input type="number" placeholder="Valor" name="post_value">
			<input type="number" placeholder="Valor Semanada" name="post_weekly_value"><br><br>
			<br><input type="submit" value="DALE">
		</form>

		<br><h3 class="">Cadastrar causa. *</h3>
		<form action="api/1.0.0/create_cause.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token">
			<input type="text" placeholder="Nome" name="post_name">
			<input type="text" placeholder="Descrição" name="post_description"><br><br>
			<br><input type="submit" value="DALE">
		</form>

		<p>Causa é 10% do valor do presente.</p>
		<p>Conquista é o valor da causa + valor do presente.</p>





		<br><h3 class="">Pegando o presente do usuário</h3>
		<form action="api/1.0.0/get_objective.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="">Pegando a causa do usuário</h3>
		<form action="api/1.0.0/get_cause.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>



















		<br><h3 class="fazer">(Apenas pais) - Vendo as respostas para as perguntas. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Nome">
			<input type="submit" value="DALE">
		</form>







		<br><h3 class="fazer">Listando penalidades de um usuário. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="submit" value="DALE">
		</form>




		<br><h3 class="fazer">Simulação de semanada. *</h3>
		<p>valor do objetivo, data para conseguir o objetivo... (tá pronto lá na unity)</p>

		

		<br><br><br><br>
	</body>
</html>