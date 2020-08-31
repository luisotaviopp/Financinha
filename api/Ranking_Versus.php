<?php
	require_once('../../connection.php');

	$sql = "SELECT username, victories_versus
			FROM users 
			ORDER BY victories_versus DESC
			LIMIT 3";
			
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