<?php
	require_once 'connection.php';

	$sql = "SELECT user.name, user.level, user.username FROM user";

	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		$emparray = array();

		while($row = mysqli_fetch_assoc($result))
		{
			$emparray[] = $row;
		}

        echo json_encode($emparray);
	} 
	else 
	{
		echo "0 results";
	}

	$conn->close();
?>