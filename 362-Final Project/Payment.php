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

if(isset($_SESSION['User']))
{
    echo "Welcome ". $U1 ->getUFirstName(); echo "";    echo "<form action=\"#\" method=\"post\">
        <input type=\"submit\" name=\"Logout\" value=\"Logout\">
        </form>";


}

if(isset($_POST['Logout']))
{
    echo "Goodbye " . $U1 ->getUFirstName();

    session_destroy();
}

if(isset($_POST['Purchase']))
{
    $CardString=$_POST['CC_Num'];
    $flag=true;

    $L4=substr($_POST['CC_Num'],-4);
    $_SESSION['Last']=$L4;

    $Char = str_split($CardString);
    $length=count($Char);
//  This checks the incoming CC to see that if anything thats not a number has been inputted
    for($i=0;$i<$length;$i++) {
        if (!is_numeric($Char[$i])) {

            echo "<p>Please do not put text in Credit Card entry</p>";
            $flag=false;
            break;
        }

    }
        if(empty($_POST['CVV'])==true or empty($_POST['Expire']==true))
        {
            $flag=false;
            echo "Please fill out all the information to purchase items";
        }

    if($flag=true) {


        // Set the string length and parity
        $number_length=strlen($CardString);
        $location=$number_length % 2;

        // Loop through each digit and do the maths
        $total=0;
        for ($i=0; $i<$number_length; $i++) {
            $digit=$CardString[$i];
            // Multiply alternate digits by two
            if ($i % 2 == $location) {
                $digit*=2;
                // If the sum is two digits, add them together (in effect)
                if ($digit > 9) {
                    $digit-=9;
                }
            }
            // Total up the digits
            $total+=$digit;

        }
        if($total % 10 ==0)
        {
            insertSale();

            echo "<script>window.location.href='Ordered.php'</script>";

        }
        else
        {
            echo "Numbered entered is not a valid credit card";
        }
    }
}

function insertSale()
{
    $dsn = 'mysql:host=localhost;dbname=362_proj';
    $username = 'root';
    $password = '';

    try {
        $db = new PDO($dsn, $username, $password);
    } catch (PDOException $e) {
        $error_message = $e->getMessage();
        echo $error_message;
        include('DB_error.php');
        exit();
    }

    $Sale_Amount = $_SESSION['TotalItemCost'];
    $Sale_Date = date("y/m/d");
    $products = array();
    $i=0;
    foreach ($_SESSION['Cart'] as $keys => $values) :
        $products[$i]=$values[0];
    $i++;
    endforeach;

    $Sold_Products = implode(",", $products);

    $U1=$_SESSION['User'];
    $UserID = $U1->getUID();



    $query = "INSERT INTO `sales` (`sale_Amount`,`Sale_Date`,`ProdID's`,`UserID`) VALUES ('$Sale_Amount','$Sale_Date','$Sold_Products','$UserID')";

//says $DB is undefined but is it the DB_conn.php file
    $statement = $db->prepare($query);
    $statement->execute();


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
            <div class="greyBar"></div>
            <div id="Shipping address" class="centeredContainer">
                <form action="Edit_Account.php" method="post">
                    <h4>Billing Address:</h4>
                    <?php echo $U1->getAddress() . "<br>" . $U1->getCity() . " " . $U1->getState() . " " . $U1->getZip() . "<br>" ?>
                    <input type="submit" value="Edit information" class="basicButton">
                </form>
                <!-- This is where the payment info is input and called -->
                <div>
                    <h4>Payment Information</h4>
                    <form id="Payment Info" action="#" method="post">
                        <div class="paymentContainer">
                            <div class="accountLabels paymentLabels">
                                <label class="lineStyle">Choose Card Type:</label>
                                <label class="lineStyle">Card Number:</label>
                                <label class="lineStyle">CVV:</label>
                                <label class="lineStyle">Expiration:</label>
                            </div>

                            <div class="accountInput">
                                <select id="Credit_card_type" class="lineStyle">
                                    <option>Mastercard</option>
                                    <option>Discover</option>
                                    <option>American Express</option>
                                    <option>Visa</option>
                                </select>
                                <input type="text" name="CC_Num" class="lineStyle" placeholder="No spaces or dashes">
                                <input type="password" name="CVV" class="lineStyle">
                                <input type="input" name="Expire" placeholder="MM/YYYY" class="lineStyle">
                            </div>
                        </div>
                        <input type="submit" name="Purchase" value="Place Order" class="basicButton">
                    </form>
                    <div class="centeredContainer">
                        <input type="button" name="Return" value="Return to cart"
                               onclick="document.location.href='Cart.php';" class="basicButton returnButton">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
