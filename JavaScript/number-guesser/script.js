let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:
const generateTarget = () => {
  return Math.floor(Math.random() * 10)
};

const compareGuesses = (humanGuess, computerGuess, secretTarget) => {
  if (Math.abs(humanGuess - secretTarget) <= Math.abs(computerGuess - secretTarget)) {
    return true;
  } else {
    return false;
  } 
};

const updateScore = (winner) => {
  if (winner === 'human') {
     return humanScore++;
  } else if (winner === 'computer') {
     return computerScore++;
  }
};

const advanceRound = () => {
    return currentRoundNumber++;
};