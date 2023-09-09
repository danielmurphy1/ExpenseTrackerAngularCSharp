import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Expense } from '../Expense';
import { EXPENSES } from '../mock-expenses';

@Injectable({
  providedIn: 'root'
})
export class ExpensesService {
  private apiUrl = 'http://localhost:5000/expenses';

  constructor(private http: HttpClient) { }

  getExpenses(): Observable<Expense[]> {
    return this.http.get<Expense[]>(this.apiUrl);
  }

  deleteExpense(expense: Expense): Observable<Expense> {
    const url = `${this.apiUrl}/${expense.id}`;
    return this.http.delete<Expense>(url);
  }
}
