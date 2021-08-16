<?php
//yhdistää inputtien tiedot variableihin. variablet "$name..." ja ottaa niihin tiedot inputeista "$_POST["name"];"
if (isset($_POST["submit"])) {
    $name = $_POST["name"];
    $email = $_POST["email"];
    $username = $_POST["uid"];
    $pwd = $_POST["pwd"];
    $pwdRepeat = $_POST["pwdRepeat"];
//require_once ottaa toisesta tiedostosta koodin ja lukee sen siihen väliin mihin se on kirjoitettu.
    require_once "dbh.inc.php";
    require_once "functions.inc.php";
//tarkistaa virheet inputeista
    if (emptyInputSignup($name, $email, $username, $pwd, $pwdRepeat) !== false) { //error jos jokin kohta on tyhjä
        header("location: ../signup.php?error=emptyinput");
        exit();
    }
    if (invalidUid($username) !== false) { //error jos käyttäjänimessä on jotain virheellisiä merkkejä
        header("location: ../signup.php?error=invaliduid");
        exit();
    }
    if (invalidEmail($email) !== false) { //error jos sposti on virheellisessä muododssa
        header("location: ../signup.php?error=invalidemail");
        exit();
    }
    if (pwdMatch($pwd, $pwdRepeat) !== false) { //error jos salasanat eivät ole sama
        header("location: ../signup.php?error=passwordsdontmatch");
        exit();
    }
    if (uidExists($conn, $username, $email) !== false) { //error jos käyttäjänimi tai sposti on jo käytössä jollain muulla käyttäjällä
        header("location: ../signup.php?error=usernametaken");
        exit();
    }

    createUser($conn, $name, $email, $username, $pwd); //luo käyttäjän
}
//kaikki kohdat ovat kunnossa ja sivu latautuu uudelleen
else {
    header("location: ../signup.php");
    exit();
}