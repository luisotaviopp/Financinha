
<?php
	require 'connection.php';

	$token = $_POST['post_token'];
	$answer = $_POST['post_answer'];

	$sql = "SELECT user.id, user.level
			FROM user
			INNER JOIN token
			ON user.id = token.user_id
			WHERE token.token = '$token'";
			
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
			$id =  $row['id'];
			$level =  $row['level'];
			
			// Insere a resposta.
			$sql2 = "INSERT INTO quiz_open_answer (answer, level, user_id) VALUES ('$answer', $level, $id)";
			$conn->query($sql2);

			echo 'Ok';
		}
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>