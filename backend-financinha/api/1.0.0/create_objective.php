<?php
	require 'connection.php';

	$token              = $_POST['post_token'];
	$gift_name          = $_POST['post_gift_name'];
	$gift_value         = $_POST['post_gift_value'];
	$cause_name         = $_POST['post_cause_name'];
	$cause_value        = $_POST['post_cause_value'];

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
            $sql2 = "INSERT INTO objective (user_id, gift_name, gift_value, cause_name, cause_value)  VALUES ($id, '$gift_name', $gift_value, '$cause_name', $cause_value)";
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