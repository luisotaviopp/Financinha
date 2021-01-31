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
            $sql2 = "UPDATE user
                    SET level = level + 1
                    WHERE user.id = ".$row['id'];
            $conn->query($sql2);
		}

        echo "Ok";
	} else {
		echo "Invalid Token";
	}

	$conn->close();
?>