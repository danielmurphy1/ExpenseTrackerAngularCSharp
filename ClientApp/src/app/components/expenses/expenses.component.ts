import { Component, Input, OnInit } from '@angular/core';
import { Expense } from "../../Expense"
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
    this.expensesService.addExpense(expense).subscribe((ex) => {
      this.expenses.push(ex);
    })
  }

  deleteExpense(expense: Expense): void {
    this.expensesService.deleteExpense(expense).subscribe(() => {
      this.expenses = this.expenses.filter(ex => ex.id != expense.id)
    })
  }
}
