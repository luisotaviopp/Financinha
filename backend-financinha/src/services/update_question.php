<?php
    session_start();

    $id = $_SESSION['question_id'];

	echo $_POST['post_adm_pass'];

	if ($_POST['post_adm_pass'] == "ADM123")
	{
		require_once '../../api/1.0.0/connection.php';

		$level          = $_POST['post_level'];
		$question       = $_POST['post_question'];
		$option_1       = $_POST['post_option_1'];
		$option_2       = $_POST['post_option_2'];
		$option_3       = $_POST['post_option_3'];
		$option_4       = $_POST['post_option_4'];
		$option_5       = $_POST['post_option_5'];
		$right_answer   = $_POST['post_right_answer'];
	
		$sql = "UPDATE question SET level = $level, question = '$question', option_1 = '$option_1', option_2 = '$option_2', option_3 = '$option_3', option_4 = '$option_4', option_5 = '$option_5', right_answer = $right_answer WHERE id = $id";
	
		if ($conn->query($sql) === TRUE) 
        {
			echo "Questão atualizada.";
			header('location: ../../table_questions.php');
		} 
        else 
        {
			echo "Error: " . $sql . "<br>" . $conn->error;
		}
	
		$conn->close();
	} 
	else 
	{
		echo 'Senha incorreta';
	}
?>