import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-new-year',
  templateUrl: './new-year.component.html',
  styleUrls: ['./new-year.component.css']
})
export class NewYearComponent {
  getName(): string|null {
    return sessionStorage.getItem("Name")
  }
}

