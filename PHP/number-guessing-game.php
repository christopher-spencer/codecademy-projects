<?php

$play_count = 0;
$correct_guesses = 0;
$guess_high = 0;
$guess_low = 0;

echo "\n Welcome to the Number Guessing Game! \n
We'll play 10 rounds! \n
I've picked a number between one and ten. \n
See if you can guess it! \n";

function guessNumber() {

  global $play_count, $correct_guesses, $guess_high, $guess_low;

  $play_count++;

  $random_number = rand(1,10);

  echo "\n What is your guess? \n";

  $player_guess = intval(readline(">> "));

  echo "\n Round: ${play_count} \n";
  echo "\n You guessed ${player_guess}... \n";
  echo "\n The correct number was ${random_number}!";

  if ($player_guess === $random_number) {
    $correct_guesses++;
  } 
  
  if ($player_guess > $random_number) {
    return $guess_high++;
  } 
  
  if ($player_guess < $random_number) {
    return $guess_low ++;
  }

}

guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();
guessNumber();

  $percent_correct = $correct_guesses/ ($play_count);

  echo "\n You got ${percent_correct}% correct! \n";

  if ($guess_high > $guess_low) {
    echo "\n When you guessed wrong, you tended to guess high... \n";
  } elseif ($guess_low > $guess_high) {
    echo "\n When you guessed wrong, you tended to guess low...\n";
  } else {
    echo "\n Those were some great guesses! \n";
  }

  echo "\n Thanks for playing! \n";