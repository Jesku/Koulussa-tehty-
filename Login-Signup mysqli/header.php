<?php
    session_start(); //kun käyttäjä kirjautuu sisään sivu aloittaa session (meni jotenki noi...?)
?>

<!doctype html>
<html lang="fi">
<head>
  <meta charset="utf-8">
  <title>test login/signup</title>
  <link rel="stylesheet" href="test.css">
</head>
<body>
    <nav>
    <div class="wrapper">
        <ul>
            <li><a href="index.php">Home</a></li>
            <?php
            if (isset($_SESSION["useruid"])) { //jos käyttäjä on kirjautunut sivulla näky profiili sivun nappi ja kirjaudu ulos nappi
                echo "<li><a href='profile.php'>Profile page</a></li>";
                echo "<li><a href='includes/logout.inc.php'>Log out</a></li>";
            }
            else { //jos kukaan ei ole kirjautunut näkyy kirjaudu ja rekisteröidy napit
                echo "<li><a href='signup.php'>Sign up</a></li>";
                echo "<li><a href='login.php'>Log in</a></li>";
            }
            ?>
        </ul>
    </div>
    </nav>

    <div class="wrapper">