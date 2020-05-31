<?php
require_once('User_Class.php');
require_once('DB_Conn.php');
$U1=new User();

    //Grabs the information necessary for the rest of the page
    session_start();

    //grabs the info from categories page
    $query1 = 'SELECT * FROM categories ORDER BY category_ID';
    //says $DB is undefined but is it the DB_conn.php file
    $statement = $db->prepare($query1);
    $statement->execute();
    $categories = $statement->fetchAll();


if(isset($_SESSION['User']))
{
    $U1=$_SESSION['User'];
    echo "Welcome ". $U1 ->getUFirstName();    echo "<form action=\"#\" method=\"post\">
        <input type=\"submit\" name=\"Logout\" value=\"Logout\">
        </form>";
}

if(isset($_POST['Logout']))
{
    echo "Goodbye " . $U1 ->getUFirstName();

    session_destroy();
}
if(isset($_GET['DelID']))
{
    foreach ($_SESSION['Cart'] as $keys=>$values)
    {
        if($values[0]==$_GET['DelID'])
        {
            unset($_SESSION['Cart'][$keys]);
            echo "Item has been removed";
        }
    }

}
function calcTotal($Price,$Quantity)
{
    $total_price=($Quantity*$Price);
    $total_price+=$total_price*0.07;
    echo number_format($total_price,2);

}
?>

<html>
    <head>
        <link rel="Stylesheet" href="Styles.css">
        <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Quantico&display=swap" rel="stylesheet">
    </head>
    <body>
    <div class="mainContainer">
        <div class="navContainer">
            <div class="logoContainer">
                <img src="Images/BITSANDBYTESLOGO.png">

            </div>
            <div id="navBar" class="navBarStyle">
                <h3 id="subhead" class="navBarHeaderStyle">Navigation</h3>
                <ul>
                    <li><a href="Main.php">Main Page</a></li>
                    <li><a href="Cart.php">Cart</a></li>
                    <li><a href="Login.php">Login</a></li>
                </ul>

                <h3 id="subhead" class="navBarHeaderStyle">Product Categories</h3>
                <ul>
                    <?php foreach ($categories as $category) : ?>
                        <!-- back end reference page -->
                        <li><a href="Categories.php?link_clicked=true&category_id=<?php echo $category['Category_ID']; ?>">
                                <!-- whats actually displayed on page -->
                                <?php echo $category['Category_name']; ?>
                            </a>
                        </li>
                    <?php endforeach; ?>
                    <li><a href="Prod_page.php">Product page</a>
                </ul>
            </div>
        </div>
        <div class="rightContainer">
            <div class="topBar"></div>
            <div class="greyBar">
                <h3 id="subhead">Your cart</h3>
            </div>
            <div class="cartContainer">
                <div class="cartTableItem">
                    <table id="Cart_table">
                        <tr>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total price with sales tax</th>
                        </tr>

                        <?php
                        if (!empty($_SESSION['Cart'])) {
                            $total = 0;
                            foreach ($_SESSION['Cart'] as $keys => $values) :?>
                                <tr>
                                    <td><?php echo $values[1]; ?></td>
                                    <td><?php echo $values[2]; ?></td>
                                    <td><?php echo $values[3]; ?></td>
                                    <td>$<?php calcTotal($values[3], $values[2]); ?></td>
                                    <td id="Remove_text"><a href="Cart.php?DelID=<?php echo $values[0] ?>" class="removeButton">Remove item
                                    </td>
                                </tr>

                            <?php endforeach; ?>

                        <?php } ?>

                    </table>
                </div>

                <form action="Checkout.php">
                    <input type="submit" name="Checkout" value="Checkout" class="basicButton">
                </form>
            </div>
        </div>
    </div>
    </body>
</html>