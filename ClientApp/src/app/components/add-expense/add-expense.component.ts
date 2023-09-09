import { Component, EventEmitter, Output, Input, OnInit } from '@angular/core';
import { Expense } from '../../Expense';

@Component({
  selector: 'app-add-expense',
  templateUrl: './add-expense.component.html',
  styleUrls: ['./add-expense.component.css']
})
export class AddExpenseComponent implements OnInit {
  @Output() onAddExpense: EventEmitter<Expense> = new EventEmitter();
  date: string;
  location: string;
  description: string;
  amount: number;
  
  constructor() {}

  ngOnInit(): void {
    
  }

  submitButtonClickHandler(expense: Expense){
    expense ={
      date: this.date, 
      location: this.location, 
      description: this.description, 
      amount: this.amount
    }
    this.onAddExpense.emit(expense);
  }
}
