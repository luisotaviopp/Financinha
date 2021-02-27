<?php
	require 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT objective.name, objective.description, objective.value, objective.weekly_value
            FROM objective 
            INNER JOIN token 
            ON token.user_id = objective.user_id 
			WHERE token.token = '$token'";
			
	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		$emparray = array();
		
		while($row = mysqli_fetch_assoc($result))
		{
			$emparray[] = $row;
		}

        echo json_encode($emparray);

	} else {
		echo "Invalid Token";
	}

	$conn->close();
?>