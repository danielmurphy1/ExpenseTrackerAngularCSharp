import { Component, OnInit, Input } from '@angular/core';
import { Expense } from '../../Expense';
import { EXPENSES } from '../../mock-expenses';

@Component({
  selector: 'app-expenses-table',
  templateUrl: './expenses-table.component.html',
  styleUrls: ['./expenses-table.component.css']
})
export class ExpensesTableComponent implements OnInit {
  expenses: Expense[];
  @Input() expense: Expense;

  constructor() {}

  ngOnInit(): void {
    this.expenses = EXPENSES;
  }

  handleDeleteButtonClick(expense: Expense){
    console.log(expense)
    this.expenses = this.expenses.filter(ex => ex.id != expense.id)
    console.log("expenses", this.expenses)
  }

}
