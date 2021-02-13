<?php
	require 'connection.php';

	$token = $_POST['post_token'];
	$username = $_POST['post_username'];

    $sql = "SELECT user.id
            FROM user
            INNER JOIN token
            ON user.id = token.user_id
            WHERE token.token = '$token'";
            
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		$emparray = array();

		$sql2 = "SELECT user.id, user.username
				FROM user
				WHERE user.username LIKE '%$username%'";
		
		$result2 = $conn->query($sql2);

		if ($result2->num_rows > 0)
		{
			while($row2 = mysqli_fetch_assoc($result2))
			{
				$emparray[] = $row2;
			}
		} 
		else
		{
			echo "Nenhum usuário encontrado.";
		}

        echo json_encode($emparray);
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>