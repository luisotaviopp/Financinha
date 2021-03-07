
<?php
	session_start();
	require_once '../connection.php';

	$level = $_POST['post_level'];

	$sql = "SELECT id, level, question, option_1, option_2, option_3, option_4, option_5, right_answer FROM question WHERE level = $level";

    $result = $conn->query($sql);

	if ($result->num_rows > 0) 
	{
        $emparray = array();
		
        while($row = $result->fetch_assoc())
		{
            $emparray[] = $row;
		}

        echo json_encode($emparray);
	}
	else 
	{
		echo "Nenhuma questão cadastrada para esta fase.";
	}

	$conn->close();
?>

