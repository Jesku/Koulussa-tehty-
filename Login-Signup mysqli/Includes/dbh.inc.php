<?php
$serverName = "localhost";
$dBUserName = "root";
$dBPassword = "";
$dBName = "testusers";

$conn = mysqli_connect($serverName, $dBUserName, $dBPassword, $dBName);

if (!$conn) {
    die("Connection failed: " . mysql_connect_error());
}

//Tällä koodilla luodaan yhteys tietokantaan ja tarkistetaan onnistuiko yhdistäminen (if), jos ei "die" lopettaa yhdistämisen.