import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { ActivatedRoute, Route, ParamMap, Router } from '@angular/router';
import { OrderResult } from '../models/OrderResult';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {


  product: Product;

  orderResult: OrderResult;

  error: string;


  constructor(private productService: ProductService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    let id = +this.route.snapshot.paramMap.get('id');
    this.productService.getProduct(id).subscribe(p => {
      console.log(p);
      this.product = p;
    },
    error =>{
      console.log(error);
      let errorResult : ApiError = error.error;
      
      if(errorResult.StatusCode == 404){
        this.router.navigate(['/404']);
      }
      else{
        
        error = errorResult.StatusCode + ' : ' + errorResult.Message;
        
      }
      
    });

  }

  onOrder(orderResult: OrderResult){
    this.orderResult = orderResult;
  }

}
