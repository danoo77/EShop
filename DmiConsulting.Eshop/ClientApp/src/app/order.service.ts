import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  private apiUrl: string;

  constructor(private http :HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl = baseUrl + "api/order"
   }

  orderProduct(productId: number, quantity: number){

    let orderItme : OrderItem = {
      ProductId: productId,
      Quantity: quantity
    };

    return this.http.post<OrderItem>(this.apiUrl, orderItme);
  }
}
