<?php
	require_once 'connection.php';

	$token = $_POST['post_token'];
    $notification_id = $_POST['post_notification_id'];

	$sql = "SELECT user.id as logado, relation_type.relation as relacao, notification.from_user, notification.to_user as to_user, notification.id as not_id, notification.relation_type as tipo
            FROM token
            INNER JOIN notification
            ON token.user_id = notification.to_user
            INNER JOIN user
            ON notification.to_user = user.id
            INNER JOIN relation_type
            on relation_type.id = notification.relation_type
            WHERE token.token =  '$token' AND 
            notification.id = $notification_id";

	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
        while($row = mysqli_fetch_assoc($result))
        {
            if($row['logado'] == $row['to_user'])
            {
                $user_a = $row['to_user'];
                $user_b = $row['from_user'];
                $relation = $row['tipo'];
                $not_id = $row['not_id'];

                // Aceita a solicitação
                $sql2 = "INSERT INTO relation (user_a, user_b, relation_type) VALUES ($user_a, $user_b, $relation)";
                $conn->query($sql2);

                // Deleta a notificação
                $sql3 = "DELETE FROM notification WHERE id = $not_id";
                $conn->query($sql3);

                echo 'Relação aceita.';
            }
            else
            {
                echo 'Usuário incorreto.';
            }
        }
	} 
	else 
	{
		echo "Nenhuma solicitação encontrada.";
	}

	$conn->close();
?>