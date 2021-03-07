<?php
    require_once '../connection.php';

    $question_id    = $_POST['post_question_id'];
    $selected       = $_POST['post_selected_option'];
    $user_id        = 1;

    $sql = "INSERT INTO user_answer (question_id, selected_option, user_id) VALUES ($question_id, $selected, $user_id)";

    if ($conn->query($sql) === TRUE)
    {
        echo "Resposta cadastrada";
    } 
    else 
    {
        echo "Error: " . $conn->error;
    }

    $conn->close();
?>