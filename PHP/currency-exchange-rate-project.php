<?php
  
$my_riel = 2103942;
$my_kyat = 19092;
$my_krones = 109;
$my_lek = 9094;

$one_riel_usd_amount = 0.000240637;
$one_kyat_usd_amount = 0.000476;
$one_krone_usd_amount = 0.093815;
$one_lek_usd_amount = 0.01001;

echo $my_riel;
echo "\n" . $my_kyat;
echo "\n" . $my_krones;
echo "\n" . $my_lek;

$riel_exchange_rate = $my_riel * $one_riel_usd_amount;
$kyat_exchange_rate = $my_kyat * $one_kyat_usd_amount;
$krones_exchange_rate = $my_krones * $one_krone_usd_amount;
$lek_exchange_rate = $my_lek * $one_lek_usd_amount;

echo "\n" . "\n" . $riel_exchange_rate;
echo "\n" . $kyat_exchange_rate;
echo "\n" . $krones_exchange_rate;
echo "\n" . $one_lek_usd_amount;

$currency_exchange_fee = 1.00;

$total_USD = ($riel_exchange_rate + $kyat_exchange_rate + $krones_exchange_rate + $lek_exchange_rate) - ($currency_exchange_fee);

$total_USD = "$" . $total_USD;

echo "\n" . "\n";
echo $total_USD;