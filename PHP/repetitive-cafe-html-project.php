<h1>Welcome to the Repetitive Cafe</h1>
<?php 
$drinks = ["Matcha" => 3.25, "Chai" => 3.25, "Mountain Dew" => 1.56, "Water" => 5.25, "Milk" => 2.55];
$pastries = ["Donut", "Croissant", "Bearclaw", "Cheese Danish", "Eclair"];
?>
<h3>Drinks!</h3>
<ul>
<?php foreach ($drinks as $drink => $price): ?>
<li><?="$drink: $$price"?></li>
<?php endforeach; ?>
</ul>
<h3>Pastries! ($2 each)</h3>
<ul>
<?php for ($i = 0; $i < count($pastries); $i++): ?>
<li><?="${pastries[$i]}"?></li>
<?php endfor;?>
</ul>