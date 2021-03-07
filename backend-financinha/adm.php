<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>Document</title>
	</head>
	<body style="text-align: center;">
		<h1>FINANCINHA - ADM</h1>

		<p> <a href="api/1.0.0/quiz/get_questions_table.php">Ver questões</a> | <a href="users.php">Ver usuários</a> </p>

		<form action="src/services/insert_question.php" autocomplete="off"  method="POST">
			<p>Fase (1 a 10):</p>
			<input type="number" name="post_level" min="1" max="10" placeholder="Fase">

			<p>Opção correta (1 a 5):</p>
			<input type="number" name="post_right_answer" min="1" max="5" placeholder="Opção correta">

			<p>Pergunta:</p>
			<input type="text" name="post_question" placeholder="Pergunta">

			<p>Opção 01:</p>
			<input type="text" name="post_option_1" placeholder="Opção 01">

			<p>Opção 02:</p>
			<input type="text" name="post_option_2" placeholder="Opção 02">

			<p>Opção 03:</p>
			<input type="text" name="post_option_3" placeholder="Opção 03">

			<p>Opção 04:</p>
			<input type="text" name="post_option_4" placeholder="Opção 04">

			<p>Opção 05:</p>
			<input type="text" name="post_option_5" placeholder="Opção 05">

			<p>Senha de ADM</p>
			<input type="password" name="post_adm_pass" placeholder="Senha"><br><br>

			<input type="submit" value="CADASTRAR">
		</form>
		
	</body>
</html>