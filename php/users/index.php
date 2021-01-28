<?php

include("../db.php");

// HTTP METHODS HASZNÁLATA

$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET":
		if(!isset($_GET["u"])){
			$books = getBooks();
			echo json_encode($books);
		}
		else{
			$user = loginUser($_GET["u"], $_GET["p"]);

			if (!$user) {
				header('HTTP/1.0 401 Unauthorized ');
				break;
			}
			$users = getUsers();
			echo json_encode($users);
		}
		break;
	case "POST":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true); // asszociatív tömb
		$user = loginUser($data["u"], $data["p"]);
		$isAdmin = userIsAdmin($data["u"], $data["p"]);
		if (!$user) {
			header('HTTP/1.0 401 Unauthorized ');
			break;
		}
		if(isset($data["username"])){
			if (!$isAdmin) {
				header('HTTP/1.0 401 Unauthorized ');
				break;
			}
			addUser($data["username"], $data["password"]);
		}
		if(isset($data["name"])){
			addBook($data["name"], $data["author"], $data["year"], $data["price"]);
		}
		
		break;
	case "PUT":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true); // asszociatív tömb
		$user = loginUser($data["u"], $data["p"]);
		if (!$user) {
			header('HTTP/1.0 401 Unauthorized ');
			break;
		}
		if(isset($data["username"])){
			//addUser($data["username"], $data["pw"]);
		}
		if(isset($data["name"])){
			updateBook($data["id"], $data["name"], $data["author"], $data["year"], $data["price"]);
		}
		break;
	case "DELETE":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true); // asszociatív tömb
		if(isset($data["id"])){
			$user = loginUser($data["u"], $data["p"]);

			if (!$user) {
				header('HTTP/1.0 401 Unauthorized ');
				break;
			}
			else{
				delBook($data["id"]);
			}
		}
		if(isset($data["username"])){
			$user = loginUser($data["u"], $data["p"]);
			$isAdmin = userIsAdmin($data["u"], $data["p"]);
			if (!$user or !$isAdmin) {
				header('HTTP/1.0 401 Unauthorized ');
				break;
			}
			else{
				delUser($data["username"]);
			}
		}
		break;
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET, POST, PUT, DELETE');
		break;
}

function loginUser($u, $p) {
	global $con;
	
	// Perform query
	$result = $con -> query("SELECT count(*) FROM user WHERE username = '$u' AND password = MD5('$p')");
	
	//print_r(array_values(mysqli_fetch_assoc($result))[0]);
	$isLoggedIn = array_values(mysqli_fetch_assoc($result))[0];

	//printf($isLoggedIn);
	

	return $isLoggedIn;
}

function userIsAdmin($u, $p) {
	global $con;
	
	// Perform query
	$result = $con -> query("SELECT count(*) FROM user WHERE username = '$u' AND password = MD5('$p') AND isAdmin = '1'");
	
	//print_r(array_values(mysqli_fetch_assoc($result))[0]);
	$isLoggedIn = array_values(mysqli_fetch_assoc($result))[0];

	//printf($isLoggedIn);
	

	return $isLoggedIn;
}

function getUsers() {
	global $con;
	
	// Perform query
	$result = $con -> query("SELECT username FROM user");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}

function addUser($username, $passwd) {
	global $con;
	
	// Perform query
	$result = $con -> query("INSERT INTO user SET username = '$username', password = MD5('$passwd'), isAdmin = 0");
}


function delUser($username) {
	global $con;
	
	// Perform query
	$result = $con -> query("DELETE FROM user WHERE username = '$username'");
}

function getBooks() {
	global $con;
	
	// Perform query
	$result = $con -> query("SELECT * FROM book");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}

function addBook($name, $author, $year, $price) {
	global $con;
	
	// Perform query
	$result = $con -> query("INSERT INTO book SET name = '$name', author = '$author', year = '$year', price = '$price'");
}

function updateBook($id, $name, $author, $year, $price) {
	global $con;
	
	// Perform query
	$result = $con -> query("UPDATE book SET name = '$name', author = '$author', year = '$year', price = '$price' WHERE id='$id'");
}

function delBook($id) {
	global $con;
	
	// Perform query
	$result = $con -> query("DELETE FROM book WHERE id = '$id'");
}
?>