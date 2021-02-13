<?php
	require 'connection.php';

	$token = $_POST['post_token'];
	$to = $_POST['post_to'];
	$relation = $_POST['post_relation_type'];

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

            $sql3 = "INSERT INTO notification (to_user, from_user, relation_type) VALUES ($to, $id, $relation)";
			$conn->query($sql3);
		}
		echo "Ok";
	} 
	else
	{
		echo "Invalid Token";
	}

	$conn->close();
?>