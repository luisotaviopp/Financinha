<?php
	require 'connection.php';

	$token = $_POST['post_token'];
	$value = $_POST['post_value'];

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
            $sql3 = "UPDATE saving
					 SET saving.amount = (saving.amount - $value) 
                     WHERE saving.user_id = " . $row['id'];
			$conn->query($sql3);
            
            //Adiciona na carteira
            $sql2 = "UPDATE wallet
					 SET wallet.amount = (wallet.amount + $value) 
                     WHERE wallet.user_id = " . $row['id'];
			$conn->query($sql2);
		}
		echo "Ok";
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>