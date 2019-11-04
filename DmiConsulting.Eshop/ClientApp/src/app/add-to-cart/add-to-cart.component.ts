import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { OrderService } from '../order.service';
import { OrderResult } from '../models/OrderResult';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-to-cart',
  templateUrl: './add-to-cart.component.html',
  styleUrls: ['./add-to-cart.component.css']
})
export class AddToCartComponent implements OnInit {

  @Input() itemIdentifier: number;
  @Output() orderResult: EventEmitter<OrderResult> = new EventEmitter<OrderResult>(); 

  quantityControl = new FormControl("", [Validators.min(1)])


  quantity: number = 1;
  isOrdered: boolean;

  constructor(private orderService: OrderService) { }

  ngOnInit() {
  }

  orderItem(){
    let result : OrderResult = new OrderResult();
    this.orderService.orderProduct(this.itemIdentifier, this.quantity).subscribe(p => {
      this.isOrdered = true;
      result.Success = true;
      result.Message = "Order has been processed";
      this.orderResult.emit(result);
    },
    error => {
      let errorResponse : ApiError = error.error;
      result.Success = false;
      result.Message = errorResponse.StatusCode + ":" + errorResponse.Message;
      this.orderResult.emit(result);
    });
  }

}
