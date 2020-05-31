<?php
require_once('DB_Conn.php');

$query = 'SELECT * FROM categories ORDER BY category_ID';
//says $DB is undefined but is it the DB_conn.php file
$statement = $db->prepare($query);
$statement->execute();
$categories = $statement->fetchAll();

function PassHash()
{
    $StrPass=$_POST['Password'];
    return password_hash($StrPass,PASSWORD_DEFAULT);
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
//This portion runs the info check and if it works then it created the account, if not it prints the error
if(isset($_POST['Submit']))
{
    $flag=Infocheck();
    if($flag==false)
    {
        echo "Error encounter when processing info, please check and re enter";
    }
    else
    {
        try {


        $HashPass=PassHash();

        $Fname=$_POST['Fname'];
        $Lname=$_POST['Lname'];
        $Email=strtolower($_POST['Email_Address']);
        $Address=$_POST['Address'];
        $City=$_POST['City'];
        $State=$_POST['State'];
        $Zip=$_POST['Zipcode'];


        $query = "INSERT INTO `users` (`UFname`,`ULname`,`UEmail`,`Uaddress`,`City`,`State`,`Zipcode`,`Password`) VALUES ('$Fname','$Lname','$Email','$Address','$City','$State','$Zip','$HashPass')";

//says $DB is undefined but is it the DB_conn.php file
        $statement = $db->prepare($query);
        $statement->execute();

        echo "Your account have been created";

        }
        catch (\mysql_xdevapi\Exception $E)
        {
            echo "Error has been encounter, please recheck information and resubmit ";
            print_r($E);
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
                <li><a href="Prod_page.php">Product page</a>
            </ul>
        </div>
    </div>
    <!-- This sections contains the information for creating an account -->
    <div class="rightContainer centeredContainer">
        <div class="topBar"></div>
        <div class="greyBar"><h4>The address provided will be used as shipping and billing address</h4></div>
        <div id="Creation portion">
            <br>
            <form action="#" method="post">
                <div class="inputContainer">
                    <div class=accountLabels>
                        <label class="lineStyle">First name:</label>
                        <label class="lineStyle">Last Name:</label>
                        <label class="lineStyle">Email:</label>
                        <label class="lineStyle">Password:</label>
                        <label class="lineStyle">Address:</label>
                        <label class="lineStyle">City:</label>
                        <label class="lineStyle">State:</label>
                        <label class="lineStyle">Zipcode:</label>
                    </div>

                    <div class=accountInput>
                        <input type="text" name="Fname" class="lineStyle">
                        <input type="text" name="Lname" class="lineStyle">
                        <input type="text" name="Email_Address" class="lineStyle">
                        <input type="password" name="Password" class="lineStyle">
                        <input type="text" name="Address" class="lineStyle">
                        <input type="text" name="City" class="lineStyle">
                        <select name="State" class="lineStyle">
                            <option value="AL">AL</option>
                            <option value="AK">AK</option>
                            <option value="AR">AR</option>
                            <option value="AZ">AZ</option>
                            <option value="CA">CA</option>
                            <option value="CO">CO</option>
                            <option value="CT">CT</option>
                            <option value="DC">DC</option>
                            <option value="DE">DE</option>
                            <option value="FL">FL</option>
                            <option value="GA">GA</option>
                            <option value="HI">HI</option>
                            <option value="IA">IA</option>
                            <option value="ID">ID</option>
                            <option value="IL">IL</option>
                            <option value="IN">IN</option>
                            <option value="KS">KS</option>
                            <option value="KY">KY</option>
                            <option value="LA">LA</option>
                            <option value="MA">MA</option>
                            <option value="MD">MD</option>
                            <option value="ME">ME</option>
                            <option value="MI">MI</option>
                            <option value="MN">MN</option>
                            <option value="MO">MO</option>
                            <option value="MS">MS</option>
                            <option value="MT">MT</option>
                            <option value="NC">NC</option>
                            <option value="NE">NE</option>
                            <option value="NH">NH</option>
                            <option value="NJ">NJ</option>
                            <option value="NM">NM</option>
                            <option value="NV">NV</option>
                            <option value="NY">NY</option>
                            <option value="ND">ND</option>
                            <option value="OH">OH</option>
                            <option value="OK">OK</option>
                            <option value="OR">OR</option>
                            <option value="PA">PA</option>
                            <option value="RI">RI</option>
                            <option value="SC">SC</option>
                            <option value="SD">SD</option>
                            <option value="TN">TN</option>
                            <option value="TX">TX</option>
                            <option value="UT">UT</option>
                            <option value="VT">VT</option>
                            <option value="VA">VA</option>
                            <option value="WA">WA</option>
                            <option value="WI">WI</option>
                            <option value="WV">WV</option>
                            <option value="WY">WY</option>
                        </select>
                        <input type="text" name="Zipcode" value="46382" class="lineStyle">
                    </div>
                </div>
                <input type="submit" name="Submit" value="Submit" class="basicButton">
            </form>
            <p>If you have an account click here to login</p>
            <a href="Login.php">Login to account</a>


        </div>
    </div>
</div>

</body>

</html>