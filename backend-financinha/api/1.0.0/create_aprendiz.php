<?php
	require 'connection.php';

	$token = $_POST['post_token'];

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
			$username = $_POST['post_username'];
			$post_name = $_POST['post_name'];
			$password = sha1($_POST['post_password']);
			$id = $row['id'];

			$sql = "INSERT INTO user (username, name, password, id_responsible, permission) VALUES ('$username', '$post_name', '$password', $id, 'apr')";
	
			if ($conn->query($sql) === TRUE)
			{
				echo "Aprendiz criado";
			} 
			else 
			{
				echo "Error: " . $conn->error;
			}
		}
		echo "Ok";

		$sql = "SELECT id, id_responsible
				FROM user
				ORDER BY id DESC
				LIMIT 1";
				
		$result = $conn->query($sql);

		if ($result->num_rows > 0)
		{
			while($row2 = mysqli_fetch_assoc($result)) 
			{
				$id = $row2['id'];
				$id_responsible = $row2['id_responsible'];

				$sql = "INSERT INTO relation (resp, apr) VALUES ($id_responsible, $id)";
		
				if ($conn->query($sql) === TRUE)
				{
					echo "Relação criada.";
				} 
				else 
				{
					echo "Error: " . $conn->error;
				}
			}
			echo "Ok";
		} 
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>