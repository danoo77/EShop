import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {


  products: Product[];

  constructor(private productService: ProductService) { }

  ngOnInit() {

    this.productService.getProducts().subscribe(p => 
      {
        console.log(p);
        this.products = p;
        console.log(this.products);
      });
    console.log(this.products);
  }


  

}
