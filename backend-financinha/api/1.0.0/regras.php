<?php
	require_once('../../connection.php');
	require_once('../../TokenGenerator.php');

    $pai = null;
    $filho = 2;

    //este caso é pensado em que um pai tenha apenas um filho, caso ele seja pai de mais de um filho, as regras nao ficam divididas por filho, no caso todos os filhos veem todas as regras
    //a nao ser que seja sempre garantido que o codigo do pai vai ser passado ai é só trocar o OR por AND
	$sql = "SELECT r.criada_por, r.criado_em, r.nome, r.descricao, r.valor, r.penalidade FROM regras r
            INNER JOIN pessoa p on p.id_pessoa = r.criada_por
            INNER JOIN parentesco par on par.pessoa_1 = p.id_pessoa
            INNER JOIN pessoa f on f.id_pessoa = par.pessoa_2
            WHERE p.id_pessoa = COALESCE($pai, 0) OR f.id_pessoa = COALESCE($filho, 0) ";

            

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