<?php
	require_once('../../connection.php');
	require_once('../../TokenGenerator.php');

	$sql = "SELECT pessoa.usuario, pessoa.senha, token.token
			FROM pessoa 
			INNER JOIN token ON pessoa.id_pessoa = tokens.id_pessoa ";

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