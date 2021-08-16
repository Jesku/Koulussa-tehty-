<?php
session_start(); 
session_unset();
session_destroy();

header("location: ../index.php");
exit();

//kolmella eri session tagilla käyttäjä kirjautui ulos sivulta en muista enempää selitystä. ja siirtää käyttäjän etusivulle