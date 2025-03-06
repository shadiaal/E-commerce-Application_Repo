import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private apiUrl = 'http://localhost:5129/api/cart'; // API URL

  constructor(private http: HttpClient) {}

  // Get cart items from the API
  getCart(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  // Add item to the cart via API
  addToCart(product: any): Observable<any> {
    return this.http.post(this.apiUrl, product); // POST to add the product
  }

  // Remove item from the cart via API
  removeFromCart(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`); // DELETE to remove the product
  }

  // Clear the cart via API
  clearCart(): Observable<any> {
    return this.http.delete(`${this.apiUrl}/clear`); // DELETE to clear the cart
  }
}
