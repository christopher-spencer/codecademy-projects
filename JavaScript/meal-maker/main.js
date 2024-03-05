const menu = {
    _meal: '',
    _price: 0,
   
   
    get todaysSpecial() {
      if (this._meal && this._price) {
        console.log(`Today's Special is ${this._meal} for $${this._price}!`);
      } else {
        console.log('Meal or price was not set correctly!');
      }
    },
   
   
    set meal(mealToCheck) {
      if (typeof mealToCheck === 'string') {
        return this._meal = mealToCheck;
      }
    },
    set price(priceToCheck) {
      if (typeof priceToCheck === 'number') {
        return this._price = priceToCheck;
      }
    }
   }
   
   
   menu.meal = 'ham sandwich';
   menu.price = 69;
   
   
   console.log(menu._meal);
   console.log(menu._price);
   
   
   console.log(menu.todaysSpecial);