<?php
include_once "header.php";
?>

    <?php
    if (isset($_SESSION["useruid"])) {
        echo "<p>Hello there " . $_SESSION["useruid"] ."</p>";
    }
    ?>

    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam luctus lorem et tincidunt aliquam.
    Duis hendrerit, turpis vel laoreet ornare, tellus est iaculis elit, et porta lacus est vitae enim.
    Etiam mi sapien, fermentum ac orci at, molestie lobortis lacus.
    Donec commodo, augue eu tincidunt placerat, sapien nisl dignissim libero, sit amet congue mauris ligula auctor dui.
    Mauris id arcu at nisi interdum malesuada. Ut luctus et justo at imperdiet. Nulla ac lacus nec diam lobortis feugiat.
    Curabitur feugiat blandit faucibus. Donec vel vehicula turpis. Integer tincidunt sapien sit amet porta ullamcorper.
    Vivamus pulvinar blandit erat, ut semper sapien volutpat eget. Maecenas ac diam id lorem mollis dictum eget at dui.
    In hac habitasse platea dictumst. Nunc ultrices magna eu metus sollicitudin, ut consectetur lectus fringilla.
    Ut nec arcu hendrerit, consectetur elit vel, maximus elit.
    In velit erat, lacinia a sagittis ac, gravida a turpis. Nulla lacinia vel justo at sagittis.
    Praesent ipsum ante, porttitor ut convallis ut, tincidunt et magna. Cras sodales vulputate arcu non interdum. 
    Pellentesque nec faucibus magna. Praesent mauris libero, placerat eu scelerisque non, vehicula sed eros. 
    Etiam quis leo sem. Mauris suscipit sapien id lectus posuere, lobortis pharetra augue imperdiet. 
    Aenean pharetra non erat in pharetra. Proin vestibulum, lectus eget facilisis ornare, diam ex dignissim nisi, eu pharetra eros orci quis augue.
    Phasellus molestie lacus in nisi lacinia sagittis.</p>
<?php
include_once "footer.php";
?>
