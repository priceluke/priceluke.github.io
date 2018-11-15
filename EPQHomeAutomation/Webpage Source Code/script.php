<?php
    // disable cache by HTTP
    header("Expires: Thu, 01 Jan 1970 00:00:00 GMT");
    header('Cache-Control: max-age=0, no-cache, no-store, must-revalidate');
    // disable cache by IE cache extensions
    header('Cache-Control: post-check=0, pre-check=0', false);
    // disable cache by Proxies
    header("Pragma: no-cache");

    $file = 'lights.html';

    if ($_SERVER['REQUEST_METHOD'] === 'POST')
    {
        // POST request

        $previous = file_get_contents($file);
        if ($previous === 'true')
        {
            file_put_contents($file, 'false');
        }
        else
        {
            file_put_contents($file, 'true');
        }
    }
    else
    {
        // not POST request, we assume it's GET

        echo file_get_contents($file);
    }
    exit();
?>