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
			<a href="api/1.0.0/quiz/get_questions_table.php">Ver questões</a> 
			<a href="testes.php">Testes da API</a> 
			<a href="docs.php">Documentação</a> 
		</header>

		<h1>FINANCINHA - ADM</h1>
		<?php
			require_once 'api/1.0.0/connection.php';

			$sql = "SELECT id, email, name, username, permission, level FROM user";
			$result = $conn->query($sql);

			if ($result->num_rows > 0) 
			{
				?>
					<table>
						<tr>
							<th>Nome</th>
							<th>Usuário</th>
							<th>Email</th>
							<th>Tipo</th>
							<th>Fase</th>
							<th>Editar</th>
							<th>Deletar</th>
						</tr>

				<?php

					while($row = $result->fetch_assoc())
					{
						?>
							<tr>
								<td> <?=$row['name']?></td>
								<td> <?=$row['username']?></td>
								<td> <?=$row['email']?></td>
								<td> <?=$row['permission']?></td>
								<td> <?=$row['level']?></td>
								<td> <a href="../../../src/services/edit_question.php?id=<?=$row['id']?>">EDITAR</a></td>
								<td> <a href="../../../src/services/delete_question.php?id=<?=$row['id']?>">DELETAR</a></td>
							</tr>
						<?php
					}
				?>
					</table>
				<?php
			}
			else 
			{
				echo "Nenhum usuário cadastrado.";
			}
			$conn->close();
		?>		
	</body>
</html>