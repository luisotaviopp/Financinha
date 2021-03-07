<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>Financinha</title>
	</head>
	<body style="text-align: center;">
		<header>
			<a href="users.php">Criar usuário</a>
			<a href="table_users.php">Ver usuários</a>
			<a href="create_question.php">Criar questão para o quiz.</a>
			<a href="table_questions.php">Ver questões</a> 
			<a href="testes.php">Testes da API</a> 
			<a href="docs.php">Documentação</a> 
		</header>

		<h1>FINANCINHA - ADM</h1>




		<br><h3 class="finalizado">Login</h3>
		<form action="api/1.0.0/login.php" method="post" autocomplete="off">
			<input type="text" name="post_username" placeholder="Usuário">
			<input type="password" name="post_password" placeholder="Senha">
			<input type="submit" value="DALE">
		</form>




		<br><h3 class="finalizado">Registrando novo aprendiz.</h3>
		<form action="api/1.0.0/create_user.php" method="post" autocomplete="off">
			<input type="text" name="post_username" placeholder="Usuário">
			<input type="text" name="post_name"placeholder="Nome">
			<input type="text" name="post_email"placeholder="Email">
			<input type="password" name="post_password"placeholder="Senha">
			<input type="submit" value="DALE">
		</form>
		<p>Passar o post_user, post_name, post_email e post_password.</p>




		<br><h3 class="finalizado">Registrando novo aprendiz</h3>
		<form action="api/1.0.0/create_aprendiz.php" method="post" autocomplete="off">
			<input type="text" name="post_token" placeholder="Token do responsável">
			<input type="text" name="post_username" placeholder="Usuário do aprendiz">
			<input type="text" name="post_name"placeholder="Nome do aprendiz">
			<input type="password" name="post_password"placeholder="Senha">
			<input type="submit" value="DALE">
		</form>

		<br><h3 class="finalizado">Registrando novo aprendiz</h3>
		<form action="api/1.0.0/list_aprendiz.php" method="post" autocomplete="off">
			<input type="text" name="post_token" placeholder="Token do responsável">
			<input type="submit" value="DALE">
		</form>
		



	</body>
</html>