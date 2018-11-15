<?php
if(isset($_POST['field1']) && isset($_POST['field2'])) {
	unlink("mydata.txt");
    $data = $_POST['field1'] . "\n" . $_POST['field2'] . "\n";
    $ret = file_put_contents('mydata.txt', $data, FILE_APPEND | LOCK_EX);
    if($ret === false) {
        die('There was an error writing this file');
    }
    else {
        echo "$ret bytes written to file";
    }
}
else {
   die('no post data to process');
}
header( "refresh:0.5;url=index.php" );
