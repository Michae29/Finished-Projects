<?php
require_once('DB_Conn.php');

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
        return $flag;
}
//This portion runs the info check and if it works then it created the account, if not it prints the error
if(isset($_POST['Username']))
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
        $Username=$_POST['Username'];

        $query = "INSERT INTO `admin` (`Admin_username`,`Admin_password`,`AFirstName`,`ALastName`) VALUES ('$Username','$HashPass','$Fname','$Lname')";

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
    <h2 id="Title">Bits and Bytes</h2>
	<h3>New Admin</h3>
</head>
<body>

<!-- This sections contains the information for creating an account -->
<div id="Creation portion">
    <br>
    <form action="#" method="post">
        <p>Enter first name:<input type="text" name="Fname" value="First name"></p>
        <p>Enter last name:<input type="text" name="Lname" value="Last name"></p>
        <p> Enter Username <input type="text" name="Username" value="Username"> </p>
        <p> Enter Password:<input type="password" name="Password" value="Password"></p>
        <input type="submit" name="Submit" value="Submit">
    </form>


</div>

</body>

</html>