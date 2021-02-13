<?php
	require 'connection.php';

	$token          = $_POST['post_token'];
	$name           = $_POST['post_name'];
	$description    = $_POST['post_description'];
	$value          = $_POST['post_value'];

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
            $sql2 = "INSERT INTO rule (created_by, name, description, value) VALUES ($id, '$name', '$description', $value)";
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