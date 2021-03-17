import { BaseCdkCell } from '@angular/cdk/table';
import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialogRef } from '@angular/material';
import { AppComponentBase } from '@shared/app-component-base';
import { AccountDto, BankInfo } from '../bank-account.component';

@Component({
  selector: 'add-bank',
  templateUrl: './add-bank-account.component.html'
})

export class AddBankAccountComponent extends AppComponentBase implements OnInit {
    closeResult = '';
    dp :any;
    loading: boolean;
    saving: boolean = false;
    bank: BankInfo = new BankInfo;
    banks : BankInfo[] = [
      {
        id: 1,
        name: "Bank of the Philippine Island",
        abb: "BPI",
        color: "red"
      },{
        id: 2,
        name: "Paymaya",
        abb: "Paymaya",
        color: "green"
      },{
        id: 3,
        name: "GCash",
        abb: "GCash",
        color: "blue"
      }

    ];

    newAccount: AccountDto = new AccountDto;
    color1: string = '#2889e9';

    @ViewChild('addBankAccountForm') form: NgForm;

    constructor(
         injector : Injector,
         private _dialogRef: MatDialogRef<AddBankAccountComponent>
    ){
        super(injector);
    }

    ngOnInit(): void {
        this.loading = true;
        console.log("ngOnInit");
        this.loading = false;
    }

    save(): void{
      console.log("save");
    }

    isLoading(): boolean{
      return this.loading;
    }

    close(bol: boolean){
    }

    add(){
        this.newAccount.bank = this.banks.find( _ => _.id == this.bank.id);
        console.log(this.newAccount);
        this._dialogRef.close(this.newAccount);
    }

    onEventLog(event: string, data: any): void {
      console.log(event, data);
    }
}
