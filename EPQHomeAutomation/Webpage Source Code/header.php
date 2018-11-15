
<script src="http://code.jquery.com/jquery-1.10.2.js"></script>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<style>
input[type=time]:focus {
    border: 3px solid #555;
	color:lightgreen;
 outline:none;
-webkit-user-select: none;  /* Chrome all / Safari all */
  -moz-user-select: none;     /* Firefox all */
  -ms-user-select: none;      /* IE 10+ */
  user-select: none;  
	background-color:black;
}

.wrapper {
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
	width:85%;
height:auto;
text-align:center;
	font-size:44px;
		font-family:'courier new';
    }

	.button2 {
	width:;
	 background:none;
    border-size:5px;
    border-width:5px;
	border-style: solid;
    margin:0;
    padding:.8em;
	font-size:44px;
	width:80%;
height:auto;
		font-family:'courier new';
    }
	
body {
	background-image: url("https://i.pinimg.com/originals/e5/5a/9e/e55a9e4765d66bad42264249b5944277.jpg");
	background-size: 100% auto;
		font-family:'courier new';
	}
	#submit {
}

#lockbutton:hover {
 cursor: pointer;}
 #logobutton:hover {
 cursor: pointer;}
</style>
<script>
function deleteAllCookies() {
    var cookies = document.cookie.split(";");

    for (var i = 0; i < cookies.length; i++) {
        var cookie = cookies[i];
        var eqPos = cookie.indexOf("=");
        var name = eqPos > -1 ? cookie.substr(0, eqPos) : cookie;
        document.cookie = name + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
    }
	location.reload();
}
    function myClick()
    {
        var url = 'script.php'; //put the url for the php
        $.post(url, {});
    }

    $("document").ready(
        function()
        {
            setInterval(
                function()
                {
                    $("#theDiv").load('script.php');
					var node = document.getElementById('theDiv');
					var text  = node.textContent;
					if (text == 'false') {
						document.getElementById("buttt").style.borderColor = "red";
						document.getElementById("buttt").style.color = "red";
					} else {
						document.getElementById("buttt").style.borderColor = "green";
						document.getElementById("buttt").style.color = "green";
					}
                },
                500
            );
        }
    );
</script>

 <img id="lockbutton" onclick="deleteAllCookies()" src='https://image.flaticon.com/icons/svg/26/26053.svg' style="float:right; width:5em; height:auto;cursor:position;"/> 
 <a href="https://docs.google.com/document/d/1jSAJopbnhooEX2_9oN3L3WqEwQJyQDIJ5QTK7hppytw/edit?usp=sharing" ><img id="logobutton" src='homemadeautomation.png' style="position: absolute; bottom: 10px; width:12em; height:auto;cursor:position;"/> </a>

<body>
<div id="theDiv" style="display: none;"></div>
<div class="wrapper" >
<form action="settime_script.php" method="POST">
    <input value="<?php $lines = file('mydata.txt'); echo trim($lines[0]); ?>" name="field1" style="text-align:center;background-image:url('https://image.flaticon.com/icons/png/512/252/252630.png');background-size: contain;background-repeat: no-repeat;" type="time" class="w3-input w3-border w3-round-large">
    <br><input  value="<?php echo trim($lines[1]); ?>" name="field2" style="text-align:center;background-image:url('https://image.flaticon.com/icons/png/512/248/248093.png');background-size: contain;background-repeat: no-repeat;" type="time" class="w3-input w3-border w3-round-large" />
	<br>
    <input type="submit" style="border-color:lightblue;" name="submit" class="button" value="Save Data">
</form>
<br>
<input type="button" value=" Light   " class="button2" id="buttt" onclick="myClick()">
</div>
</body>