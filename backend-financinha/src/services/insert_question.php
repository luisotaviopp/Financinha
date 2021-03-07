<?php
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
	
		$sql = "INSERT INTO question (level, question, option_1, option_2, option_3, option_4, option_5, right_answer)
		VALUES ($level, '$question', '$option_1', '$option_2', '$option_3', '$option_4', '$option_5', $right_answer)";
	
		if ($conn->query($sql) === TRUE)
		{
			echo "New record created successfully";
			header('location: ../../api/1.0.0/quiz/get_questions_table.php');
		} 
		else 
		{
			echo "Error: " . $conn->error;
		}
	
		$conn->close();
	} 
	else 
	{
		echo 'Senha incorreta';
	}
?>