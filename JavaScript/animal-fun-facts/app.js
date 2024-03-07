import { animals } from './animals';
import React from 'react';
import { createRoot } from 'react-dom/client';

const container = document.getElementById('app');
const root = createRoot(container);

const background = <img className='background' alt='ocean' src='/images/ocean.jpg' />;

const images = [];
for(const animal in animals) {
  const image = (
      <img
        key={animal}
        className='animal'
        alt={animal}
        src={animals[animal].image}
        aria-label={animal}
        role='button'
        onClick={displayFact}
      />
    );
    images.push(image);
}

function displayFact(e) {
  const animalName = e.target.alt;
  const randomIndex = Math.floor(Math.random() * animals[animalName].facts.length);
  const funFact = animals[animalName].facts[randomIndex];
  const p = document.getElementById('fact');
  p.innerHTML = funFact;
}

const title = '';
const animalFacts = (
  <div>
    <h1>{title === ''? 'Click an animal for a fun fact!' : title}</h1>;
    {background}
    <div className='animals'>
      {images}
    </div>
    <p id='fact'></p>
  </div>
  );

root.render(animalFacts);