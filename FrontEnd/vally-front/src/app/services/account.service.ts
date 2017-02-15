import { Injectable } from '@angular/core';
import { Account } from '../account';


@Injectable()
export class AccountService {

  constructor() {}

  getAll(){
    let accounts: Array<Account>;
    accounts = new Array<Account>();
  }

}
