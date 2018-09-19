import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  p1: number;
  p2: number;
  result: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }

  add() {
    this.http.get<number>('https://localhost:44361/api/Values/add/' + this.p1 + '/' + this.p2)
      .subscribe(data => {
        this.result = data
      });
  }

  minus() {
    this.http.get<number>('https://localhost:44361/api/Values/minus/' + this.p1 + '/' + this.p2)
      .subscribe(data => {
        this.result = data
      });
  }

  multiply() {
    this.http.get<number>('https://localhost:44361/api/Values/multiply/' + this.p1 + '/' + this.p2)
      .subscribe(data => {
        this.result = data
      });
  }

  divide() {
    this.http.get<number>('https://localhost:44361/api/Values/divide/' + this.p1 + '/' + this.p2)
      .subscribe(data => {
        this.result = data
      });
  }
}
