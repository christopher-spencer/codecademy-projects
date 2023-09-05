<?php

class StringUtils {

public static function secondCase($string) {
  
  $string = strtolower($string);

  if (strlen($string) >= 2) {
    $string[1] = strtoupper($string[1]);
  }

  return $string;
}

}

//Testing static secondCase
echo StringUtils::secondCase("HeLlo, My friEnDs!");
echo "\n";
echo StringUtils::secondCase("");
echo "\n";
echo StringUtils::secondCase("H");
echo "\n \n";

class Pajamas {
  private $owner, $fit, $color;

  function __construct($owner = "ownerless", $fit = "nice", $color = "green") {
    $this->owner = StringUtils::secondCase($owner);
    $this->fit = $fit;
    $this->color = $color;
  }

  public function describe() {
    return "These are $this->owner's pajamas. They fit $this->fit and they are $this->color!";
  }

  public function setFit($update_fit) {
    $this->fit = $update_fit;
  }

}

$chicken_PJs = new Pajamas("Chicken", "loose", "gold-plated");
echo $chicken_PJs->describe();
echo "\n \n";
$chicken_PJs->setFit("really tight");
echo $chicken_PJs->describe();
echo "\n \n";

class ButtonablePajamas extends Pajamas {
  private $button_state = "unbuttoned";

  public function describe() {
    return Pajamas::describe() . " They are even $this->button_state!";
  }

  public function toggleButtons() {
    if ($this->button_state === "unbuttoned") {
      $this->button_state = "buttoned";
    } else {
      $this->button_state = "unbuttoned";
    }
  }
}

$moose_PJs = new ButtonablePajamas("moose", "huge", "fiery-orange");
echo $moose_PJs->describe();
echo "\n \n";
$moose_PJs->toggleButtons();
echo $moose_PJs->describe();
