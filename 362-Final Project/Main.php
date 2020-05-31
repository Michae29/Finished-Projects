<?php
//This has the connections to the database
require_once('DB_Conn.php');
require_once('User_Class.php');

$query = 'SELECT * FROM categories ORDER BY category_ID';
//says $DB is undefined but is it the DB_conn.php file
$statement = $db->prepare($query);
$statement->execute();
$categories = $statement->fetchAll();

$query = 'SELECT * FROM products WHERE Prod_ID =1';
$statement = $db->prepare($query);
$statement->execute();
$Product1 = $statement->fetch();
$statement->closeCursor();

$query = 'SELECT * FROM products WHERE Prod_ID =2';
$statement = $db->prepare($query);
$statement->execute();
$Product2 = $statement->fetch();
$statement->closeCursor();

$query = 'SELECT * FROM products WHERE Prod_ID =3';
$statement = $db->prepare($query);
$statement->execute();
$Product3 = $statement->fetch();
$statement->closeCursor();

session_start();
if(isset($_SESSION['User']))
{
    $U1=new User();
    $U1=$_SESSION['User'];

    echo "Welcome ". $U1 ->getUFirstName();

    echo "<form action=\"#\" method=\"post\">	
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
    <hr>
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

    <!--This is the main side part of the first page -->
    <div id="Main_part" class="rightContainer">
        <div class="topBar"></div>
        <div class="mainPageHeader greyBar">
            <h4 id="Subhead">Featured products</h4>
            <p> We here at B&B inc provide only the highest of quality computer components at the lowest possible prices.</p>
        </div>
        <div class="featuredProductContainer">
            <!-- This is the first feature product -->
            <div class="featuredProductItem centeredContainer boxShadow">
                <div class="productImageBox">
                    <img src="Images/I7-8700K.png" class="productImage">
                </div>
                <div class="productContainer">
                    <a href="Prod_page.php?link_clicked=true&Product_ID=<?php echo $Product1['Prod_ID'] ?>"><?php echo $Product1['Product_name']; ?></a>
                    <p>Your price:  <?php echo $Product1['Price']; ?> </p>
                    <p><?php echo $Product1['Description']; ?></p>
                </div>
            </div>
            <!-- second featured product -->
            <div class="featuredProductItem centeredContainer boxShadow">
                <div class="productImageBox">
                    <img src="Images/Panzer_Evo.png" class="productImage">
                </div>
                <div class="productContainer">
                    <a href="Prod_page.php?link_clicked=true&Product_ID=<?php echo $Product2['Prod_ID'] ?>" ><?php echo $Product2['Product_name']; ?></a>
                    <p>Your price:  <?php echo $Product2['Price']; ?> </p>
                    <p><?php echo $Product2['Description']; ?></p>
                </div>
            </div>
            <!-- third product -->
            <div class="featuredProductItem centeredContainer boxShadow">
                <div class="productImageBox">
                    <img src="Images/Asus_Prime.jpg" class="productImage">
                </div>
                <div class="productContainer">
                    <a href="Prod_page.php?link_clicked=true&Product_ID=<?php echo $Product3['Prod_ID'] ?>" ><?php echo $Product3['Product_name']; ?></a>
                    <p>Your price:  <?php echo $Product3['Price']; ?> </p>
                    <p><?php echo $Product3['Description']; ?></p>
                </div>
            </div>
        </div>
    </div>
</div>
<div id="adminLogin">
    <a href="admin_login.php" id="admintext" >Admin login</a>
</div>
</body>
</html>

