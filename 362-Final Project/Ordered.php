<?php
require_once('User_Class.php');
require_once('DB_Conn.php');
$U1=new User();
//Grabs the information necessary for the rest of the page
session_start();

$U1=$_SESSION['User'];

//grabs the info from categories page
$query1 = 'SELECT * FROM categories ORDER BY category_ID';
//says $DB is undefined but is it the DB_conn.php file
$statement = $db->prepare($query1);
$statement->execute();
$categories = $statement->fetchAll();


$query2 = 'SELECT MAX(SaleID) FROM sales WHERE UserID='.$U1->getUID();
//says $DB is undefined but is it the DB_conn.php file
$statement = $db->prepare($query2);
$statement->execute();
$Record = $statement->fetch();


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
                        <li>
                            <a href="Categories.php?link_clicked=true&category_id=<?php echo $category['Category_ID']; ?>">
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
            <div class="greyBar"><h4>Thank you for your order!</h4></div>
            <div id="Ordered Info" class="orderContainer">
                <div class="leftOrder">
                    <div class="orderInfo boxShadow">
                        <h4>Order information</h4>
                        <p>Order number: <?php echo $Record[0] ?></p>
                        <p>Order date: <?php echo date("m/d/yy") ?></p>
                        <h4>Shipping information</h4>
                        <p>Has not shipped yet</p>
                        <p><?php echo $U1->getAddress(); ?></p>
                        <p><?php echo $U1->getCity() . " " . $U1->getState() . " " . $U1->getZip(); ?></p>
                        <h4>Billing information</h4>
                        <p>Card Info: ...<?php echo $_SESSION['Last']; ?></p>
                        <p><?php echo $U1->getAddress(); ?></p>
                        <p><?php echo $U1->getCity() . " " . $U1->getState() . " " . $U1->getZip(); ?></p></div>
                </div>
                <div class="rightOrder">
                    <h4>Your Items:</h4>
                    <table id="Checkout_table">
                        <tr>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total price with sales tax</th>
                        </tr>

                        <?php
                        if (!empty($_SESSION['Cart'])) {
                            foreach ($_SESSION['Cart'] as $keys => $values) :?>
                                <tr>
                                    <td><?php echo $values[1]; ?></td>
                                    <td><?php echo $values[2]; ?></td>
                                    <td><?php echo $values[3]; ?></td>
                                    <td>$<?php calcTotal($values[3], $values[2]); ?></td>
                                </tr>

                            <?php endforeach; ?>
                            <tr>
                                <td><b>Total</b>:$<?php echo $_SESSION['TotalItemCost']; ?></td>
                            </tr>

                        <?php } ?>
                    </table>
                </div>
        </div>
    </div>
    </body>
</html>