import { Component, Input, OnInit } from '@angular/core';
import { Expense } from "../../Expense"
import { EXPENSES } from '../../mock-expenses';
import { ExpensesService } from '../../services/expenses.service';

@Component({
  selector: 'app-expenses',
  templateUrl: './expenses.component.html',
  styleUrls: ['./expenses.component.css']
})
export class ExpensesComponent implements OnInit {
  expenses: Expense[];

  constructor(private expensesService: ExpensesService) {

  }

  ngOnInit(): void {
    this.expensesService.getExpenses().subscribe(expenses => {
      this.expenses = expenses
    });
  }

  addExpense(expense: Expense): void {
    console.log("expense parameter", expense)
    expense.id = this.expenses.length + 1
    this.expenses.push(expense)
    console.log("expenses in expenses component after add", this.expenses)
  }

  deleteExpense(expense: Expense): void {
    this.expensesService.deleteExpense(expense).subscribe(() => {
      this.expenses = this.expenses.filter(ex => ex.id != expense.id)
    })
    console.log("expenses in expenses component after delete", this.expenses)

  }
}
