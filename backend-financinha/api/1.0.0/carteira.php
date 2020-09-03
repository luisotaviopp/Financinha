<?php
	require_once('../../connection.php');
	require_once('../../TokenGenerator.php');

    $pessoa = 2;

	$sql = "SELECT SUM(c.valor) FROM carteira c
            INNER JOIN pessoa p on p.id_pessoa = c.id_pessoa
            WHERE p.id_pessoa = $pessoa ";

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