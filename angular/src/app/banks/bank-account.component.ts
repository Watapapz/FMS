import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { formatDate } from '@angular/common';
import { MatDialog } from '@angular/material';
import { AddBankAccountComponent } from './add-bank/add-bank-account.component';

export class AccountDto{
    id: number;
    bank: BankInfo;
    accountNo: string;
    expirationDate: string;
    balance: number;
}

export class BankInfo{
    id: number;
    name: string;
    abb: string;
    color: string;
}


@Component({
    templateUrl: './bank-account.component.html',
    animations: [appModuleAnimation()]
})

export class BankAccountComponent extends AppComponentBase implements OnInit {
    idCtr: number = 3;
    newAccount : AccountDto;
    bankAccounts: AccountDto[] = [
        {
            id: 1,
            bank: {
                id: 1,
                name: "Bank of the Philippine Island",
                abb: "BPI",
                color: "red"
            },
            accountNo: "5555555",
            expirationDate : formatDate(new Date(), 'yyyy/MM/dd', 'en'),
            balance : 50
        },
        {
            id: 2,
            bank: {
                id: 2,
                name: "Paymaya",
                abb: "Paymaya",
                color: "green"
            },
            accountNo: "1111111",
            expirationDate : formatDate(new Date(), 'yyyy/MM/dd', 'en'),
            balance: 500
        },
        {
            id: 3,
            bank: {
                id: 3,
                name: "GCash",
                abb: "GCash",
                color: "blue"
            },
            accountNo: "2222222",
            expirationDate : formatDate(new Date(), 'yyyy/MM/dd', 'en'),
            balance: 1000
        }
    ];

    constructor(
        injector: Injector,
        private _dialog: MatDialog
    ) {
        super(injector);
    }

    ngOnInit(): void {

    }

    refresh(): void {
        console.log("refresh");
    }

    changeColor(bank: BankInfo)
    {
        return "bg-" + bank.color;
    }

    createAccount(): void {
        // this.idCtr++;
        // this.newAccount = new AccountDto();
        // this.newAccount.bank = new BankInfo();
        // this.newAccount.id = this.idCtr;
        // this.newAccount.bank.id = 1;
        // this.newAccount.bank.name = "Bank of the Philippine Island";
        // this.newAccount.bank.abb = "BPI";
        // this.newAccount.bank.color = "red";
        // this.newAccount.accountNo = "00000000";
        // this.newAccount.expirationDate = formatDate(new Date(), 'yyyy/MM/dd', 'en');
        // this.newAccount.balance = 5000;

        // this.banks.push(this.newAccount);
        //console.log(this.banks);
        this.showCreateOrEditAccountDialog();
    }

    editAccount(account: AccountDto): void {
        this.showCreateOrEditAccountDialog(account.id);
    }

    showCreateOrEditAccountDialog(id?: number): void {
        let createOrEditAccountDialog;
        if (id === undefined || id <= 0) {
            createOrEditAccountDialog = this._dialog.open(AddBankAccountComponent, {
                disableClose: true,
                autoFocus: false
            });
        } else {
            // createOrEditAccountDialog = this._dialog.open(EditUnitOfMeasureDialogComponent, {
            //     data: id,
            //     disableClose: true,
            //     autoFocus: false
            // });
        }

        createOrEditAccountDialog.afterClosed().subscribe(result => {
            if (result) {
                this.bankAccounts.push(result);
                console.log(this.bankAccounts);
                this.refresh();
            }else{
                this.refresh();
            }
        });
    }

    removeAccount(id: number)
    {
        this.bankAccounts.splice(this.bankAccounts.findIndex(r => r.id == id), 1);
        console.log(this.bankAccounts);
    }
}
