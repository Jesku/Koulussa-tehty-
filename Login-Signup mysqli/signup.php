<?php
include_once "header.php";
?>

    <h2>Sign up</h2>
    <div class="signup">
    <form action="includes/signup.inc.php" method="post">
        <input type="text" name="name" placeholder="Full name...">
        <input type="text" name="email" placeholder="Email...">
        <input type="text" name="uid" placeholder="Username...">
        <input type="password" name="pwd" placeholder="Password...">
        <input type="password" name="pwdRepeat" placeholder="Repeat password...">
        <button type="submit" name="submit">Sign up</button>
    </form>
    </div>

    <?php
    //tarkistaa errorit "signup.inc.php if kohdista" ja tulostaa käyttäjälle viestin mikä meni väärin
        if (isset($_GET["error"])) {
            if ($_GET["error"] == "emptyinput") { //tyhjä input
                echo "<p>Fill in all fields!</p>";
            }
            else if ($_GET["error"] == "invaliduid") { //virheellinen käyttäjätunnus
                echo "<p>Choose proper username!</p>";
            }
            else if ($_GET["error"] == "invalidemail") { //virheellinen sposti
                echo "<p>Choose proper email!</p>";
            }
            else if ($_GET["error"] == "passwordsdontmatch") { //salasanat eivät ole sama
                echo "<p>Passwords doesn't match!</p>";
            }
            else if ($_GET["error"] == "stmtfailed") { //jotain meni vikaan yhteys ongelma tietokantaan tai jotain muuta ei käyttäjästä riippuvaa
                echo "<p>Something went wrong, try again!</p>";
            }
            else if ($_GET["error"] == "usernametaken") { //käyttäjänimi on jo käytössä
                echo "<p>Username already taken!</p>";
            }
            else if ($_GET["error"] == "none") { //ei virheitä ollenkaan
                echo "<p>You have signed up!</p>";
            }
        }
    ?>

<?php
include_once "footer.php";
?>
