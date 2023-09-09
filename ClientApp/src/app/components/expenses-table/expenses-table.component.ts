import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Expense } from '../../Expense';

@Component({
  selector: 'app-expenses-table',
  templateUrl: './expenses-table.component.html',
  styleUrls: ['./expenses-table.component.css']
})
export class ExpensesTableComponent implements OnInit {
  @Input() expenses: Expense[];
  @Output() onDeleteExpense: EventEmitter<Expense> = new EventEmitter();

  constructor() {}

  ngOnInit(): void {
    // this.expenses = EXPENSES;
  }

  handleDeleteButtonClick(expense: Expense){
    console.log(expense)
    // this.expenses = this.expenses.filter(ex => ex.id != expense.id)
    this.onDeleteExpense.emit(expense);
    console.log("expenses in table component", this.expenses)
  }

}
