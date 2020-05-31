<?php
require_once('User_Class.php');
require_once('DB_Conn.php');
$U1=new User();

session_start();
//grabs the info from product page

if (isset($_GET['link_clicked'])) {

        $_SESSION['Selected_ID']=$_GET['Product_ID'];
    }


$query = 'SELECT * FROM products where Prod_ID='.$_SESSION['Selected_ID'];
$statement = $db->prepare($query);
$statement->execute();
$Products = $statement->fetch();
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

if(isset($_POST['Submit']))
{
    //This section checks the input to the quantity if its text/whitespace/empty
    $Deter=$_POST['Quan'];
    $flag=true;

    $Char = str_split($Deter);
    $length=count($Char);

    for($i=0;$i<$length;$i++) {
        if (!is_numeric($Char[$i])) {

            echo "<p>Please do not put text the box</p>";
            $flag = false;
            break;
        } elseif (ctype_space($Char[$i])) {
            echo "<p>Please do not put spaces in text</p>";
            $flag = false;
            break;
        } elseif (empty($Char[$i])) {
            echo "<p> No text was entered</p>";
            $flag = false;
            break;
        }

        if ($flag == true) {
            //if the criteria is not met then it goes here and gets added to the cart

            if (isset($_SESSION['Cart'])) {

                $Item_array_ID = array_column($_SESSION['Cart'],0);

                if (!in_array($_SESSION['Selected_ID'], $Item_array_ID)) {
                    $count = count($_SESSION['Cart']);
                    $Item = array($_GET['Product_ID'], $Products['Product_name'], $Products['Price'], $_POST['Quan']);
                    $_SESSION['Cart'][$count] = $Item;
                    echo "Item was added";
                } else {
                    echo "Item has already been added";
                }

            } else {
                $Item = array($_GET['Product_ID'], $Products['Product_name'], $Products['Price'], $_POST['Quan']);
                $_SESSION['Cart'][0] = $Item;
            }
        }
    }
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
        <div class="rightContainer centeredContainer">
            <div class="topBar"></div>
            <div class="greyBar"></div>
            <div id="Product display" class="categoryContainer">
                <?php echo($Products['Product_name']); ?>
                <br/>
                <b>Sale Price : </b><?php echo($Products['Price']); ?>
                <br>
                <form action="#" method="post">
                    <b>Quantity: </b> <input type="text" name="Quan">
                    <input type="submit" name="Submit" value="Add to Cart">
                </form>
                <b>Description</b>
                <br>
                <?php echo($Products['Description']); ?>
            </div>
        </div>
    </div>
		<div id="adminLogin">
			<hr>
		</div>
	</body>
</html>

