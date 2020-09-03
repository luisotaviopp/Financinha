<?php
	require_once('../../connection.php');
    require_once('../../TokenGenerator.php');
    
    $nome = 'aaaaaaaaa';
    $permissao = 1;
    $senha = "1234";
    $login = "testando123";

	$sql = "INSERT INTO pessoa (lvl, nome, permissoes, senha, usuario) VALUES (1,  '$nome' , $permissao , '$senha' , '$login' )";

	$result = $conn->query($sql);

	if ($result === TRUE) {
		echo "Usuario cadastrado com sucesso";
	  } else {
		echo "Error: " . $sql . "<br>" . $conn->error;
	  }

	echo json_encode($emparray);

	$conn->close();
?>
