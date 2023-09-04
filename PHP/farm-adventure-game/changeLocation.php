<?php
  // Change player location
function changeLocation(){	
  // Write your code here:
  global $location;

  echo "Where do you want to go?\n";
  $where_to_go = readline (">> ");
  $where_to_go = strtolower($where_to_go);

  echo "\n";

  if ($location === "kitchen" && $where_to_go === "bathroom") {
    $location = $where_to_go;
    echo "You go to: bathroom.\n";
  } elseif ($location === "kitchen" && $where_to_go === "woods") {
    $location = $where_to_go;
    echo "You follow the winding path, shivering as you make your way deep into the Terror Woods.\n";
  } elseif ($location === "bathroom" && $where_to_go === "kitchen") {
    $location = $where_to_go;
    echo "You go to kitchen.\n";
  } elseif ($location === "woods" && $where_to_go === "kitchen") {
    $location = $where_to_go;
    echo "You go to: kitchen.\n";
  } elseif ($where_to_go === "kitchen" || $where_to_go === "bathroom" || $where_to_go === "woods") {
    echo "You can't go directly to there from your current location. Try going somewhere else first.\n.";
  } else {
    echo "That doesn't make sense. Are you confused? Try 'look around'.\n.";
  }
}