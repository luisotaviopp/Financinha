<?php
	require_once('../../connection.php');
    require_once('../../TokenGenerator.php');
    
    $pessoa = 1; //id do pai
    $parente = 2; //id do filho
    $grau = "1"; //pai seleciona em um select oneMenu

	$sql = "INSERT INTO parentesco (pessoa_1, pessoa_2, grau) VALUES ($pessoa, $parente, $grau)";

	$result = $conn->query($sql);

	if ($result === TRUE) {
		echo "Parentesco cadastrado com sucesso";
	  } else {
		echo "Error: " . $sql . "<br>" . $conn->error;
	  }

	$conn->close();
?>