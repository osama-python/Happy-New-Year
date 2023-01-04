import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { CommonLayoutComponent } from '../common-layout/common-layout.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  exportAs:'ngForm'
})
export class HomeComponent implements OnInit{
  title = 'HappyNewYear'

  status: string ="";
  errormsg:string = "";
  msg: string ="";
  showDiv: boolean = false;
  Name: string= ""
  constructor(private router:Router){}

  ngOnInit(): void{

  }
  submitLoginForm(form: NgForm){
    this.status="true";
    this.showDiv= true;
    
    if(this.status.toLowerCase() !="invalid credentials"){
      sessionStorage.setItem('Name', form.value.Name);
      this.router.navigate(['/new'])
    }
    else{
      this.msg= this.status+". Try again later"
    }
  }
  disclaimer() {
    alert("This application is just for fun ❤️")
  }
}
