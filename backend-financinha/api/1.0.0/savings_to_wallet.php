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
            //Retira do cofrinho
            $sql2 = "UPDATE saving
					 SET saving.amount = (saving.amount - $value) 
                     WHERE saving.user_id = " . $row['id'];
			$conn->query($sql2);
            
            //Adiciona na carteira
            $sql3 = "UPDATE wallet
					 SET wallet.amount = (wallet.amount + $value) 
                     WHERE wallet.user_id = " . $row['id'];
			$conn->query($sql3);

			// Gera o evento para pegar no extrato depois.
			$id =  $row['id'];
			$sql4 = "INSERT INTO event (user_id, type, value, reason) VALUES ($id, 's2w', $value, '$reason')";
			$conn->query($sql4);
		}
		echo "Ok";
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>