<!doctype html>
<html lang="en">
<head>
  <link rel="shortcut icon" type="image/png" href="https://image.flaticon.com/icons/png/512/248/248093.png" />

  <meta charset="utf-8">

  <title>Home[Made] Automation</title>
  <meta name="Hub For Controlling Office Light" content="Login - Time Set - Toggle Switch">
  <meta name="Luke Price" content="Home Automation System">
</head>
<style> 
input[type=text] {
    width: 14em;
	font-family:'courier new';
    padding: 12px 20px;
    margin: 8px 0;
    box-sizing: border-box;
    border: 3px solid #ccc;
    -webkit-transition: 0.5s;
    transition: 0.5s;
    outline: none;
}

input[type=text]:focus {
    border: 3px solid #555;
	color:lightgreen;
	background-color:black;
}
input[type=password] {
    width: 14em;
    padding: 12px 20px;
    margin: 8px 0;
		font-family:'courier new';

    box-sizing: border-box;
    border: 3px solid #ccc;
    -webkit-transition: 0.5s;
    transition: 0.5s;
    outline: none;
}

input[type=password]:focus {
    border: 3px solid #555;
	color:lightgreen;
	background-color:black;
}
</style>
<?php
$username = "mediumfanta";
$password = "pompey111";
$nonsense = "supercalifragilisticexpialidocious";

if (isset($_COOKIE['PrivatePageLogin'])) {
   if ($_COOKIE['PrivatePageLogin'] == md5($password.$nonsense)) {
?>

<?php include('header.php'); ?>

<?php
      exit;
   } else {
      echo "Bad Cookie.";
      exit;
   }
}

if (isset($_GET['p']) && $_GET['p'] == "login") {
   if ($_POST['user'] != $username) {
      echo "Sorry, that username does not match.";
      exit;
   } else if ($_POST['keypass'] != $password) {
      echo "Sorry, that password does not match.";
      exit;
   } else if ($_POST['user'] == $username && $_POST['keypass'] == $password) {
      setcookie('PrivatePageLogin', md5($_POST['keypass'].$nonsense));
      header("Location: $_SERVER[PHP_SELF]");
   } else {
      echo "Sorry, you could not be logged in at this time.";
   }
}
?>

<script src="http://code.jquery.com/jquery-1.10.2.js"></script>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<style>.wrapper {
    text-align: center;
	position: absolute;
top: 20%;
left:40%;
}
.wrapper1 {
    text-align: center;
	position: absolute;
top: 75%;
left:43%;
}
#login-form{
	height:0px;
	width:0px;
}

.button {
	 background:none;
    border-size:5px;
    border-width:5px;
	border-style: solid;
    margin:0;
    padding:.8em;
	font-size:44px;
	font-family:'courier new';
    }

	.button2 {
	 background:none;
    border-size:5px;
    border-width:0px;
	border-style: solid;
    margin:0;
    padding:.8em;
	font-size:44px;
	font-family:'courier new';
    }
	
body {
	background-image: url("https://i.pinimg.com/originals/e5/5a/9e/e55a9e4765d66bad42264249b5944277.jpg");
	background-size: 100% auto;
	font-family:'courier new';
	color:lightgreen;
	}

#submit {
 background-image:url('https://image.flaticon.com/icons/svg/26/26053.svg');background-size: contain;background-repeat: no-repeat;background-position: center; 
}

#submit:hover {
 background-image:url('https://www.shareicon.net/download/2016/06/15/781471_lock_512x512.png');background-size: contain;background-repeat: no-repeat;background-position: center; 

 cursor: pointer;}
</style>
<body>
 <a href="https://docs.google.com/document/d/1jSAJopbnhooEX2_9oN3L3WqEwQJyQDIJ5QTK7hppytw/edit?usp=sharing" ><img id="logobutton" src='homemadeautomation.png' style="position: absolute; bottom: 10px; width:12em; height:auto;cursor:position;"/> </a>

<div id="theDiv" style="display: none;"></div>
<div class="wrapper">
<form style="text-align:center;" action="<?php echo $_SERVER['PHP_SELF']; ?>?p=login" id="login-form" method="post">
	<label>Name<input type="text" name="user" id="user" /> </label><br />
	<label>Password<input type="password" name="keypass" id="keypass" /> </label><br/>
	<br><input type="submit" id="submit" class="button2" value="     " />
</form>
</div>

</body>
