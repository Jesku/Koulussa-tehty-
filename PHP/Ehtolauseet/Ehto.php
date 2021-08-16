<?php
$ikä = $_POST["ikä"];
$sukupuoli = $_POST["sukupuoli"];

if ($ikä < 0) {
	echo "Ethän sä ny oo ees syntyny vielä";
}

if ($ikä > 110) {
	echo "Vieläki elossa huhhuh";
}

if ($ikä >=0  && $ikä <=13 && $sukupuoli == "mies") {
	echo "Mitä poitsu";
}
elseif ($ikä >=0  && $ikä <=13 && $sukupuoli == "nainen") {
	echo "Mitä tytsy";
}

if ($ikä >= 14 && $ikä <=25 && $sukupuoli == "mies") {
	echo "Mitä nuorimies";
}
elseif ($ikä >=14  && $ikä <=25 && $sukupuoli == "nainen") {
	echo "Mitä nuorinainen";
}

if ($ikä >= 26 && $ikä <=69 && $sukupuoli == "mies") {
	echo "Olet mies parhaassa iässä";
}
elseif ($ikä >=26  && $ikä <=69 && $sukupuoli == "nainen") {
	echo "Olet nainen parhaassa iässä";
}

if ($ikä >= 70 && $ikä <=110 && $sukupuoli == "mies") {
	echo "Olet jo eläke iässä";
}
elseif ($ikä >=70  && $ikä <=110 && $sukupuoli == "nainen") {
	echo "Olet jo eläke iässä";
}
?> 