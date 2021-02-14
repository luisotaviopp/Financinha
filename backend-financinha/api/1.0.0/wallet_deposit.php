<?php
	require 'connection.php';

	$token = $_POST['post_token'];
	$value = $_POST['post_value'];
	$reason = $_POST['post_reason'];

	$sql = "SELECT user.id
			FROM user
			INNER JOIN token
			ON user.id = token.user_id
			WHERE token.token = '$token'";
			
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
			// Insere a grana
			$sql2 = "UPDATE wallet
					 SET wallet.amount = (wallet.amount + $value) WHERE wallet.user_id = ". $row['id'];
			$conn->query($sql2);

			// Gera o evento para pegar no extrato depois.
			$id =  $row['id'];
			$sql3 = "INSERT INTO event (user_id, type, value, reason) VALUES ($id, 'w_deposit', $value, '$reason')";
			$conn->query($sql3);

			echo 'Ok';
		}
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>