<?php
    require_once 'connection.php';
    require_once 'token_generator.php';
    
    $username = $_POST["post_username"];
    $password = $_POST["post_password"];

	$sql = "SELECT password, id
			FROM user 
			WHERE username = '$username'";
			
	$result = $conn->query($sql);

    if ($result->num_rows > 0)
    {
        $emparray = array();
        
		while($row = mysqli_fetch_assoc($result))
		{
            if($row["password"] == sha1($password))
            {
                $new_token = random_str();

				//Update Token
				$sql2 = "UPDATE token 
						SET token = '$new_token', created_at = current_timestamp
                        WHERE user_id =".  $row['id'];
                $conn->query($sql2);
			
				//Getting user data
				$sql3 = "SELECT user.level as level, token.token
                        FROM user INNER JOIN token  
                        ON user.id = token.user_id
                        WHERE user_id =". $row['id'];
				
				$result2 = $conn->query($sql3);

                if ($result2->num_rows > 0)
                {
					while($row = mysqli_fetch_assoc($result2))
					{
						$emparray[] = $row;
					}
				} else {
				//	echo "0 results";
                }
                
                echo json_encode($emparray);
                
            } else {
                echo "Wrong credentials";
            }
		}
	} else {
		echo "Username does not exists";
	}

	$conn->close();
?>