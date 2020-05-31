<?php
class User
{


    private $UID;
    private $UFirstName;
    private $ULastName;
    private $Email;
    private $Address;
    private $City;
    private $State;
    private $Zip;

    function getUID()
    {
        return $this->UID;

    }

    function setUID($CUID)
    {
        $this->UID = $CUID;
    }

    function getUFirstName()
    {
        return $this->UFirstName;

    }

    function setUFirstName($CUFname)
    {
        $this->UFirstName = $CUFname;
    }

    function GetULastName()
    {
        return $this->ULastName;

    }

    function setULastName($CULname)
    {
        $this->ULastName = $CULname;
    }

    function getEmail()
    {
        return $this->Email;

    }

    function setEmail($CEmail)
    {
        $this->Email = $CEmail;
    }

    function getAddress()
    {
        return $this->Address;

    }

    function setAddress($CAddress)
    {
        $this->Address = $CAddress;
    }

    function getCity()
    {
        return $this->City;

    }

    function setCity($CCity)
    {
        $this->City = $CCity;
    }

    function getState()
    {
        return $this->State;

    }

    function setState($CState)
    {
        $this->State = $CState;
    }

    function getZip()
    {
        return $this->Zip;

    }

    function setZip($CZip)
    {
        $this->Zip = $CZip;
    }

    function setData($SentEm, $StrPass)
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

        $query = "SELECT * FROM users where UEmail= '" . $SentEm . "'";
//says $DB is undefined but is it the DB_conn.php file
        $statement = $db->prepare($query);
        $statement->execute();
        $Return = $statement->fetch();


            if (password_verify($StrPass, $Return['Password']) == false) {
                echo "Password entered was incorrect, please check information and resubmit";

            } else {
                $this->UID = $Return['UserID'];
                $this->UFirstName = $Return['UFname'];
                $this->ULastName = $Return['ULname'];
                $this->Email = $Return['UEmail'];
                $this->Address = $Return['Uaddress'];
                $this->City = $Return['City'];
                $this->State = $Return['State'];
                $this->Zip = $Return['Zipcode'];


            }



    }

    function setData1($SentEm)
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

        $query = "SELECT * FROM users where UEmail= '" . $SentEm . "'";
//says $DB is undefined but is it the DB_conn.php file
        $statement = $db->prepare($query);
        $statement->execute();
        $Return = $statement->fetch();


        $this->UID = $Return['UserID'];
        $this->UFirstName = $Return['UFname'];
        $this->ULastName = $Return['ULname'];
        $this->Email = $Return['UEmail'];
        $this->Address = $Return['Uaddress'];
        $this->City = $Return['City'];
        $this->State = $Return['State'];
        $this->Zip = $Return['Zipcode'];


    }


}
?>