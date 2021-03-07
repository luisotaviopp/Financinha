<?php
	session_start();
		require_once '../../api/1.0.0/connection.php';

	$id = $_GET['id'];
	$_SESSION['question_id'] = $id;

	$sql = "SELECT id, level, question, option_1, option_2, option_3, option_4, option_5, right_answer FROM question WHERE id =  $id AND is_active = true ORDER BY level ASC";
	$result = $conn->query($sql);

	if ($result->num_rows > 0) 
	{
		while($row = $result->fetch_assoc())
		{
			?>
			<!DOCTYPE html>
				<html lang="en">
					<head>
						<meta charset="UTF-8">
						<meta http-equiv="X-UA-Compatible" content="IE=edge">
						<meta name="viewport" content="width=device-width, initial-scale=1.0">
						<title>Financinha</title>
					</head>
					<body style="text-align: center;">
						<h1>FINANCINHA - ADM</h1>

						<p> <a href="../../table_questions.php">Ver questões</a> | <a href="users.php">Ver usuários</a> </p>										

						<form action="update_question.php" autocomplete="off"  method="POST">
							<p>Fase (1 a 10):</p>
							<input type="number" name="post_level" min="1" max="10" value="<?=$row['level']?>" placeholder="Fase">

							<p>Opção correta (1 a 5):</p>
							<input type="number" name="post_right_answer" min="1" max="5" value="<?=$row['right_answer']?>" placeholder="Opção correta">

							<p>Pergunta:</p>
							<input type="text" name="post_question" value="<?=$row['question']?>" placeholder="Pergunta">

							<p>Opção 01:</p>
							<input type="text" name="post_option_1" value="<?=$row['option_1']?>" placeholder="Opção 01">

							<p>Opção 02:</p>
							<input type="text" name="post_option_2" value="<?=$row['option_2']?>" placeholder="Opção 02">

							<p>Opção 03:</p>
							<input type="text" name="post_option_3" value="<?=$row['option_3']?>" placeholder="Opção 03">

							<p>Opção 04:</p>
							<input type="text" name="post_option_4" value="<?=$row['option_4']?>" placeholder="Opção 04">

							<p>Opção 05:</p>
							<input type="text" name="post_option_5" value="<?=$row['option_5']?>" placeholder="Opção 05">

							<p>Senha de ADM</p>
							<input type="password" name="post_adm_pass" placeholder="Senha"><br><br>

							<input type="submit" value="SALVAR">
						</form>							
					</body>
				</html>
			<?php
		}
	}
	else 
	{
		echo "Nenhuma questão cadastrada.";
	}

	$conn->close();
?>

