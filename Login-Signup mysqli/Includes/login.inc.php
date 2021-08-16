<?php
//yhdistää inputtien tiedot variableihin. variablet "$uusername..." ja ottaa niihin tiedot inputeista "$_POST["uid"];"
if (isset($_POST["submit"])) {
    $username = $_POST["uid"];
    $pwd = $_POST["pwd"];
//require_once ottaa toisesta tiedostosta koodin ja lukee sen siihen väliin mihin se on kirjoitettu.
    require_once "dbh.inc.php";
    require_once "functions.inc.php";
//tarkistaa virheet
    if (emptyInputLogin($username, $pwd) !== false) { //jokin input kohta on tyhjä
        header("location: ../login.php?error=emptyinput");
        exit();
    }
//kirjaa käyttäjän sisään
    loginUser($conn, $username, $pwd);
}
//kaikki kohdat ovat kunnossa ja sivu latautuu uudelleen
else {
    header("location: ../login.php");
    exit();
}