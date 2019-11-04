import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      this.apiUrl = baseUrl + "api/product"
   }

  getProducts(){
    return this.http.get<Product[]>(this.apiUrl);
  }

  getProduct(id: number){
    return this.http.get<Product>(this.apiUrl + '/' + id);
  }
}
