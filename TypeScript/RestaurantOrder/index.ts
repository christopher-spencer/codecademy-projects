import { restaurants, Restaurant } from "./restaurants";
import { orders, Order, PriceBracket } from "./orders";


function getMaxPrice(price: PriceBracket) {
 switch (price) {
   case PriceBracket.Low:
     return 10.0;
   case PriceBracket.Medium:
     return 20.0;
   case PriceBracket.High:
     return 30.0;
 }
}

function getOrders(price: PriceBracket, orders: Order[][]) {
   let filteredOrders: Order[][] = [];


   orders.forEach((restaurant: Order[]) => {
     const result = restaurant.filter((order: Order) => order.price <= getMaxPrice(price));
     filteredOrders.push(result);
   });
   return filteredOrders;
}

function printOrders(restaurants: Restaurant[], orders: Order[][]) {
 restaurants.forEach((restaurant: Restaurant, index: number) => {
  
   if (orders[index].length > 0) {
       console.log(restaurant.name);


       orders[index].forEach((order) => {
         console.log(`- ${order.name}: ${order.price}`);
       });
   }
 });
}


// Main
const eligibleOrders = getOrders(PriceBracket.Low, orders);
// console.log(eligibleOrders);
printOrders(restaurants, eligibleOrders);