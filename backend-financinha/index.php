<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>Document</title>
	</head>
	<body>
		<h1>ENDPOINTS E TESTES DA API DO FINANCINHA</h1>
		
		<a href="api/1.0.0/list_users.php"> VER TODOS OS USUARIOS</a>

		<br><h3>Registrando novo usuário</h3>
		<form action="api/1.0.0/create_user.php" method="post" autocomplete="off">
			<input type="text" name="post_user" placeholder="Usuário">
			<input type="text" name="post_name"placeholder="Nome">
			<input type="password" name="post_password"placeholder="Senha">
			<input type="submit" value="DALE">
		</form>
		<p>Passar o post_user, post_name e post_password.</p>


		<br><h3>Login</h3>
		<form action="api/1.0.0/login.php" method="post" autocomplete="off">
			<input type="text" name="post_username" placeholder="Usuário">
			<input type="password" name="post_password" placeholder="Senha">
			<input type="submit" value="DALE">
		</form>









		<br><h3>Verificando o login de um usuário (se o token é válido)</h3>
		<form action="api/1.0.0/check_login.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>







		
		<br><h3>Verificando o valor total da carteira</h3>
		<form action="api/1.0.0/wallet_amount.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>






		<br><h3>Verificando o valor total do cofrinho</h3>
		<form action="api/1.0.0/saving_amount.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>






		<br><h3>Verificando o level de um usuário</h3>
		<form action="api/1.0.0/user_level.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>




		<br><h3>Aumentando o level de um usuário</h3>
		<form action="api/1.0.0/increase_level.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token" name="post_token" maxlength="128">
			<input type="submit" value="DALE">
		</form>





		<br><h3>Listando penalidades de um usuário. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Criando regras da casa de um usuário. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="text" placeholder="Nome da regra">
			<input type="text" placeholder="Descrição">
			<input type="number" placeholder="Valor">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Listando regras da casa de um usuário. *</h3>
		<p>Provavelmente vai precisar de uma tabela de ligação, já que a cardinalidade relacional é N para N.</p>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Transferindo da carteira para o cofrinho. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="number" placeholder="Valor">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Transferindo do cofrinho para a carteira. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="number" placeholder="Valor">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Listando os familiáres de um usuário. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Procurando um usuário. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Nome">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Retirando (usando) o dinheiro da carteira. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Motivo">
			<input type="number" placeholder="Valor">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Extrato. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Token">
			<input type="submit" value="DALE">
		</form>

		<br><h3>(Apenas filhos) - Cadastrando uma resposta para uma pergunta. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<textarea name="answer" id="" cols="30" rows="10"></textarea>
			<br><input type="submit" value="DALE">
		</form>

		<br><h3>(Apenas pais) - Vendo as respostas para as perguntas. *</h3>
		<form action="api/1.0.0/search_user.php" method="post" autocomplete="off">
			<input type="text" placeholder="Nome">
			<input type="submit" value="DALE">
		</form>

		<br><h3>Depositando na carteira. *</h3>

		<br><h3>Simulação de semanada. *</h3>
		<p>valor do objetivo, data para conseguir o objetivo... (tá pronto lá na unity)</p>

		<br><h3>Cadastrar objetivo. *</h3>

		<br><h3>Cadastrar causa. *</h3>
		<p>Causa é 10% do valor do presente.</p>
		<p>Conquista é o valor da causa + valor do presente.</p>
		

		<br><br><br><br>
	</body>
</html>