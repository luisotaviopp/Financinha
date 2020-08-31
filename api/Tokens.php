<?php
	require_once('../../connection.php');
	require_once('../../TokenGenerator.php');

	$sql = "SELECT users.username, tokens.creation_date
			FROM users INNER JOIN tokens 
			ON users.id = tokens.user_id";

	$result = $conn->query($sql);

	if ($result->num_rows > 0) {

		$emparray = array();

		while($row = mysqli_fetch_assoc($result))
		{
			$emparray[] = $row;
		}

	} else {
		echo "0 results";
	}

	echo json_encode($emparray);

	$conn->close();
?>