<script src="http://code.jquery.com/jquery-1.10.2.js"></script>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<style>

.wrapper {
    text-align: center;
	position: absolute;
top: 30%;
left:40%;
}

.button {
	 background:none;
    border-size:5px;
    border-width:5px;
	border-style: solid;
    margin:0;
    padding:.8em;
	font-size:66px;
	font-family:monospace;
    }

body {
	background-image: url("https://i.pinimg.com/originals/e5/5a/9e/e55a9e4765d66bad42264249b5944277.jpg");
	background-size: 100% auto;
	}
</style>
<script>
</script>
<body>
<div id="theDiv" style="display: none;"></div>
<div class="wrapper" >
<form action="settime_script.php" method="POST">
    turn on:<input value="<?php $lines = file('mydata.txt'); echo trim($lines[0]); ?>" name="field1" style="text-align:center;" type="time" class="w3-input w3-border w3-round-large"/>
    turn off:<input  value="<?php echo trim($lines[1]); ?>" name="field2"  style="text-align:center;" type="time" class="w3-input w3-border w3-round-large" />
	<br>
    <input type="submit" name="submit" class="button" id="buttt" value="Save Data">
</form></div>
</body>
