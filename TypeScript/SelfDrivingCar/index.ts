import { getObstacleEvents } from './computer-vision';

interface AutonomousCar {
  isRunning?: boolean;
  respond: (events: Events) => void;
}

interface AutonomousCarProps {
  isRunning?: boolean;
  steeringControl: Steering;
}

interface Events {
  [obstacle: string]: boolean;
}

interface Control {
  execute: (command: string) => void;
}

interface Steering extends Control {
  turn: (direction: string) => void;
}

class SteeringControl implements Steering {
  execute(command: string) {
    console.log(`Executing: ${command}`);
  }

  turn(direction: string) {
    this.execute(`Turn ${direction}`);
  }
}

class Car implements AutonomousCar {
  isRunning;
  steeringControl;

  constructor(props: AutonomousCarProps) {
    this.isRunning = props.isRunning;
    this.steeringControl = props.steeringControl;
  }

  respond(events: Events) {
    if (!this.isRunning) {
      return console.log('The car is not running...');
    }
/*
  The Object.keys() static method returns an array of a given 
  object's own enumerable string-keyed property names.
 */
    Object.keys(events).forEach((eventKey) => {
      if (!events[eventKey]) {
        return;
      }

      if (eventKey === 'ObstacleLeft') {
        this.steeringControl.turn('right');
      }

      if (eventKey === 'ObstacleRight') {
        this.steeringControl.turn('left');
      }
    });
  }
}

const steering = new SteeringControl();

//steering.turn('left');

const autonomousCar = new Car({isRunning : true, steeringControl: steering});

autonomousCar.respond(getObstacleEvents());
autonomousCar.respond(getObstacleEvents());
autonomousCar.respond(getObstacleEvents());
autonomousCar.respond(getObstacleEvents());
autonomousCar.respond(getObstacleEvents());
autonomousCar.respond(getObstacleEvents());