<?php
    include "connect.php";

    $sql = "SELECT * FROM user";

    $res = $conn->query($sql);

    if ($res->num_rows > 0) {
        $data = array();

        while ($row = $res->fetch_assoc()) {
            $data[] = $row;
        }

        echo json_encode(array('encontrado' => true, 'data' => $data));
    } else {
        echo json_encode(array('encontrado' => false));
    }

?>