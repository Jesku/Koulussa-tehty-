<?php
$nimi = $_POST["nimi"];
$kuukausipalkka = $_POST["kuukausipalkka"];
$veroprosentti = $_POST["veroprosentti"];
$kokonaispalkka= (100-$veroprosentti)/100*$kuukausipalkka;
echo "Nimi:" . $nimi;
echo "<br>";
echo "Bruttopalkka:" . $kuukausipalkka;
echo "<br>";
echo "Nettopalkka:" . $kokonaispalkka;
?> 