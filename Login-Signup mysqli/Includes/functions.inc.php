<?php //kaikki functiot samassa tiedostossa
//tarkistaa tyhjät input paikat rekisteröinnissä
function emptyInputSignup($name, $email, $username, $pwd, $pwdRepeat) {
    $result;
    if (empty($name) || empty($email) || empty($username) || empty($pwd) || empty($pwdRepeat)) {
        $result = true;
    }
    else {
        $result = false;
    }
    return $result;
}
//virheellinen käyttäjätunnus
function invalidUid($username) {
    $result;
    if (!preg_match("/^[a-zA-Z0-9]*$/", $username)) {
        $result = true;
    }
    else {
        $result = false;
    }
    return $result;
}
//virheellinen sposti
function invalidEmail($email) {
    $result;
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) { //php oma komento mikä tarkistaa sähköpostin muodon
        $result = true;
    }
    else {
        $result = false;
    }
    return $result;
}
//salasanat eivät ole samat
function pwdMatch($pwd, $pwdRepeat) {
    $result;
    if ($pwd !== $pwdRepeat) {
        $result = true;
    }
    else {
        $result = false;
    }
    return $result;
}
//käyttäjänimi tai sposti ovat jo käytössä
function uidExists($conn, $username, $email) {
    $sql = "SELECT * FROM users WHERE usersUid = ? OR usersEmail = ?;";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("location: ../signup.php?error=stmtfailed");
        exit();
    }

    mysqli_stmt_bind_param($stmt, "ss", $username, $email);
    mysqli_stmt_execute($stmt);

    $resultData = mysqli_stmt_get_result($stmt);

    if ($row = mysqli_fetch_assoc($resultData)) {
        return $row;
    }
    else {
        $result = false;
        return $result;
    }
    mysqli_stmt_close($stmt);
}
//luo käyttäjän ja lisää tiedot tietokantaan "INSERT INTO"
function createUser($conn, $name, $email, $username, $pwd) {
    $sql = "INSERT INTO users (usersName, usersEmail, usersUid, usersPwd) VALUES (?, ?, ?, ?)";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("location: ../signup.php?error=stmtfailed");
        exit();
    }

    $hashedPwd = password_hash($pwd, PASSWORD_DEFAULT); //tämä oli vain php oma salasana suojaus eli ei argon2 suojaus

    mysqli_stmt_bind_param($stmt, "ssss", $name, $email, $username, $hashedPwd);
    mysqli_stmt_execute($stmt);
    mysqli_stmt_close($stmt);
    header("location: ../signup.php?error=none");
    exit();
}
//tarkistaa tyhjät input paikat kirjautumisessa
function emptyInputLogin($username, $pwd) {
    $result;
    if (empty($username) || empty($pwd)) {
        $result = true;
    }
    else {
        $result = false;
    }
    return $result;
}
//kirjaa käyttäjän sisään
function loginUser($conn, $username, $pwd) {
    $uidExists = uidExists($conn, $username, $username);
    if ($uidExists === false) { //tarkastaa ensin onko käyttäjänimi tai sposti annettu oikein
        header("location: ../login.php?error=wronglogin");
    }
    $hashedPwd = $uidExists["usersPwd"];
    $checkPwd = password_verify($pwd, $hashedPwd);
    if ($checkPwd === false) { //tarkastaa onko salasana annettu oikein
        header("location: ../login.php?error=wronglogin");
        exit();
    }
    else if ($checkPwd === true) { //kun molemmat kohdat on annettu oikein kirjaa sisään ja menee etusivulle 
        session_start(); 
        $_SESSION["userid"] = $uidExists["usersId"];
        $_SESSION["useruid"] = $uidExists["usersUid"];
        header("location: ../index.php");
        exit();
    }
}