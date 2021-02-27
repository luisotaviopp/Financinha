<?php
	require 'connection.php';

	$token          = $_POST['post_token'];
	$name           = $_POST['post_name'];
	$description    = $_POST['post_description'];

    $sql = "SELECT user.id, objective.value
            FROM user
            INNER JOIN token
            ON user.id = token.user_id
            INNER JOIN objective
            ON token.user_id = objective.user_id
            WHERE token.token = '$token'";
            
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
            $id = $row['id'];
            $new_value = $row['value'] * 0.1;
            $sql2 = "INSERT INTO cause (user_id, name, description, value) VALUES ($id, '$name', '$description', $new_value)";
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