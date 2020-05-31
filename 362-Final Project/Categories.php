<?php
require_once('User_Class.php');
require_once('DB_Conn.php');
$U1=new User();

session_start();
//This has the connections to the database


if (isset($_GET['link_clicked'])) {
    $_SESSION['CatID']=$_GET['category_id'];
}

$query = 'SELECT * FROM Products where Category_ID='.$_SESSION['CatID'];
$statement = $db->prepare($query);
$statement->execute();
$Products = $statement->fetchall();
$statement->closeCursor();
//use as example to display information from row set
//echo($Products['Product_name']);

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

?>
<!DOCTYPE html>
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
                    </ul>
                </div>
            </div>

            <!-- Displays all products from the categories selected in previous page -->
            <div class="rightContainer centeredContainer">
                <div class="topBar"></div>
                <div class="greyBar">
                    <h3 id="subhead">Products by Category</h3>
                </div>
                <div id="Category display" class="categoryContainer">
                    <ul>
                        <?php foreach ($Products as $Prod) : ?>
                            <!-- back end reference page -->
                            <li><a href="Prod_page.php?link_clicked=true&Product_ID=<?php echo $Prod['Prod_ID']; ?>">
                                    <!-- whats actually displayed on page -->
                                    <?php echo $Prod['Product_name']; ?>
                                </a>
                                <!-- Displays the description of respective item below the name-->
                                <div id="Product_Listing">
                                    <?php echo $Prod['Description']; ?>
                                    <?php echo nl2br("\n <b>Price</b>: " . $Prod['Price']); ?>
                                </div>
                            </li>
                        <?php endforeach; ?>
                    </ul>

                 </div>
            </div>
        </div>
        <div id="adminLogin">
            <hr>
        </div>
	</body>
</html>
