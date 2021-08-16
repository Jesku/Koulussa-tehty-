<?php
include_once "header.php";
?>

    <h2>Log In</h2>
    <div class="login">
    <form action="includes/login.inc.php" method="post"> 
        <input type="text" name="uid" placeholder="Email/Username...">
        <input type="password" name="pwd" placeholder="Password...">
        <button type="submit" name="submit">Log In</button>
    </form>
    </div>

    <?php
    //tarkistaa onko tiedot annettu oikein ja ilmoittaa käyttäjälle onko jokin mennyt väärin
        if (isset($_GET["error"])) {
            if ($_GET["error"] == "emptyinput") {
                echo "<p>Fill in all fields!</p>";
            }
            else if ($_GET["error"] == "wronglogin") {
                echo "<p>Incorrect login information!</p>";
            }
        }
    ?>

<?php
include_once "footer.php";
?>
