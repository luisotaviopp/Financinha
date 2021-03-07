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
		
        <?php
            require_once 'api/1.0.0/connection.php';

            $sql = "SELECT id, level, question, option_1, option_2, option_3, option_4, option_5, right_answer FROM question WHERE is_active = true ORDER BY level ASC";
            $result = $conn->query($sql);

            if ($result->num_rows > 0) 
            {
                ?>
                    <table>
                        <tr>
                            <th>Fase</th>
                            <th>Certa</th>
                            <th>Questão</th>
                            <th>Opt1</th>
                            <th>Opt2</th>
                            <th>Opt3</th>
                            <th>Opt4</th>
                            <th>Opt5</th>
                            <th>Editar</th>
                            <th>Deletar</th>
                        </tr>

                <?php

                    while($row = $result->fetch_assoc())
                    {
                        ?>
                            <tr>
                                <td> <?=$row['level']?></td>
                                <td> <?=$row['right_answer']?></td>
                                <td> <?=$row['question']?></td>
                                <td> <?=$row['option_1']?></td>
                                <td> <?=$row['option_2']?></td>
                                <td> <?=$row['option_3']?></td>
                                <td> <?=$row['option_4']?></td>
                                <td> <?=$row['option_5']?></td>
                                <td> <a href="src/services/edit_question.php?id=<?=$row['id']?>">EDITAR</a></td>
                                <td> <a href="src/services/delete_question.php?id=<?=$row['id']?>">DELETAR</a></td>
                            </tr>
                        <?php
                    }
                ?>
                    </table>

                    <h3>Pegar lista de questões por fase:</h3>
                    <form action="api/1.0.0/quiz/get_questions_level.php" method="post">
                        <input type="number" placeholder="Qual a fase?" min="1" max="10" name="post_level">
                        <input type="submit" value="selecionar">
                    </form>
                <?php
            }
            else 
            {
                echo "Nenhuma questão cadastrada.";
            }

            $conn->close();
        ?>
	</body>
</html>