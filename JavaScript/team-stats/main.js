const team = {
    _players: [
      {
        firstName: 'Johnny',
        lastName: 'Bravo',
        age: 74
      },
      {
        firstName: 'Doug',
        lastName: 'Waffles',
        age: 14
      },
      {
        firstName: 'Wanda',
        lastName: 'Wilkinson',
        age: 23
      }
    ],
    _games: [
      {
        opponent: "The Rascals",
        teamPoints: 5,
        opponentPoints: 87
      },
          {
        opponent: "Eagle Masters",
        teamPoints: 52,
        opponentPoints: 71
      },
          {
        opponent: "Butt Champions",
        teamPoints: 57,
        opponentPoints: 47
      }
    ],
   
   
    get players() {
      return this._players;
    },
    get games() {
      return this._games;
    },
   
   
    addPlayer(newFirstName, newLastName, newAge) {
      this._players.push({
        firstName: newFirstName,
        lastName: newLastName,
        age: newAge
      });
    },
    addGame(newOpponent, newTeamPoints, newOpponentPoints) {
      this._games.push({
        opponent: newOpponent,
        teamPoints: newTeamPoints,
        opponentPoints: newOpponentPoints
      });
    }
   };
   
   
   console.log(team.players);
   console.log('\n');
   console.log(team.games);
   console.log('\n');
   
   
   team.addPlayer('Hobbit', 'Jones', 43);
   team.addPlayer('Bugs', 'Bunny', 76);
   team.addGame('Titans', 100, 98);
   
   
   console.log(team.players);
   console.log('\n');
   console.log(team.games);