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
			$id = $row['id'];

            $sql2 = "UPDATE user
                    SET level = level + 1
                    WHERE user.id = ".$id;
            $conn->query($sql2);



			// Retorna o level atualizado
			$sql3 = "SELECT level FROM user WHERE user.id = " . $id;
            $result3 = $conn->query($sql3);
			
			if ($result3->num_rows > 0)
			{
				while($row3 = mysqli_fetch_assoc($result3))
				{
					echo ($row3['level']);
				}
			} else {
				echo "Opa! Algo deu errado no servidor.";
			}
		}
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>