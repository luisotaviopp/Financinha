<?php
	require 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT user.username, saving.amount
			FROM user 
			INNER JOIN token 
			ON token.user_id = user.id 
			INNER JOIN saving 
			ON token.user_id = saving.user_id
			WHERE token.token = '$token'";
			
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
			echo $row['amount'];
		}
	} else {
		echo "Invalid Token";
	}

	$conn->close();
?>