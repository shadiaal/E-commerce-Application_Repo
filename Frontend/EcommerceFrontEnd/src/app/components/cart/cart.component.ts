
import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-cart',
  imports: [CommonModule, RouterModule],
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  cartItems: any[] = [];  // List of cart items

  constructor(private cartService: CartService) {}

  ngOnInit(): void {
    this.getCartItems(); // Fetch cart when the component loads
  }

  // Get cart items from the API
  getCartItems(): void {
    this.cartService.getCart().subscribe((items) => {
      this.cartItems = items;
    });
  }

  // Add product to the cart
  addToCart(product: any): void {
    this.cartService.addToCart(product).subscribe(() => {
      this.getCartItems();  // Refresh cart after adding
    });
  }

  // Remove product from the cart
  removeFromCart(id: number): void {
    this.cartService.removeFromCart(id).subscribe(() => {
      this.getCartItems();  // Refresh cart after removal
    });
  }

  // Clear the cart
  clearCart(): void {
    this.cartService.clearCart().subscribe(() => {
      this.cartItems = [];  // Clear cart in the frontend
    });
  }

  // Calculate the total price of the cart
  getTotal(): number {
    return this.cartItems.reduce((total, item) => total + (item.quantity * item.price), 0);
  }
}
