<?php
	function getAllUsers()
	{
		$db = openDatabaseConnection();
		$sql = "SELECT * FROM person";
		$query = $db->prepare($sql);
		$query->execute();

		$db = null;
		
		return $query->fetchAll();
	}

	function userLogin()
	{
		$users = getAllUsers();
		foreach ($users as $user) 
		{
			if($_POST['passcode'] == $user['Passcode'])
			{
				session_start();
				$_SESSION["user_id"] = $user['Id'];
				$_SESSION["user_name"] = $user['Email'];
				$_SESSION['loggedin_time'] = time();    
				return true;
			}
		}
		return false;
	}

	function getUserByEmail($email)
	{
		$db = openDatabaseConnection();
		$sql = "SELECT * FROM person WHERE email = :email";
		$query = $db->prepare($sql);
		$query->execute(array(":email" => $email));

		$db = null;
		return $query->fetch();
	}
