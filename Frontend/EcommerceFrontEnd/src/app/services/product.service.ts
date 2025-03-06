// src/app/services/product.service.ts
import { Injectable } from '@angular/core';
import { HttpClient,HttpErrorResponse  } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private apiUrl = 'http://localhost:5129/api/products';

  constructor(private http: HttpClient) {}

  // Get all products
  getProducts(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl).pipe(
      catchError(this.handleError)
    );
  }

  // Get product details by ID
  getProductById(id: string): Observable<any> {
    const numericId = +id; // Convert string to number
    return this.http.get<any>(`${this.apiUrl}/${numericId}`).pipe(
      catchError(this.handleError)
    );
  }
  

   // Handle errors
   private handleError(error: HttpErrorResponse) {
    let errorMessage = 'An error occurred while communicating with the server';
    if (error.status === 404) {
      errorMessage = 'Product not found';
    } else if (error.status === 500) {
      errorMessage = 'There is a problem with the server, please try again later';
    }
    alert(errorMessage);
    return throwError(() => new Error(errorMessage));
  }
}
