<?php
	require_once('../../connection.php');
	require_once('../../TokenGenerator.php');

	$sql = "SELECT * FROM transacao t
            INNER JOIN carteira c on c.id_carteira = t.id_cofrinho
            WHERE c.id_pessoa = 1 t.tipo = 1 ";

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
