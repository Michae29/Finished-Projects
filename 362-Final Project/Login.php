<?php
require_once('DB_Conn.php');
require_once('User_Class.php');
$U1= new User;

session_start();

$query = 'SELECT * FROM categories ORDER BY category_ID';
//says $DB is undefined but is it the DB_conn.php file
$statement = $db->prepare($query);
$statement->execute();
$categories = $statement->fetchAll();

if(isset($_SESSION['User']))
{
    $U1=$_SESSION['User'];

    echo "Welcome ". $U1 ->getUFirstName();    echo "<form action=\"#\" method=\"post\">
        <input type=\"submit\" name=\"Logout\" value=\"Logout\">
        </form>";

}

if(isset($_POST['Email_Address'] )and (!isset($_SESSION['User'])))
{
        $U1 ->setData(strtolower($_POST['Email_Address']),$_POST['Password']);

        echo "Welcome ". $U1 ->getUFirstName();

        $_SESSION['User']=$U1;

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
                <!-- This sections contains the information for login into a account -->
            <div class="rightContainer centeredContainer">
                <div class="topBar"></div>
                <div class="greyBar"></div>
                <div class="loginContainer boxShadow">
                    <div id="login portion" class="centeredContainer">
                        <h4 id="Subhead" class="loginTitle">Login</h4>
                        <form action="#" method="post" class="centeredContainer">
                            <p> Please enter email address:</p><input type="text" name="Email_Address"
                                                                      class="textBoxLogin">
                            <br>
                            <p>Please enter password: </p><input type="password" name="Password" class="textBoxLogin">
                            <br>
                            <input type="submit" name="Submit" value="Login" class="basicButton loginButton">
                        </form>
                        <div class="bottomLoginItem"><p>If you do not have an account click here to make one</p>
                            <a href="Create_account.php">Create account</a>
                            <p>Click here to edit your account information</p>
                            <a href="Edit_Account.php">Edit account</a>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
    </body>

</html>