<?php
	header('Access-Control-Allow-Origin: *');
	header('Access-Control-Allow-Methods: GET, POST');

	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbname = "financinha_000";

	// Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);

    // Check connection
	if ($conn->connect_error)
	{
		die("Connection failed: " . $conn->connect_error);
	}
?>