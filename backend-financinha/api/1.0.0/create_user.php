<?php
	require_once 'connection.php';

	//Registra o usuário
	$stmt = $conn->prepare("INSERT INTO user (username, name, email, password) VALUES (?, ?, ?, ?)");
	$stmt->bind_param("ssss", $username, $post_name, $post_email, $password);

	$username = $_POST['post_username'];
	$post_name = $_POST['post_name'];
	$post_email = $_POST['post_email'];
	$password = sha1($_POST['post_password']);
	$stmt->execute();


	//Pega o ID do usuário recém criado
	$sql = "SELECT id FROM user ORDER BY id DESC LIMIT 1";
	$result = $conn->query($sql);

	if ($result->num_rows > 0) 
	{
		while($row = $result->fetch_assoc())
		{

			$id = $row['id'];

			//Cria a carteira
			$sql = "INSERT INTO wallet (user_id, amount) VALUES ($id, 0)";

			if ($conn->query($sql) === TRUE)
			{
				echo "Carteira criada.";
			} 
			else 
			{
				echo "Error: " . $sql . "<br>" . $conn->error;
			}



			//Cria o cofrinho
			$sql = "INSERT INTO saving (user_id, amount) VALUES ($id, 0)";

			if ($conn->query($sql) === TRUE)
			{
				echo "Cofrinho criado.";
			} 
			else 
			{
				echo "Error: " . $sql . "<br>" . $conn->error;
			}


			//Cria o token
			$sql = "INSERT INTO token (user_id, token) VALUES ($id, 'init')";

			if ($conn->query($sql) === TRUE)
			{
				echo "Token criado.";
			} 
			else 
			{
				echo "Error: " . $sql . "<br>" . $conn->error;
			}
		}
	}

	$stmt->close();
	$conn->close();

?>