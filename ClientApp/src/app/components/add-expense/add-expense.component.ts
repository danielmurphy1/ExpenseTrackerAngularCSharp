import { Component } from '@angular/core';

@Component({
  selector: 'app-add-expense',
  templateUrl: './add-expense.component.html',
  styleUrls: ['./add-expense.component.css']
})
export class AddExpenseComponent {
  date: string;
  location: string;
  description: string;
  amount: number;
  
  click(){
    console.log('clicked')
  }
}
