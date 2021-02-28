<?php
	header('Access-Control-Allow-Origin: *');
	header('Access-Control-Allow-Methods: GET, POST');

	$servername = "31.170.161.64";
	$username = "u507878706_financinha_usr";
	$password = "VUa1gUJ08z@G";
	$dbname = "u507878706_financinha_000";

	// Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);

    // Check connection
	if ($conn->connect_error)
	{
		die("Connection failed: " . $conn->connect_error);
	}
?>