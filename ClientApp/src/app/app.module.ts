import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';;
import { HeaderComponent } from './components/header/header.component';
import { AddExpenseComponent } from './components/add-expense/add-expense.component';
import { ExpensesTableComponent } from './components/expenses-table/expenses-table.component';
import { ExpensesComponent } from './components/expenses/expenses.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    AddExpenseComponent,
    ExpensesTableComponent,
    ExpensesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
