import { Injectable } from '@angular/core';
import { Account } from '../account';
import { Http } from '@angular/http';

@Injectable()
export class AccountService {
  private serviceUrl: string;

  constructor(private http: Http) {
    this.serviceUrl = "http://vally-api.azurewebsites.net/api/accounts";
  }

  getAll(){
    
  }

}
