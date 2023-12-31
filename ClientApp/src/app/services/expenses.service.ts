import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Expense } from '../Expense';

@Injectable({
  providedIn: 'root'
})
export class ExpensesService {
  //json-server server
  // private apiUrl = 'http://localhost:5000/expenses';
  //Local C# Server 
  // private apiUrl = 'https://localhost:7001/api/expenses';
  //Production Server
  private apiUrl = '/api/expenses';


  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  constructor(private http: HttpClient) { }

  getExpenses(): Observable<Expense[]> {
    return this.http.get<Expense[]>(this.apiUrl);
  }

  deleteExpense(expense: Expense): Observable<Expense> {
    const url = `${this.apiUrl}/${expense.id}`;
    return this.http.delete<Expense>(url);
  }
  
  addExpense(expense: Expense): Observable<Expense> {
    return this.http.post<Expense>(this.apiUrl, expense, this.httpOptions);
  }
}
