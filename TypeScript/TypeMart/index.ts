import products from './products';

let productName: string = 'fanny pack';
let shipping: number;
let taxPercent: number;
let taxTotal: number;
let total: number;
let shippingAddress: string = '2020 Lala Street';

let product = products.find(product => product.name === productName);

console.log(product);

if (product && Boolean(product.preOrder) === true) {
  console.log('We will send a message when your product is on the way!');
}

if (product && Number(product.price) >= 25) {
  shipping = 0;
  console.log('We will provide free shipping for this product');
} else {
  shipping = 5;
}

if (shippingAddress.match('New York')) {
  taxPercent = 0.1;
} else {
  taxPercent = 0.05;
}

if (product) {
  taxTotal = Number(product.price) * taxPercent;
  total = Number(product.price) + taxTotal + shipping;

  console.log(`The product name is ${product.name}. The shipping address is ${shippingAddress}. The price is $${product.price}. The total tax is ${taxTotal}. The shipping is ${shipping}. The total due is ${total}.`);
}