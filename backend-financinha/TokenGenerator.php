<?php

    function random_str(
        int $length = 128,
        string $keyspace = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%&'
    ): string {
        if ($length < 1) {
            throw new \RangeException("Length must be a positive integer");
        }
        $pieces = [];
        $max = mb_strlen($keyspace, '8bit') - 1;
        for ($i = 0; $i < $length; ++$i) {
            $pieces []= $keyspace[random_int(0, $max)];
        }
        return implode('', $pieces);
    }   
   // date_default_timezone_set('America/Sao_Paulo');
   // echo "O dia de hoje é ". date("d-m-Y G:i:s"); em Java > dd-MM-yyyy hh:mm:ss
   echo random_str();
?>