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
        <input type=\"submit\" name=\"Logout\" value=\"Logout\" >
        </form>";

}


if(isset($_POST['Logout']))
{
    echo "Goodbye " . $U1 ->getUFirstName();

    session_destroy();
}

if(isset($_POST['Submit']))
{

    $flag=Infocheck();
    if($flag==false)
    {
        echo "Error encounter when processing info, please check and re enter";
    }
    else {

        $UID = $U1->getUID();

        $Fname = $_POST['Fname'];
        $Lname = $_POST['Lname'];
        $Email = strtolower($_POST['Email_Address']);
        $Address = $_POST['Address'];
        $City = $_POST['City'];
        $State = $_POST['State'];
        $Zip = $_POST['Zipcode'];

        $query = " UPDATE users SET UFname = '$Fname',`ULname`= '$Lname',`UEmail`='$Email',`Uaddress`='$Address',`City`='$City',`State`='$State',`Zipcode`='$Zip' WHERE UserID = ".$UID;
//says $DB is undefined but is it the DB_conn.php file
        $statement = $db->prepare($query);
        if ($statement->execute()) {
            echo "Record updated";

            $U1->SetData1($Email);
            $_SESSION['User']=$U1;

        } else {
            echo "Record did not update";
        }
    }
}

function Infocheck()
{

    $InfoString=$_POST['Fname'].$_POST['Lname'];

    $flag=true;

    $Char = str_split($InfoString);
    $length=count($Char);

    for($i=0;$i<$length;$i++) {
        if (is_numeric($Char[$i])) {

            echo "<p>Please do not put numbers in text</p>";
            $flag = false;
            break;
        } elseif (ctype_space($Char[$i])) {
            echo "<p>Please do not put spaces in text</p>";
            $flag = false;
            break;
        } elseif (empty($Char[$i])) {
            echo "<p> No text was entered info check 1</p>";
            $flag = false;
            break;
        }
    }

    $InfoString=$_POST['Email_Address'].$_POST['Address'].$_POST['State'].$_POST['Zipcode'];

    $Char = str_split($InfoString);
    $length=count($Char);

    for($i=0;$i<$length;$i++) {

        if (empty($Char[$i]) and $Char[$i] !="0") {
            echo "<p>  No text was entered</p>";

            $flag = false;
            break;
        }
    }

    return $flag;

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
                    <li><a href="Prod_page.php">Product page</a>
                </ul>
            </div>
        </div>
        <!-- This sections contains the information for login into a account -->
        <div class="rightContainer">
            <div class="topBar"></div>
            <div class="greyBar"></div>
            <div id="edit portion" class="editPortion centeredContainer">
                <?php
                if (!isset($_SESSION['User'])) {

                    echo "To edit an account please login or create one";
                    echo "<p>If you do not have an account click here to make one</p>
            <a href=\"Create_account.php\">Create account</a>";

                }
                if (isset($_SESSION['User'])) {

                    echo "<form action=\"#\" method=\"post\">";
                    echo "<h4>The address provided will be used as shipping and billing address</h4>";
                    echo "<p>First name:<input type=\"text\" name=\"Fname\" value=" . $U1->getUFirstName() . "></p>";
                    echo "<p>Last name:<input type=\"text\" name=\"Lname\" value=" . $U1->getULastName() . "></p>";
                    echo "<p>Email Address:<input type=\"text\" name=\"Email_Address\" value=" . $U1->getEmail() . "></p>";
                    echo "<p>Address:<input type=\"text\" name=\"Address\" value='" . $U1->getAddress() . "'></p>";
                    echo "<p>City:<input type=\"text\" name=\"City\" value='" . $U1->getCity() . "'></p>";
                    echo "<p> state:
                    <select name=\"State\" >
                    <option> " . $U1->getState() . "</option>
                        <option value=\"AL\">AL</option>
                        <option value=\"AK\">AK</option>
                        <option value=\"AR\">AR</option>
                        <option value=\"AZ\">AZ</option>
                        <option value=\"CA\">CA</option>
                        <option value=\"CO\">CO</option>
                        <option value=\"CT\">CT</option>
                        <option value=\"DC\">DC</option>
                        <option value=\"DE\">DE</option>
                        <option value=\"FL\">FL</option>
                        <option value=\"GA\">GA</option>
                        <option value=\"HI\">HI</option>
                        <option value=\"IA\">IA</option>
                        <option value=\"ID\">ID</option>
                        <option value=\"IL\">IL</option>
                        <option value=\"IN\">IN</option>
                        <option value=\"KS\">KS</option>
                        <option value=\"KY\">KY</option>
                        <option value=\"LA\">LA</option>
                        <option value=\"MA\">MA</option>
                        <option value=\"MD\">MD</option>
                        <option value=\"ME\">ME</option>
                        <option value=\"MI\">MI</option>
                        <option value=\"MN\">MN</option>
                        <option value=\"MO\">MO</option>
                        <option value=\"MS\">MS</option>
                        <option value=\"MT\">MT</option>
                        <option value=\"NC\">NC</option>
                        <option value=\"NE\">NE</option>
                        <option value=\"NH\">NH</option>
                        <option value=\"NJ\">NJ</option>
                        <option value=\"NM\">NM</option>
                        <option value=\"NV\">NV</option>
                        <option value=\"NY\">NY</option>
                        <option value=\"ND\">ND</option>
                        <option value=\"OH\">OH</option>
                        <option value=\"OK\">OK</option>
                        <option value=\"OR\">OR</option>
                        <option value=\"PA\">PA</option>
                        <option value=\"RI\">RI</option>
                        <option value=\"SC\">SC</option>
                        <option value=\"SD\">SD</option>
                        <option value=\"TN\">TN</option>
                        <option value=\"TX\">TX</option>
                        <option value=\"UT\">UT</option>
                        <option value=\"VT\">VT</option>
                        <option value=\"VA\">VA</option>
                        <option value=\"WA\">WA</option>
                        <option value=\"WI\">WI</option>
                        <option value=\"WV\">WV</option>
                        <option value=\"WY\">WY</option>
                    </select>";
                    echo "<p>State:<input type=\"text\" name=\"Zipcode\" value=" . $U1->getZip() . "></p>";
                    echo "<input type=\"submit\" name=\"Submit\" value=\"Submit\" class='basicButton'>";
                    echo "</form>";

                }

                ?>

            </div>
        </div>
    </div>
    </body>

</html>